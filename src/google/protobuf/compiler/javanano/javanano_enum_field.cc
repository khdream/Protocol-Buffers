// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
// http://code.google.com/p/protobuf/
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Author: kenton@google.com (Kenton Varda)
//  Based on original Protocol Buffers design by
//  Sanjay Ghemawat, Jeff Dean, and others.

#include <map>
#include <string>

#include <google/protobuf/compiler/javanano/javanano_enum_field.h>
#include <google/protobuf/stubs/common.h>
#include <google/protobuf/compiler/javanano/javanano_helpers.h>
#include <google/protobuf/io/printer.h>
#include <google/protobuf/wire_format.h>
#include <google/protobuf/stubs/strutil.h>

namespace google {
namespace protobuf {
namespace compiler {
namespace javanano {

namespace {

// TODO(kenton):  Factor out a "SetCommonFieldVariables()" to get rid of
//   repeat code between this and the other field types.
void SetEnumVariables(const Params& params,
    const FieldDescriptor* descriptor, map<string, string>* variables) {
  (*variables)["name"] =
    RenameJavaKeywords(UnderscoresToCamelCase(descriptor));
  (*variables)["capitalized_name"] =
    RenameJavaKeywords(UnderscoresToCapitalizedCamelCase(descriptor));
  (*variables)["number"] = SimpleItoa(descriptor->number());
  if (params.use_reference_types_for_primitives()
      && !descriptor->is_repeated()) {
    (*variables)["type"] = "java.lang.Integer";
    (*variables)["default"] = "null";
  } else {
    (*variables)["type"] = "int";
    (*variables)["default"] = DefaultValue(params, descriptor);
  }
  (*variables)["repeated_default"] =
      "com.google.protobuf.nano.WireFormatNano.EMPTY_INT_ARRAY";
  (*variables)["tag"] = SimpleItoa(internal::WireFormat::MakeTag(descriptor));
  (*variables)["tag_size"] = SimpleItoa(
      internal::WireFormat::TagSize(descriptor->number(), descriptor->type()));
  (*variables)["message_name"] = descriptor->containing_type()->name();
}

}  // namespace

// ===================================================================

EnumFieldGenerator::
EnumFieldGenerator(const FieldDescriptor* descriptor, const Params& params)
  : FieldGenerator(params), descriptor_(descriptor) {
  SetEnumVariables(params, descriptor, &variables_);
}

EnumFieldGenerator::~EnumFieldGenerator() {}

void EnumFieldGenerator::
GenerateMembers(io::Printer* printer, bool /* unused lazy_init */) const {
  printer->Print(variables_,
    "public $type$ $name$;\n");

  if (params_.generate_has()) {
    printer->Print(variables_,
      "public boolean has$capitalized_name$;\n");
  }
}

void EnumFieldGenerator::
GenerateClearCode(io::Printer* printer) const {
  printer->Print(variables_,
    "$name$ = $default$;\n");

  if (params_.generate_has()) {
    printer->Print(variables_,
      "has$capitalized_name$ = false;\n");
  }
}

void EnumFieldGenerator::
GenerateMergingCode(io::Printer* printer) const {
  printer->Print(variables_,
    "this.$name$ = input.readInt32();\n");

  if (params_.generate_has()) {
    printer->Print(variables_,
      "has$capitalized_name$ = true;\n");
  }
}

void EnumFieldGenerator::
GenerateSerializationCode(io::Printer* printer) const {
  if (descriptor_->is_required() && !params_.generate_has()) {
    // Always serialize a required field if we don't have the 'has' signal.
    printer->Print(variables_,
      "output.writeInt32($number$, this.$name$);\n");
  } else {
    if (params_.generate_has()) {
      printer->Print(variables_,
        "if (this.$name$ != $default$ || has$capitalized_name$) {\n");
    } else {
      printer->Print(variables_,
        "if (this.$name$ != $default$) {\n");
    }
    printer->Print(variables_,
      "  output.writeInt32($number$, this.$name$);\n"
      "}\n");
  }
}

void EnumFieldGenerator::
GenerateSerializedSizeCode(io::Printer* printer) const {
  if (descriptor_->is_required() && !params_.generate_has()) {
    printer->Print(variables_,
      "size += com.google.protobuf.nano.CodedOutputByteBufferNano\n"
      "  .computeInt32Size($number$, this.$name$);\n");
  } else {
    if (params_.generate_has()) {
      printer->Print(variables_,
        "if (this.$name$ != $default$ || has$capitalized_name$) {\n");
    } else {
      printer->Print(variables_,
        "if (this.$name$ != $default$) {\n");
    }
    printer->Print(variables_,
      "  size += com.google.protobuf.nano.CodedOutputByteBufferNano\n"
      "    .computeInt32Size($number$, this.$name$);\n"
      "}\n");
  }
}

void EnumFieldGenerator::GenerateEqualsCode(io::Printer* printer) const {
  if (params_.use_reference_types_for_primitives()) {
    printer->Print(variables_,
      "if (this.$name$ == null) {\n"
      "  if (other.$name$ != null) {\n"
      "    return false;\n"
      "  }\n"
      "} else if (!this.$name$.equals(other.$name$)) {\n"
      "  return false;"
      "}\n");
  } else {
    // We define equality as serialized form equality. If generate_has(),
    // then if the field value equals the default value in both messages,
    // but one's 'has' field is set and the other's is not, the serialized
    // forms are different and we should return false.
    printer->Print(variables_,
      "if (this.$name$ != other.$name$");
    if (params_.generate_has()) {
      printer->Print(variables_,
        "\n"
        "    || (this.$name$ == $default$\n"
        "        && this.has$capitalized_name$ != other.has$capitalized_name$)");
    }
    printer->Print(") {\n"
      "  return false;\n"
      "}\n");
  }
}

void EnumFieldGenerator::GenerateHashCodeCode(io::Printer* printer) const {
  printer->Print(
    "result = 31 * result + ");
  if (params_.use_reference_types_for_primitives()) {
    printer->Print(variables_,
      "(this.$name$ == null ? 0 : this.$name$)");
  } else {
    printer->Print(variables_,
      "this.$name$");
  }
  printer->Print(";\n");
}

// ===================================================================

AccessorEnumFieldGenerator::
AccessorEnumFieldGenerator(const FieldDescriptor* descriptor,
    const Params& params, int has_bit_index)
  : FieldGenerator(params), descriptor_(descriptor) {
  SetEnumVariables(params, descriptor, &variables_);
  SetBitOperationVariables("has", has_bit_index, &variables_);
}

AccessorEnumFieldGenerator::~AccessorEnumFieldGenerator() {}

void AccessorEnumFieldGenerator::
GenerateMembers(io::Printer* printer, bool /* unused lazy_init */) const {
  printer->Print(variables_,
    "private int $name$_;\n"
    "public int get$capitalized_name$() {\n"
    "  return $name$_;\n"
    "}\n"
    "public $message_name$ set$capitalized_name$(int value) {\n"
    "  $name$_ = value;\n"
    "  $set_has$;\n"
    "  return this;\n"
    "}\n"
    "public boolean has$capitalized_name$() {\n"
    "  return $get_has$;\n"
    "}\n"
    "public $message_name$ clear$capitalized_name$() {\n"
    "  $name$_ = $default$;\n"
    "  $clear_has$;\n"
    "  return this;\n"
    "}\n");
}

void AccessorEnumFieldGenerator::
GenerateClearCode(io::Printer* printer) const {
  printer->Print(variables_,
    "$name$_ = $default$;\n");
}

void AccessorEnumFieldGenerator::
GenerateMergingCode(io::Printer* printer) const {
  printer->Print(variables_,
    "$name$_ = input.readInt32();\n"
    "$set_has$;\n");
}

void AccessorEnumFieldGenerator::
GenerateSerializationCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if ($get_has$) {\n"
    "  output.writeInt32($number$, $name$_);\n"
    "}\n");
}

void AccessorEnumFieldGenerator::
GenerateSerializedSizeCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if ($get_has$) {\n"
    "  size += com.google.protobuf.nano.CodedOutputByteBufferNano\n"
    "    .computeInt32Size($number$, $name$_);\n"
    "}\n");
}

void AccessorEnumFieldGenerator::
GenerateEqualsCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if ($different_has$\n"
    "    || $name$_ != other.$name$_) {\n"
    "  return false;\n"
    "}\n");
}

void AccessorEnumFieldGenerator::
GenerateHashCodeCode(io::Printer* printer) const {
  printer->Print(variables_,
    "result = 31 * result + $name$_;\n");
}

// ===================================================================

RepeatedEnumFieldGenerator::
RepeatedEnumFieldGenerator(const FieldDescriptor* descriptor, const Params& params)
  : FieldGenerator(params), descriptor_(descriptor) {
  SetEnumVariables(params, descriptor, &variables_);
}

RepeatedEnumFieldGenerator::~RepeatedEnumFieldGenerator() {}

void RepeatedEnumFieldGenerator::
GenerateMembers(io::Printer* printer, bool /* unused lazy_init */) const {
  printer->Print(variables_,
    "public $type$[] $name$;\n");
}

void RepeatedEnumFieldGenerator::
GenerateClearCode(io::Printer* printer) const {
  printer->Print(variables_,
    "$name$ = $repeated_default$;\n");
}

void RepeatedEnumFieldGenerator::
GenerateMergingCode(io::Printer* printer) const {
  // First, figure out the length of the array, then parse.
  printer->Print(variables_,
    "int arrayLength = com.google.protobuf.nano.WireFormatNano\n"
    "    .getRepeatedFieldArrayLength(input, $tag$);\n"
    "int i = this.$name$ == null ? 0 : this.$name$.length;\n"
    "int[] newArray = new int[i + arrayLength];\n"
    "if (i != 0) {\n"
    "  java.lang.System.arraycopy(this.$name$, 0, newArray, 0, i);\n"
    "}\n"
    "for (; i < newArray.length - 1; i++) {\n"
    "  newArray[i] = input.readInt32();\n"
    "  input.readTag();\n"
    "}\n"
    "// Last one without readTag.\n"
    "newArray[i] = input.readInt32();\n"
    "this.$name$ = newArray;\n");
}

void RepeatedEnumFieldGenerator::
GenerateMergingCodeFromPacked(io::Printer* printer) const {
  printer->Print(variables_,
    "int length = input.readRawVarint32();\n"
    "int limit = input.pushLimit(length);\n"
    "// First pass to compute array length.\n"
    "int arrayLength = 0;\n"
    "int startPos = input.getPosition();\n"
    "while (input.getBytesUntilLimit() > 0) {\n"
    "  input.readInt32();\n"
    "  arrayLength++;\n"
    "}\n"
    "input.rewindToPosition(startPos);\n"
    "int i = this.$name$ == null ? 0 : this.$name$.length;\n"
    "int[] newArray = new int[i + arrayLength];\n"
    "if (i != 0) {\n"
    "  java.lang.System.arraycopy(this.$name$, 0, newArray, 0, i);\n"
    "}\n"
    "for (; i < newArray.length; i++) {\n"
    "  newArray[i] = input.readInt32();\n"
    "}\n"
    "this.$name$ = newArray;\n"
    "input.popLimit(limit);\n");
}

void RepeatedEnumFieldGenerator::
GenerateRepeatedDataSizeCode(io::Printer* printer) const {
  // Creates a variable dataSize and puts the serialized size in there.
  printer->Print(variables_,
    "int dataSize = 0;\n"
    "for (int i = 0; i < this.$name$.length; i++) {\n"
    "  int element = this.$name$[i];\n"
    "  dataSize += com.google.protobuf.nano.CodedOutputByteBufferNano\n"
    "      .computeInt32SizeNoTag(element);\n"
    "}\n");
}

void RepeatedEnumFieldGenerator::
GenerateSerializationCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if (this.$name$ != null && this.$name$.length > 0) {\n");
  printer->Indent();

  if (descriptor_->options().packed()) {
    GenerateRepeatedDataSizeCode(printer);
    printer->Print(variables_,
      "output.writeRawVarint32($tag$);\n"
      "output.writeRawVarint32(dataSize);\n"
      "for (int i = 0; i < this.$name$.length; i++) {\n"
      "  output.writeRawVarint32(this.$name$[i]);\n"
      "}\n");
  } else {
    printer->Print(variables_,
      "for (int i = 0; i < this.$name$.length; i++) {\n"
      "  output.writeInt32($number$, this.$name$[i]);\n"
      "}\n");
  }

  printer->Outdent();
  printer->Print(variables_,
    "}\n");
}

void RepeatedEnumFieldGenerator::
GenerateSerializedSizeCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if (this.$name$ != null && this.$name$.length > 0) {\n");
  printer->Indent();

  GenerateRepeatedDataSizeCode(printer);

  printer->Print(
    "size += dataSize;\n");
  if (descriptor_->options().packed()) {
    printer->Print(variables_,
      "size += $tag_size$;\n"
      "size += com.google.protobuf.nano.CodedOutputByteBufferNano\n"
      "    .computeRawVarint32Size(dataSize);\n");
  } else {
    printer->Print(variables_,
      "size += $tag_size$ * this.$name$.length;\n");
  }

  printer->Outdent();

  printer->Print(
    "}\n");
}

void RepeatedEnumFieldGenerator::
GenerateEqualsCode(io::Printer* printer) const {
  printer->Print(variables_,
    "if (!com.google.protobuf.nano.InternalNano.equals(\n"
    "    this.$name$, other.$name$)) {\n"
    "  return false;\n"
    "}\n");
}

void RepeatedEnumFieldGenerator::
GenerateHashCodeCode(io::Printer* printer) const {
  printer->Print(variables_,
    "result = 31 * result\n"
    "    + com.google.protobuf.nano.InternalNano.hashCode(this.$name$);\n");
}

}  // namespace javanano
}  // namespace compiler
}  // namespace protobuf
}  // namespace google
