using System;
using Il2CppDummyDll;
using Tapdaq;

namespace Technology.Ads
{
	[Token(Token = "0x2000E70")]
	internal class TapdaqInterstitialAd : Ad
	{
		[Token(Token = "0x17000BF4")]
		public override bool HasAdAvailable
		{
			[Token(Token = "0x60058D8")]
			[Address(RVA = "0xB51F94", Offset = "0xB51F94", VA = "0xB51F94", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000181")]
		public override event Action OnAdOpened
		{
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0xB51BD4", Offset = "0xB51BD4", VA = "0xB51BD4", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BBC8", Offset = "0x62BBC8")]
			add
			{
			}
			[Token(Token = "0x60058D3")]
			[Address(RVA = "0xB51C74", Offset = "0xB51C74", VA = "0xB51C74", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BBD8", Offset = "0x62BBD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000182")]
		public override event Action<string> OnAdFailedToOpen
		{
			[Token(Token = "0x60058D4")]
			[Address(RVA = "0xB51D14", Offset = "0xB51D14", VA = "0xB51D14", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BBE8", Offset = "0x62BBE8")]
			add
			{
			}
			[Token(Token = "0x60058D5")]
			[Address(RVA = "0xB51DB4", Offset = "0xB51DB4", VA = "0xB51DB4", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BBF8", Offset = "0x62BBF8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000183")]
		public override event Action<bool> OnAdClosed
		{
			[Token(Token = "0x60058D6")]
			[Address(RVA = "0xB51E54", Offset = "0xB51E54", VA = "0xB51E54", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC08", Offset = "0x62BC08")]
			add
			{
			}
			[Token(Token = "0x60058D7")]
			[Address(RVA = "0xB51EF4", Offset = "0xB51EF4", VA = "0xB51EF4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BC18", Offset = "0x62BC18")]
			remove
			{
			}
		}

		[Token(Token = "0x60058D9")]
		[Address(RVA = "0xB51890", Offset = "0xB51890", VA = "0xB51890")]
		public TapdaqInterstitialAd()
		{
		}

		[Token(Token = "0x60058DA")]
		[Address(RVA = "0xB51FDC", Offset = "0xB51FDC", VA = "0xB51FDC", Slot = "11")]
		public override void Show()
		{
		}

		[Token(Token = "0x60058DB")]
		[Address(RVA = "0xB521E4", Offset = "0xB521E4", VA = "0xB521E4")]
		private void OnTapdaqAdDidDisplay(TDAdEvent tdaEvent)
		{
		}

		[Token(Token = "0x60058DC")]
		[Address(RVA = "0xB522D8", Offset = "0xB522D8", VA = "0xB522D8")]
		private void OnTapdaqAdDidFailToDisplay(TDAdEvent tdaEvent)
		{
		}

		[Token(Token = "0x60058DD")]
		[Address(RVA = "0xB52438", Offset = "0xB52438", VA = "0xB52438")]
		private void OnTapdaqAdClosed(TDAdEvent tdaEvent)
		{
		}
	}
}
