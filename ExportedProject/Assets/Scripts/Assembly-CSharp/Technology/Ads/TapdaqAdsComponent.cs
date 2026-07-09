using Il2CppDummyDll;
using Technology.Core;

namespace Technology.Ads
{
	[Token(Token = "0x2000E6E")]
	public class TapdaqAdsComponent : IAdsComponent, IArmoryComponent
	{
		[Token(Token = "0x2000E6F")]
		public class RequestTapdaqParameters : RequestAdParameters
		{
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0xA54DCC", Offset = "0xA54DCC", VA = "0xA54DCC")]
			public RequestTapdaqParameters()
			{
			}
		}

		[Token(Token = "0x60058CE")]
		[Address(RVA = "0xB517EC", Offset = "0xB517EC", VA = "0xB517EC")]
		public TapdaqAdsComponent()
		{
		}

		[Token(Token = "0x60058CF")]
		[Address(RVA = "0xB51824", Offset = "0xB51824", VA = "0xB51824", Slot = "5")]
		public Ad RequestInterstitialAd(RequestAdParameters parameters)
		{
			return null;
		}

		[Token(Token = "0x60058D0")]
		[Address(RVA = "0xB518E8", Offset = "0xB518E8", VA = "0xB518E8", Slot = "4")]
		public Ad RequestRewardedVideoAd(RequestAdParameters parameters)
		{
			return null;
		}
	}
}
