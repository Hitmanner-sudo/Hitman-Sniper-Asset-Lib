using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B18")]
	public class StoreKitProduct
	{
		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC5D8", Offset = "0x5BC5D8")]
		public string ProductIdentifier;

		[Token(Token = "0x400389B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC610", Offset = "0x5BC610")]
		public string Title;

		[Token(Token = "0x400389C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC648", Offset = "0x5BC648")]
		public string Description;

		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC680", Offset = "0x5BC680")]
		public string Price;

		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC6B8", Offset = "0x5BC6B8")]
		public string CurrencySymbol;

		[Token(Token = "0x400389F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC6F0", Offset = "0x5BC6F0")]
		public string CurrencyCode;

		[Token(Token = "0x40038A0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC728", Offset = "0x5BC728")]
		public string FormattedPrice;

		[Token(Token = "0x40038A1")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BC760", Offset = "0x5BC760")]
		public string CountryCode;

		[Token(Token = "0x6004573")]
		[Address(RVA = "0xD2D06C", Offset = "0xD2D06C", VA = "0xD2D06C")]
		public static List<StoreKitProduct> ProductsFromJson(string json)
		{
			return null;
		}

		[Token(Token = "0x6004574")]
		[Address(RVA = "0xD2D2D4", Offset = "0xD2D2D4", VA = "0xD2D2D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004575")]
		[Address(RVA = "0xD2D4CC", Offset = "0xD2D4CC", VA = "0xD2D4CC")]
		public StoreKitProduct()
		{
		}
	}
}
