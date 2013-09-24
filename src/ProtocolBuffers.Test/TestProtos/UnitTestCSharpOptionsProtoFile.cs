// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UnitTestCSharpOptionsProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_protobuf_unittest_OptionsMessage__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.OptionsMessage, global::Google.ProtocolBuffers.TestProtos.OptionsMessage.Builder> internal__static_protobuf_unittest_OptionsMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static UnitTestCSharpOptionsProtoFile() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfY3NoYXJwX29wdGlvbnMucHJv", 
            "dG8SEXByb3RvYnVmX3VuaXR0ZXN0GiRnb29nbGUvcHJvdG9idWYvY3NoYXJw", 
            "X29wdGlvbnMucHJvdG8iXgoOT3B0aW9uc01lc3NhZ2USDgoGbm9ybWFsGAEg", 
            "ASgJEhcKD29wdGlvbnNfbWVzc2FnZRgCIAEoCRIjCgpjdXN0b21pemVkGAMg", 
            "ASgJQg/CPgwKCkN1c3RvbU5hbWVCRsI+QwohR29vZ2xlLlByb3RvY29sQnVm", 
            "ZmVycy5UZXN0UHJvdG9zEh5Vbml0VGVzdENTaGFycE9wdGlvbnNQcm90b0Zp", 
          "bGU="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_protobuf_unittest_OptionsMessage__Descriptor = Descriptor.MessageTypes[0];
        internal__static_protobuf_unittest_OptionsMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.OptionsMessage, global::Google.ProtocolBuffers.TestProtos.OptionsMessage.Builder>(internal__static_protobuf_unittest_OptionsMessage__Descriptor,
                new string[] { "Normal", "OptionsMessage_", "CustomName", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class OptionsMessage : pb::GeneratedMessage<OptionsMessage, OptionsMessage.Builder> {
    private OptionsMessage() { }
    private static readonly OptionsMessage defaultInstance = new OptionsMessage().MakeReadOnly();
    private static readonly string[] _optionsMessageFieldNames = new string[] { "customized", "normal", "options_message" };
    private static readonly uint[] _optionsMessageFieldTags = new uint[] { 26, 10, 18 };
    public static OptionsMessage DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override OptionsMessage DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override OptionsMessage ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestCSharpOptionsProtoFile.internal__static_protobuf_unittest_OptionsMessage__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<OptionsMessage, OptionsMessage.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestCSharpOptionsProtoFile.internal__static_protobuf_unittest_OptionsMessage__FieldAccessorTable; }
    }
    
    public const int NormalFieldNumber = 1;
    private bool hasNormal;
    private string normal_ = "";
    public bool HasNormal {
      get { return hasNormal; }
    }
    public string Normal {
      get { return normal_; }
    }
    
    public const int OptionsMessage_FieldNumber = 2;
    private bool hasOptionsMessage_;
    private string optionsMessage_ = "";
    public bool HasOptionsMessage_ {
      get { return hasOptionsMessage_; }
    }
    public string OptionsMessage_ {
      get { return optionsMessage_; }
    }
    
    public const int CustomNameFieldNumber = 3;
    private bool hasCustomName;
    private string customized_ = "";
    public bool HasCustomName {
      get { return hasCustomName; }
    }
    public string CustomName {
      get { return customized_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _optionsMessageFieldNames;
      if (hasNormal) {
        output.WriteString(1, field_names[1], Normal);
      }
      if (hasOptionsMessage_) {
        output.WriteString(2, field_names[2], OptionsMessage_);
      }
      if (hasCustomName) {
        output.WriteString(3, field_names[0], CustomName);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasNormal) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Normal);
        }
        if (hasOptionsMessage_) {
          size += pb::CodedOutputStream.ComputeStringSize(2, OptionsMessage_);
        }
        if (hasCustomName) {
          size += pb::CodedOutputStream.ComputeStringSize(3, CustomName);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static OptionsMessage ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static OptionsMessage ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static OptionsMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static OptionsMessage ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static OptionsMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private OptionsMessage MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(OptionsMessage prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<OptionsMessage, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(OptionsMessage cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private OptionsMessage result;
      
      private OptionsMessage PrepareBuilder() {
        if (resultIsReadOnly) {
          OptionsMessage original = result;
          result = new OptionsMessage();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override OptionsMessage MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.TestProtos.OptionsMessage.Descriptor; }
      }
      
      public override OptionsMessage DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.OptionsMessage.DefaultInstance; }
      }
      
      public override OptionsMessage BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is OptionsMessage) {
          return MergeFrom((OptionsMessage) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(OptionsMessage other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.OptionsMessage.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasNormal) {
          Normal = other.Normal;
        }
        if (other.HasOptionsMessage_) {
          OptionsMessage_ = other.OptionsMessage_;
        }
        if (other.HasCustomName) {
          CustomName = other.CustomName;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_optionsMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _optionsMessageFieldTags[field_ordinal];
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
              result.hasNormal = input.ReadString(ref result.normal_);
              break;
            }
            case 18: {
              result.hasOptionsMessage_ = input.ReadString(ref result.optionsMessage_);
              break;
            }
            case 26: {
              result.hasCustomName = input.ReadString(ref result.customized_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasNormal {
        get { return result.hasNormal; }
      }
      public string Normal {
        get { return result.Normal; }
        set { SetNormal(value); }
      }
      public Builder SetNormal(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasNormal = true;
        result.normal_ = value;
        return this;
      }
      public Builder ClearNormal() {
        PrepareBuilder();
        result.hasNormal = false;
        result.normal_ = "";
        return this;
      }
      
      public bool HasOptionsMessage_ {
        get { return result.hasOptionsMessage_; }
      }
      public string OptionsMessage_ {
        get { return result.OptionsMessage_; }
        set { SetOptionsMessage_(value); }
      }
      public Builder SetOptionsMessage_(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasOptionsMessage_ = true;
        result.optionsMessage_ = value;
        return this;
      }
      public Builder ClearOptionsMessage_() {
        PrepareBuilder();
        result.hasOptionsMessage_ = false;
        result.optionsMessage_ = "";
        return this;
      }
      
      public bool HasCustomName {
        get { return result.hasCustomName; }
      }
      public string CustomName {
        get { return result.CustomName; }
        set { SetCustomName(value); }
      }
      public Builder SetCustomName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasCustomName = true;
        result.customized_ = value;
        return this;
      }
      public Builder ClearCustomName() {
        PrepareBuilder();
        result.hasCustomName = false;
        result.customized_ = "";
        return this;
      }
    }
    static OptionsMessage() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnitTestCSharpOptionsProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
