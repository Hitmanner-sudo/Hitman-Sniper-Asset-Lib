using System;
using Il2CppDummyDll;
using Technology.Core.Auth;

namespace Technology.GooglePlayGames.Auth
{
	[Token(Token = "0x2000BAE")]
	internal sealed class LogoutGooglePlayGames : IAuthenticationState
	{
		[Token(Token = "0x1700095C")]
		public bool IsInProgress
		{
			[Token(Token = "0x6004A35")]
			[Address(RVA = "0x9DED78", Offset = "0x9DED78", VA = "0x9DED78", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x9DED80", Offset = "0x9DED80", VA = "0x9DED80", Slot = "5")]
		public void Handle(Action<object> resultAction, AuthenticationContext context)
		{
		}

		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x9DEE5C", Offset = "0x9DEE5C", VA = "0x9DEE5C")]
		public LogoutGooglePlayGames()
		{
		}
	}
}
