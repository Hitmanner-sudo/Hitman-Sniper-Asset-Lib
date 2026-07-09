using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B4F")]
	public class ToolsData
	{
		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x10")]
		private ShopConfiguration _shopConfiguration;

		[Token(Token = "0x40039A5")]
		[FieldOffset(Offset = "0x18")]
		private bool _initialized;

		[Token(Token = "0x1700091B")]
		public List<Item> Items
		{
			[Token(Token = "0x60047A1")]
			[Address(RVA = "0xAD5010", Offset = "0xAD5010", VA = "0xAD5010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091C")]
		public List<OfferDescription> Offers
		{
			[Token(Token = "0x60047A2")]
			[Address(RVA = "0xAD5030", Offset = "0xAD5030", VA = "0xAD5030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091D")]
		public List<string> BundleURLList
		{
			[Token(Token = "0x60047A3")]
			[Address(RVA = "0xAD5050", Offset = "0xAD5050", VA = "0xAD5050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60047A0")]
		[Address(RVA = "0xAD4F64", Offset = "0xAD4F64", VA = "0xAD4F64")]
		private ShopConfiguration GetShopConfiguration()
		{
			return null;
		}

		[Token(Token = "0x60047A4")]
		[Address(RVA = "0xAD53D4", Offset = "0xAD53D4", VA = "0xAD53D4")]
		public ToolsData()
		{
		}
	}
}
