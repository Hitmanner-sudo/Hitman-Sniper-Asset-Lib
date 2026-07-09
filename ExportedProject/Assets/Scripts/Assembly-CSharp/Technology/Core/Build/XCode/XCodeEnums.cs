using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Token(Token = "0x2000D7E")]
	public static class XCodeEnums
	{
		[Token(Token = "0x2000D7F")]
		public enum DebugSymbols
		{
			[Token(Token = "0x400408B")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE484", Offset = "0x5BE484")]
			DWARF = 0,
			[Token(Token = "0x400408C")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE4BC", Offset = "0x5BE4BC")]
			DWARF_WITH_DSYM = 1,
			[Token(Token = "0x400408D")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE4F4", Offset = "0x5BE4F4")]
			NONE = 2
		}

		[Token(Token = "0x2000D80")]
		public enum Team
		{
			[Token(Token = "0x400408F")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE52C", Offset = "0x5BE52C")]
			SQUARE_ENIX_LTD = 0,
			[Token(Token = "0x4004090")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE564", Offset = "0x5BE564")]
			EIDOS_INTERACTIVE_CORPORATION = 1
		}

		[Token(Token = "0x2000D81")]
		public enum Mode
		{
			[Token(Token = "0x4004092")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE59C", Offset = "0x5BE59C")]
			DEBUG = 0,
			[Token(Token = "0x4004093")]
			[Attribute(Name = "XCodeAttribute", RVA = "0x5BE5D4", Offset = "0x5BE5D4")]
			RELEASE = 1
		}
	}
}
