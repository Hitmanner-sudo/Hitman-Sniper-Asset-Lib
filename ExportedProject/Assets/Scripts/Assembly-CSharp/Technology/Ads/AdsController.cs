using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core;

namespace Technology.Ads
{
	[Token(Token = "0x2000E67")]
	public class AdsController : IAdsProvider, IComponentProvider<IAdsComponent>, IArmoryProvider
	{
		[Token(Token = "0x40043EE")]
		[FieldOffset(Offset = "0x10")]
		private IAdsComponent _activeComponent;

		[Token(Token = "0x40043EF")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, IAdsComponent> _components;

		[Token(Token = "0x60058BD")]
		[Address(RVA = "0xD5DAF8", Offset = "0xD5DAF8", VA = "0xD5DAF8", Slot = "4")]
		public void Register(IAdsComponent component)
		{
		}

		[Token(Token = "0x60058BE")]
		[Address(RVA = "0xD5DBB4", Offset = "0xD5DBB4", VA = "0xD5DBB4", Slot = "5")]
		public bool Contains(IAdsComponent component)
		{
			return default(bool);
		}

		[Token(Token = "0x60058BF")]
		[Address(RVA = "0xD5DC2C", Offset = "0xD5DC2C", VA = "0xD5DC2C", Slot = "6")]
		public void SetActive(IAdsComponent component)
		{
		}

		[Token(Token = "0x60058C0")]
		[Address(RVA = "0xD5DC64", Offset = "0xD5DC64", VA = "0xD5DC64")]
		private void SetActive(Type type)
		{
		}

		[Token(Token = "0x60058C1")]
		[Address(RVA = "0xD5DCE0", Offset = "0xD5DCE0", VA = "0xD5DCE0")]
		public Ad RequestRewardedVideoAd(RequestAdParameters parameters)
		{
			return null;
		}

		[Token(Token = "0x60058C2")]
		[Address(RVA = "0xD5DDAC", Offset = "0xD5DDAC", VA = "0xD5DDAC")]
		public Ad RequestInterstitialAd(RequestAdParameters parameters)
		{
			return null;
		}

		[Token(Token = "0x60058C3")]
		[Address(RVA = "0xD5DE7C", Offset = "0xD5DE7C", VA = "0xD5DE7C")]
		public AdsController()
		{
		}
	}
}
