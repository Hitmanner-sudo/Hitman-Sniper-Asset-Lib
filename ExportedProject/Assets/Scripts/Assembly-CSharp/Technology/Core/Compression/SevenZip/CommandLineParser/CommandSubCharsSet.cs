using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D7B")]
	internal class CommandSubCharsSet
	{
		[Token(Token = "0x4004086")]
		[FieldOffset(Offset = "0x10")]
		public string Chars;

		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0x18")]
		public bool EmptyAllowed;

		[Token(Token = "0x600534E")]
		[Address(RVA = "0x8DBD64", Offset = "0x8DBD64", VA = "0x8DBD64")]
		public CommandSubCharsSet()
		{
		}
	}
}
