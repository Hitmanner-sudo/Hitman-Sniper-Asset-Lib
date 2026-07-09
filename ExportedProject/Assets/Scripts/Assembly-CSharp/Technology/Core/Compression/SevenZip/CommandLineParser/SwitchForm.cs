using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D77")]
	public class SwitchForm
	{
		[Token(Token = "0x4004074")]
		[FieldOffset(Offset = "0x10")]
		public string IDString;

		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x18")]
		public SwitchType Type;

		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x1C")]
		public bool Multi;

		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x20")]
		public int MinLen;

		[Token(Token = "0x4004078")]
		[FieldOffset(Offset = "0x24")]
		public int MaxLen;

		[Token(Token = "0x4004079")]
		[FieldOffset(Offset = "0x28")]
		public string PostCharSet;

		[Token(Token = "0x6005342")]
		[Address(RVA = "0xB49F3C", Offset = "0xB49F3C", VA = "0xB49F3C")]
		public SwitchForm(string idString, SwitchType type, bool multi, int minLen, int maxLen, string postCharSet)
		{
		}

		[Token(Token = "0x6005343")]
		[Address(RVA = "0xB49FA8", Offset = "0xB49FA8", VA = "0xB49FA8")]
		public SwitchForm(string idString, SwitchType type, bool multi, int minLen)
		{
		}

		[Token(Token = "0x6005344")]
		[Address(RVA = "0xB4A034", Offset = "0xB4A034", VA = "0xB4A034")]
		public SwitchForm(string idString, SwitchType type, bool multi)
		{
		}
	}
}
