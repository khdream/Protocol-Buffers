// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/field_mask.proto

#include <google/protobuf/field_mask.pb.h>

#include <algorithm>

#include <google/protobuf/stubs/common.h>
#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/wire_format_lite_inl.h>
#include <google/protobuf/descriptor.h>
#include <google/protobuf/generated_message_reflection.h>
#include <google/protobuf/reflection_ops.h>
#include <google/protobuf/wire_format.h>
// @@protoc_insertion_point(includes)
#include <google/protobuf/port_def.inc>

namespace google {
namespace protobuf {
class FieldMaskDefaultTypeInternal {
 public:
  ::google::protobuf::internal::ExplicitlyConstructed<FieldMask> _instance;
} _FieldMask_default_instance_;
}  // namespace protobuf
}  // namespace google
static void InitDefaultsFieldMask_google_2fprotobuf_2ffield_5fmask_2eproto() {
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  {
    void* ptr = &::google::protobuf::_FieldMask_default_instance_;
    new (ptr) ::google::protobuf::FieldMask();
    ::google::protobuf::internal::OnShutdownDestroyMessage(ptr);
  }
  ::google::protobuf::FieldMask::InitAsDefaultInstance();
}

PROTOBUF_EXPORT ::google::protobuf::internal::SCCInfo<0> scc_info_FieldMask_google_2fprotobuf_2ffield_5fmask_2eproto =
    {{ATOMIC_VAR_INIT(::google::protobuf::internal::SCCInfoBase::kUninitialized), 0, InitDefaultsFieldMask_google_2fprotobuf_2ffield_5fmask_2eproto}, {}};

void InitDefaults_google_2fprotobuf_2ffield_5fmask_2eproto() {
  ::google::protobuf::internal::InitSCC(&scc_info_FieldMask_google_2fprotobuf_2ffield_5fmask_2eproto.base);
}

::google::protobuf::Metadata file_level_metadata_google_2fprotobuf_2ffield_5fmask_2eproto[1];
constexpr ::google::protobuf::EnumDescriptor const** file_level_enum_descriptors_google_2fprotobuf_2ffield_5fmask_2eproto = nullptr;
constexpr ::google::protobuf::ServiceDescriptor const** file_level_service_descriptors_google_2fprotobuf_2ffield_5fmask_2eproto = nullptr;

const ::google::protobuf::uint32 TableStruct_google_2fprotobuf_2ffield_5fmask_2eproto::offsets[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  ~0u,  // no _has_bits_
  PROTOBUF_FIELD_OFFSET(::google::protobuf::FieldMask, _internal_metadata_),
  ~0u,  // no _extensions_
  ~0u,  // no _oneof_case_
  ~0u,  // no _weak_field_map_
  PROTOBUF_FIELD_OFFSET(::google::protobuf::FieldMask, paths_),
};
static const ::google::protobuf::internal::MigrationSchema schemas[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  { 0, -1, sizeof(::google::protobuf::FieldMask)},
};

static ::google::protobuf::Message const * const file_default_instances[] = {
  reinterpret_cast<const ::google::protobuf::Message*>(&::google::protobuf::_FieldMask_default_instance_),
};

::google::protobuf::internal::AssignDescriptorsTable assign_descriptors_table_google_2fprotobuf_2ffield_5fmask_2eproto = {
  {}, AddDescriptors_google_2fprotobuf_2ffield_5fmask_2eproto, "google/protobuf/field_mask.proto", schemas,
  file_default_instances, TableStruct_google_2fprotobuf_2ffield_5fmask_2eproto::offsets,
  file_level_metadata_google_2fprotobuf_2ffield_5fmask_2eproto, 1, file_level_enum_descriptors_google_2fprotobuf_2ffield_5fmask_2eproto, file_level_service_descriptors_google_2fprotobuf_2ffield_5fmask_2eproto,
};

const char descriptor_table_protodef_google_2fprotobuf_2ffield_5fmask_2eproto[] =
  "\n google/protobuf/field_mask.proto\022\017goog"
  "le.protobuf\"\032\n\tFieldMask\022\r\n\005paths\030\001 \003(\tB"
  "\214\001\n\023com.google.protobufB\016FieldMaskProtoP"
  "\001Z9google.golang.org/genproto/protobuf/f"
  "ield_mask;field_mask\370\001\001\242\002\003GPB\252\002\036Google.P"
  "rotobuf.WellKnownTypesb\006proto3"
  ;
::google::protobuf::internal::DescriptorTable descriptor_table_google_2fprotobuf_2ffield_5fmask_2eproto = {
  false, InitDefaults_google_2fprotobuf_2ffield_5fmask_2eproto, 
  descriptor_table_protodef_google_2fprotobuf_2ffield_5fmask_2eproto,
  "google/protobuf/field_mask.proto", &assign_descriptors_table_google_2fprotobuf_2ffield_5fmask_2eproto, 230,
};

void AddDescriptors_google_2fprotobuf_2ffield_5fmask_2eproto() {
  static constexpr ::google::protobuf::internal::InitFunc deps[1] =
  {
  };
 ::google::protobuf::internal::AddDescriptors(&descriptor_table_google_2fprotobuf_2ffield_5fmask_2eproto, deps, 0);
}

// Force running AddDescriptors() at dynamic initialization time.
static bool dynamic_init_dummy_google_2fprotobuf_2ffield_5fmask_2eproto = []() { AddDescriptors_google_2fprotobuf_2ffield_5fmask_2eproto(); return true; }();
namespace google {
namespace protobuf {

// ===================================================================

void FieldMask::InitAsDefaultInstance() {
}
class FieldMask::HasBitSetters {
 public:
};

#if !defined(_MSC_VER) || _MSC_VER >= 1900
const int FieldMask::kPathsFieldNumber;
#endif  // !defined(_MSC_VER) || _MSC_VER >= 1900

FieldMask::FieldMask()
  : ::google::protobuf::Message(), _internal_metadata_(nullptr) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:google.protobuf.FieldMask)
}
FieldMask::FieldMask(::google::protobuf::Arena* arena)
  : ::google::protobuf::Message(),
  _internal_metadata_(arena),
  paths_(arena) {
  SharedCtor();
  RegisterArenaDtor(arena);
  // @@protoc_insertion_point(arena_constructor:google.protobuf.FieldMask)
}
FieldMask::FieldMask(const FieldMask& from)
  : ::google::protobuf::Message(),
      _internal_metadata_(nullptr),
      paths_(from.paths_) {
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  // @@protoc_insertion_point(copy_constructor:google.protobuf.FieldMask)
}

void FieldMask::SharedCtor() {
  ::google::protobuf::internal::InitSCC(
      &scc_info_FieldMask_google_2fprotobuf_2ffield_5fmask_2eproto.base);
}

FieldMask::~FieldMask() {
  // @@protoc_insertion_point(destructor:google.protobuf.FieldMask)
  SharedDtor();
}

void FieldMask::SharedDtor() {
  GOOGLE_DCHECK(GetArenaNoVirtual() == nullptr);
}

void FieldMask::ArenaDtor(void* object) {
  FieldMask* _this = reinterpret_cast< FieldMask* >(object);
  (void)_this;
}
void FieldMask::RegisterArenaDtor(::google::protobuf::Arena*) {
}
void FieldMask::SetCachedSize(int size) const {
  _cached_size_.Set(size);
}
const FieldMask& FieldMask::default_instance() {
  ::google::protobuf::internal::InitSCC(&::scc_info_FieldMask_google_2fprotobuf_2ffield_5fmask_2eproto.base);
  return *internal_default_instance();
}


void FieldMask::Clear() {
// @@protoc_insertion_point(message_clear_start:google.protobuf.FieldMask)
  ::google::protobuf::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  paths_.Clear();
  _internal_metadata_.Clear();
}

#if GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
const char* FieldMask::_InternalParse(const char* begin, const char* end, void* object,
                  ::google::protobuf::internal::ParseContext* ctx) {
  auto msg = static_cast<FieldMask*>(object);
  ::google::protobuf::int32 size; (void)size;
  int depth; (void)depth;
  ::google::protobuf::uint32 tag;
  ::google::protobuf::internal::ParseFunc parser_till_end; (void)parser_till_end;
  auto ptr = begin;
  while (ptr < end) {
    ptr = ::google::protobuf::io::Parse32(ptr, &tag);
    GOOGLE_PROTOBUF_PARSER_ASSERT(ptr);
    switch (tag >> 3) {
      // repeated string paths = 1;
      case 1: {
        if (static_cast<::google::protobuf::uint8>(tag) != 10) goto handle_unusual;
        do {
          ptr = ::google::protobuf::io::ReadSize(ptr, &size);
          GOOGLE_PROTOBUF_PARSER_ASSERT(ptr);
          ctx->extra_parse_data().SetFieldName("google.protobuf.FieldMask.paths");
          auto str = msg->add_paths();
          if (size > end - ptr + ::google::protobuf::internal::ParseContext::kSlopBytes) {
            object = str;
            str->clear();
            str->reserve(size);
            parser_till_end = ::google::protobuf::internal::GreedyStringParserUTF8;
            goto len_delim_till_end;
          }
          GOOGLE_PROTOBUF_PARSER_ASSERT(::google::protobuf::internal::StringCheckUTF8(ptr, size, ctx));
          ::google::protobuf::internal::InlineGreedyStringParser(str, ptr, size, ctx);
          ptr += size;
          if (ptr >= end) break;
        } while ((::google::protobuf::io::UnalignedLoad<::google::protobuf::uint64>(ptr) & 255) == 10 && (ptr += 1));
        break;
      }
      default: {
      handle_unusual:
        if ((tag & 7) == 4 || tag == 0) {
          ctx->EndGroup(tag);
          return ptr;
        }
        auto res = UnknownFieldParse(tag, {_InternalParse, msg},
          ptr, end, msg->_internal_metadata_.mutable_unknown_fields(), ctx);
        ptr = res.first;
        GOOGLE_PROTOBUF_PARSER_ASSERT(ptr != nullptr);
        if (res.second) return ptr;
      }
    }  // switch
  }  // while
  return ptr;
len_delim_till_end:
  return ctx->StoreAndTailCall(ptr, end, {_InternalParse, msg},
                               {parser_till_end, object}, size);
}
#else  // GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
bool FieldMask::MergePartialFromCodedStream(
    ::google::protobuf::io::CodedInputStream* input) {
#define DO_(EXPRESSION) if (!PROTOBUF_PREDICT_TRUE(EXPRESSION)) goto failure
  ::google::protobuf::uint32 tag;
  // @@protoc_insertion_point(parse_start:google.protobuf.FieldMask)
  for (;;) {
    ::std::pair<::google::protobuf::uint32, bool> p = input->ReadTagWithCutoffNoLastTag(127u);
    tag = p.first;
    if (!p.second) goto handle_unusual;
    switch (::google::protobuf::internal::WireFormatLite::GetTagFieldNumber(tag)) {
      // repeated string paths = 1;
      case 1: {
        if (static_cast< ::google::protobuf::uint8>(tag) == (10 & 0xFF)) {
          DO_(::google::protobuf::internal::WireFormatLite::ReadString(
                input, this->add_paths()));
          DO_(::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
            this->paths(this->paths_size() - 1).data(),
            static_cast<int>(this->paths(this->paths_size() - 1).length()),
            ::google::protobuf::internal::WireFormatLite::PARSE,
            "google.protobuf.FieldMask.paths"));
        } else {
          goto handle_unusual;
        }
        break;
      }

      default: {
      handle_unusual:
        if (tag == 0) {
          goto success;
        }
        DO_(::google::protobuf::internal::WireFormat::SkipField(
              input, tag, _internal_metadata_.mutable_unknown_fields()));
        break;
      }
    }
  }
success:
  // @@protoc_insertion_point(parse_success:google.protobuf.FieldMask)
  return true;
failure:
  // @@protoc_insertion_point(parse_failure:google.protobuf.FieldMask)
  return false;
#undef DO_
}
#endif  // GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER

void FieldMask::SerializeWithCachedSizes(
    ::google::protobuf::io::CodedOutputStream* output) const {
  // @@protoc_insertion_point(serialize_start:google.protobuf.FieldMask)
  ::google::protobuf::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // repeated string paths = 1;
  for (int i = 0, n = this->paths_size(); i < n; i++) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->paths(i).data(), static_cast<int>(this->paths(i).length()),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "google.protobuf.FieldMask.paths");
    ::google::protobuf::internal::WireFormatLite::WriteString(
      1, this->paths(i), output);
  }

  if (_internal_metadata_.have_unknown_fields()) {
    ::google::protobuf::internal::WireFormat::SerializeUnknownFields(
        _internal_metadata_.unknown_fields(), output);
  }
  // @@protoc_insertion_point(serialize_end:google.protobuf.FieldMask)
}

::google::protobuf::uint8* FieldMask::InternalSerializeWithCachedSizesToArray(
    ::google::protobuf::uint8* target) const {
  // @@protoc_insertion_point(serialize_to_array_start:google.protobuf.FieldMask)
  ::google::protobuf::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // repeated string paths = 1;
  for (int i = 0, n = this->paths_size(); i < n; i++) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->paths(i).data(), static_cast<int>(this->paths(i).length()),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "google.protobuf.FieldMask.paths");
    target = ::google::protobuf::internal::WireFormatLite::
      WriteStringToArray(1, this->paths(i), target);
  }

  if (_internal_metadata_.have_unknown_fields()) {
    target = ::google::protobuf::internal::WireFormat::SerializeUnknownFieldsToArray(
        _internal_metadata_.unknown_fields(), target);
  }
  // @@protoc_insertion_point(serialize_to_array_end:google.protobuf.FieldMask)
  return target;
}

size_t FieldMask::ByteSizeLong() const {
// @@protoc_insertion_point(message_byte_size_start:google.protobuf.FieldMask)
  size_t total_size = 0;

  if (_internal_metadata_.have_unknown_fields()) {
    total_size +=
      ::google::protobuf::internal::WireFormat::ComputeUnknownFieldsSize(
        _internal_metadata_.unknown_fields());
  }
  ::google::protobuf::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  // repeated string paths = 1;
  total_size += 1 *
      ::google::protobuf::internal::FromIntSize(this->paths_size());
  for (int i = 0, n = this->paths_size(); i < n; i++) {
    total_size += ::google::protobuf::internal::WireFormatLite::StringSize(
      this->paths(i));
  }

  int cached_size = ::google::protobuf::internal::ToCachedSize(total_size);
  SetCachedSize(cached_size);
  return total_size;
}

void FieldMask::MergeFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:google.protobuf.FieldMask)
  GOOGLE_DCHECK_NE(&from, this);
  const FieldMask* source =
      ::google::protobuf::DynamicCastToGenerated<FieldMask>(
          &from);
  if (source == nullptr) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:google.protobuf.FieldMask)
    ::google::protobuf::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:google.protobuf.FieldMask)
    MergeFrom(*source);
  }
}

void FieldMask::MergeFrom(const FieldMask& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:google.protobuf.FieldMask)
  GOOGLE_DCHECK_NE(&from, this);
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  ::google::protobuf::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  paths_.MergeFrom(from.paths_);
}

void FieldMask::CopyFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:google.protobuf.FieldMask)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void FieldMask::CopyFrom(const FieldMask& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:google.protobuf.FieldMask)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool FieldMask::IsInitialized() const {
  return true;
}

void FieldMask::Swap(FieldMask* other) {
  if (other == this) return;
  if (GetArenaNoVirtual() == other->GetArenaNoVirtual()) {
    InternalSwap(other);
  } else {
    FieldMask* temp = New(GetArenaNoVirtual());
    temp->MergeFrom(*other);
    other->CopyFrom(*this);
    InternalSwap(temp);
    if (GetArenaNoVirtual() == nullptr) {
      delete temp;
    }
  }
}
void FieldMask::UnsafeArenaSwap(FieldMask* other) {
  if (other == this) return;
  GOOGLE_DCHECK(GetArenaNoVirtual() == other->GetArenaNoVirtual());
  InternalSwap(other);
}
void FieldMask::InternalSwap(FieldMask* other) {
  using std::swap;
  _internal_metadata_.Swap(&other->_internal_metadata_);
  paths_.InternalSwap(CastToBase(&other->paths_));
}

::google::protobuf::Metadata FieldMask::GetMetadata() const {
  ::google::protobuf::internal::AssignDescriptors(&::assign_descriptors_table_google_2fprotobuf_2ffield_5fmask_2eproto);
  return ::file_level_metadata_google_2fprotobuf_2ffield_5fmask_2eproto[kIndexInFileMessages];
}


// @@protoc_insertion_point(namespace_scope)
}  // namespace protobuf
}  // namespace google
namespace google {
namespace protobuf {
template<> PROTOBUF_NOINLINE ::google::protobuf::FieldMask* Arena::CreateMaybeMessage< ::google::protobuf::FieldMask >(Arena* arena) {
  return Arena::CreateMessageInternal< ::google::protobuf::FieldMask >(arena);
}
}  // namespace protobuf
}  // namespace google

// @@protoc_insertion_point(global_scope)
#include <google/protobuf/port_undef.inc>
