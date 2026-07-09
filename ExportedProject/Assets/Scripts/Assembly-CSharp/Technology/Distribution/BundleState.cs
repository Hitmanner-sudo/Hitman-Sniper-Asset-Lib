using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BC9")]
	public enum BundleState
	{
		[Token(Token = "0x4003B2F")]
		Initialized = 0,
		[Token(Token = "0x4003B30")]
		LoadedFromCache = 1,
		[Token(Token = "0x4003B31")]
		LoadedFromRemote = 2,
		[Token(Token = "0x4003B32")]
		LoadedFromGame = 3,
		[Token(Token = "0x4003B33")]
		LoadingFromCache = 4,
		[Token(Token = "0x4003B34")]
		LoadingFromRemote = 5,
		[Token(Token = "0x4003B35")]
		LoadingIntoScene = 6,
		[Token(Token = "0x4003B36")]
		LoadedIntoScene = 7,
		[Token(Token = "0x4003B37")]
		Unloaded = 8,
		[Token(Token = "0x4003B38")]
		Error = 9
	}
}
