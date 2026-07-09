using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop
{
	[Token(Token = "0x2000B21")]
	internal class OnlineSuiteShop : AbstractShop
	{
		[Token(Token = "0x2000B22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597F90", Offset = "0x597F90")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40038C0")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetItemOffers svcop;

			[Token(Token = "0x40038C1")]
			[FieldOffset(Offset = "0x18")]
			public OnlineSuiteConfiguration osconfig;

			[Token(Token = "0x60045C2")]
			[Address(RVA = "0x8CE9AC", Offset = "0x8CE9AC", VA = "0x8CE9AC")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60045C3")]
			[Address(RVA = "0x8CE9B4", Offset = "0x8CE9B4", VA = "0x8CE9B4")]
			internal void _003CRefreshOffers_003Eb__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000B23")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597FA0", Offset = "0x597FA0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40038C2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40038C3")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, Item>, bool> _003C_003E9__10_0;

			[Token(Token = "0x60045C5")]
			[Address(RVA = "0x8CE94C", Offset = "0x8CE94C", VA = "0x8CE94C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60045C6")]
			[Address(RVA = "0x8CE954", Offset = "0x8CE954", VA = "0x8CE954")]
			internal bool _003CSetDebits_003Eb__10_0(KeyValuePair<string, Item> pair)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40038BC")]
		internal const string SHOP_ID = "ONLINESUITESHOP";

		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x78")]
		private readonly string _idKey;

		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x80")]
		private readonly string _ownerKey;

		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x88")]
		private readonly string _creditsKey;

		[Token(Token = "0x170008BB")]
		internal override string Id
		{
			[Token(Token = "0x60045B9")]
			[Address(RVA = "0x9FAD10", Offset = "0x9FAD10", VA = "0x9FAD10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BC")]
		internal override int RefreshOrderIndex
		{
			[Token(Token = "0x60045BB")]
			[Address(RVA = "0x9FB020", Offset = "0x9FB020", VA = "0x9FB020", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x9FAD54", Offset = "0x9FAD54", VA = "0x9FAD54")]
		public OnlineSuiteShop()
		{
		}

		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x9FB028", Offset = "0x9FB028", VA = "0x9FB028", Slot = "4")]
		protected override bool RefreshOffers()
		{
			return default(bool);
		}

		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x9FB0EC", Offset = "0x9FB0EC", VA = "0x9FB0EC")]
		private void SetDebits(JSONNode jsonNode, List<Debit> debits)
		{
		}

		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x9FB5E0", Offset = "0x9FB5E0", VA = "0x9FB5E0")]
		private List<Credit> SetCredits(Dictionary<string, Item> newstock, JSONArray jsonArray)
		{
			return null;
		}

		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x9FBD40", Offset = "0x9FBD40", VA = "0x9FBD40", Slot = "5")]
		internal override void RestorePurchases()
		{
		}

		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x9FBD44", Offset = "0x9FBD44", VA = "0x9FBD44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626628", Offset = "0x626628")]
		private void _003CRefreshOffers_003Eb__9_0(bool isAvailable)
		{
		}

		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x9FBFA8", Offset = "0x9FBFA8", VA = "0x9FBFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626638", Offset = "0x626638")]
		private void _003CRefreshOffers_003Eb__9_2(IResponseContext context, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> meta)
		{
		}
	}
}
