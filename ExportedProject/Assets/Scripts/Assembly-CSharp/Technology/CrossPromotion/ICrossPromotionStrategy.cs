using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C08")]
	public interface ICrossPromotionStrategy
	{
		[Token(Token = "0x6004C0A")]
		CrossPromotionRecord GetNewRecord(CrossPromotionInputInformation inputInformation);
	}
}
