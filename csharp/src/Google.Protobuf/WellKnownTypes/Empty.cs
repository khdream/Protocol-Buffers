// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/empty.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Empty {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Empty() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Chtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8SD2dvb2dsZS5wcm90b2J1", 
              "ZiIHCgVFbXB0eUJKChNjb20uZ29vZ2xlLnByb3RvYnVmQgpFbXB0eVByb3Rv", 
              "UAGiAgNHUEKqAh5Hb29nbGUuUHJvdG9idWYuV2VsbEtub3duVHlwZXNiBnBy", 
            "b3RvMw=="));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new global::System.Type[] { typeof(global::Google.Protobuf.WellKnownTypes.Empty), });
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] {  };
    private static readonly uint[] _fieldTags = new uint[] {  };
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Proto.Empty.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    private bool _frozen = false;
    public bool IsFrozen { get { return _frozen; } }

    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Empty(Empty other) : this() {
    }

    public Empty Clone() {
      return new Empty(this);
    }

    public void Freeze() {
      if (IsFrozen) {
        return;
      }
      _frozen = true;
    }

    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
