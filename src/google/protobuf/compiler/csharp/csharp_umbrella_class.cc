// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
// https://developers.google.com/protocol-buffers/
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

#include <sstream>

#include <google/protobuf/compiler/code_generator.h>
#include <google/protobuf/compiler/plugin.h>
#include <google/protobuf/descriptor.h>
#include <google/protobuf/descriptor.pb.h>
#include <google/protobuf/io/printer.h>
#include <google/protobuf/io/zero_copy_stream.h>


#include <google/protobuf/compiler/csharp/csharp_enum.h>
#include <google/protobuf/compiler/csharp/csharp_helpers.h>
#include <google/protobuf/compiler/csharp/csharp_message.h>
#include <google/protobuf/compiler/csharp/csharp_names.h>
#include <google/protobuf/compiler/csharp/csharp_umbrella_class.h>

namespace google {
namespace protobuf {
namespace compiler {
namespace csharp {

UmbrellaClassGenerator::UmbrellaClassGenerator(const FileDescriptor* file)
    : SourceGeneratorBase(file),
      file_(file) {
  namespace_ = GetFileNamespace(file);
  umbrellaClassname_ = GetFileUmbrellaClassname(file);
  umbrellaNamespace_ = GetFileUmbrellaNamespace(file);
}

UmbrellaClassGenerator::~UmbrellaClassGenerator() {
}

void UmbrellaClassGenerator::Generate(io::Printer* printer) {
  WriteIntroduction(printer);

  printer->Print("#region Static variables\n");
  for (int i = 0; i < file_->message_type_count(); i++) {
    MessageGenerator messageGenerator(file_->message_type(i));
    messageGenerator.GenerateStaticVariables(printer);
  }
  printer->Print("#endregion\n");
  WriteDescriptor(printer);
  // Close the class declaration.
  printer->Outdent();
  printer->Print("}\n");

  // Close the namespace around the umbrella class if defined
  if (!umbrellaNamespace_.empty()) {
    printer->Outdent();
    printer->Print("}\n");
  }

  // write children: Enums
  if (file_->enum_type_count() > 0) {
    printer->Print("#region Enums\n");
    for (int i = 0; i < file_->enum_type_count(); i++) {
      EnumGenerator enumGenerator(file_->enum_type(i));
      enumGenerator.Generate(printer);
    }
    printer->Print("#endregion\n");
    printer->Print("\n");
  }

  // write children: Messages
  if (file_->message_type_count() > 0) {
    printer->Print("#region Messages\n");
    for (int i = 0; i < file_->message_type_count(); i++) {
      MessageGenerator messageGenerator(file_->message_type(i));
      messageGenerator.Generate(printer);
    }
    printer->Print("#endregion\n");
    printer->Print("\n");
  }

  // TODO(jtattermusch): add insertion point for services.

  if (!namespace_.empty()) {
    printer->Outdent();
    printer->Print("}\n");
  }
  printer->Print("\n");
  printer->Print("#endregion Designer generated code\n");
}

void UmbrellaClassGenerator::WriteIntroduction(io::Printer* printer) {
  printer->Print(
    "// Generated by the protocol buffer compiler.  DO NOT EDIT!\n"
    "// source: $file_name$\n"
    "#pragma warning disable 1591, 0612, 3021\n"
    "#region Designer generated code\n"
    "\n"
    "using pb = global::Google.Protobuf;\n"
    "using pbc = global::Google.Protobuf.Collections;\n"
    "using pbr = global::Google.Protobuf.Reflection;\n"
    "using scg = global::System.Collections.Generic;\n",
    "file_name", file_->name());

  if (!namespace_.empty()) {
    printer->Print("namespace $namespace$ {\n", "namespace", namespace_);
    printer->Indent();
    printer->Print("\n");
  }

  // Add the namespace around the umbrella class if defined
  if (!umbrellaNamespace_.empty()) {
    printer->Print("namespace $umbrella_namespace$ {\n",
                   "umbrella_namespace", umbrellaNamespace_);
    printer->Indent();
    printer->Print("\n");
  }

  printer->Print(
    "[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]\n");
  WriteGeneratedCodeAttributes(printer);
  printer->Print(
    "$access_level$ static partial class $umbrella_class_name$ {\n"
    "\n",
    "access_level", class_access_level(),
    "umbrella_class_name", umbrellaClassname_);
  printer->Indent();
}

void UmbrellaClassGenerator::WriteDescriptor(io::Printer* printer) {
  printer->Print(
    "#region Descriptor\n"
    "public static pbr::FileDescriptor Descriptor {\n"
    "  get { return descriptor; }\n"
    "}\n"
    "private static pbr::FileDescriptor descriptor;\n"
    "\n"
    "static $umbrella_class_name$() {\n",
    "umbrella_class_name", umbrellaClassname_);
  printer->Indent();
  printer->Print(
    "byte[] descriptorData = global::System.Convert.FromBase64String(\n");
  printer->Indent();
  printer->Indent();
  printer->Print("string.Concat(\n");
  printer->Indent();

  // TODO(jonskeet): Consider a C#-escaping format here instead of just Base64.
  std::string base64 = FileDescriptorToBase64(file_);
  while (base64.size() > 60) {
    printer->Print("\"$base64$\", \n", "base64", base64.substr(0, 60));
    base64 = base64.substr(60);
  }
  printer->Outdent();
  printer->Print("\"$base64$\"));\n", "base64", base64);
  printer->Outdent();
  printer->Outdent();

  // -----------------------------------------------------------------
  // Invoke InternalBuildGeneratedFileFrom() to build the file.
  printer->Print(
      "descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,\n");
  printer->Print("    new pbr::FileDescriptor[] {\n");
  for (int i = 0; i < file_->dependency_count(); i++) {
    printer->Print(
      "    $full_umbrella_class_name$.Descriptor, \n",
      "full_umbrella_class_name",
      GetFullUmbrellaClassName(file_->dependency(i)));
  }
  printer->Print("    });\n");
  // Then invoke any other static variable initializers, e.g. field accessors.
  for (int i = 0; i < file_->message_type_count(); i++) {
      MessageGenerator messageGenerator(file_->message_type(i));
      messageGenerator.GenerateStaticVariableInitializers(printer);
  }
  printer->Outdent();
  printer->Print("}\n");
  printer->Print("#endregion\n\n");
}

}  // namespace csharp
}  // namespace compiler
}  // namespace protobuf
}  // namespace google
