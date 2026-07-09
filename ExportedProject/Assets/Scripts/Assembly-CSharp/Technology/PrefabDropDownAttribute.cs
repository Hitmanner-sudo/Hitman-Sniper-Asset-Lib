using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB4")]
	public class PrefabDropDownAttribute : PropertyAttribute
	{
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x10")]
		public string PrefabFolder;

		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x18")]
		public Type ComponentType;

		[Token(Token = "0x6004302")]
		[Address(RVA = "0xB38644", Offset = "0xB38644", VA = "0xB38644")]
		public PrefabDropDownAttribute(Type componentType, string fromFolder = "/")
		{
		}
	}
}
