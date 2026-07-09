using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Serializable]
	[Token(Token = "0x2000E0F")]
	public class NamedObject : IComparable
	{
		[Token(Token = "0x4004266")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x600566A")]
		[Address(RVA = "0xC55E7C", Offset = "0xC55E7C", VA = "0xC55E7C")]
		public NamedObject()
		{
		}

		[Token(Token = "0x600566B")]
		[Address(RVA = "0xC55EF8", Offset = "0xC55EF8", VA = "0xC55EF8")]
		public NamedObject(string name)
		{
		}

		[Token(Token = "0x600566C")]
		[Address(RVA = "0xC55F68", Offset = "0xC55F68", VA = "0xC55F68", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x600566D")]
		public static bool Contains<T>(List<T> namedObjectList, string name) where T : NamedObject
		{
			return default(bool);
		}

		[Token(Token = "0x600566E")]
		public static int IndexOf<T>(List<T> namedObjectList, string name) where T : NamedObject
		{
			return default(int);
		}

		[Token(Token = "0x600566F")]
		public static string[] ToArray<T>(List<T> namedObjectList) where T : NamedObject
		{
			return null;
		}
	}
}
