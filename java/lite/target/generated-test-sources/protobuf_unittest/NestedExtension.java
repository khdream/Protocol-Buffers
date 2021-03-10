// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: com/google/protobuf/nested_extension.proto

package protobuf_unittest;

public final class NestedExtension {
  private NestedExtension() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
    registry.add(protobuf_unittest.NestedExtension.MyNestedExtension.recursiveExtension);
    registry.add(protobuf_unittest.NestedExtension.MyNestedExtension.default_);
  }
  public interface MyNestedExtensionOrBuilder extends
      // @@protoc_insertion_point(interface_extends:protobuf_unittest.MyNestedExtension)
      com.google.protobuf.MessageLiteOrBuilder {
  }
  /**
   * Protobuf type {@code protobuf_unittest.MyNestedExtension}
   */
  public  static final class MyNestedExtension extends
      com.google.protobuf.GeneratedMessageLite<
          MyNestedExtension, MyNestedExtension.Builder> implements
      // @@protoc_insertion_point(message_implements:protobuf_unittest.MyNestedExtension)
      MyNestedExtensionOrBuilder {
    private MyNestedExtension() {
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        java.nio.ByteBuffer data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        java.nio.ByteBuffer data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        com.google.protobuf.ByteString data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        com.google.protobuf.ByteString data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(byte[] data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        byte[] data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(java.io.InputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input, extensionRegistry);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseDelimitedFrom(java.io.InputStream input)
        throws java.io.IOException {
      return parseDelimitedFrom(DEFAULT_INSTANCE, input);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseDelimitedFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return parseDelimitedFrom(DEFAULT_INSTANCE, input, extensionRegistry);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        com.google.protobuf.CodedInputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input);
    }
    public static protobuf_unittest.NestedExtension.MyNestedExtension parseFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input, extensionRegistry);
    }

    public static Builder newBuilder() {
      return (Builder) DEFAULT_INSTANCE.createBuilder();
    }
    public static Builder newBuilder(protobuf_unittest.NestedExtension.MyNestedExtension prototype) {
      return (Builder) DEFAULT_INSTANCE.createBuilder(prototype);
    }

    /**
     * Protobuf type {@code protobuf_unittest.MyNestedExtension}
     */
    public static final class Builder extends
        com.google.protobuf.GeneratedMessageLite.Builder<
          protobuf_unittest.NestedExtension.MyNestedExtension, Builder> implements
        // @@protoc_insertion_point(builder_implements:protobuf_unittest.MyNestedExtension)
        protobuf_unittest.NestedExtension.MyNestedExtensionOrBuilder {
      // Construct using protobuf_unittest.NestedExtension.MyNestedExtension.newBuilder()
      private Builder() {
        super(DEFAULT_INSTANCE);
      }


      // @@protoc_insertion_point(builder_scope:protobuf_unittest.MyNestedExtension)
    }
    @java.lang.Override
    @java.lang.SuppressWarnings({"unchecked", "fallthrough"})
    protected final java.lang.Object dynamicMethod(
        com.google.protobuf.GeneratedMessageLite.MethodToInvoke method,
        java.lang.Object arg0, java.lang.Object arg1) {
      switch (method) {
        case NEW_MUTABLE_INSTANCE: {
          return new protobuf_unittest.NestedExtension.MyNestedExtension();
        }
        case NEW_BUILDER: {
          return new Builder();
        }
        case BUILD_MESSAGE_INFO: {
            java.lang.Object[] objects = null;java.lang.String info =
                "\u0001\u0000";
            return newMessageInfo(DEFAULT_INSTANCE, info, objects);
        }
        // fall through
        case GET_DEFAULT_INSTANCE: {
          return DEFAULT_INSTANCE;
        }
        case GET_PARSER: {
          com.google.protobuf.Parser<protobuf_unittest.NestedExtension.MyNestedExtension> parser = PARSER;
          if (parser == null) {
            synchronized (protobuf_unittest.NestedExtension.MyNestedExtension.class) {
              parser = PARSER;
              if (parser == null) {
                parser =
                    new DefaultInstanceBasedParser<protobuf_unittest.NestedExtension.MyNestedExtension>(
                        DEFAULT_INSTANCE);
                PARSER = parser;
              }
            }
          }
          return parser;
      }
      case GET_MEMOIZED_IS_INITIALIZED: {
        return (byte) 1;
      }
      case SET_MEMOIZED_IS_INITIALIZED: {
        return null;
      }
      }
      throw new UnsupportedOperationException();
    }


    // @@protoc_insertion_point(class_scope:protobuf_unittest.MyNestedExtension)
    private static final protobuf_unittest.NestedExtension.MyNestedExtension DEFAULT_INSTANCE;
    static {
      MyNestedExtension defaultInstance = new MyNestedExtension();
      // New instances are implicitly immutable so no need to make
      // immutable.
      DEFAULT_INSTANCE = defaultInstance;
      com.google.protobuf.GeneratedMessageLite.registerDefaultInstance(
        MyNestedExtension.class, defaultInstance);
    }

    public static protobuf_unittest.NestedExtension.MyNestedExtension getDefaultInstance() {
      return DEFAULT_INSTANCE;
    }

    private static volatile com.google.protobuf.Parser<MyNestedExtension> PARSER;

    public static com.google.protobuf.Parser<MyNestedExtension> parser() {
      return DEFAULT_INSTANCE.getParserForType();
    }
    public static final int RECURSIVEEXTENSION_FIELD_NUMBER = 2;
    /**
     * <code>extend .protobuf_unittest.MessageToBeExtended { ... }</code>
     */
    public static final
      com.google.protobuf.GeneratedMessageLite.GeneratedExtension<
        protobuf_unittest.NonNestedExtension.MessageToBeExtended,
        protobuf_unittest.NonNestedExtension.MessageToBeExtended> recursiveExtension = com.google.protobuf.GeneratedMessageLite
            .newSingularGeneratedExtension(
          protobuf_unittest.NonNestedExtension.MessageToBeExtended.getDefaultInstance(),
          protobuf_unittest.NonNestedExtension.MessageToBeExtended.getDefaultInstance(),
          protobuf_unittest.NonNestedExtension.MessageToBeExtended.getDefaultInstance(),
          null,
          2,
          com.google.protobuf.WireFormat.FieldType.MESSAGE,
          protobuf_unittest.NonNestedExtension.MessageToBeExtended.class);
    public static final int DEFAULT_FIELD_NUMBER = 2002;
    /**
     * <code>extend .protobuf_unittest.MessageToBeExtended { ... }</code>
     */
    public static final
      com.google.protobuf.GeneratedMessageLite.GeneratedExtension<
        protobuf_unittest.NonNestedExtension.MessageToBeExtended,
        java.lang.Integer> default_ = com.google.protobuf.GeneratedMessageLite
            .newSingularGeneratedExtension(
          protobuf_unittest.NonNestedExtension.MessageToBeExtended.getDefaultInstance(),
          0,
          null,
          null,
          2002,
          com.google.protobuf.WireFormat.FieldType.INT32,
          java.lang.Integer.class);
  }


  static {
  }

  // @@protoc_insertion_point(outer_class_scope)
}
