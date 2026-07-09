using System;
using Il2CppDummyDll;

namespace Technology.Social
{
	[Token(Token = "0x2000ADE")]
	[Flags]
	public enum NfService
	{
		[Token(Token = "0x4003798")]
		INGAMEPURCHASE = 1,
		[Token(Token = "0x4003799")]
		ACHIEVEMENTS = 4,
		[Token(Token = "0x400379A")]
		LEADERBOARDS = 8,
		[Token(Token = "0x400379B")]
		SOCIAL_SERVICE = 0x10,
		[Token(Token = "0x400379C")]
		FIRSTPARTY_ACCOUNT = 0x20,
		[Token(Token = "0x400379D")]
		CLOUD_STORAGE = 0x40,
		[Token(Token = "0x400379E")]
		NOTIFICATIONS = 0x80
	}
}
