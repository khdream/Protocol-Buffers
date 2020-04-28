﻿#region Copyright notice and license
// Protocol Buffers - Google's data interchange format
// Copyright 2017 Google Inc.  All rights reserved.
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

using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using UnitTest.Issues.TestProtos;
using static Google.Protobuf.WireFormat;
using static UnitTest.Issues.TestProtos.ComplexOptionType2.Types;
using static UnitTest.Issues.TestProtos.UnittestCustomOptionsProto3Extensions;
using static UnitTest.Issues.TestProtos.DummyMessageContainingEnum.Types;
using Google.Protobuf.TestProtos;

#pragma warning disable CS0618

namespace Google.Protobuf.Test.Reflection
{
    /// <summary>
    /// The majority of the testing here is done via parsed descriptors. That's simpler to
    /// achieve (and more important) than constructing a CodedInputStream manually.
    /// </summary>
    public class CustomOptionsTest
    {
        delegate bool OptionFetcher<T>(int field, out T value);

        OptionFetcher<E> EnumFetcher<E>(CustomOptions options)
        {
            return (int i, out E v) => {
                if (options.TryGetInt32(i, out int value))
                {
                    v = (E)(object)value;
                    return true;
                }
                else
                {
                    v = default(E);
                    return false;
                }
            };
        }

        [Test]
        public void ScalarOptions()
        {
            var d = CustomOptionOtherValues.Descriptor;
            var customOptions = d.CustomOptions;
            AssertOption(-100, customOptions.TryGetInt32, Int32Opt, d.Options.GetExtension);
            AssertOption(12.3456789f, customOptions.TryGetFloat, FloatOpt, d.Options.GetExtension);
            AssertOption(1.234567890123456789d, customOptions.TryGetDouble, DoubleOpt, d.Options.GetExtension);
            AssertOption("Hello, \"World\"", customOptions.TryGetString, StringOpt, d.Options.GetExtension);
            AssertOption(ByteString.CopyFromUtf8("Hello\0World"), customOptions.TryGetBytes, BytesOpt, d.Options.GetExtension);
            AssertOption(TestEnumType.TestOptionEnumType2, EnumFetcher<TestEnumType>(customOptions), EnumOpt, d.Options.GetExtension);
        }

        [Test]
        public void MessageOptions()
        {
            var d = VariousComplexOptions.Descriptor;
            var customOptions = d.CustomOptions;
            AssertOption(new ComplexOptionType1 { Foo = 42, Foo4 = { 99, 88 } }, customOptions.TryGetMessage, ComplexOpt1, d.Options.GetExtension);
            AssertOption(new ComplexOptionType2
            {
                Baz = 987,
                Bar = new ComplexOptionType1 { Foo = 743 },
                Fred = new ComplexOptionType4 { Waldo = 321 },
                Barney = { new ComplexOptionType4 { Waldo = 101 }, new ComplexOptionType4 { Waldo = 212 } }
            },
                customOptions.TryGetMessage, ComplexOpt2, d.Options.GetExtension);
            AssertOption(new ComplexOptionType3 { Qux = 9 }, customOptions.TryGetMessage, ComplexOpt3, d.Options.GetExtension);
        }

        [Test]
        public void OptionLocations()
        {
            var fileDescriptor = UnittestCustomOptionsProto3Reflection.Descriptor;
            AssertOption(9876543210UL, fileDescriptor.CustomOptions.TryGetUInt64, FileOpt1, fileDescriptor.Options.GetExtension);

            var messageDescriptor = TestMessageWithCustomOptions.Descriptor;
            AssertOption(-56, messageDescriptor.CustomOptions.TryGetInt32, MessageOpt1, messageDescriptor.Options.GetExtension);

            var fieldDescriptor = TestMessageWithCustomOptions.Descriptor.Fields["field1"];
            AssertOption(8765432109UL, fieldDescriptor.CustomOptions.TryGetFixed64, FieldOpt1, fieldDescriptor.Options.GetExtension);

            var oneofDescriptor = TestMessageWithCustomOptions.Descriptor.Oneofs[0];
            AssertOption(-99, oneofDescriptor.CustomOptions.TryGetInt32, OneofOpt1, oneofDescriptor.Options.GetExtension);

            var enumDescriptor = TestMessageWithCustomOptions.Descriptor.EnumTypes[0];
            AssertOption(-789, enumDescriptor.CustomOptions.TryGetSFixed32, EnumOpt1, enumDescriptor.Options.GetExtension);

            var enumValueDescriptor = TestMessageWithCustomOptions.Descriptor.EnumTypes[0].FindValueByNumber(2);
            AssertOption(123, enumValueDescriptor.CustomOptions.TryGetInt32, EnumValueOpt1, enumValueDescriptor.Options.GetExtension);

            var serviceDescriptor = UnittestCustomOptionsProto3Reflection.Descriptor.Services
                .Single(s => s.Name == "TestServiceWithCustomOptions");
            AssertOption(-9876543210, serviceDescriptor.CustomOptions.TryGetSInt64, ServiceOpt1, serviceDescriptor.Options.GetExtension);

            var methodDescriptor = serviceDescriptor.Methods[0];
            AssertOption(UnitTest.Issues.TestProtos.MethodOpt1.Val2, EnumFetcher<UnitTest.Issues.TestProtos.MethodOpt1>(methodDescriptor.CustomOptions), UnittestCustomOptionsProto3Extensions.MethodOpt1, methodDescriptor.Options.GetExtension);
        }

        [Test]
        public void MinValues()
        {
            var d = CustomOptionMinIntegerValues.Descriptor;
            var customOptions = d.CustomOptions;
            AssertOption(false, customOptions.TryGetBool, BoolOpt, d.Options.GetExtension);
            AssertOption(int.MinValue, customOptions.TryGetInt32, Int32Opt, d.Options.GetExtension);
            AssertOption(long.MinValue, customOptions.TryGetInt64, Int64Opt, d.Options.GetExtension);
            AssertOption(uint.MinValue, customOptions.TryGetUInt32, Uint32Opt, d.Options.GetExtension);
            AssertOption(ulong.MinValue, customOptions.TryGetUInt64, Uint64Opt, d.Options.GetExtension);
            AssertOption(int.MinValue, customOptions.TryGetSInt32, Sint32Opt, d.Options.GetExtension);
            AssertOption(long.MinValue, customOptions.TryGetSInt64, Sint64Opt, d.Options.GetExtension);
            AssertOption(uint.MinValue, customOptions.TryGetUInt32, Fixed32Opt, d.Options.GetExtension);
            AssertOption(ulong.MinValue, customOptions.TryGetUInt64, Fixed64Opt, d.Options.GetExtension);
            AssertOption(int.MinValue, customOptions.TryGetInt32, Sfixed32Opt, d.Options.GetExtension);
            AssertOption(long.MinValue, customOptions.TryGetInt64, Sfixed64Opt, d.Options.GetExtension);
        }

        [Test]
        public void MaxValues()
        {
            var d = CustomOptionMaxIntegerValues.Descriptor;
            var customOptions = d.CustomOptions;
            AssertOption(true, customOptions.TryGetBool, BoolOpt, d.Options.GetExtension);
            AssertOption(int.MaxValue, customOptions.TryGetInt32, Int32Opt, d.Options.GetExtension);
            AssertOption(long.MaxValue, customOptions.TryGetInt64, Int64Opt, d.Options.GetExtension);
            AssertOption(uint.MaxValue, customOptions.TryGetUInt32, Uint32Opt, d.Options.GetExtension);
            AssertOption(ulong.MaxValue, customOptions.TryGetUInt64, Uint64Opt, d.Options.GetExtension);
            AssertOption(int.MaxValue, customOptions.TryGetSInt32, Sint32Opt, d.Options.GetExtension);
            AssertOption(long.MaxValue, customOptions.TryGetSInt64, Sint64Opt, d.Options.GetExtension);
            AssertOption(uint.MaxValue, customOptions.TryGetFixed32, Fixed32Opt, d.Options.GetExtension);
            AssertOption(ulong.MaxValue, customOptions.TryGetFixed64, Fixed64Opt, d.Options.GetExtension);
            AssertOption(int.MaxValue, customOptions.TryGetSFixed32, Sfixed32Opt, d.Options.GetExtension);
            AssertOption(long.MaxValue, customOptions.TryGetSFixed64, Sfixed64Opt, d.Options.GetExtension);
        }

        [Test]
        public void AggregateOptions()
        {
            // Just two examples
            var messageDescriptor = AggregateMessage.Descriptor;
            AssertOption(new Aggregate { I = 101, S = "MessageAnnotation" }, messageDescriptor.CustomOptions.TryGetMessage, Msgopt, messageDescriptor.Options.GetExtension);

            var fieldDescriptor = messageDescriptor.Fields["fieldname"];
            AssertOption(new Aggregate { S = "FieldAnnotation" }, fieldDescriptor.CustomOptions.TryGetMessage, Fieldopt, fieldDescriptor.Options.GetExtension);
        }

        [Test]
        public void NoOptions()
        {
            var fileDescriptor = UnittestProto3Reflection.Descriptor;
            var messageDescriptor = TestAllTypes.Descriptor;
            Assert.NotNull(fileDescriptor.CustomOptions);
            Assert.NotNull(messageDescriptor.CustomOptions);
            Assert.NotNull(messageDescriptor.Fields[1].CustomOptions);
            Assert.NotNull(fileDescriptor.Services[0].CustomOptions);
            Assert.NotNull(fileDescriptor.Services[0].Methods[0].CustomOptions);
            Assert.NotNull(fileDescriptor.EnumTypes[0].CustomOptions);
            Assert.NotNull(fileDescriptor.EnumTypes[0].Values[0].CustomOptions);
            Assert.NotNull(TestAllTypes.Descriptor.Oneofs[0].CustomOptions);
        }

        [Test]
        public void MultipleImportOfSameFileWithExtension()
        {
            var descriptor = UnittestIssue6936CReflection.Descriptor;
            var foo = Foo.Descriptor;
            var bar = Bar.Descriptor;
            AssertOption("foo", foo.CustomOptions.TryGetString, UnittestIssue6936AExtensions.Opt, foo.Options.GetExtension);
            AssertOption("bar", bar.CustomOptions.TryGetString, UnittestIssue6936AExtensions.Opt, bar.Options.GetExtension);
        }

        private void AssertOption<T, D>(T expected, OptionFetcher<T> customOptionFetcher, Extension<D, T> extension, Func<Extension<D, T>, T> extensionFetcher) where D : IExtendableMessage<D>
        {
            Assert.IsTrue(customOptionFetcher(extension.FieldNumber, out T customOptionsValue));
            Assert.AreEqual(expected, customOptionsValue);

            T extensionValue = extensionFetcher(extension);
            Assert.AreEqual(expected, extensionValue);
        }
    }
}
