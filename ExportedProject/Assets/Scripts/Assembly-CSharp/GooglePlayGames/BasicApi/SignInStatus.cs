using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009F6")]
	public enum SignInStatus
	{
		[Token(Token = "0x40034C2")]
		Success = 0,
		[Token(Token = "0x40034C3")]
		UiSignInRequired = 1,
		[Token(Token = "0x40034C4")]
		DeveloperError = 2,
		[Token(Token = "0x40034C5")]
		NetworkError = 3,
		[Token(Token = "0x40034C6")]
		InternalError = 4,
		[Token(Token = "0x40034C7")]
		Canceled = 5,
		[Token(Token = "0x40034C8")]
		AlreadyInProgress = 6,
		[Token(Token = "0x40034C9")]
		Failed = 7,
		[Token(Token = "0x40034CA")]
		NotAuthenticated = 8
	}
}
