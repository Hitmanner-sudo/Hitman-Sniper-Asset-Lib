using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D87")]
	internal sealed class ConnectFacebook : IAuthenticationState
	{
		[Token(Token = "0x2000D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5988E4", Offset = "0x5988E4")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x40040A0")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpConnectFacebookId svcOp;

			[Token(Token = "0x40040A1")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			[Token(Token = "0x40040A2")]
			[FieldOffset(Offset = "0x20")]
			public string fbid;

			[Token(Token = "0x600536C")]
			[Address(RVA = "0x8629FC", Offset = "0x8629FC", VA = "0x8629FC")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600536D")]
			[Address(RVA = "0x862A04", Offset = "0x862A04", VA = "0x862A04")]
			internal void _003CHandle_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000D89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5988F4", Offset = "0x5988F4")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40040A3")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpRefreshFacebookFriends svcOpRefreshFriends;

			[Token(Token = "0x40040A4")]
			[FieldOffset(Offset = "0x18")]
			public ConnectFacebook _003C_003E4__this;

			[Token(Token = "0x40040A5")]
			[FieldOffset(Offset = "0x20")]
			public IResponseContext responseContext;

			[Token(Token = "0x40040A6")]
			[FieldOffset(Offset = "0x28")]
			public IRequestContext requestContext;

			[Token(Token = "0x40040A7")]
			[FieldOffset(Offset = "0x30")]
			public OSRequestState state;

			[Token(Token = "0x40040A8")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, object> meta;

			[Token(Token = "0x600536E")]
			[Address(RVA = "0x862A28", Offset = "0x862A28", VA = "0x862A28")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600536F")]
			[Address(RVA = "0x862A30", Offset = "0x862A30", VA = "0x862A30")]
			internal void _003CSubscriberAction_003Eb__0()
			{
			}

			[Token(Token = "0x6005370")]
			[Address(RVA = "0x862A74", Offset = "0x862A74", VA = "0x862A74")]
			internal void _003CSubscriberAction_003Eb__1(IResponseContext _003Cp0_003E, IRequestContext _003Cp1_003E, OSRequestState _003Cp2_003E, Dictionary<string, object> _003Cp3_003E)
			{
			}
		}

		[Token(Token = "0x400409D")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultantAction;

		[Token(Token = "0x400409E")]
		[FieldOffset(Offset = "0x18")]
		private AuthenticationContext _context;

		[Token(Token = "0x400409F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE61C", Offset = "0x5BE61C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AE4")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005367")]
			[Address(RVA = "0x8E0534", Offset = "0x8E0534", VA = "0x8E0534", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A150", Offset = "0x62A150")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005368")]
			[Address(RVA = "0x8E053C", Offset = "0x8E053C", VA = "0x8E053C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A160", Offset = "0x62A160")]
			private set
			{
			}
		}

		[Token(Token = "0x6005369")]
		[Address(RVA = "0x8E0548", Offset = "0x8E0548", VA = "0x8E0548", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x600536A")]
		[Address(RVA = "0x8E079C", Offset = "0x8E079C", VA = "0x8E079C")]
		private void SubscriberAction(IResponseContext responseContext, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}

		[Token(Token = "0x600536B")]
		[Address(RVA = "0x8E0970", Offset = "0x8E0970", VA = "0x8E0970")]
		public ConnectFacebook()
		{
		}
	}
}
