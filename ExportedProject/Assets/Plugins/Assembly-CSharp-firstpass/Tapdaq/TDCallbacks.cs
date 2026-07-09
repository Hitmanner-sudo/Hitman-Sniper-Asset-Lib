using System;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Token(Token = "0x200006B")]
	public class TDCallbacks
	{
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		private static TDCallbacks reference;

		[Token(Token = "0x1700002C")]
		public static TDCallbacks instance
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x10F2210", Offset = "0x10F2210", VA = "0x10F2210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400001D")]
		public static event Action<TDAdEvent> AdAvailable
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x10F2294", Offset = "0x10F2294", VA = "0x10F2294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB08", Offset = "0x6FAB08")]
			add
			{
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x10F2354", Offset = "0x10F2354", VA = "0x10F2354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB18", Offset = "0x6FAB18")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public static event Action<TDAdEvent> AdNotAvailable
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x10F2414", Offset = "0x10F2414", VA = "0x10F2414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB28", Offset = "0x6FAB28")]
			add
			{
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x10F24D4", Offset = "0x10F24D4", VA = "0x10F24D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB38", Offset = "0x6FAB38")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public static event Action<TDAdEvent> AdRefresh
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x10F2594", Offset = "0x10F2594", VA = "0x10F2594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB48", Offset = "0x6FAB48")]
			add
			{
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x10F2654", Offset = "0x10F2654", VA = "0x10F2654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB58", Offset = "0x6FAB58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public static event Action<TDAdEvent> AdFailToRefresh
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x10F2714", Offset = "0x10F2714", VA = "0x10F2714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB68", Offset = "0x6FAB68")]
			add
			{
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x10F27D4", Offset = "0x10F27D4", VA = "0x10F27D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB78", Offset = "0x6FAB78")]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public static event Action<TDAdEvent> AdWillDisplay
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x10F2894", Offset = "0x10F2894", VA = "0x10F2894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB88", Offset = "0x6FAB88")]
			add
			{
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x10F2954", Offset = "0x10F2954", VA = "0x10F2954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAB98", Offset = "0x6FAB98")]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public static event Action<TDAdEvent> AdDidDisplay
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x10F2A14", Offset = "0x10F2A14", VA = "0x10F2A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABA8", Offset = "0x6FABA8")]
			add
			{
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x10F2AD4", Offset = "0x10F2AD4", VA = "0x10F2AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABB8", Offset = "0x6FABB8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public static event Action<TDAdEvent> AdDidFailToDisplay
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x10F2B94", Offset = "0x10F2B94", VA = "0x10F2B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABC8", Offset = "0x6FABC8")]
			add
			{
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x10F2C54", Offset = "0x10F2C54", VA = "0x10F2C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABD8", Offset = "0x6FABD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public static event Action<TDAdEvent> AdClicked
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x10F2D14", Offset = "0x10F2D14", VA = "0x10F2D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABE8", Offset = "0x6FABE8")]
			add
			{
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x10F2DD4", Offset = "0x10F2DD4", VA = "0x10F2DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FABF8", Offset = "0x6FABF8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public static event Action<TDAdEvent> AdClosed
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x10F2E94", Offset = "0x10F2E94", VA = "0x10F2E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC08", Offset = "0x6FAC08")]
			add
			{
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x10F2F54", Offset = "0x10F2F54", VA = "0x10F2F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC18", Offset = "0x6FAC18")]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public static event Action<TDAdEvent> AdError
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x10F3014", Offset = "0x10F3014", VA = "0x10F3014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC28", Offset = "0x6FAC28")]
			add
			{
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x10F30D4", Offset = "0x10F30D4", VA = "0x10F30D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC38", Offset = "0x6FAC38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000027")]
		public static event Action TapdaqConfigLoaded
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x10F3194", Offset = "0x10F3194", VA = "0x10F3194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC48", Offset = "0x6FAC48")]
			add
			{
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x10F3254", Offset = "0x10F3254", VA = "0x10F3254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC58", Offset = "0x6FAC58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public static event Action<TDAdError> TapdaqConfigFailedToLoad
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x10F3314", Offset = "0x10F3314", VA = "0x10F3314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC68", Offset = "0x6FAC68")]
			add
			{
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x10F33D4", Offset = "0x10F33D4", VA = "0x10F33D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC78", Offset = "0x6FAC78")]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public static event Action<TDVideoReward> RewardVideoValidated
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x10F3494", Offset = "0x10F3494", VA = "0x10F3494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC88", Offset = "0x6FAC88")]
			add
			{
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x10F3554", Offset = "0x10F3554", VA = "0x10F3554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAC98", Offset = "0x6FAC98")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6FB078", Offset = "0x6FB078")]
		public static event Action<TDAdEvent> AdStarted
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x10F3614", Offset = "0x10F3614", VA = "0x10F3614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACA8", Offset = "0x6FACA8")]
			add
			{
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x10F36D4", Offset = "0x10F36D4", VA = "0x10F36D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACB8", Offset = "0x6FACB8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6FB0B0", Offset = "0x6FB0B0")]
		public static event Action<TDAdEvent> AdFinished
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x10F3794", Offset = "0x10F3794", VA = "0x10F3794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACC8", Offset = "0x6FACC8")]
			add
			{
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x10F3854", Offset = "0x10F3854", VA = "0x10F3854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FACD8", Offset = "0x6FACD8")]
			remove
			{
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x10F228C", Offset = "0x10F228C", VA = "0x10F228C")]
		internal TDCallbacks()
		{
		}

		[Token(Token = "0x60002BC")]
		private static void Invoke<T>(Action<T> action, T value)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x10F3914", Offset = "0x10F3914", VA = "0x10F3914")]
		private static void Invoke(Action action)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x10F3924", Offset = "0x10F3924", VA = "0x10F3924")]
		public void OnAdAvailable(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x10F3990", Offset = "0x10F3990", VA = "0x10F3990")]
		public void OnAdRefresh(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x10F39FC", Offset = "0x10F39FC", VA = "0x10F39FC")]
		public void OnAdFailToRefresh(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x10F3A68", Offset = "0x10F3A68", VA = "0x10F3A68")]
		public void OnAdClicked(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x10F3AD4", Offset = "0x10F3AD4", VA = "0x10F3AD4")]
		public void OnAdError(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x10F3B40", Offset = "0x10F3B40", VA = "0x10F3B40")]
		public void OnAdClosed(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x10F3BAC", Offset = "0x10F3BAC", VA = "0x10F3BAC")]
		public void OnAdNotAvailable(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x10F3C18", Offset = "0x10F3C18", VA = "0x10F3C18")]
		public void OnAdDidDisplay(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x10F3C84", Offset = "0x10F3C84", VA = "0x10F3C84")]
		public void OnAdWillDisplay(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x10F3CF0", Offset = "0x10F3CF0", VA = "0x10F3CF0")]
		public void OnAdDidFailToDisplay(TDAdEvent adEvent)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x10F3D5C", Offset = "0x10F3D5C", VA = "0x10F3D5C")]
		public void OnTapdaqConfigLoaded()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x10F3DBC", Offset = "0x10F3DBC", VA = "0x10F3DBC")]
		public void OnTapdaqConfigFailedToLoad(TDAdError error)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x10F3E28", Offset = "0x10F3E28", VA = "0x10F3E28")]
		public void OnRewardedVideoValidated(TDVideoReward reward)
		{
		}
	}
}
