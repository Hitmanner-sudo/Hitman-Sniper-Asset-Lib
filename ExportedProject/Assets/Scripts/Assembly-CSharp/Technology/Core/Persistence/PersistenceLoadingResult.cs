using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D44")]
	public enum PersistenceLoadingResult
	{
		[Token(Token = "0x4003F42")]
		Success = 0,
		[Token(Token = "0x4003F43")]
		SuccessNoChange = 1,
		[Token(Token = "0x4003F44")]
		ConnectionFailure = 2,
		[Token(Token = "0x4003F45")]
		DataError = 3
	}
}
