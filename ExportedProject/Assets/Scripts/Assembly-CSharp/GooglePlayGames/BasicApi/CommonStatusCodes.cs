using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009DC")]
	public enum CommonStatusCodes
	{
		[Token(Token = "0x4003431")]
		SuccessCached = -1,
		[Token(Token = "0x4003432")]
		Success = 0,
		[Token(Token = "0x4003433")]
		ServiceMissing = 1,
		[Token(Token = "0x4003434")]
		ServiceVersionUpdateRequired = 2,
		[Token(Token = "0x4003435")]
		ServiceDisabled = 3,
		[Token(Token = "0x4003436")]
		SignInRequired = 4,
		[Token(Token = "0x4003437")]
		InvalidAccount = 5,
		[Token(Token = "0x4003438")]
		ResolutionRequired = 6,
		[Token(Token = "0x4003439")]
		NetworkError = 7,
		[Token(Token = "0x400343A")]
		InternalError = 8,
		[Token(Token = "0x400343B")]
		ServiceInvalid = 9,
		[Token(Token = "0x400343C")]
		DeveloperError = 10,
		[Token(Token = "0x400343D")]
		LicenseCheckFailed = 11,
		[Token(Token = "0x400343E")]
		Error = 13,
		[Token(Token = "0x400343F")]
		Interrupted = 14,
		[Token(Token = "0x4003440")]
		Timeout = 15,
		[Token(Token = "0x4003441")]
		Canceled = 16,
		[Token(Token = "0x4003442")]
		ApiNotConnected = 17,
		[Token(Token = "0x4003443")]
		AuthApiInvalidCredentials = 3000,
		[Token(Token = "0x4003444")]
		AuthApiAccessForbidden = 3001,
		[Token(Token = "0x4003445")]
		AuthApiClientError = 3002,
		[Token(Token = "0x4003446")]
		AuthApiServerError = 3003,
		[Token(Token = "0x4003447")]
		AuthTokenError = 3004,
		[Token(Token = "0x4003448")]
		AuthUrlResolution = 3005
	}
}
