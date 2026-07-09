using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB6")]
	public class SortableListElementAttribute : PropertyAttribute
	{
		[Serializable]
		[Token(Token = "0x2000AB7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C54", Offset = "0x597C54")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40036F9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40036FA")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<GameObject> _003C_003E9__2_0;

			[Token(Token = "0x40036FB")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<int> _003C_003E9__2_1;

			[Token(Token = "0x40036FC")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<float> _003C_003E9__2_2;

			[Token(Token = "0x6004307")]
			[Address(RVA = "0xA4FC44", Offset = "0xA4FC44", VA = "0xA4FC44")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004308")]
			[Address(RVA = "0xA4FC4C", Offset = "0xA4FC4C", VA = "0xA4FC4C")]
			internal int _003CSortParentArray_003Eb__2_0(GameObject a, GameObject b)
			{
				return default(int);
			}

			[Token(Token = "0x6004309")]
			[Address(RVA = "0xA4FE00", Offset = "0xA4FE00", VA = "0xA4FE00")]
			internal int _003CSortParentArray_003Eb__2_1(int a, int b)
			{
				return default(int);
			}

			[Token(Token = "0x600430A")]
			[Address(RVA = "0xA4FE2C", Offset = "0xA4FE2C", VA = "0xA4FE2C")]
			internal int _003CSortParentArray_003Eb__2_2(float a, float b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x10")]
		private Type m_Type;

		[Token(Token = "0x6004304")]
		[Address(RVA = "0xA6CCF8", Offset = "0xA6CCF8", VA = "0xA6CCF8")]
		public SortableListElementAttribute(Type a_Type)
		{
		}

		[Token(Token = "0x6004305")]
		[Address(RVA = "0xA6CD24", Offset = "0xA6CD24", VA = "0xA6CD24")]
		public void SortParentArray(object a_ParentArray)
		{
		}
	}
}
