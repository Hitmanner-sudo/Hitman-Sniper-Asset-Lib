using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C07")]
	public interface ICrossPromotionConfig
	{
		[Token(Token = "0x6004C08")]
		string GetUserId();

		[Token(Token = "0x6004C09")]
		string GetGameId();
	}
}
