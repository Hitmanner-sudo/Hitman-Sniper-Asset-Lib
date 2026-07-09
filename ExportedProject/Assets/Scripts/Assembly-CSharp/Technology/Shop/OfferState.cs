using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B24")]
	[Flags]
	public enum OfferState
	{
		[Token(Token = "0x40038C5")]
		Preparing = 0,
		[Token(Token = "0x40038C6")]
		Ready = 1,
		[Token(Token = "0x40038C7")]
		FailedToInitialize = 2,
		[Token(Token = "0x40038C8")]
		UILoaded = 4,
		[Token(Token = "0x40038C9")]
		Diposed = 5
	}
}
