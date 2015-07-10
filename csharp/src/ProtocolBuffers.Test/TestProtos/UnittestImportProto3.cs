// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/unittest_import_proto3.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbd = global::Google.Protobuf.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.TestProtos {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UnittestImportProto3 {

    #region Static variables
    internal static pb::FieldAccess.FieldAccessorTable internal__static_protobuf_unittest_import_ImportMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;

    static UnittestImportProto3() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfaW1wb3J0X3Byb3RvMy5wcm90", 
            "bxIYcHJvdG9idWZfdW5pdHRlc3RfaW1wb3J0GjNnb29nbGUvcHJvdG9idWYv", 
            "dW5pdHRlc3RfaW1wb3J0X3B1YmxpY19wcm90bzMucHJvdG8iGgoNSW1wb3J0", 
            "TWVzc2FnZRIJCgFkGAEgASgFKlkKCkltcG9ydEVudW0SGwoXSU1QT1JUX0VO", 
            "VU1fVU5TUEVDSUZJRUQQABIOCgpJTVBPUlRfRk9PEAcSDgoKSU1QT1JUX0JB", 
            "UhAIEg4KCklNUE9SVF9CQVoQCUI8Chhjb20uZ29vZ2xlLnByb3RvYnVmLnRl", 
            "c3RIAfgBAaoCGkdvb2dsZS5Qcm90b2J1Zi5UZXN0UHJvdG9zUABiBnByb3Rv", 
          "Mw=="));
      descriptor = pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.Protobuf.TestProtos.UnittestImportPublicProto3.Descriptor, 
          });
      internal__static_protobuf_unittest_import_ImportMessage__FieldAccessorTable = 
          new pb::FieldAccess.FieldAccessorTable(typeof(global::Google.Protobuf.TestProtos.ImportMessage), descriptor.MessageTypes[0],
              new string[] { "D", });
    }
    #endregion

  }
  #region Enums
  public enum ImportEnum {
    IMPORT_ENUM_UNSPECIFIED = 0,
    IMPORT_FOO = 7,
    IMPORT_BAR = 8,
    IMPORT_BAZ = 9,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ImportMessage : pb::IMessage<ImportMessage> {
    private static readonly pb::MessageParser<ImportMessage> _parser = new pb::MessageParser<ImportMessage>(() => new ImportMessage());
    public static pb::MessageParser<ImportMessage> Parser { get { return _parser; } }

    private static readonly string[] _fieldNames = new string[] { "d" };
    private static readonly uint[] _fieldTags = new uint[] { 8 };
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.TestProtos.UnittestImportProto3.Descriptor.MessageTypes[0]; }
    }

    public pb::FieldAccess.FieldAccessorTable Fields {
      get { return global::Google.Protobuf.TestProtos.UnittestImportProto3.internal__static_protobuf_unittest_import_ImportMessage__FieldAccessorTable; }
    }

    private bool _frozen = false;
    public bool IsFrozen { get { return _frozen; } }

    public ImportMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ImportMessage(ImportMessage other) : this() {
      d_ = other.d_;
    }

    public ImportMessage Clone() {
      return new ImportMessage(this);
    }

    public void Freeze() {
      if (IsFrozen) {
        return;
      }
      _frozen = true;
    }

    public const int DFieldNumber = 1;
    private int d_;
    public int D {
      get { return d_; }
      set {
        pb::Freezable.CheckMutable(this);
        d_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ImportMessage);
    }

    public bool Equals(ImportMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (D != other.D) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (D != 0) hash ^= D.GetHashCode();
      return hash;
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (D != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(D);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (D != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(D);
      }
      return size;
    }

    public void MergeFrom(ImportMessage other) {
      if (other == null) {
        return;
      }
      if (other.D != 0) {
        D = other.D;
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
          case 8: {
            D = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
