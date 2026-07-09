using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D93")]
	internal sealed class LogoutFacebook : IAuthenticationState
	{
		[Token(Token = "0x40040B7")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE68C", Offset = "0x5BE68C")]
		private bool _003CIsInProgress_003Ek__BackingField;

		[Token(Token = "0x17000AEC")]
		public bool IsInProgress
		{
			[Token(Token = "0x6005397")]
			[Address(RVA = "0x9DEBD0", Offset = "0x9DEBD0", VA = "0x9DEBD0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A230", Offset = "0x62A230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005398")]
			[Address(RVA = "0x9DEBD8", Offset = "0x9DEBD8", VA = "0x9DEBD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A240", Offset = "0x62A240")]
			private set
			{
			}
		}

		[Token(Token = "0x6005399")]
		[Address(RVA = "0x9DEBE4", Offset = "0x9DEBE4", VA = "0x9DEBE4", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x600539A")]
		[Address(RVA = "0x9DECC8", Offset = "0x9DECC8", VA = "0x9DECC8")]
		public LogoutFacebook()
		{
		}
	}
}
