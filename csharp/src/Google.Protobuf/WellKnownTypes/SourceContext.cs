// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/source_context.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class SourceContext {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static SourceContext() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "CiRnb29nbGUvcHJvdG9idWYvc291cmNlX2NvbnRleHQucHJvdG8SD2dvb2ds", 
              "ZS5wcm90b2J1ZiIiCg1Tb3VyY2VDb250ZXh0EhEKCWZpbGVfbmFtZRgBIAEo", 
              "CUJSChNjb20uZ29vZ2xlLnByb3RvYnVmQhJTb3VyY2VDb250ZXh0UHJvdG9Q", 
              "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv", 
            "dG8z"));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new global::System.Type[] { typeof(global::Google.Protobuf.WellKnownTypes.SourceContext), });
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SourceContext : pb::IMessage<SourceContext> {
    private static readonly pb::MessageParser<SourceContext> _parser = new pb::MessageParser<SourceContext>(() => new SourceContext());
    public static pb::MessageParser<SourceContext> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] { "file_name" };
    private static readonly uint[] _fieldTags = new uint[] { 10 };
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Proto.SourceContext.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    private bool _frozen = false;
    public bool IsFrozen { get { return _frozen; } }

    public SourceContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SourceContext(SourceContext other) : this() {
      fileName_ = other.fileName_;
    }

    public SourceContext Clone() {
      return new SourceContext(this);
    }

    public void Freeze() {
      if (IsFrozen) {
        return;
      }
      _frozen = true;
    }

    public const int FileNameFieldNumber = 1;
    private string fileName_ = "";
    [pbr::ProtobufField(1, "file_name")]
    public string FileName {
      get { return fileName_; }
      set {
        pb::Freezable.CheckMutable(this);
        fileName_ = value ?? "";
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SourceContext);
    }

    public bool Equals(SourceContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileName != other.FileName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      return size;
    }

    public void MergeFrom(SourceContext other) {
      if (other == null) {
        return;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while (input.ReadTag(out tag)) {
        switch(tag) {
          case 0:
            throw pb::InvalidProtocolBufferException.InvalidTag();
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            break;
          case 10: {
            FileName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
