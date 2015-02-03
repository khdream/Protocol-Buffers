// Protocol Buffers - Google's data interchange format
// Copyright 2013 Google Inc.  All rights reserved.
// https://developers.google.com/protocol-buffers/
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

package com.google.protobuf.nano;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

/**
 * Utility class for maps support.
 */
public final class MapUtil {
  public static interface MapFactory {
    <K, V> Map<K, V> forMap(Map<K, V> oldMap);
  }
  public static void setMapFactory(MapFactory newMapFactory) {
    mapFactory = newMapFactory;
  }

  private static class DefaultMapFactory implements MapFactory {
    public <K, V> Map<K, V> forMap(Map<K, V> oldMap) {
      if (oldMap == null) {
        return new HashMap<K, V>();
      }
      return oldMap;
    }
  }
  private static volatile MapFactory mapFactory = new DefaultMapFactory();

  @SuppressWarnings("unchecked")
  public static final <K, V> Map<K, V> mergeEntry(
      Map<K, V> target, CodedInputByteBufferNano input,
      int keyType, int valueType, V value,
      int keyTag, int valueTag)
      throws IOException {
    target = mapFactory.forMap(target);
    final int length = input.readRawVarint32();
    final int oldLimit = input.pushLimit(length);
    K key = null;
    while (true) {
      int tag = input.readTag();
      if (tag == 0) {
        break;
      }
      if (tag == keyTag) {
        key = (K) input.readData(keyType);
      } else if (tag == valueTag) {
        if (valueType == InternalNano.TYPE_MESSAGE) {
          input.readMessage((MessageNano) value);
        } else {
          value = (V) input.readData(valueType);
        }
      } else {
        if (!input.skipField(tag)) {
          break;
        }
      }
    }
    input.checkLastTagWas(0);
    input.popLimit(oldLimit);

    if (key != null) {
      target.put(key, value);
    }
    return target;
  }

  private MapUtil() {}
}
