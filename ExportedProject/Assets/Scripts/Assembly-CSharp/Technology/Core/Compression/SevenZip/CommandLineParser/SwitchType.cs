using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D76")]
	public enum SwitchType
	{
		[Token(Token = "0x400406F")]
		Simple = 0,
		[Token(Token = "0x4004070")]
		PostMinus = 1,
		[Token(Token = "0x4004071")]
		LimitedPostString = 2,
		[Token(Token = "0x4004072")]
		UnLimitedPostString = 3,
		[Token(Token = "0x4004073")]
		PostChar = 4
	}
}
