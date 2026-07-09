using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB5")]
	public class RegexAttribute : PropertyAttribute
	{
		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x10")]
		public readonly string pattern;

		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x18")]
		public readonly string helpMessage;

		[Token(Token = "0x6004303")]
		[Address(RVA = "0x9630BC", Offset = "0x9630BC", VA = "0x9630BC")]
		public RegexAttribute(string pattern, string helpMessage)
		{
		}
	}
}
