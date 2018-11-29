<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/protobuf/descriptor.proto

namespace Google\Protobuf\Internal\FieldOptions;

use UnexpectedValueException;

/**
 * Protobuf type <code>google.protobuf.FieldOptions.JSType</code>
 */
class JSType
{
    /**
     * Use the default type.
     *
     * Generated from protobuf enum <code>JS_NORMAL = 0;</code>
     */
    const JS_NORMAL = 0;
    /**
     * Use JavaScript strings.
     *
     * Generated from protobuf enum <code>JS_STRING = 1;</code>
     */
    const JS_STRING = 1;
    /**
     * Use JavaScript numbers.
     *
     * Generated from protobuf enum <code>JS_NUMBER = 2;</code>
     */
    const JS_NUMBER = 2;

    private static $valueToName = [
        self::JS_NORMAL => 'JS_NORMAL',
        self::JS_STRING => 'JS_STRING',
        self::JS_NUMBER => 'JS_NUMBER',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }

    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(JSType::class, \Google\Protobuf\Internal\FieldOptions_JSType::class);

