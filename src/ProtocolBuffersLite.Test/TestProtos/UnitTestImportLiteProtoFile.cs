// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public static partial class UnitTestImportLiteProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static UnitTestImportLiteProtoFile() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Enums
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public enum ImportEnumLite {
    IMPORT_LITE_FOO = 7,
    IMPORT_LITE_BAR = 8,
    IMPORT_LITE_BAZ = 9,
  }
  
  #endregion
  
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
  public sealed partial class ImportMessageLite : pb::GeneratedMessageLite<ImportMessageLite, ImportMessageLite.Builder> {
    private static readonly ImportMessageLite defaultInstance = new ImportMessageLite().MakeReadOnly();
    private static readonly string[] _importMessageLiteFieldNames = new string[] { "d" };
    private static readonly uint[] _importMessageLiteFieldTags = new uint[] { 8 };
    public static ImportMessageLite DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ImportMessageLite DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override ImportMessageLite ThisMessage {
      get { return this; }
    }
    
    public const int DFieldNumber = 1;
    private bool hasD;
    private int d_;
    public bool HasD {
      get { return hasD; }
    }
    public int D {
      get { return d_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _importMessageLiteFieldNames;
      if (hasD) {
        output.WriteInt32(1, field_names[0], D);
      }
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasD) {
          size += pb::CodedOutputStream.ComputeInt32Size(1, D);
        }
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasD) hash ^= d_.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      ImportMessageLite other = obj as ImportMessageLite;
      if (other == null) return false;
      if (hasD != other.hasD || (hasD && !d_.Equals(other.d_))) return false;
      return true;
    }
    
    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("d", hasD, d_, writer);
    }
    #endregion
    
    public static ImportMessageLite ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ImportMessageLite ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ImportMessageLite ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ImportMessageLite ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ImportMessageLite MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ImportMessageLite prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.3.0.277")]
    public sealed partial class Builder : pb::GeneratedBuilderLite<ImportMessageLite, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ImportMessageLite cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private ImportMessageLite result;
      
      private ImportMessageLite PrepareBuilder() {
        if (resultIsReadOnly) {
          ImportMessageLite original = result;
          result = new ImportMessageLite();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override ImportMessageLite MessageBeingBuilt {
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
      
      public override ImportMessageLite DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.ImportMessageLite.DefaultInstance; }
      }
      
      public override ImportMessageLite BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is ImportMessageLite) {
          return MergeFrom((ImportMessageLite) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ImportMessageLite other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.ImportMessageLite.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasD) {
          D = other.D;
        }
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_importMessageLiteFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _importMessageLiteFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasD = input.ReadInt32(ref result.d_);
              break;
            }
          }
        }
        
        return this;
      }
      
      
      public bool HasD {
        get { return result.hasD; }
      }
      public int D {
        get { return result.D; }
        set { SetD(value); }
      }
      public Builder SetD(int value) {
        PrepareBuilder();
        result.hasD = true;
        result.d_ = value;
        return this;
      }
      public Builder ClearD() {
        PrepareBuilder();
        result.hasD = false;
        result.d_ = 0;
        return this;
      }
    }
    static ImportMessageLite() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnitTestImportLiteProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
