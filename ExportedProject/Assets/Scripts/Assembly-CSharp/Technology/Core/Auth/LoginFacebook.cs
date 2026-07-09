using System;
using Facebook.Unity;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D90")]
	internal sealed class LoginFacebook : IAuthenticationState
	{
		[Token(Token = "0x40040B1")]
		[FieldOffset(Offset = "0x10")]
		private Action<object> _resultAction;

		[Token(Token = "0x40040B2")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE66C", Offset = "0x5BE66C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AEA")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005387")]
			[Address(RVA = "0x9DD9C8", Offset = "0x9DD9C8", VA = "0x9DD9C8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A1F0", Offset = "0x62A1F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005388")]
			[Address(RVA = "0x9DD9D0", Offset = "0x9DD9D0", VA = "0x9DD9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A200", Offset = "0x62A200")]
			private set
			{
			}
		}

		[Token(Token = "0x6005389")]
		[Address(RVA = "0x9DD9DC", Offset = "0x9DD9DC", VA = "0x9DD9DC", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x600538A")]
		[Address(RVA = "0x9DDB20", Offset = "0x9DDB20", VA = "0x9DDB20")]
		private void OnInitComplete()
		{
		}

		[Token(Token = "0x600538B")]
		[Address(RVA = "0x9DDE98", Offset = "0x9DDE98", VA = "0x9DDE98")]
		private void OnHideUnity(bool isGameShown)
		{
		}

		[Token(Token = "0x600538C")]
		[Address(RVA = "0x9DDE9C", Offset = "0x9DDE9C", VA = "0x9DDE9C")]
		private void LoginCallback(ILoginResult result)
		{
		}

		[Token(Token = "0x600538D")]
		[Address(RVA = "0x9DDCE0", Offset = "0x9DDCE0", VA = "0x9DDCE0")]
		private void GetUserInfo()
		{
		}

		[Token(Token = "0x600538E")]
		[Address(RVA = "0x9DDF50", Offset = "0x9DDF50", VA = "0x9DDF50")]
		private void APICallback(IGraphResult result)
		{
		}

		[Token(Token = "0x600538F")]
		[Address(RVA = "0x9DDFB8", Offset = "0x9DDFB8", VA = "0x9DDFB8")]
		public LoginFacebook()
		{
		}
	}
}
