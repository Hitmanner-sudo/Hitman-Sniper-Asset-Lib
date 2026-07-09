using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000076")]
	public class TDAdEvent
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string adType;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tag;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TDAdError error;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x10F2068", Offset = "0x10F2068", VA = "0x10F2068")]
		public TDAdEvent()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x10F2070", Offset = "0x10F2070", VA = "0x10F2070")]
		public TDAdEvent(string adType, string message, [Optional] string tag)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x10F20B0", Offset = "0x10F20B0", VA = "0x10F20B0")]
		public TDAdType GetTypeOfEvent()
		{
			return default(TDAdType);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x10F21A0", Offset = "0x10F21A0", VA = "0x10F21A0")]
		public bool IsInterstitialEvent()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10F21BC", Offset = "0x10F21BC", VA = "0x10F21BC")]
		public bool IsVideoEvent()
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x10F21D8", Offset = "0x10F21D8", VA = "0x10F21D8")]
		public bool IsRewardedVideoEvent()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x10F21F4", Offset = "0x10F21F4", VA = "0x10F21F4")]
		public bool IsBannerEvent()
		{
			return default(bool);
		}
	}
}
