using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DE3")]
	public enum CoreInitializeOrder
	{
		[Token(Token = "0x4004200")]
		CRASHLOGGING = 110,
		[Token(Token = "0x4004201")]
		PERSISTENCE = 100,
		[Token(Token = "0x4004202")]
		ARMORY_NETWORK = 90,
		[Token(Token = "0x4004203")]
		ARMORY_AUTHENTICATION = 80,
		[Token(Token = "0x4004204")]
		ARMORY_ONLINESERVICES = 70,
		[Token(Token = "0x4004205")]
		ARMORY = 60,
		[Token(Token = "0x4004206")]
		ONLINE_PERSISTENCE = 50,
		[Token(Token = "0x4004207")]
		FIRST_PARTY = 40,
		[Token(Token = "0x4004208")]
		THIRD_PARTY = 30,
		[Token(Token = "0x4004209")]
		LOWEST = 0
	}
}
