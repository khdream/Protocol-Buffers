// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/type.proto

package com.google.protobuf;

public interface OptionOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.protobuf.Option)
    com.google.protobuf.MessageLiteOrBuilder {

  /**
   * <pre>
   * The option's name. For protobuf built-in options (options defined in
   * descriptor.proto), this is the short name. For example, `"map_entry"`.
   * For custom options, it should be the fully-qualified name. For example,
   * `"google.api.http"`.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The option's name. For protobuf built-in options (options defined in
   * descriptor.proto), this is the short name. For example, `"map_entry"`.
   * For custom options, it should be the fully-qualified name. For example,
   * `"google.api.http"`.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The option's value packed in an Any message. If the value is a primitive,
   * the corresponding wrapper type defined in google/protobuf/wrappers.proto
   * should be used. If the value is an enum, it should be stored as an int32
   * value using the google.protobuf.Int32Value type.
   * </pre>
   *
   * <code>.google.protobuf.Any value = 2;</code>
   * @return Whether the value field is set.
   */
  boolean hasValue();
  /**
   * <pre>
   * The option's value packed in an Any message. If the value is a primitive,
   * the corresponding wrapper type defined in google/protobuf/wrappers.proto
   * should be used. If the value is an enum, it should be stored as an int32
   * value using the google.protobuf.Int32Value type.
   * </pre>
   *
   * <code>.google.protobuf.Any value = 2;</code>
   * @return The value.
   */
  com.google.protobuf.Any getValue();
}
