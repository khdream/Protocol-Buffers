// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.Examples.AddressBook {
  
  public static partial class AddressBookProtos {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_tutorial_Person__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Builder> internal__static_tutorial_Person__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_tutorial_Person_PhoneNumber__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Builder> internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_tutorial_AddressBook__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook, global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook.Builder> internal__static_tutorial_AddressBook__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static AddressBookProtos() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "Chp0dXRvcmlhbC9hZGRyZXNzYm9vay5wcm90bxIIdHV0b3JpYWwaJGdvb2ds" + 
          "ZS9wcm90b2J1Zi9jc2hhcnBfb3B0aW9ucy5wcm90byLaAQoGUGVyc29uEgwK" + 
          "BG5hbWUYASACKAkSCgoCaWQYAiACKAUSDQoFZW1haWwYAyABKAkSKwoFcGhv" + 
          "bmUYBCADKAsyHC50dXRvcmlhbC5QZXJzb24uUGhvbmVOdW1iZXIaTQoLUGhv" + 
          "bmVOdW1iZXISDgoGbnVtYmVyGAEgAigJEi4KBHR5cGUYAiABKA4yGi50dXRv" + 
          "cmlhbC5QZXJzb24uUGhvbmVUeXBlOgRIT01FIisKCVBob25lVHlwZRIKCgZN" + 
          "T0JJTEUQABIICgRIT01FEAESCAoEV09SSxACIi8KC0FkZHJlc3NCb29rEiAK" + 
          "BnBlcnNvbhgBIAMoCzIQLnR1dG9yaWFsLlBlcnNvbkJFSAHCPkAKK0dvb2ds" + 
          "ZS5Qcm90b2NvbEJ1ZmZlcnMuRXhhbXBsZXMuQWRkcmVzc0Jvb2sSEUFkZHJl" + 
          "c3NCb29rUHJvdG9z");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_tutorial_Person__Descriptor = Descriptor.MessageTypes[0];
        internal__static_tutorial_Person__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Builder>(internal__static_tutorial_Person__Descriptor,
                new string[] { "Name", "Id", "Email", "Phone", });
        internal__static_tutorial_Person_PhoneNumber__Descriptor = internal__static_tutorial_Person__Descriptor.NestedTypes[0];
        internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Builder>(internal__static_tutorial_Person_PhoneNumber__Descriptor,
                new string[] { "Number", "Type", });
        internal__static_tutorial_AddressBook__Descriptor = Descriptor.MessageTypes[1];
        internal__static_tutorial_AddressBook__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook, global::Google.ProtocolBuffers.Examples.AddressBook.AddressBook.Builder>(internal__static_tutorial_AddressBook__Descriptor,
                new string[] { "Person", });
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
  public sealed partial class Person : pb::GeneratedMessage<Person, Person.Builder> {
    private static readonly Person defaultInstance = new Builder().BuildPartial();
    public static Person DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Person DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Person ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_Person__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Person, Person.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_Person__FieldAccessorTable; }
    }
    
    #region Nested types
    public static class Types {
      public enum PhoneType {
        MOBILE = 0,
        HOME = 1,
        WORK = 2,
      }
      
      public sealed partial class PhoneNumber : pb::GeneratedMessage<PhoneNumber, PhoneNumber.Builder> {
        private static readonly PhoneNumber defaultInstance = new Builder().BuildPartial();
        public static PhoneNumber DefaultInstance {
          get { return defaultInstance; }
        }
        
        public override PhoneNumber DefaultInstanceForType {
          get { return defaultInstance; }
        }
        
        protected override PhoneNumber ThisMessage {
          get { return this; }
        }
        
        public static pbd::MessageDescriptor Descriptor {
          get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_Person_PhoneNumber__Descriptor; }
        }
        
        protected override pb::FieldAccess.FieldAccessorTable<PhoneNumber, PhoneNumber.Builder> InternalFieldAccessors {
          get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_Person_PhoneNumber__FieldAccessorTable; }
        }
        
        public const int NumberFieldNumber = 1;
        private bool hasNumber;
        private string number_ = "";
        public bool HasNumber {
          get { return hasNumber; }
        }
        public string Number {
          get { return number_; }
        }
        
        public const int TypeFieldNumber = 2;
        private bool hasType;
        private global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType type_ = global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME;
        public bool HasType {
          get { return hasType; }
        }
        public global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType Type {
          get { return type_; }
        }
        
        public override bool IsInitialized {
          get {
            if (!hasNumber) return false;
            return true;
          }
        }
        
        public override void WriteTo(pb::CodedOutputStream output) {
          if (HasNumber) {
            output.WriteString(1, Number);
          }
          if (HasType) {
            output.WriteEnum(2, (int) Type);
          }
          UnknownFields.WriteTo(output);
        }
        
        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            
            size = 0;
            if (HasNumber) {
              size += pb::CodedOutputStream.ComputeStringSize(1, Number);
            }
            if (HasType) {
              size += pb::CodedOutputStream.ComputeEnumSize(2, (int) Type);
            }
            size += UnknownFields.SerializedSize;
            memoizedSerializedSize = size;
            return size;
          }
        }
        
        public static PhoneNumber ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static PhoneNumber ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static PhoneNumber ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static PhoneNumber ParseFrom(pb::CodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static PhoneNumber ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(PhoneNumber prototype) {
          return (Builder) new Builder().MergeFrom(prototype);
        }
        
        public sealed partial class Builder : pb::GeneratedBuilder<PhoneNumber, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {}
          
          PhoneNumber result = new PhoneNumber();
          
          protected override PhoneNumber MessageBeingBuilt {
            get { return result; }
          }
          
          public override Builder Clear() {
            result = new PhoneNumber();
            return this;
          }
          
          public override Builder Clone() {
            return new Builder().MergeFrom(result);
          }
          
          public override pbd::MessageDescriptor DescriptorForType {
            get { return PhoneNumber.Descriptor; }
          }
          
          public override PhoneNumber DefaultInstanceForType {
            get { return PhoneNumber.DefaultInstance; }
          }
          
          public override PhoneNumber BuildPartial() {
            if (result == null) {
              throw new global::System.InvalidOperationException("build() has already been called on this Builder");
            }
            PhoneNumber returnMe = result;
            result = null;
            return returnMe;
          }
          
          public override Builder MergeFrom(pb::IMessage other) {
            if (other is PhoneNumber) {
              return MergeFrom((PhoneNumber) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }
          
          public override Builder MergeFrom(PhoneNumber other) {
            if (other == PhoneNumber.DefaultInstance) return this;
            if (other.HasNumber) {
              Number = other.Number;
            }
            if (other.HasType) {
              Type = other.Type;
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }
          
          public override Builder MergeFrom(pb::CodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }
          
          public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            pb::UnknownFieldSet.Builder unknownFields = null;
            while (true) {
              uint tag = input.ReadTag();
              switch (tag) {
                case 0: {
                  if (unknownFields != null) {
                    this.UnknownFields = unknownFields.Build();
                  }
                  return this;
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
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag);
                  break;
                }
                case 10: {
                  Number = input.ReadString();
                  break;
                }
                case 16: {
                  int rawValue = input.ReadEnum();
                  if (!global::System.Enum.IsDefined(typeof(global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType), rawValue)) {
                    if (unknownFields == null) {
                      unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                    }
                    unknownFields.MergeVarintField(2, (ulong) rawValue);
                  } else {
                    Type = (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType) rawValue;
                  }
                  break;
                }
              }
            }
          }
          
          
          public bool HasNumber {
            get { return result.HasNumber; }
          }
          public string Number {
            get { return result.Number; }
            set { SetNumber(value); }
          }
          public Builder SetNumber(string value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            result.hasNumber = true;
            result.number_ = value;
            return this;
          }
          public Builder ClearNumber() {
            result.hasNumber = false;
            result.number_ = "";
            return this;
          }
          
          public bool HasType {
           get { return result.HasType; }
          }
          public global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType Type {
            get { return result.Type; }
            set { SetType(value); }
          }
          public Builder SetType(global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType value) {
            result.hasType = true;
            result.type_ = value;
            return this;
          }
          public Builder ClearType() {
            result.hasType = false;
            result.type_ = global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneType.HOME;
            return this;
          }
        }
        static PhoneNumber() {
          pbd::FileDescriptor descriptor = global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.Descriptor;
        }
      }
      
    }
    #endregion
    
    public const int NameFieldNumber = 1;
    private bool hasName;
    private string name_ = "";
    public bool HasName {
      get { return hasName; }
    }
    public string Name {
      get { return name_; }
    }
    
    public const int IdFieldNumber = 2;
    private bool hasId;
    private int id_ = 0;
    public bool HasId {
      get { return hasId; }
    }
    public int Id {
      get { return id_; }
    }
    
    public const int EmailFieldNumber = 3;
    private bool hasEmail;
    private string email_ = "";
    public bool HasEmail {
      get { return hasEmail; }
    }
    public string Email {
      get { return email_; }
    }
    
    public const int PhoneFieldNumber = 4;
    private pbc::PopsicleList<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> phone_ = new pbc::PopsicleList<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber>();
    public scg::IList<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> PhoneList {
      get { return phone_; }
    }
    public int PhoneCount {
      get { return phone_.Count; }
    }
    public global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber GetPhone(int index) {
      return phone_[index];
    }
    
    public override bool IsInitialized {
      get {
        if (!hasName) return false;
        if (!hasId) return false;
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber element in PhoneList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      if (HasName) {
        output.WriteString(1, Name);
      }
      if (HasId) {
        output.WriteInt32(2, Id);
      }
      if (HasEmail) {
        output.WriteString(3, Email);
      }
      foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber element in PhoneList) {
        output.WriteMessage(4, element);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasName) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Name);
        }
        if (HasId) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, Id);
        }
        if (HasEmail) {
          size += pb::CodedOutputStream.ComputeStringSize(3, Email);
        }
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber element in PhoneList) {
          size += pb::CodedOutputStream.ComputeMessageSize(4, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Person ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Person ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Person ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Person ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Person ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Person ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Person ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Person ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Person ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Person ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Person prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Person, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Person result = new Person();
      
      protected override Person MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Person();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return Person.Descriptor; }
      }
      
      public override Person DefaultInstanceForType {
        get { return Person.DefaultInstance; }
      }
      
      public override Person BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.phone_.MakeReadOnly();
        Person returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Person) {
          return MergeFrom((Person) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Person other) {
        if (other == Person.DefaultInstance) return this;
        if (other.HasName) {
          Name = other.Name;
        }
        if (other.HasId) {
          Id = other.Id;
        }
        if (other.HasEmail) {
          Email = other.Email;
        }
        if (other.phone_.Count != 0) {
          base.AddRange(other.phone_, result.phone_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
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
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              Name = input.ReadString();
              break;
            }
            case 16: {
              Id = input.ReadInt32();
              break;
            }
            case 26: {
              Email = input.ReadString();
              break;
            }
            case 34: {
              global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Builder subBuilder = global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.CreateBuilder();
              input.ReadMessage(subBuilder, extensionRegistry);
              AddPhone(subBuilder.BuildPartial());
              break;
            }
          }
        }
      }
      
      
      public bool HasName {
        get { return result.HasName; }
      }
      public string Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder ClearName() {
        result.hasName = false;
        result.name_ = "";
        return this;
      }
      
      public bool HasId {
        get { return result.HasId; }
      }
      public int Id {
        get { return result.Id; }
        set { SetId(value); }
      }
      public Builder SetId(int value) {
        result.hasId = true;
        result.id_ = value;
        return this;
      }
      public Builder ClearId() {
        result.hasId = false;
        result.id_ = 0;
        return this;
      }
      
      public bool HasEmail {
        get { return result.HasEmail; }
      }
      public string Email {
        get { return result.Email; }
        set { SetEmail(value); }
      }
      public Builder SetEmail(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasEmail = true;
        result.email_ = value;
        return this;
      }
      public Builder ClearEmail() {
        result.hasEmail = false;
        result.email_ = "";
        return this;
      }
      
      public scg::IList<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> PhoneList {
        get { return result.phone_; }
      }
      public int PhoneCount {
        get { return result.PhoneCount; }
      }
      public global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber GetPhone(int index) {
        return result.GetPhone(index);
      }
      public Builder SetPhone(int index, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.phone_[index] = value;
        return this;
      }
      public Builder SetPhone(int index, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.phone_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddPhone(global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.phone_.Add(value);
        return this;
      }
      public Builder AddPhone(global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.phone_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangePhone(scg::IEnumerable<global::Google.ProtocolBuffers.Examples.AddressBook.Person.Types.PhoneNumber> values) {
        base.AddRange(values, result.phone_);
        return this;
      }
      public Builder ClearPhone() {
        result.phone_.Clear();
        return this;
      }
    }
    static Person() {
      pbd::FileDescriptor descriptor = global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.Descriptor;
    }
  }
  
  public sealed partial class AddressBook : pb::GeneratedMessage<AddressBook, AddressBook.Builder> {
    private static readonly AddressBook defaultInstance = new Builder().BuildPartial();
    public static AddressBook DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override AddressBook DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override AddressBook ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_AddressBook__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<AddressBook, AddressBook.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.internal__static_tutorial_AddressBook__FieldAccessorTable; }
    }
    
    public const int PersonFieldNumber = 1;
    private pbc::PopsicleList<global::Google.ProtocolBuffers.Examples.AddressBook.Person> person_ = new pbc::PopsicleList<global::Google.ProtocolBuffers.Examples.AddressBook.Person>();
    public scg::IList<global::Google.ProtocolBuffers.Examples.AddressBook.Person> PersonList {
      get { return person_; }
    }
    public int PersonCount {
      get { return person_.Count; }
    }
    public global::Google.ProtocolBuffers.Examples.AddressBook.Person GetPerson(int index) {
      return person_[index];
    }
    
    public override bool IsInitialized {
      get {
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person element in PersonList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person element in PersonList) {
        output.WriteMessage(1, element);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        foreach (global::Google.ProtocolBuffers.Examples.AddressBook.Person element in PersonList) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static AddressBook ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AddressBook ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AddressBook ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AddressBook ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AddressBook ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AddressBook ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static AddressBook ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static AddressBook ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static AddressBook ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AddressBook ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(AddressBook prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<AddressBook, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      AddressBook result = new AddressBook();
      
      protected override AddressBook MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new AddressBook();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return AddressBook.Descriptor; }
      }
      
      public override AddressBook DefaultInstanceForType {
        get { return AddressBook.DefaultInstance; }
      }
      
      public override AddressBook BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.person_.MakeReadOnly();
        AddressBook returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is AddressBook) {
          return MergeFrom((AddressBook) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(AddressBook other) {
        if (other == AddressBook.DefaultInstance) return this;
        if (other.person_.Count != 0) {
          base.AddRange(other.person_, result.person_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
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
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              global::Google.ProtocolBuffers.Examples.AddressBook.Person.Builder subBuilder = global::Google.ProtocolBuffers.Examples.AddressBook.Person.CreateBuilder();
              input.ReadMessage(subBuilder, extensionRegistry);
              AddPerson(subBuilder.BuildPartial());
              break;
            }
          }
        }
      }
      
      
      public scg::IList<global::Google.ProtocolBuffers.Examples.AddressBook.Person> PersonList {
        get { return result.person_; }
      }
      public int PersonCount {
        get { return result.PersonCount; }
      }
      public global::Google.ProtocolBuffers.Examples.AddressBook.Person GetPerson(int index) {
        return result.GetPerson(index);
      }
      public Builder SetPerson(int index, global::Google.ProtocolBuffers.Examples.AddressBook.Person value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.person_[index] = value;
        return this;
      }
      public Builder SetPerson(int index, global::Google.ProtocolBuffers.Examples.AddressBook.Person.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.person_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddPerson(global::Google.ProtocolBuffers.Examples.AddressBook.Person value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.person_.Add(value);
        return this;
      }
      public Builder AddPerson(global::Google.ProtocolBuffers.Examples.AddressBook.Person.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.person_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangePerson(scg::IEnumerable<global::Google.ProtocolBuffers.Examples.AddressBook.Person> values) {
        base.AddRange(values, result.person_);
        return this;
      }
      public Builder ClearPerson() {
        result.person_.Clear();
        return this;
      }
    }
    static AddressBook() {
      pbd::FileDescriptor descriptor = global::Google.ProtocolBuffers.Examples.AddressBook.AddressBookProtos.Descriptor;
    }
  }
  
  #endregion
  
}
