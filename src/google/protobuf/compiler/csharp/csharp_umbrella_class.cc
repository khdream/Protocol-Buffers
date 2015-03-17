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

#include <google/protobuf/compiler/csharp/csharp_umbrella_class.h>
#include <google/protobuf/compiler/csharp/csharp_enum.h>
#include <google/protobuf/compiler/csharp/csharp_extension.h>
#include <google/protobuf/compiler/csharp/csharp_helpers.h>
#include <google/protobuf/compiler/csharp/csharp_message.h>
#include <google/protobuf/compiler/csharp/csharp_writer.h>

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

void UmbrellaClassGenerator::Generate(Writer* writer) {
  WriteIntroduction(writer);
  WriteExtensionRegistration(writer);

  // write children: Extensions
  if (file_->extension_count() > 0) {
    writer->WriteLine("#region Extensions");
    for (int i = 0; i < file_->extension_count(); i++) {
      ExtensionGenerator extensionGenerator(file_->extension(i));
      extensionGenerator.Generate(writer);
    }
    writer->WriteLine("#endregion");
    writer->WriteLine();
  }

  writer->WriteLine("#region Static variables");
  for (int i = 0; i < file_->message_type_count(); i++) {
    MessageGenerator messageGenerator(file_->message_type(i));
    messageGenerator.GenerateStaticVariables(writer);
  }
  writer->WriteLine("#endregion");
  if (!use_lite_runtime()) {
    WriteDescriptor(writer);
  } else {
    WriteLiteExtensions(writer);
  }
  // The class declaration either gets closed before or after the children are written.
  if (!file_->options().csharp_nest_classes()) {
    writer->Outdent();
    writer->WriteLine("}");

    // Close the namespace around the umbrella class if defined
    if (!file_->options().csharp_nest_classes()
        && !umbrellaNamespace_.empty()) {
      writer->Outdent();
      writer->WriteLine("}");
    }
  }

  // write children: Enums
  if (file_->enum_type_count() > 0) {
    writer->WriteLine("#region Enums");
    for (int i = 0; i < file_->enum_type_count(); i++) {
      EnumGenerator enumGenerator(file_->enum_type(i));
      enumGenerator.Generate(writer);
    }
    writer->WriteLine("#endregion");
    writer->WriteLine();
  }

  // write children: Messages
  if (file_->message_type_count() > 0) {
    writer->WriteLine("#region Messages");
    for (int i = 0; i < file_->message_type_count(); i++) {
      MessageGenerator messageGenerator(file_->message_type(i));
      messageGenerator.Generate(writer);
    }
    writer->WriteLine("#endregion");
    writer->WriteLine();
  }

  // TODO(jtattermusch): add support for generating services.
  //WriteChildren(writer, "Services", Descriptor.Services);
  if (file_->options().csharp_nest_classes()) {
    writer->Outdent();
    writer->WriteLine("}");
  }
  if (!namespace_.empty()) {
    writer->Outdent();
    writer->WriteLine("}");
  }
  writer->WriteLine();
  writer->WriteLine("#endregion Designer generated code");
}

void UmbrellaClassGenerator::WriteIntroduction(Writer* writer) {
  writer->WriteLine(
      "// Generated by the protocol buffer compiler.  DO NOT EDIT!");
  writer->WriteLine("// source: $0$", file_->name());
  writer->WriteLine("#pragma warning disable 1591, 0612, 3021");
  writer->WriteLine("#region Designer generated code");

  writer->WriteLine();
  writer->WriteLine("using pb = global::Google.ProtocolBuffers;");
  writer->WriteLine("using pbc = global::Google.ProtocolBuffers.Collections;");
  writer->WriteLine("using pbd = global::Google.ProtocolBuffers.Descriptors;");
  writer->WriteLine("using scg = global::System.Collections.Generic;");

  if (!namespace_.empty()) {
    writer->WriteLine("namespace $0$ {", namespace_);
    writer->Indent();
    writer->WriteLine();
  }

  // Add the namespace around the umbrella class if defined
  if (!file_->options().csharp_nest_classes() && !umbrellaNamespace_.empty()) {
    writer->WriteLine("namespace $0$ {", umbrellaNamespace_);
    writer->Indent();
    writer->WriteLine();
  }

  if (file_->options().csharp_code_contracts()) {
    writer->WriteLine(
        "[global::System.Diagnostics.Contracts.ContractVerificationAttribute(false)]");
  }
  writer->WriteLine(
      "[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]");
  WriteGeneratedCodeAttributes(writer);
  writer->WriteLine("$0$ static partial class $1$ {", class_access_level(),
                    umbrellaClassname_);
  writer->WriteLine();
  writer->Indent();
}

void UmbrellaClassGenerator::WriteExtensionRegistration(Writer* writer) {
  writer->WriteLine("#region Extension registration");
  writer->WriteLine(
      "public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {");
  writer->Indent();
  for (int i = 0; i < file_->extension_count(); i++) {
    ExtensionGenerator extensionGenerator(file_->extension(i));
    extensionGenerator.GenerateExtensionRegistrationCode(writer);
  }
  for (int i = 0; i < file_->message_type_count(); i++) {
    MessageGenerator messageGenerator(file_->message_type(i));
    messageGenerator.GenerateExtensionRegistrationCode(writer);
  }
  writer->Outdent();
  writer->WriteLine("}");
  writer->WriteLine("#endregion");
}

void UmbrellaClassGenerator::WriteDescriptor(Writer* writer) {
  writer->WriteLine("#region Descriptor");

  writer->WriteLine("public static pbd::FileDescriptor Descriptor {");
  writer->WriteLine("  get { return descriptor; }");
  writer->WriteLine("}");
  writer->WriteLine("private static pbd::FileDescriptor descriptor;");
  writer->WriteLine();
  writer->WriteLine("static $0$() {", umbrellaClassname_);
  writer->Indent();
  writer->WriteLine(
      "byte[] descriptorData = global::System.Convert.FromBase64String(");
  writer->Indent();
  writer->Indent();
  writer->WriteLine("string.Concat(");
  writer->Indent();

  // TODO(jonskeet): Consider a C#-escaping format here instead of just Base64.
  std::string base64 = FileDescriptorToBase64(file_);
  while (base64.size() > 60) {
    writer->WriteLine("\"$0$\", ", base64.substr(0, 60));
    base64 = base64.substr(60);
  }
  writer->Outdent();
  writer->WriteLine("\"$0$\"));", base64);
  writer->Outdent();
  writer->Outdent();
  writer->WriteLine(
      "pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {");
  writer->Indent();
  writer->WriteLine("descriptor = root;");
  for (int i = 0; i < file_->message_type_count(); i++) {
    MessageGenerator messageGenerator(file_->message_type(i));
    messageGenerator.GenerateStaticVariableInitializers(writer);
  }
  for (int i = 0; i < file_->extension_count(); i++) {
    ExtensionGenerator extensionGenerator(file_->extension(i));
    extensionGenerator.GenerateStaticVariableInitializers(writer);
  }

  if (uses_extensions()) {
    // Must construct an ExtensionRegistry containing all possible extensions
    // and return it.
    writer->WriteLine(
        "pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();");
    writer->WriteLine("RegisterAllExtensions(registry);");
    for (int i = 0; i < file_->dependency_count(); i++) {
      writer->WriteLine("$0$.RegisterAllExtensions(registry);",
                        GetFullUmbrellaClassName(file_->dependency(i)));
    }
    writer->WriteLine("return registry;");
  } else {
    writer->WriteLine("return null;");
  }
  writer->Outdent();
  writer->WriteLine("};");

  // -----------------------------------------------------------------
  // Invoke internalBuildGeneratedFileFrom() to build the file.
  writer->WriteLine(
      "pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,");
  writer->WriteLine("    new pbd::FileDescriptor[] {");
  for (int i = 0; i < file_->dependency_count(); i++) {
    writer->WriteLine("    $0$.Descriptor, ",
                      GetFullUmbrellaClassName(file_->dependency(i)));
  }
  writer->WriteLine("    }, assigner);");
  writer->Outdent();
  writer->WriteLine("}");
  writer->WriteLine("#endregion");
  writer->WriteLine();
}

void UmbrellaClassGenerator::WriteLiteExtensions(Writer* writer) {
  writer->WriteLine("#region Extensions");
  writer->WriteLine("internal static readonly object Descriptor;");
  writer->WriteLine("static $0$() {", umbrellaClassname_);
  writer->Indent();
  writer->WriteLine("Descriptor = null;");
  for (int i = 0; i < file_->message_type_count(); i++) {
    MessageGenerator messageGenerator(file_->message_type(i));
    messageGenerator.GenerateStaticVariableInitializers(writer);
  }
  for (int i = 0; i < file_->extension_count(); i++) {
    ExtensionGenerator extensionGenerator(file_->extension(i));
    extensionGenerator.GenerateStaticVariableInitializers(writer);
  }
  writer->Outdent();
  writer->WriteLine("}");
  writer->WriteLine("#endregion");
  writer->WriteLine();
}

bool UmbrellaClassGenerator::uses_extensions() {
  // TODO(jtattermusch): implement recursive descent that looks for extensions.
  // For now, we conservatively assume that extensions are used.
  return true;
}

}  // namespace csharp
}  // namespace compiler
}  // namespace protobuf
}  // namespace google
