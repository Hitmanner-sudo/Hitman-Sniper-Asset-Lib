using System;
using Il2CppDummyDll;

namespace Technology.Core.Build.XCode
{
	[Token(Token = "0x2000D82")]
	public class XCodeAttribute : Attribute
	{
		[Token(Token = "0x4004094")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x6005358")]
		[Address(RVA = "0x880478", Offset = "0x880478", VA = "0x880478")]
		public XCodeAttribute(string key)
		{
		}

		[Token(Token = "0x6005359")]
		[Address(RVA = "0x8804A4", Offset = "0x8804A4", VA = "0x8804A4")]
		public static XCodeAttribute GetAttribute(object obj)
		{
			return null;
		}
	}
}
