using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x200007E")]
	public class GoogleBuyIntentExtraParams
	{
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x10")]
		public List<string> skusToReplace;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x18")]
		public bool replaceSkusProration;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x20")]
		public string accountId;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x10E8CC0", Offset = "0x10E8CC0", VA = "0x10E8CC0")]
		public GoogleBuyIntentExtraParams()
		{
		}
	}
}
