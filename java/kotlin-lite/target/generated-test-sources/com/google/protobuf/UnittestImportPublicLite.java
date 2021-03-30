// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/unittest_import_public_lite.proto

package com.google.protobuf;

public final class UnittestImportPublicLite {
  private UnittestImportPublicLite() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }
  public interface PublicImportMessageLiteOrBuilder extends
      // @@protoc_insertion_point(interface_extends:protobuf_unittest_import.PublicImportMessageLite)
      com.google.protobuf.MessageLiteOrBuilder {

    /**
     * <code>optional int32 e = 1;</code>
     * @return Whether the e field is set.
     */
    boolean hasE();
    /**
     * <code>optional int32 e = 1;</code>
     * @return The e.
     */
    int getE();
  }
  /**
   * Protobuf type {@code protobuf_unittest_import.PublicImportMessageLite}
   */
  public  static final class PublicImportMessageLite extends
      com.google.protobuf.GeneratedMessageLite<
          PublicImportMessageLite, PublicImportMessageLite.Builder> implements
      // @@protoc_insertion_point(message_implements:protobuf_unittest_import.PublicImportMessageLite)
      PublicImportMessageLiteOrBuilder {
    private PublicImportMessageLite() {
    }
    private int bitField0_;
    public static final int E_FIELD_NUMBER = 1;
    private int e_;
    /**
     * <code>optional int32 e = 1;</code>
     * @return Whether the e field is set.
     */
    @java.lang.Override
    public boolean hasE() {
      return ((bitField0_ & 0x00000001) != 0);
    }
    /**
     * <code>optional int32 e = 1;</code>
     * @return The e.
     */
    @java.lang.Override
    public int getE() {
      return e_;
    }
    /**
     * <code>optional int32 e = 1;</code>
     * @param value The e to set.
     */
    private void setE(int value) {
      bitField0_ |= 0x00000001;
      e_ = value;
    }
    /**
     * <code>optional int32 e = 1;</code>
     */
    private void clearE() {
      bitField0_ = (bitField0_ & ~0x00000001);
      e_ = 0;
    }

    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        java.nio.ByteBuffer data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        java.nio.ByteBuffer data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        com.google.protobuf.ByteString data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        com.google.protobuf.ByteString data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(byte[] data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        byte[] data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, data, extensionRegistry);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(java.io.InputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input, extensionRegistry);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseDelimitedFrom(java.io.InputStream input)
        throws java.io.IOException {
      return parseDelimitedFrom(DEFAULT_INSTANCE, input);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseDelimitedFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return parseDelimitedFrom(DEFAULT_INSTANCE, input, extensionRegistry);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        com.google.protobuf.CodedInputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input);
    }
    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite parseFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageLite.parseFrom(
          DEFAULT_INSTANCE, input, extensionRegistry);
    }

    public static Builder newBuilder() {
      return (Builder) DEFAULT_INSTANCE.createBuilder();
    }
    public static Builder newBuilder(com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite prototype) {
      return (Builder) DEFAULT_INSTANCE.createBuilder(prototype);
    }

    /**
     * Protobuf type {@code protobuf_unittest_import.PublicImportMessageLite}
     */
    public static final class Builder extends
        com.google.protobuf.GeneratedMessageLite.Builder<
          com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite, Builder> implements
        // @@protoc_insertion_point(builder_implements:protobuf_unittest_import.PublicImportMessageLite)
        com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLiteOrBuilder {
      // Construct using com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite.newBuilder()
      private Builder() {
        super(DEFAULT_INSTANCE);
      }


      /**
       * <code>optional int32 e = 1;</code>
       * @return Whether the e field is set.
       */
      @java.lang.Override
      public boolean hasE() {
        return instance.hasE();
      }
      /**
       * <code>optional int32 e = 1;</code>
       * @return The e.
       */
      @java.lang.Override
      public int getE() {
        return instance.getE();
      }
      /**
       * <code>optional int32 e = 1;</code>
       * @param value The e to set.
       * @return This builder for chaining.
       */
      public Builder setE(int value) {
        copyOnWrite();
        instance.setE(value);
        return this;
      }
      /**
       * <code>optional int32 e = 1;</code>
       * @return This builder for chaining.
       */
      public Builder clearE() {
        copyOnWrite();
        instance.clearE();
        return this;
      }

      // @@protoc_insertion_point(builder_scope:protobuf_unittest_import.PublicImportMessageLite)
    }
    @java.lang.Override
    @java.lang.SuppressWarnings({"unchecked", "fallthrough"})
    protected final java.lang.Object dynamicMethod(
        com.google.protobuf.GeneratedMessageLite.MethodToInvoke method,
        java.lang.Object arg0, java.lang.Object arg1) {
      switch (method) {
        case NEW_MUTABLE_INSTANCE: {
          return new com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite();
        }
        case NEW_BUILDER: {
          return new Builder();
        }
        case BUILD_MESSAGE_INFO: {
            java.lang.Object[] objects = new java.lang.Object[] {
              "bitField0_",
              "e_",
            };
            java.lang.String info =
                "\u0001\u0001\u0000\u0001\u0001\u0001\u0001\u0000\u0000\u0000\u0001\u1004\u0000";
            return newMessageInfo(DEFAULT_INSTANCE, info, objects);
        }
        // fall through
        case GET_DEFAULT_INSTANCE: {
          return DEFAULT_INSTANCE;
        }
        case GET_PARSER: {
          com.google.protobuf.Parser<com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite> parser = PARSER;
          if (parser == null) {
            synchronized (com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite.class) {
              parser = PARSER;
              if (parser == null) {
                parser =
                    new DefaultInstanceBasedParser<com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite>(
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


    // @@protoc_insertion_point(class_scope:protobuf_unittest_import.PublicImportMessageLite)
    private static final com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite DEFAULT_INSTANCE;
    static {
      PublicImportMessageLite defaultInstance = new PublicImportMessageLite();
      // New instances are implicitly immutable so no need to make
      // immutable.
      DEFAULT_INSTANCE = defaultInstance;
      com.google.protobuf.GeneratedMessageLite.registerDefaultInstance(
        PublicImportMessageLite.class, defaultInstance);
    }

    public static com.google.protobuf.UnittestImportPublicLite.PublicImportMessageLite getDefaultInstance() {
      return DEFAULT_INSTANCE;
    }

    private static volatile com.google.protobuf.Parser<PublicImportMessageLite> PARSER;

    public static com.google.protobuf.Parser<PublicImportMessageLite> parser() {
      return DEFAULT_INSTANCE.getParserForType();
    }
  }


  static {
  }

  // @@protoc_insertion_point(outer_class_scope)
}
