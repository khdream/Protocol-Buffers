//Generated by the protocol buffer compiler. DO NOT EDIT!
// source: google/protobuf/unittest_lite.proto

package com.google.protobuf;

@kotlin.jvm.JvmSynthetic
inline fun v1MessageLite(block: com.google.protobuf.V1MessageLiteKt.Dsl.() -> Unit): com.google.protobuf.UnittestLite.V1MessageLite =
  com.google.protobuf.V1MessageLiteKt.Dsl._create(com.google.protobuf.UnittestLite.V1MessageLite.newBuilder()).apply { block() }._build()
object V1MessageLiteKt {
  @kotlin.OptIn(com.google.protobuf.kotlin.OnlyForUseByGeneratedProtoCode::class)
  @com.google.protobuf.kotlin.ProtoDslMarker
  class Dsl private constructor(
    @kotlin.jvm.JvmField private val _builder: com.google.protobuf.UnittestLite.V1MessageLite.Builder
  ) {
    companion object {
      @kotlin.jvm.JvmSynthetic
      @kotlin.PublishedApi
      internal fun _create(builder: com.google.protobuf.UnittestLite.V1MessageLite.Builder): Dsl = Dsl(builder)
    }

    @kotlin.jvm.JvmSynthetic
    @kotlin.PublishedApi
    internal fun _build(): com.google.protobuf.UnittestLite.V1MessageLite = _builder.build()

    /**
     * <code>required int32 int_field = 1;</code>
     */
    var intField: kotlin.Int
      @JvmName("getIntField")
      get() = _builder.getIntField()
      @JvmName("setIntField")
      set(value) {
        _builder.setIntField(value)
      }
    /**
     * <code>required int32 int_field = 1;</code>
     */
    fun clearIntField() {
      _builder.clearIntField()
    }
    /**
     * <code>required int32 int_field = 1;</code>
     * @return Whether the intField field is set.
     */
    fun hasIntField(): kotlin.Boolean {
      return _builder.hasIntField()
    }

    /**
     * <code>optional .protobuf_unittest.V1EnumLite enum_field = 2 [default = V1_FIRST];</code>
     */
    var enumField: com.google.protobuf.UnittestLite.V1EnumLite
      @JvmName("getEnumField")
      get() = _builder.getEnumField()
      @JvmName("setEnumField")
      set(value) {
        _builder.setEnumField(value)
      }
    /**
     * <code>optional .protobuf_unittest.V1EnumLite enum_field = 2 [default = V1_FIRST];</code>
     */
    fun clearEnumField() {
      _builder.clearEnumField()
    }
    /**
     * <code>optional .protobuf_unittest.V1EnumLite enum_field = 2 [default = V1_FIRST];</code>
     * @return Whether the enumField field is set.
     */
    fun hasEnumField(): kotlin.Boolean {
      return _builder.hasEnumField()
    }
  }
}
inline fun com.google.protobuf.UnittestLite.V1MessageLite.copy(block: com.google.protobuf.V1MessageLiteKt.Dsl.() -> Unit): com.google.protobuf.UnittestLite.V1MessageLite =
  com.google.protobuf.V1MessageLiteKt.Dsl._create(this.toBuilder()).apply { block() }._build()
