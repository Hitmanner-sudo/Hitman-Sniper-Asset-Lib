using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B19")]
	public enum StoreKitTransactionState
	{
		[Token(Token = "0x40038A3")]
		Purchasing = 0,
		[Token(Token = "0x40038A4")]
		Purchased = 1,
		[Token(Token = "0x40038A5")]
		Failed = 2,
		[Token(Token = "0x40038A6")]
		Restored = 3,
		[Token(Token = "0x40038A7")]
		Deferred = 4
	}
}
