using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B08")]
	public class MetaOffer : Offer
	{
		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0xC0")]
		private readonly Offer[] _offerAlternates;

		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0xC8")]
		private int _offerID;

		[Token(Token = "0x170008A9")]
		public Offer[] OfferAlternates
		{
			[Token(Token = "0x60044E5")]
			[Address(RVA = "0x9C16A8", Offset = "0x9C16A8", VA = "0x9C16A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AA")]
		public Offer Offer
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x9C16B0", Offset = "0x9C16B0", VA = "0x9C16B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x9C16F0", Offset = "0x9C16F0", VA = "0x9C16F0")]
		public MetaOffer(OfferDescription desc, string shopOwnerId, OfferState state)
		{
		}

		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x9C18CC", Offset = "0x9C18CC", VA = "0x9C18CC")]
		public int GetIdx()
		{
			return default(int);
		}

		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x9C18D4", Offset = "0x9C18D4", VA = "0x9C18D4")]
		public void ChangeID(int id, long endDate)
		{
		}
	}
}
