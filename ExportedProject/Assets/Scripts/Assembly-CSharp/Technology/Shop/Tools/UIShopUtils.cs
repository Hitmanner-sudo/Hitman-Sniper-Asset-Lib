using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B53")]
	public class UIShopUtils
	{
		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int FIELD_WIDTH;

		[Token(Token = "0x40039BB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SPACING_WIDTH;

		[Token(Token = "0x40039BC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int SPACING_HEIGHT;

		[Token(Token = "0x40039BD")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int SPACING_OFFSET;

		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x1430308", Offset = "0x1430308", VA = "0x1430308")]
		public static void DateLabel(Rect pos, DateTime date)
		{
		}

		[Token(Token = "0x60047B2")]
		[Address(RVA = "0x1430A7C", Offset = "0x1430A7C", VA = "0x1430A7C")]
		public static DateTime DateField(Rect pos, DateTime date)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60047B3")]
		[Address(RVA = "0x14312C8", Offset = "0x14312C8", VA = "0x14312C8")]
		public UIShopUtils()
		{
		}
	}
}
