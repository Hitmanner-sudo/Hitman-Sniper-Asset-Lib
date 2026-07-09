using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B25")]
	public class OfferEvent : EventArgs
	{
		[Token(Token = "0x40038CA")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7E8", Offset = "0x5BC7E8")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BC7F8", Offset = "0x5BC7F8")]
		private Offer _003COffer_003Ek__BackingField;

		[Token(Token = "0x170008BD")]
		public string ErrorMessage
		{
			[Token(Token = "0x60045C7")]
			[Address(RVA = "0x9F5874", Offset = "0x9F5874", VA = "0x9F5874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626648", Offset = "0x626648")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045C8")]
			[Address(RVA = "0x9F587C", Offset = "0x9F587C", VA = "0x9F587C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626658", Offset = "0x626658")]
			private set
			{
			}
		}

		[Token(Token = "0x170008BE")]
		public Offer Offer
		{
			[Token(Token = "0x60045C9")]
			[Address(RVA = "0x9F5884", Offset = "0x9F5884", VA = "0x9F5884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626668", Offset = "0x626668")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045CA")]
			[Address(RVA = "0x9F588C", Offset = "0x9F588C", VA = "0x9F588C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626678", Offset = "0x626678")]
			private set
			{
			}
		}

		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x9F0A08", Offset = "0x9F0A08", VA = "0x9F0A08")]
		public OfferEvent(string errorMessage)
		{
		}

		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x9F2590", Offset = "0x9F2590", VA = "0x9F2590")]
		public OfferEvent(string errorMessage, Offer offer)
		{
		}
	}
}
