using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D91")]
	internal sealed class LoginGameCenter : IAuthenticationState
	{
		[Token(Token = "0x2000D92")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598914", Offset = "0x598914")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40040B5")]
			[FieldOffset(Offset = "0x10")]
			public LoginGameCenter _003C_003E4__this;

			[Token(Token = "0x40040B6")]
			[FieldOffset(Offset = "0x18")]
			public Action<object> resultAction;

			[Token(Token = "0x6005395")]
			[Address(RVA = "0x8C338C", Offset = "0x8C338C", VA = "0x8C338C")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6005396")]
			[Address(RVA = "0x8C3394", Offset = "0x8C3394", VA = "0x8C3394")]
			internal void _003CHandle_003Eb__0(bool isLoggedIn)
			{
			}
		}

		[Token(Token = "0x40040B3")]
		[FieldOffset(Offset = "0x10")]
		private bool _authenticationAttempted;

		[Token(Token = "0x40040B4")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE67C", Offset = "0x5BE67C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AEB")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005390")]
			[Address(RVA = "0x9DDFC0", Offset = "0x9DDFC0", VA = "0x9DDFC0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A210", Offset = "0x62A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005391")]
			[Address(RVA = "0x9DDFC8", Offset = "0x9DDFC8", VA = "0x9DDFC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A220", Offset = "0x62A220")]
			private set
			{
			}
		}

		[Token(Token = "0x6005392")]
		[Address(RVA = "0x9DDFD4", Offset = "0x9DDFD4", VA = "0x9DDFD4", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005393")]
		[Address(RVA = "0x9DE1EC", Offset = "0x9DE1EC", VA = "0x9DE1EC")]
		private void LoginResult(Action<object> resultAction, bool isLoggedIn, string message)
		{
		}

		[Token(Token = "0x6005394")]
		[Address(RVA = "0x9DE27C", Offset = "0x9DE27C", VA = "0x9DE27C")]
		public LoginGameCenter()
		{
		}
	}
}
