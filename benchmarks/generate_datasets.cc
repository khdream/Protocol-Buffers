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

const char *file_prefix = "dataset.";
const char *file_suffix = ".pb";

#include <fstream>
#include <iostream>
#include "benchmarks.pb.h"
#include "google_message1.h"
#include "google_message2.h"

using benchmarks::BenchmarkDataset;
using google::protobuf::Descriptor;
using google::protobuf::DescriptorPool;
using google::protobuf::Message;
using google::protobuf::MessageFactory;

#define ARRAY_TO_STRING(arr) std::string(arr, arr + sizeof(arr))

std::set<std::string> names;

void WriteFileWithPayloads(const std::string& name,
                           const std::string& message_name,
                           const std::vector<std::string>& payload) {
  if (!names.insert(name).second) {
    std::cerr << "Duplicate test name: " << name << "\n";
    abort();
  }

  // First verify that this message name exists in our set of benchmark messages
  // and that these payloads are valid for the given message.
  const Descriptor* d =
      DescriptorPool::generated_pool()->FindMessageTypeByName(message_name);

  if (!d) {
    std::cerr << "For dataset " << name << ", no such message: "
              << message_name << "\n";
    abort();
  }

  Message* m = MessageFactory::generated_factory()->GetPrototype(d)->New();

  for (size_t i = 0; i < payload.size(); i++) {
    if (!m->ParseFromString(payload[i])) {
      std::cerr << "For dataset " << name << ", payload[" << i << "] fails "
                << "to parse\n";
      abort();
    }
  }

  BenchmarkDataset dataset;
  dataset.set_name(name);
  dataset.set_message_name(message_name);
  for (size_t i = 0; i < payload.size(); i++) {
    dataset.add_payload()->assign(payload[i]);
  }

  std::string serialized;
  dataset.SerializeToString(&serialized);

  std::ofstream writer;
  std::string fname = file_prefix + name + file_suffix;
  writer.open(fname);
  writer << serialized;
  writer.close();

  std::cerr << "Wrote dataset: " << fname << "\n";
}

void WriteFile(const std::string& name, const std::string& message_name,
               const std::string& payload) {
  std::vector<std::string> payloads;
  payloads.push_back(payload);
  WriteFileWithPayloads(name, message_name, payloads);
}

int main() {
  WriteFile("google_message1_proto3", "benchmarks.p3.GoogleMessage1",
            ARRAY_TO_STRING(google_message1_dat));
  WriteFile("google_message1_proto2", "benchmarks.p2.GoogleMessage1",
            ARRAY_TO_STRING(google_message1_dat));

  // Not in proto3 because it has a group, which is not supported.
  WriteFile("google_message2", "benchmarks.p2.GoogleMessage2",
            ARRAY_TO_STRING(google_message2_dat));
}
