using System;
using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Serializable]
	[Token(Token = "0x2000D83")]
	public class XCodeKeyValue
	{
		[Token(Token = "0x4004095")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x4004096")]
		[FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x600535A")]
		[Address(RVA = "0x8805F4", Offset = "0x8805F4", VA = "0x8805F4")]
		public XCodeKeyValue()
		{
		}
	}
}
