// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/source_context.proto

#include <google/protobuf/source_context.pb.h>

#include <algorithm>

#include <google/protobuf/stubs/common.h>
#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/wire_format_lite.h>
#include <google/protobuf/descriptor.h>
#include <google/protobuf/generated_message_reflection.h>
#include <google/protobuf/reflection_ops.h>
#include <google/protobuf/wire_format.h>
// @@protoc_insertion_point(includes)
#include <google/protobuf/port_def.inc>

PROTOBUF_NAMESPACE_OPEN
class SourceContextDefaultTypeInternal {
 public:
  ::PROTOBUF_NAMESPACE_ID::internal::ExplicitlyConstructed<SourceContext> _instance;
} _SourceContext_default_instance_;
PROTOBUF_NAMESPACE_CLOSE
static void InitDefaultsSourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto() {
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  {
    void* ptr = &PROTOBUF_NAMESPACE_ID::_SourceContext_default_instance_;
    new (ptr) PROTOBUF_NAMESPACE_ID::SourceContext();
    ::PROTOBUF_NAMESPACE_ID::internal::OnShutdownDestroyMessage(ptr);
  }
  PROTOBUF_NAMESPACE_ID::SourceContext::InitAsDefaultInstance();
}

PROTOBUF_EXPORT ::PROTOBUF_NAMESPACE_ID::internal::SCCInfo<0> scc_info_SourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto =
    {{ATOMIC_VAR_INIT(::PROTOBUF_NAMESPACE_ID::internal::SCCInfoBase::kUninitialized), 0, InitDefaultsSourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto}, {}};

static ::PROTOBUF_NAMESPACE_ID::Metadata file_level_metadata_google_2fprotobuf_2fsource_5fcontext_2eproto[1];
static constexpr ::PROTOBUF_NAMESPACE_ID::EnumDescriptor const** file_level_enum_descriptors_google_2fprotobuf_2fsource_5fcontext_2eproto = nullptr;
static constexpr ::PROTOBUF_NAMESPACE_ID::ServiceDescriptor const** file_level_service_descriptors_google_2fprotobuf_2fsource_5fcontext_2eproto = nullptr;

const ::PROTOBUF_NAMESPACE_ID::uint32 TableStruct_google_2fprotobuf_2fsource_5fcontext_2eproto::offsets[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  ~0u,  // no _has_bits_
  PROTOBUF_FIELD_OFFSET(PROTOBUF_NAMESPACE_ID::SourceContext, _internal_metadata_),
  ~0u,  // no _extensions_
  ~0u,  // no _oneof_case_
  ~0u,  // no _weak_field_map_
  PROTOBUF_FIELD_OFFSET(PROTOBUF_NAMESPACE_ID::SourceContext, file_name_),
};
static const ::PROTOBUF_NAMESPACE_ID::internal::MigrationSchema schemas[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  { 0, -1, sizeof(PROTOBUF_NAMESPACE_ID::SourceContext)},
};

static ::PROTOBUF_NAMESPACE_ID::Message const * const file_default_instances[] = {
  reinterpret_cast<const ::PROTOBUF_NAMESPACE_ID::Message*>(&PROTOBUF_NAMESPACE_ID::_SourceContext_default_instance_),
};

static ::PROTOBUF_NAMESPACE_ID::internal::AssignDescriptorsTable assign_descriptors_table_google_2fprotobuf_2fsource_5fcontext_2eproto = {
  {}, AddDescriptors_google_2fprotobuf_2fsource_5fcontext_2eproto, "google/protobuf/source_context.proto", schemas,
  file_default_instances, TableStruct_google_2fprotobuf_2fsource_5fcontext_2eproto::offsets,
  file_level_metadata_google_2fprotobuf_2fsource_5fcontext_2eproto, 1, file_level_enum_descriptors_google_2fprotobuf_2fsource_5fcontext_2eproto, file_level_service_descriptors_google_2fprotobuf_2fsource_5fcontext_2eproto,
};

const char descriptor_table_protodef_google_2fprotobuf_2fsource_5fcontext_2eproto[] =
  "\n$google/protobuf/source_context.proto\022\017"
  "google.protobuf\"\"\n\rSourceContext\022\021\n\tfile"
  "_name\030\001 \001(\tB\225\001\n\023com.google.protobufB\022Sou"
  "rceContextProtoP\001ZAgoogle.golang.org/gen"
  "proto/protobuf/source_context;source_con"
  "text\242\002\003GPB\252\002\036Google.Protobuf.WellKnownTy"
  "pesb\006proto3"
  ;
static ::PROTOBUF_NAMESPACE_ID::internal::DescriptorTable descriptor_table_google_2fprotobuf_2fsource_5fcontext_2eproto = {
  false, descriptor_table_protodef_google_2fprotobuf_2fsource_5fcontext_2eproto,
  "google/protobuf/source_context.proto", &assign_descriptors_table_google_2fprotobuf_2fsource_5fcontext_2eproto, 251,
};

void AddDescriptors_google_2fprotobuf_2fsource_5fcontext_2eproto() {
  static constexpr ::PROTOBUF_NAMESPACE_ID::internal::InitFunc deps[1] =
  {
  };
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&scc_info_SourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto.base);
 ::PROTOBUF_NAMESPACE_ID::internal::AddDescriptors(&descriptor_table_google_2fprotobuf_2fsource_5fcontext_2eproto, deps, 0);
}

// Force running AddDescriptors() at dynamic initialization time.
static bool dynamic_init_dummy_google_2fprotobuf_2fsource_5fcontext_2eproto = []() { AddDescriptors_google_2fprotobuf_2fsource_5fcontext_2eproto(); return true; }();
PROTOBUF_NAMESPACE_OPEN

// ===================================================================

void SourceContext::InitAsDefaultInstance() {
}
class SourceContext::HasBitSetters {
 public:
};

#if !defined(_MSC_VER) || _MSC_VER >= 1900
const int SourceContext::kFileNameFieldNumber;
#endif  // !defined(_MSC_VER) || _MSC_VER >= 1900

SourceContext::SourceContext()
  : ::PROTOBUF_NAMESPACE_ID::Message(), _internal_metadata_(nullptr) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:google.protobuf.SourceContext)
}
SourceContext::SourceContext(const SourceContext& from)
  : ::PROTOBUF_NAMESPACE_ID::Message(),
      _internal_metadata_(nullptr) {
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  file_name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  if (from.file_name().size() > 0) {
    file_name_.AssignWithDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from.file_name_);
  }
  // @@protoc_insertion_point(copy_constructor:google.protobuf.SourceContext)
}

void SourceContext::SharedCtor() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(
      &scc_info_SourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto.base);
  file_name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
}

SourceContext::~SourceContext() {
  // @@protoc_insertion_point(destructor:google.protobuf.SourceContext)
  SharedDtor();
}

void SourceContext::SharedDtor() {
  file_name_.DestroyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
}

void SourceContext::SetCachedSize(int size) const {
  _cached_size_.Set(size);
}
const SourceContext& SourceContext::default_instance() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&::scc_info_SourceContext_google_2fprotobuf_2fsource_5fcontext_2eproto.base);
  return *internal_default_instance();
}


void SourceContext::Clear() {
// @@protoc_insertion_point(message_clear_start:google.protobuf.SourceContext)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  file_name_.ClearToEmptyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  _internal_metadata_.Clear();
}

#if GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
const char* SourceContext::_InternalParse(const char* ptr, ::PROTOBUF_NAMESPACE_ID::internal::ParseContext* ctx) {
#define CHK_(x) if (PROTOBUF_PREDICT_FALSE(!(x))) goto failure
  while (!ctx->Done(&ptr)) {
    ::PROTOBUF_NAMESPACE_ID::uint32 tag;
    ptr = ::PROTOBUF_NAMESPACE_ID::internal::ReadTag(ptr, &tag);
    CHK_(ptr);
    switch (tag >> 3) {
      // string file_name = 1;
      case 1: {
        if (static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) != 10) goto handle_unusual;
        ptr = ::PROTOBUF_NAMESPACE_ID::internal::InlineGreedyStringParserUTF8(mutable_file_name(), ptr, ctx, "google.protobuf.SourceContext.file_name");
        CHK_(ptr);
        break;
      }
      default: {
      handle_unusual:
        if ((tag & 7) == 4 || tag == 0) {
          ctx->SetLastTag(tag);
          goto success;
        }
        ptr = UnknownFieldParse(tag, &_internal_metadata_, ptr, ctx);
        CHK_(ptr != nullptr);
        break;
      }
    }  // switch
  }  // while
success:
  return ptr;
failure:
  ptr = nullptr;
  goto success;
#undef CHK_
}
#else  // GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER
bool SourceContext::MergePartialFromCodedStream(
    ::PROTOBUF_NAMESPACE_ID::io::CodedInputStream* input) {
#define DO_(EXPRESSION) if (!PROTOBUF_PREDICT_TRUE(EXPRESSION)) goto failure
  ::PROTOBUF_NAMESPACE_ID::uint32 tag;
  // @@protoc_insertion_point(parse_start:google.protobuf.SourceContext)
  for (;;) {
    ::std::pair<::PROTOBUF_NAMESPACE_ID::uint32, bool> p = input->ReadTagWithCutoffNoLastTag(127u);
    tag = p.first;
    if (!p.second) goto handle_unusual;
    switch (::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::GetTagFieldNumber(tag)) {
      // string file_name = 1;
      case 1: {
        if (static_cast< ::PROTOBUF_NAMESPACE_ID::uint8>(tag) == (10 & 0xFF)) {
          DO_(::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::ReadString(
                input, this->mutable_file_name()));
          DO_(::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
            this->file_name().data(), static_cast<int>(this->file_name().length()),
            ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::PARSE,
            "google.protobuf.SourceContext.file_name"));
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
        DO_(::PROTOBUF_NAMESPACE_ID::internal::WireFormat::SkipField(
              input, tag, _internal_metadata_.mutable_unknown_fields()));
        break;
      }
    }
  }
success:
  // @@protoc_insertion_point(parse_success:google.protobuf.SourceContext)
  return true;
failure:
  // @@protoc_insertion_point(parse_failure:google.protobuf.SourceContext)
  return false;
#undef DO_
}
#endif  // GOOGLE_PROTOBUF_ENABLE_EXPERIMENTAL_PARSER

void SourceContext::SerializeWithCachedSizes(
    ::PROTOBUF_NAMESPACE_ID::io::CodedOutputStream* output) const {
  // @@protoc_insertion_point(serialize_start:google.protobuf.SourceContext)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // string file_name = 1;
  if (this->file_name().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->file_name().data(), static_cast<int>(this->file_name().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "google.protobuf.SourceContext.file_name");
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::WriteStringMaybeAliased(
      1, this->file_name(), output);
  }

  if (_internal_metadata_.have_unknown_fields()) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormat::SerializeUnknownFields(
        _internal_metadata_.unknown_fields(), output);
  }
  // @@protoc_insertion_point(serialize_end:google.protobuf.SourceContext)
}

::PROTOBUF_NAMESPACE_ID::uint8* SourceContext::InternalSerializeWithCachedSizesToArray(
    ::PROTOBUF_NAMESPACE_ID::uint8* target) const {
  // @@protoc_insertion_point(serialize_to_array_start:google.protobuf.SourceContext)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // string file_name = 1;
  if (this->file_name().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->file_name().data(), static_cast<int>(this->file_name().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "google.protobuf.SourceContext.file_name");
    target =
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::WriteStringToArray(
        1, this->file_name(), target);
  }

  if (_internal_metadata_.have_unknown_fields()) {
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormat::SerializeUnknownFieldsToArray(
        _internal_metadata_.unknown_fields(), target);
  }
  // @@protoc_insertion_point(serialize_to_array_end:google.protobuf.SourceContext)
  return target;
}

size_t SourceContext::ByteSizeLong() const {
// @@protoc_insertion_point(message_byte_size_start:google.protobuf.SourceContext)
  size_t total_size = 0;

  if (_internal_metadata_.have_unknown_fields()) {
    total_size +=
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormat::ComputeUnknownFieldsSize(
        _internal_metadata_.unknown_fields());
  }
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  // string file_name = 1;
  if (this->file_name().size() > 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::StringSize(
        this->file_name());
  }

  int cached_size = ::PROTOBUF_NAMESPACE_ID::internal::ToCachedSize(total_size);
  SetCachedSize(cached_size);
  return total_size;
}

void SourceContext::MergeFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:google.protobuf.SourceContext)
  GOOGLE_DCHECK_NE(&from, this);
  const SourceContext* source =
      ::PROTOBUF_NAMESPACE_ID::DynamicCastToGenerated<SourceContext>(
          &from);
  if (source == nullptr) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:google.protobuf.SourceContext)
    ::PROTOBUF_NAMESPACE_ID::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:google.protobuf.SourceContext)
    MergeFrom(*source);
  }
}

void SourceContext::MergeFrom(const SourceContext& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:google.protobuf.SourceContext)
  GOOGLE_DCHECK_NE(&from, this);
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  if (from.file_name().size() > 0) {

    file_name_.AssignWithDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from.file_name_);
  }
}

void SourceContext::CopyFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:google.protobuf.SourceContext)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void SourceContext::CopyFrom(const SourceContext& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:google.protobuf.SourceContext)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool SourceContext::IsInitialized() const {
  return true;
}

void SourceContext::Swap(SourceContext* other) {
  if (other == this) return;
  InternalSwap(other);
}
void SourceContext::InternalSwap(SourceContext* other) {
  using std::swap;
  _internal_metadata_.Swap(&other->_internal_metadata_);
  file_name_.Swap(&other->file_name_, &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
    GetArenaNoVirtual());
}

::PROTOBUF_NAMESPACE_ID::Metadata SourceContext::GetMetadata() const {
  ::PROTOBUF_NAMESPACE_ID::internal::AssignDescriptors(&::assign_descriptors_table_google_2fprotobuf_2fsource_5fcontext_2eproto);
  return ::file_level_metadata_google_2fprotobuf_2fsource_5fcontext_2eproto[kIndexInFileMessages];
}


// @@protoc_insertion_point(namespace_scope)
PROTOBUF_NAMESPACE_CLOSE
PROTOBUF_NAMESPACE_OPEN
template<> PROTOBUF_NOINLINE PROTOBUF_NAMESPACE_ID::SourceContext* Arena::CreateMaybeMessage< PROTOBUF_NAMESPACE_ID::SourceContext >(Arena* arena) {
  return Arena::CreateInternal< PROTOBUF_NAMESPACE_ID::SourceContext >(arena);
}
PROTOBUF_NAMESPACE_CLOSE

// @@protoc_insertion_point(global_scope)
#include <google/protobuf/port_undef.inc>
