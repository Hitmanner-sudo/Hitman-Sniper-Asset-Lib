using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009DE")]
	public enum ResponseStatus
	{
		[Token(Token = "0x400344D")]
		Success = 1,
		[Token(Token = "0x400344E")]
		SuccessWithStale = 2,
		[Token(Token = "0x400344F")]
		LicenseCheckFailed = -1,
		[Token(Token = "0x4003450")]
		InternalError = -2,
		[Token(Token = "0x4003451")]
		NotAuthorized = -3,
		[Token(Token = "0x4003452")]
		VersionUpdateRequired = -4,
		[Token(Token = "0x4003453")]
		Timeout = -5,
		[Token(Token = "0x4003454")]
		ResolutionRequired = -6
	}
}
