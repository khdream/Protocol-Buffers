// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
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

#ifndef GOOGLE_PROTOBUF_PYTHON_CPP_MESSAGE_MAP_CONTAINER_H__
#define GOOGLE_PROTOBUF_PYTHON_CPP_MESSAGE_MAP_CONTAINER_H__

#include <Python.h>

#include <memory>
#ifndef _SHARED_PTR_H
#include <google/protobuf/stubs/shared_ptr.h>
#endif

#include <google/protobuf/descriptor.h>

namespace google {
namespace protobuf {

class Message;

#ifdef _SHARED_PTR_H
using std::shared_ptr;
#else
using internal::shared_ptr;
#endif

namespace python {

struct CMessage;

struct MessageMapContainer {
  PyObject_HEAD;

  // This is the top-level C++ Message object that owns the whole
  // proto tree.  Every Python MessageMapContainer holds a
  // reference to it in order to keep it alive as long as there's a
  // Python object that references any part of the tree.
  shared_ptr<Message> owner;

  // Pointer to the C++ Message that contains this container.  The
  // MessageMapContainer does not own this pointer.
  Message* message;

  // Weak reference to a parent CMessage object (i.e. may be NULL.)
  //
  // Used to make sure all ancestors are also mutable when first
  // modifying the container.
  CMessage* parent;

  // Pointer to the parent's descriptor that describes this
  // field.  Used together with the parent's message when making a
  // default message instance mutable.
  // The pointer is owned by the global DescriptorPool.
  const FieldDescriptor* parent_field_descriptor;
  const FieldDescriptor* key_field_descriptor;
  const FieldDescriptor* value_field_descriptor;

  // A callable that is used to create new child messages.
  PyObject* subclass_init;

  // A dict mapping Message* -> CMessage.
  PyObject* message_dict;

  // We bump this whenever we perform a mutation, to invalidate existing
  // iterators.
  uint64 version;
};

#if PY_MAJOR_VERSION >= 3
  extern PyObject *MessageMapContainer_Type;
  extern PyType_Spec MessageMapContainer_Type_spec;
#else
  extern PyTypeObject MessageMapContainer_Type;
#endif
extern PyTypeObject MessageMapIterator_Type;

namespace message_map_container {

// Builds a MessageMapContainer object, from a parent message and a
// field descriptor.
extern PyObject* NewContainer(CMessage* parent,
                              const FieldDescriptor* parent_field_descriptor,
                              PyObject* concrete_class);

// Releases the messages in the container to a new message.
//
// Returns 0 on success, -1 on failure.
int Release(MessageMapContainer* self);

// Set the owner field of self and any children of self.
void SetOwner(MessageMapContainer* self,
              const shared_ptr<Message>& new_owner);

}  // namespace message_map_container
}  // namespace python
}  // namespace protobuf

}  // namespace google
#endif  // GOOGLE_PROTOBUF_PYTHON_CPP_MESSAGE_MAP_CONTAINER_H__
