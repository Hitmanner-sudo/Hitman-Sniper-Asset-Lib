using Il2CppDummyDll;
using Technology.Core.Common;

namespace Technology.Ads
{
	[Token(Token = "0x2000E68")]
	[RegisterForInitialize]
	public static class ArmoryAds
	{
		[Token(Token = "0x40043F0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AdsController _controller;

		[Token(Token = "0x60058C4")]
		[Address(RVA = "0xD4E708", Offset = "0xD4E708", VA = "0xD4E708")]
		static ArmoryAds()
		{
		}

		[Token(Token = "0x60058C5")]
		[Address(RVA = "0xD4E7D0", Offset = "0xD4E7D0", VA = "0xD4E7D0")]
		public static Ad RequestRewardedVideoAd(RequestAdParameters parameters)
		{
			return null;
		}

		[Token(Token = "0x60058C6")]
		[Address(RVA = "0xD4E848", Offset = "0xD4E848", VA = "0xD4E848")]
		public static Ad RequestInterstitialAd(RequestAdParameters parameters)
		{
			return null;
		}
	}
}
