// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: msg.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DMS.GrpcTest.Protocol {
  public static partial class MsgService
  {
    static readonly string __ServiceName = "DMS.GrpcTest.Protocol.MsgService";

    static readonly grpc::Marshaller<global::DMS.GrpcTest.Protocol.GetMsgNumRequest> __Marshaller_GetMsgNumRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DMS.GrpcTest.Protocol.GetMsgNumRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DMS.GrpcTest.Protocol.GetMsgSumReply> __Marshaller_GetMsgSumReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DMS.GrpcTest.Protocol.GetMsgSumReply.Parser.ParseFrom);

    static readonly grpc::Method<global::DMS.GrpcTest.Protocol.GetMsgNumRequest, global::DMS.GrpcTest.Protocol.GetMsgSumReply> __Method_GetSum = new grpc::Method<global::DMS.GrpcTest.Protocol.GetMsgNumRequest, global::DMS.GrpcTest.Protocol.GetMsgSumReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSum",
        __Marshaller_GetMsgNumRequest,
        __Marshaller_GetMsgSumReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DMS.GrpcTest.Protocol.MsgReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MsgService</summary>
    public abstract partial class MsgServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::DMS.GrpcTest.Protocol.GetMsgSumReply> GetSum(global::DMS.GrpcTest.Protocol.GetMsgNumRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MsgService</summary>
    public partial class MsgServiceClient : grpc::ClientBase<MsgServiceClient>
    {
      /// <summary>Creates a new client for MsgService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MsgServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MsgService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MsgServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MsgServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MsgServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::DMS.GrpcTest.Protocol.GetMsgSumReply GetSum(global::DMS.GrpcTest.Protocol.GetMsgNumRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSum(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DMS.GrpcTest.Protocol.GetMsgSumReply GetSum(global::DMS.GrpcTest.Protocol.GetMsgNumRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSum, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::DMS.GrpcTest.Protocol.GetMsgSumReply> GetSumAsync(global::DMS.GrpcTest.Protocol.GetMsgNumRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSumAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::DMS.GrpcTest.Protocol.GetMsgSumReply> GetSumAsync(global::DMS.GrpcTest.Protocol.GetMsgNumRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSum, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MsgServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MsgServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MsgServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSum, serviceImpl.GetSum).Build();
    }

  }
}
#endregion
