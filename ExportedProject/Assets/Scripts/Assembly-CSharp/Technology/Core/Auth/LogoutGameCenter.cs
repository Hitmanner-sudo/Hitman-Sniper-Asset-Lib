using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D94")]
	internal sealed class LogoutGameCenter : IAuthenticationState
	{
		[Token(Token = "0x17000AED")]
		public bool IsInProgress
		{
			[Token(Token = "0x600539B")]
			[Address(RVA = "0x9DECD0", Offset = "0x9DECD0", VA = "0x9DECD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600539C")]
		[Address(RVA = "0x9DECD8", Offset = "0x9DECD8", VA = "0x9DECD8", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x600539D")]
		[Address(RVA = "0x9DED70", Offset = "0x9DED70", VA = "0x9DED70")]
		public LogoutGameCenter()
		{
		}
	}
}
