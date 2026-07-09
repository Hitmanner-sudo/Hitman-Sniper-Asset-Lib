using Il2CppDummyDll;
using Technology.Core;

namespace Technology.Ads
{
	[Token(Token = "0x2000E6A")]
	public interface IAdsComponent : IArmoryComponent
	{
		[Token(Token = "0x60058C8")]
		Ad RequestRewardedVideoAd(RequestAdParameters parameters);

		[Token(Token = "0x60058C9")]
		Ad RequestInterstitialAd(RequestAdParameters parameters);
	}
}
