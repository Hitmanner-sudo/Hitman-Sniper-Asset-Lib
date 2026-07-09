using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D7A")]
	public class CommandForm
	{
		[Token(Token = "0x4004084")]
		[FieldOffset(Offset = "0x10")]
		public string IDString;

		[Token(Token = "0x4004085")]
		[FieldOffset(Offset = "0x18")]
		public bool PostStringMode;

		[Token(Token = "0x600534D")]
		[Address(RVA = "0x8DBCF0", Offset = "0x8DBCF0", VA = "0x8DBCF0")]
		public CommandForm(string idString, bool postStringMode)
		{
		}
	}
}
