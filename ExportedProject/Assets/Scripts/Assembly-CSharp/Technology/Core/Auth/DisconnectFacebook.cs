using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D8B")]
	internal sealed class DisconnectFacebook : IAuthenticationState
	{
		[Token(Token = "0x2000D8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598904", Offset = "0x598904")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40040AC")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpDisconnectFacebookId svcOp;

			[Token(Token = "0x40040AD")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x600537A")]
			[Address(RVA = "0x86BC78", Offset = "0x86BC78", VA = "0x86BC78")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600537B")]
			[Address(RVA = "0x86BC80", Offset = "0x86BC80", VA = "0x86BC80")]
			internal void _003CHandle_003Eb__0()
			{
			}
		}

		[Token(Token = "0x40040AA")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultantAction;

		[Token(Token = "0x40040AB")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE63C", Offset = "0x5BE63C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE6")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005375")]
			[Address(RVA = "0xC156B0", Offset = "0xC156B0", VA = "0xC156B0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A190", Offset = "0x62A190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005376")]
			[Address(RVA = "0xC156B8", Offset = "0xC156B8", VA = "0xC156B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1A0", Offset = "0x62A1A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6005377")]
		[Address(RVA = "0xC156C4", Offset = "0xC156C4", VA = "0xC156C4", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005378")]
		[Address(RVA = "0xC15888", Offset = "0xC15888", VA = "0xC15888")]
		private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x6005379")]
		[Address(RVA = "0xC15948", Offset = "0xC15948", VA = "0xC15948")]
		public DisconnectFacebook()
		{
		}
	}
}
