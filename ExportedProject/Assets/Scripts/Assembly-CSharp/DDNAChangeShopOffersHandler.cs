using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20007F7")]
public static class DDNAChangeShopOffersHandler
{
	[Serializable]
	[Token(Token = "0x20007F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965DC", Offset = "0x5965DC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, string[]> _003C_003E9__8_0;

		[Token(Token = "0x600342A")]
		[Address(RVA = "0x865B7C", Offset = "0x865B7C", VA = "0x865B7C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600342B")]
		[Address(RVA = "0x865B84", Offset = "0x865B84", VA = "0x865B84")]
		internal string[] _003CHandle_003Eb__8_0(string part)
		{
			return null;
		}
	}

	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CHANGE_SHOP_OFFERS_KEY;

	[Token(Token = "0x4002CA7")]
	private const string CHANGE_SHOP_OFFERS2_KEY = "changeShopOffers2";

	[Token(Token = "0x4002CA8")]
	private const string CHANGE_SHOP_OFFERS3_KEY = "changeShopOffers3";

	[Token(Token = "0x4002CA9")]
	private const string OFFER_CAMPAIGN_CONSIDERED_VALID_KEY = "offerCampaignConsideredValid";

	[Token(Token = "0x4002CAA")]
	private const string OFFER_DATE_TIME_LIMIT_KEY = "offerDateTimeLimit";

	[Token(Token = "0x4002CAB")]
	private const string OFFER_DURATION_KEY = "offerDuration";

	[Token(Token = "0x4002CAC")]
	private const string CAMPAIGN_ALL_VALID = "allValid";

	[Token(Token = "0x4002CAD")]
	private const string CAMPAIGN_ONE_VALID = "oneValid";

	[Token(Token = "0x6003426")]
	[Address(RVA = "0xBC2114", Offset = "0xBC2114", VA = "0xBC2114")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003427")]
	[Address(RVA = "0xBC31F4", Offset = "0xBC31F4", VA = "0xBC31F4")]
	private static Dictionary<string, int> GetMappedOffers(IEnumerable<string[]> offers)
	{
		return null;
	}
}
