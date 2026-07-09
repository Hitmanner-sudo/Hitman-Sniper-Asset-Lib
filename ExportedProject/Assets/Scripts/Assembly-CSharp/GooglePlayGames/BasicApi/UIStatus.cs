using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009DF")]
	public enum UIStatus
	{
		[Token(Token = "0x4003456")]
		Valid = 1,
		[Token(Token = "0x4003457")]
		InternalError = -2,
		[Token(Token = "0x4003458")]
		NotAuthorized = -3,
		[Token(Token = "0x4003459")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x400345A")]
		Timeout = -5,
		[Token(Token = "0x400345B")]
		UserClosedUI = -6,
		[Token(Token = "0x400345C")]
		UiBusy = -12,
		[Token(Token = "0x400345D")]
		NetworkError = -20
	}
}
