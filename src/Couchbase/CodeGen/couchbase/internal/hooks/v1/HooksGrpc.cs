// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: couchbase/internal/hooks/v1/hooks.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Couchbase.Protostellar.Internal.Hooks.V1 {
  public static partial class HooksService
  {
    static readonly string __ServiceName = "couchbase.internal.hooks.v1.HooksService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest> __Marshaller_couchbase_internal_hooks_v1_CreateHooksContextRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse> __Marshaller_couchbase_internal_hooks_v1_CreateHooksContextResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest> __Marshaller_couchbase_internal_hooks_v1_DestroyHooksContextRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse> __Marshaller_couchbase_internal_hooks_v1_DestroyHooksContextResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest> __Marshaller_couchbase_internal_hooks_v1_AddHooksRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse> __Marshaller_couchbase_internal_hooks_v1_AddHooksResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest> __Marshaller_couchbase_internal_hooks_v1_WatchBarrierRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse> __Marshaller_couchbase_internal_hooks_v1_WatchBarrierResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest> __Marshaller_couchbase_internal_hooks_v1_SignalBarrierRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse> __Marshaller_couchbase_internal_hooks_v1_SignalBarrierResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse> __Method_CreateHooksContext = new grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateHooksContext",
        __Marshaller_couchbase_internal_hooks_v1_CreateHooksContextRequest,
        __Marshaller_couchbase_internal_hooks_v1_CreateHooksContextResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse> __Method_DestroyHooksContext = new grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DestroyHooksContext",
        __Marshaller_couchbase_internal_hooks_v1_DestroyHooksContextRequest,
        __Marshaller_couchbase_internal_hooks_v1_DestroyHooksContextResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse> __Method_AddHooks = new grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddHooks",
        __Marshaller_couchbase_internal_hooks_v1_AddHooksRequest,
        __Marshaller_couchbase_internal_hooks_v1_AddHooksResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse> __Method_WatchBarrier = new grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "WatchBarrier",
        __Marshaller_couchbase_internal_hooks_v1_WatchBarrierRequest,
        __Marshaller_couchbase_internal_hooks_v1_WatchBarrierResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse> __Method_SignalBarrier = new grpc::Method<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest, global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignalBarrier",
        __Marshaller_couchbase_internal_hooks_v1_SignalBarrierRequest,
        __Marshaller_couchbase_internal_hooks_v1_SignalBarrierResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Couchbase.Protostellar.Internal.Hooks.V1.HooksReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for HooksService</summary>
    public partial class HooksServiceClient : grpc::ClientBase<HooksServiceClient>
    {
      /// <summary>Creates a new client for HooksService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HooksServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HooksService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HooksServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HooksServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HooksServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse CreateHooksContext(global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHooksContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse CreateHooksContext(global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateHooksContext, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse> CreateHooksContextAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHooksContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextResponse> CreateHooksContextAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.CreateHooksContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateHooksContext, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse DestroyHooksContext(global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DestroyHooksContext(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse DestroyHooksContext(global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DestroyHooksContext, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse> DestroyHooksContextAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DestroyHooksContextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextResponse> DestroyHooksContextAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.DestroyHooksContextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DestroyHooksContext, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse AddHooks(global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddHooks(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse AddHooks(global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddHooks, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse> AddHooksAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddHooksAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksResponse> AddHooksAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.AddHooksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddHooks, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse> WatchBarrier(global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return WatchBarrier(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierResponse> WatchBarrier(global::Couchbase.Protostellar.Internal.Hooks.V1.WatchBarrierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_WatchBarrier, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse SignalBarrier(global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignalBarrier(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse SignalBarrier(global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SignalBarrier, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse> SignalBarrierAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignalBarrierAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierResponse> SignalBarrierAsync(global::Couchbase.Protostellar.Internal.Hooks.V1.SignalBarrierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SignalBarrier, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override HooksServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HooksServiceClient(configuration);
      }
    }

  }
}
#endregion
