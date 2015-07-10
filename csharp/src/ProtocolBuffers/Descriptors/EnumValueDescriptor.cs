#region Copyright notice and license
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
#endregion

using Google.Protobuf.DescriptorProtos;

namespace Google.Protobuf.Descriptors
{
    /// <summary>
    /// Descriptor for a single enum value within an enum in a .proto file.
    /// </summary>
    public sealed class EnumValueDescriptor : DescriptorBase                                            
    {
        private readonly EnumDescriptor enumDescriptor;
        private readonly EnumValueDescriptorProto proto;

        internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file,
                                     EnumDescriptor parent, int index)
            : base(file, parent.FullName + "." + proto.Name, index)
        {
            this.proto = proto;
            enumDescriptor = parent;
            file.DescriptorPool.AddSymbol(this);
            file.DescriptorPool.AddEnumValueByNumber(this);
        }

        internal EnumValueDescriptorProto Proto { get { return proto; } }
        
        public override string Name { get { return proto.Name; } }

        public int Number { get { return Proto.Number; } }

        public EnumDescriptor EnumDescriptor { get { return enumDescriptor; } }
    }
}