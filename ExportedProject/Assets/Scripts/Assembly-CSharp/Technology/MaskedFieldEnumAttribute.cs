using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB2")]
	public class MaskedFieldEnumAttribute : PropertyAttribute
	{
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x10")]
		public Type EnumToMask;

		[Token(Token = "0x6004300")]
		[Address(RVA = "0x9AFA64", Offset = "0x9AFA64", VA = "0x9AFA64")]
		public MaskedFieldEnumAttribute(Type enumToMask)
		{
		}
	}
}
