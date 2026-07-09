using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D11")]
	internal class OSResponse : EventArgs
	{
		[Token(Token = "0x4003E8C")]
		[FieldOffset(Offset = "0x10")]
		public Action<IResponseContext, IRequestContext, OSRequestState, Dictionary<string, object>> SubscriberAction;

		[Token(Token = "0x4003E8D")]
		[FieldOffset(Offset = "0x18")]
		public IRequestContext RequestContext;

		[Token(Token = "0x4003E8E")]
		[FieldOffset(Offset = "0x20")]
		public IResponseContext ResponseContext;

		[Token(Token = "0x4003E8F")]
		[FieldOffset(Offset = "0x28")]
		public OSRequestState State;

		[Token(Token = "0x4003E90")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, object> AdditionalRequestMeta;

		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x9E8D58", Offset = "0x9E8D58", VA = "0x9E8D58")]
		public OSResponse()
		{
		}
	}
}
