using System;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B1F")]
	internal class OfflineShop : AbstractShop
	{
		[Serializable]
		[Token(Token = "0x2000B20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F80", Offset = "0x597F80")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40038BA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40038BB")]
			[FieldOffset(Offset = "0x8")]
			public static Func<OfferDescription, bool> _003C_003E9__5_0;

			[Token(Token = "0x60045B7")]
			[Address(RVA = "0x8CE470", Offset = "0x8CE470", VA = "0x8CE470")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60045B8")]
			[Address(RVA = "0x8CE478", Offset = "0x8CE478", VA = "0x8CE478")]
			internal bool _003CRefreshOffers_003Eb__5_0(OfferDescription description)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40038B9")]
		internal const string SHOP_ID = "OFFLINESHOP";

		[Token(Token = "0x170008B9")]
		internal override string Id
		{
			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x9F6474", Offset = "0x9F6474", VA = "0x9F6474", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BA")]
		internal override int RefreshOrderIndex
		{
			[Token(Token = "0x60045B2")]
			[Address(RVA = "0x9F64B8", Offset = "0x9F64B8", VA = "0x9F64B8", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x9F64C0", Offset = "0x9F64C0", VA = "0x9F64C0", Slot = "4")]
		protected override bool RefreshOffers()
		{
			return default(bool);
		}

		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x9F6638", Offset = "0x9F6638", VA = "0x9F6638", Slot = "5")]
		internal override void RestorePurchases()
		{
		}

		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x9F663C", Offset = "0x9F663C", VA = "0x9F663C")]
		public OfflineShop()
		{
		}
	}
}
