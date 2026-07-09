using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D8F")]
	public interface IAuthenticationState
	{
		[Token(Token = "0x17000AE9")]
		bool IsInProgress
		{
			[Token(Token = "0x6005385")]
			get;
		}

		[Token(Token = "0x6005386")]
		void Handle(Action<object> resultAction, AuthenticationContext context);
	}
}
