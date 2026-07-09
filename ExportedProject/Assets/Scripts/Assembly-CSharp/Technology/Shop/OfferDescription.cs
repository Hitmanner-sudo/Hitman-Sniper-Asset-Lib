using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Shop
{
	[Token(Token = "0x2000B2A")]
	public class OfferDescription : ScriptableObject
	{
		[Token(Token = "0x40038EA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BC958", Offset = "0x5BC958")]
		public string Id;

		[Token(Token = "0x40038EB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BC990", Offset = "0x5BC990")]
		public PlatformID RestorePurchaseId;

		[Token(Token = "0x40038EC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BC9C8", Offset = "0x5BC9C8")]
		public OfferID[] OfferIds;

		[Token(Token = "0x40038ED")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCA00", Offset = "0x5BCA00")]
		public string Name;

		[Token(Token = "0x40038EE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCA38", Offset = "0x5BCA38")]
		public string Description;

		[Token(Token = "0x40038EF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCA70", Offset = "0x5BCA70")]
		public List<Debit> Debits;

		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCAA8", Offset = "0x5BCAA8")]
		public List<Credit> Credits;

		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCAE0", Offset = "0x5BCAE0")]
		public bool IsRegisteredWithFirstParty;

		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCB18", Offset = "0x5BCB18")]
		public string UIContentURI;

		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BCB50", Offset = "0x5BCB50")]
		public string SortingCategory;

		[Token(Token = "0x600462C")]
		[Address(RVA = "0x9F55F0", Offset = "0x9F55F0", VA = "0x9F55F0")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x600462D")]
		[Address(RVA = "0x9F57BC", Offset = "0x9F57BC", VA = "0x9F57BC")]
		public OfferDescription()
		{
		}
	}
}
