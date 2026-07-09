using System.Collections;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D78")]
	public class SwitchResult
	{
		[Token(Token = "0x400407A")]
		[FieldOffset(Offset = "0x10")]
		public bool ThereIs;

		[Token(Token = "0x400407B")]
		[FieldOffset(Offset = "0x11")]
		public bool WithMinus;

		[Token(Token = "0x400407C")]
		[FieldOffset(Offset = "0x18")]
		public ArrayList PostStrings;

		[Token(Token = "0x400407D")]
		[FieldOffset(Offset = "0x20")]
		public int PostCharIndex;

		[Token(Token = "0x6005345")]
		[Address(RVA = "0xB4A040", Offset = "0xB4A040", VA = "0xB4A040")]
		public SwitchResult()
		{
		}
	}
}
