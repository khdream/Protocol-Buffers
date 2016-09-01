// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/source_context.proto

// This CPP symbol can be defined to use imports that match up to the framework
// imports needed when using CocoaPods.
#if !defined(GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS)
 #define GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS 0
#endif

#if GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS
 #import <Protobuf/GPBProtocolBuffers_RuntimeSupport.h>
#else
 #import "GPBProtocolBuffers_RuntimeSupport.h"
#endif

#if GPB_USE_PROTOBUF_FRAMEWORK_IMPORTS
 #import <Protobuf/SourceContext.pbobjc.h>
#else
 #import "google/protobuf/SourceContext.pbobjc.h"
#endif
// @@protoc_insertion_point(imports)

#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wdeprecated-declarations"

#pragma mark - GPBSourceContextRoot

@implementation GPBSourceContextRoot

// No extensions in the file and no imports, so no need to generate
// +extensionRegistry.

@end

#pragma mark - GPBSourceContextRoot_FileDescriptor

static GPBFileDescriptor *GPBSourceContextRoot_FileDescriptor(void) {
  // This is called by +initialize so there is no need to worry
  // about thread safety of the singleton.
  static GPBFileDescriptor *descriptor = NULL;
  if (!descriptor) {
    GPBDebugCheckRuntimeVersion();
    descriptor = [[GPBFileDescriptor alloc] initWithPackage:@"google.protobuf"
                                                     syntax:GPBFileSyntaxProto3];
  }
  return descriptor;
}

#pragma mark - GPBSourceContext

@implementation GPBSourceContext

@dynamic fileName;

typedef struct GPBSourceContext__storage_ {
  uint32_t _has_storage_[1];
  NSString *fileName;
} GPBSourceContext__storage_;

// This method is threadsafe because it is initially called
// in +initialize for each subclass.
+ (GPBDescriptor *)descriptor {
  static GPBDescriptor *descriptor = nil;
  if (!descriptor) {
    static GPBMessageFieldDescription fields[] = {
      {
        .name = "fileName",
        .dataTypeSpecific.className = NULL,
        .number = GPBSourceContext_FieldNumber_FileName,
        .hasIndex = 0,
        .offset = (uint32_t)offsetof(GPBSourceContext__storage_, fileName),
        .flags = GPBFieldOptional,
        .dataType = GPBDataTypeString,
      },
    };
    GPBDescriptor *localDescriptor =
        [GPBDescriptor allocDescriptorForClass:[GPBSourceContext class]
                                     rootClass:[GPBSourceContextRoot class]
                                          file:GPBSourceContextRoot_FileDescriptor()
                                        fields:fields
                                    fieldCount:(uint32_t)(sizeof(fields) / sizeof(GPBMessageFieldDescription))
                                   storageSize:sizeof(GPBSourceContext__storage_)
                                         flags:0];
    NSAssert(descriptor == nil, @"Startup recursed!");
    descriptor = localDescriptor;
  }
  return descriptor;
}

@end


#pragma clang diagnostic pop

// @@protoc_insertion_point(global_scope)
