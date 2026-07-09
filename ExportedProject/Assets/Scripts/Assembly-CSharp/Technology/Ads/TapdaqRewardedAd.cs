using System;
using Il2CppDummyDll;
using Tapdaq;

namespace Technology.Ads
{
	[Token(Token = "0x2000E71")]
	public class TapdaqRewardedAd : Ad
	{
		[Token(Token = "0x40043F5")]
		[FieldOffset(Offset = "0x10")]
		private bool _isRewardValid;

		[Token(Token = "0x40043F6")]
		[FieldOffset(Offset = "0x14")]
		private float _lastVolume;

		[Token(Token = "0x17000BF5")]
		public override bool HasAdAvailable
		{
			[Token(Token = "0x60058DE")]
			[Address(RVA = "0xB524FC", Offset = "0xB524FC", VA = "0xB524FC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000184")]
		public override event Action OnAdOpened
		{
			[Token(Token = "0x60058DF")]
			[Address(RVA = "0xB52544", Offset = "0xB52544", VA = "0xB52544", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC28", Offset = "0x62BC28")]
			add
			{
			}
			[Token(Token = "0x60058E0")]
			[Address(RVA = "0xB525E4", Offset = "0xB525E4", VA = "0xB525E4", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC38", Offset = "0x62BC38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000185")]
		public override event Action<string> OnAdFailedToOpen
		{
			[Token(Token = "0x60058E1")]
			[Address(RVA = "0xB52684", Offset = "0xB52684", VA = "0xB52684", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC48", Offset = "0x62BC48")]
			add
			{
			}
			[Token(Token = "0x60058E2")]
			[Address(RVA = "0xB52724", Offset = "0xB52724", VA = "0xB52724", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC58", Offset = "0x62BC58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000186")]
		public override event Action<bool> OnAdClosed
		{
			[Token(Token = "0x60058E3")]
			[Address(RVA = "0xB527C4", Offset = "0xB527C4", VA = "0xB527C4", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC68", Offset = "0x62BC68")]
			add
			{
			}
			[Token(Token = "0x60058E4")]
			[Address(RVA = "0xB52864", Offset = "0xB52864", VA = "0xB52864", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC78", Offset = "0x62BC78")]
			remove
			{
			}
		}

		[Token(Token = "0x60058E5")]
		[Address(RVA = "0xB51954", Offset = "0xB51954", VA = "0xB51954")]
		public TapdaqRewardedAd()
		{
		}

		[Token(Token = "0x60058E6")]
		[Address(RVA = "0xB52904", Offset = "0xB52904", VA = "0xB52904", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60058E7")]
		[Address(RVA = "0xB52BB8", Offset = "0xB52BB8", VA = "0xB52BB8")]
		private void OnTapdaqAdDidDisplay(TDAdEvent tdaEvent)
		{
		}

		[Token(Token = "0x60058E8")]
		[Address(RVA = "0xB52CAC", Offset = "0xB52CAC", VA = "0xB52CAC")]
		private void OnTapdaqAdDidFailToDisplay(TDAdEvent tdaEvent)
		{
		}

		[Token(Token = "0x60058E9")]
		[Address(RVA = "0xB52DDC", Offset = "0xB52DDC", VA = "0xB52DDC")]
		private void OnRewardVideoValidated(TDVideoReward rewardEvent)
		{
		}

		[Token(Token = "0x60058EA")]
		[Address(RVA = "0xB52E94", Offset = "0xB52E94", VA = "0xB52E94")]
		private void OnTapDaqAdClosed(TDAdEvent closeAdEventArg)
		{
		}
	}
}
