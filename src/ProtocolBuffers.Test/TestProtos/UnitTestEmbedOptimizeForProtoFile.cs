// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class UnitTestEmbedOptimizeForProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.Builder> internal__static_protobuf_unittest_TestEmbedOptimizedForSize__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static UnitTestEmbedOptimizeForProtoFile() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CjFnb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfZW1iZWRfb3B0aW1pemVfZm9y" + 
          "LnByb3RvEhFwcm90b2J1Zl91bml0dGVzdBokZ29vZ2xlL3Byb3RvYnVmL2Nz" + 
          "aGFycF9vcHRpb25zLnByb3RvGitnb29nbGUvcHJvdG9idWYvdW5pdHRlc3Rf" + 
          "b3B0aW1pemVfZm9yLnByb3RvIqEBChlUZXN0RW1iZWRPcHRpbWl6ZWRGb3JT" + 
          "aXplEkEKEG9wdGlvbmFsX21lc3NhZ2UYASABKAsyJy5wcm90b2J1Zl91bml0" + 
          "dGVzdC5UZXN0T3B0aW1pemVkRm9yU2l6ZRJBChByZXBlYXRlZF9tZXNzYWdl" + 
          "GAIgAygLMicucHJvdG9idWZfdW5pdHRlc3QuVGVzdE9wdGltaXplZEZvclNp" + 
          "emVCS0gBwj5GCiFHb29nbGUuUHJvdG9jb2xCdWZmZXJzLlRlc3RQcm90b3MS" + 
          "IVVuaXRUZXN0RW1iZWRPcHRpbWl6ZUZvclByb3RvRmlsZQ==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protobuf_unittest_TestEmbedOptimizedForSize__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.Builder>(internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor,
                new string[] { "OptionalMessage", "RepeatedMessage", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class TestEmbedOptimizedForSize : pb::GeneratedMessage<TestEmbedOptimizedForSize, TestEmbedOptimizedForSize.Builder> {
    private TestEmbedOptimizedForSize() { }
    private static readonly TestEmbedOptimizedForSize defaultInstance = new Builder().BuildPartial();
    private static readonly string[] _testEmbedOptimizedForSizeFieldNames = new string[] { "optional_message", "repeated_message" };
    private static readonly uint[] _testEmbedOptimizedForSizeFieldTags = new uint[] { 10, 18 };
    public static TestEmbedOptimizedForSize DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestEmbedOptimizedForSize DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestEmbedOptimizedForSize ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestEmbedOptimizeForProtoFile.internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestEmbedOptimizedForSize, TestEmbedOptimizedForSize.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestEmbedOptimizeForProtoFile.internal__static_protobuf_unittest_TestEmbedOptimizedForSize__FieldAccessorTable; }
    }
    
    public const int OptionalMessageFieldNumber = 1;
    private bool hasOptionalMessage;
    private global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance;
    public bool HasOptionalMessage {
      get { return hasOptionalMessage; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize OptionalMessage {
      get { return optionalMessage_; }
    }
    
    public const int RepeatedMessageFieldNumber = 2;
    private pbc::PopsicleList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> repeatedMessage_ = new pbc::PopsicleList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize>();
    public scg::IList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> RepeatedMessageList {
      get { return repeatedMessage_; }
    }
    public int RepeatedMessageCount {
      get { return repeatedMessage_.Count; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize GetRepeatedMessage(int index) {
      return repeatedMessage_[index];
    }
    
    public override bool IsInitialized {
      get {
        if (HasOptionalMessage) {
          if (!OptionalMessage.IsInitialized) return false;
        }
        foreach (global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize element in RepeatedMessageList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _testEmbedOptimizedForSizeFieldNames;
      if (hasOptionalMessage) {
        output.WriteMessage(1, field_names[0], OptionalMessage);
      }
      if (repeatedMessage_.Count > 0) {
        output.WriteMessageArray(2, field_names[1], repeatedMessage_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasOptionalMessage) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, OptionalMessage);
        }
        foreach (global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize element in RepeatedMessageList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static TestEmbedOptimizedForSize ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestEmbedOptimizedForSize prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilder<TestEmbedOptimizedForSize, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestEmbedOptimizedForSize result = new TestEmbedOptimizedForSize();
      
      protected override TestEmbedOptimizedForSize MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestEmbedOptimizedForSize();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.Descriptor; }
      }
      
      public override TestEmbedOptimizedForSize DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.DefaultInstance; }
      }
      
      public override TestEmbedOptimizedForSize BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.repeatedMessage_.MakeReadOnly();
        TestEmbedOptimizedForSize returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is TestEmbedOptimizedForSize) {
          return MergeFrom((TestEmbedOptimizedForSize) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TestEmbedOptimizedForSize other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.DefaultInstance) return this;
        if (other.HasOptionalMessage) {
          MergeOptionalMessage(other.OptionalMessage);
        }
        if (other.repeatedMessage_.Count != 0) {
          result.repeatedMessage_.Add(other.repeatedMessage_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_testEmbedOptimizedForSizeFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _testEmbedOptimizedForSizeFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.CreateBuilder();
              if (result.hasOptionalMessage) {
                subBuilder.MergeFrom(OptionalMessage);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              OptionalMessage = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.repeatedMessage_, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasOptionalMessage {
       get { return result.hasOptionalMessage; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize OptionalMessage {
        get { return result.OptionalMessage; }
        set { SetOptionalMessage(value); }
      }
      public Builder SetOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasOptionalMessage = true;
        result.optionalMessage_ = value;
        return this;
      }
      public Builder SetOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasOptionalMessage = true;
        result.optionalMessage_ = builderForValue.Build();
        return this;
      }
      public Builder MergeOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.hasOptionalMessage &&
            result.optionalMessage_ != global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance) {
            result.optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.CreateBuilder(result.optionalMessage_).MergeFrom(value).BuildPartial();
        } else {
          result.optionalMessage_ = value;
        }
        result.hasOptionalMessage = true;
        return this;
      }
      public Builder ClearOptionalMessage() {
        result.hasOptionalMessage = false;
        result.optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance;
        return this;
      }
      
      public pbc::IPopsicleList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> RepeatedMessageList {
        get { return result.repeatedMessage_; }
      }
      public int RepeatedMessageCount {
        get { return result.RepeatedMessageCount; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize GetRepeatedMessage(int index) {
        return result.GetRepeatedMessage(index);
      }
      public Builder SetRepeatedMessage(int index, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.repeatedMessage_[index] = value;
        return this;
      }
      public Builder SetRepeatedMessage(int index, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.repeatedMessage_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddRepeatedMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.repeatedMessage_.Add(value);
        return this;
      }
      public Builder AddRepeatedMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.repeatedMessage_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeRepeatedMessage(scg::IEnumerable<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> values) {
        result.repeatedMessage_.Add(values);
        return this;
      }
      public Builder ClearRepeatedMessage() {
        result.repeatedMessage_.Clear();
        return this;
      }
    }
    static TestEmbedOptimizedForSize() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnitTestEmbedOptimizeForProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
