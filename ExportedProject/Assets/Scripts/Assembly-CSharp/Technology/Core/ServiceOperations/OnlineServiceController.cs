using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D12")]
	public class OnlineServiceController
	{
		[Token(Token = "0x2000D13")]
		private enum AsyncResponse
		{
			[Token(Token = "0x4003E98")]
			Event = 0
		}

		[Token(Token = "0x2000D14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59881C", Offset = "0x59881C")]
		private sealed class _003C_003Ec__DisplayClass23_0
		{
			[Token(Token = "0x4003E99")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpRegisterNotificationServiceClient svcOp;

			[Token(Token = "0x4003E9A")]
			[FieldOffset(Offset = "0x18")]
			public string deviceTokenAsString;

			[Token(Token = "0x4003E9B")]
			[FieldOffset(Offset = "0x20")]
			public string language2C;

			[Token(Token = "0x60050CE")]
			[Address(RVA = "0x8CE504", Offset = "0x8CE504", VA = "0x8CE504")]
			public _003C_003Ec__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60050CF")]
			[Address(RVA = "0x8CE50C", Offset = "0x8CE50C", VA = "0x8CE50C")]
			internal void _003CPostNotificationServiceClient_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000D15")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59882C", Offset = "0x59882C")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x4003E9C")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpPushNotification svcOp;

			[Token(Token = "0x4003E9D")]
			[FieldOffset(Offset = "0x18")]
			public string playerId;

			[Token(Token = "0x4003E9E")]
			[FieldOffset(Offset = "0x20")]
			public string notificationId;

			[Token(Token = "0x4003E9F")]
			[FieldOffset(Offset = "0x28")]
			public string[] parameters;

			[Token(Token = "0x60050D0")]
			[Address(RVA = "0x8CE568", Offset = "0x8CE568", VA = "0x8CE568")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60050D1")]
			[Address(RVA = "0x8CE570", Offset = "0x8CE570", VA = "0x8CE570")]
			internal void _003CPostPushNotification_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000D16")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59883C", Offset = "0x59883C")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x4003EA0")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetItemOffers svcOp;

			[Token(Token = "0x60050D2")]
			[Address(RVA = "0x8CE5A0", Offset = "0x8CE5A0", VA = "0x8CE5A0")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60050D3")]
			[Address(RVA = "0x8CE5A8", Offset = "0x8CE5A8", VA = "0x8CE5A8")]
			internal void _003CGetItemOffers_003Eb__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000D17")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59884C", Offset = "0x59884C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003EA1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003EA2")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IResponseContext> _003C_003E9__29_0;

			[Token(Token = "0x60050D5")]
			[Address(RVA = "0x8CE4F8", Offset = "0x8CE4F8", VA = "0x8CE4F8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60050D6")]
			[Address(RVA = "0x8CE500", Offset = "0x8CE500", VA = "0x8CE500")]
			internal void _003CExecuteTestRequest_003Eb__29_0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003E91")]
		[FieldOffset(Offset = "0x0")]
		private static OnlineServiceController _instance;

		[Token(Token = "0x4003E92")]
		[FieldOffset(Offset = "0x8")]
		public static bool ForceEnqueueDisable;

		[Token(Token = "0x4003E93")]
		[FieldOffset(Offset = "0x10")]
		public OnlineSuiteConfiguration Settings;

		[Token(Token = "0x4003E94")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<OSRequest> _requestQueue;

		[Token(Token = "0x4003E95")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<OSResponse> _responseQueue;

		[Token(Token = "0x4003E96")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object _svcopExecutorlocker;

		[Token(Token = "0x17000AAA")]
		public static OnlineServiceController Instance
		{
			[Token(Token = "0x60050B7")]
			[Address(RVA = "0x9F8630", Offset = "0x9F8630", VA = "0x9F8630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x9F8414", Offset = "0x9F8414", VA = "0x9F8414")]
		private OnlineServiceController()
		{
		}

		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x9F86CC", Offset = "0x9F86CC", VA = "0x9F86CC")]
		internal void Initialize()
		{
		}

		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x9F86D0", Offset = "0x9F86D0", VA = "0x9F86D0")]
		public void OnAuthenticationStateChanged()
		{
		}

		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x9F86D4", Offset = "0x9F86D4", VA = "0x9F86D4")]
		public void ForceUpdate()
		{
		}

		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x9F86D8", Offset = "0x9F86D8", VA = "0x9F86D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x9F8A58", Offset = "0x9F8A58", VA = "0x9F8A58")]
		private void ExecuteResponse()
		{
		}

		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x9F87FC", Offset = "0x9F87FC", VA = "0x9F87FC")]
		private void ExecuteRequest()
		{
		}

		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x9F8BF0", Offset = "0x9F8BF0", VA = "0x9F8BF0")]
		internal void Enqueue(SvcOp svcOp, Action svcOpRunAction)
		{
		}

		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x9F8DC4", Offset = "0x9F8DC4", VA = "0x9F8DC4")]
		internal void Enqueue(SvcOp svcOp, Action svcOpRunAction, Action<IResponseContext, IRequestContext, OSRequestState, Dictionary<string, object>> subscriberAction)
		{
		}

		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x9F8BFC", Offset = "0x9F8BFC", VA = "0x9F8BFC")]
		internal void Enqueue(SvcOp svcOp, Action svcOpRunAction, Action<IResponseContext, IRequestContext, OSRequestState, Dictionary<string, object>> subscriberAction, Dictionary<string, object> additionalRequestMeta)
		{
		}

		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x9F8DCC", Offset = "0x9F8DCC", VA = "0x9F8DCC")]
		internal void Enqueue(OSResponse response)
		{
		}

		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x9F8F10", Offset = "0x9F8F10", VA = "0x9F8F10")]
		private void RequestOnError(object sender, OSResponse osResponse)
		{
		}

		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x9F8F18", Offset = "0x9F8F18", VA = "0x9F8F18")]
		private void RequestOnCancelled(object sender, OSResponse osResponse)
		{
		}

		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x9F8F20", Offset = "0x9F8F20", VA = "0x9F8F20")]
		private void RequestOnComplete(object sender, OSResponse osResponse)
		{
		}

		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x9F8F28", Offset = "0x9F8F28", VA = "0x9F8F28")]
		public OnlineServiceError PostNotificationServiceClient(string deviceToken, string language)
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x9F9088", Offset = "0x9F9088", VA = "0x9F9088")]
		public OnlineServiceError PostPushNotification(string playerId, string notificationId, string[] parameters)
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x9F91A8", Offset = "0x9F91A8", VA = "0x9F91A8")]
		public OnlineServiceError GetItemOffers()
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x9F9304", Offset = "0x9F9304", VA = "0x9F9304")]
		private void HandleGetItemOffers(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> additionalRequestMeta)
		{
		}

		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x9F9448", Offset = "0x9F9448", VA = "0x9F9448")]
		private void HandleQueryResultJson(string jsonString)
		{
		}

		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x9F95B0", Offset = "0x9F95B0", VA = "0x9F95B0")]
		private void HandleSingleResult(JSONNode jsonNode)
		{
		}

		[Token(Token = "0x60050CB")]
		[Address(RVA = "0x9F96CC", Offset = "0x9F96CC", VA = "0x9F96CC")]
		public void ExecuteTestRequest(bool b)
		{
		}

		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x9F9800", Offset = "0x9F9800", VA = "0x9F9800")]
		public void Shutdown()
		{
		}
	}
}
