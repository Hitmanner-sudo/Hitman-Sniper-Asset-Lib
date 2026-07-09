using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000AFB")]
	public class DynamicLoaderEvent : EventArgs
	{
		[Token(Token = "0x400382B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC390", Offset = "0x5BC390")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x400382C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC3A0", Offset = "0x5BC3A0")]
		private string _003CURL_003Ek__BackingField;

		[Token(Token = "0x400382D")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC3B0", Offset = "0x5BC3B0")]
		private UnityEngine.Object[] _003CObjects_003Ek__BackingField;

		[Token(Token = "0x1700089E")]
		public string ErrorMessage
		{
			[Token(Token = "0x600447C")]
			[Address(RVA = "0xC2297C", Offset = "0xC2297C", VA = "0xC2297C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260C8", Offset = "0x6260C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600447D")]
			[Address(RVA = "0xC22984", Offset = "0xC22984", VA = "0xC22984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260D8", Offset = "0x6260D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700089F")]
		public string URL
		{
			[Token(Token = "0x600447E")]
			[Address(RVA = "0xC2298C", Offset = "0xC2298C", VA = "0xC2298C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260E8", Offset = "0x6260E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600447F")]
			[Address(RVA = "0xC22994", Offset = "0xC22994", VA = "0xC22994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6260F8", Offset = "0x6260F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008A0")]
		public UnityEngine.Object[] Objects
		{
			[Token(Token = "0x6004480")]
			[Address(RVA = "0xC2299C", Offset = "0xC2299C", VA = "0xC2299C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626108", Offset = "0x626108")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004481")]
			[Address(RVA = "0xC229A4", Offset = "0xC229A4", VA = "0xC229A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626118", Offset = "0x626118")]
			private set
			{
			}
		}

		[Token(Token = "0x6004482")]
		[Address(RVA = "0xC225AC", Offset = "0xC225AC", VA = "0xC225AC")]
		public DynamicLoaderEvent(string url, string ErrorMessage, UnityEngine.Object[] objects)
		{
		}
	}
}
