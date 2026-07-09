using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000801")]
public class DDNAInactivityOfferHandler
{
	[Token(Token = "0x2000802")]
	private struct InactivityPromotionsOverrideEqualityComparer : IEqualityComparer<ShopCampaignManager.InactivityPromotionOverride>
	{
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x868AE0", Offset = "0x868AE0", VA = "0x868AE0", Slot = "4")]
		public bool Equals(ShopCampaignManager.InactivityPromotionOverride x, ShopCampaignManager.InactivityPromotionOverride y)
		{
			return default(bool);
		}

		[Token(Token = "0x600344D")]
		[Address(RVA = "0x868AF4", Offset = "0x868AF4", VA = "0x868AF4", Slot = "5")]
		public int GetHashCode(ShopCampaignManager.InactivityPromotionOverride obj)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4002CC5")]
	private const string INACTIVITY_PARAMETER = "inactivityOffers";

	[Token(Token = "0x6003449")]
	[Address(RVA = "0xBC8C68", Offset = "0xBC8C68", VA = "0xBC8C68")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x600344A")]
	[Address(RVA = "0xBD34E8", Offset = "0xBD34E8", VA = "0xBD34E8")]
	private static void Fail(string message, long transactionId)
	{
	}

	[Token(Token = "0x600344B")]
	[Address(RVA = "0xBD35B8", Offset = "0xBD35B8", VA = "0xBD35B8")]
	public DDNAInactivityOfferHandler()
	{
	}
}
