using System;
using Il2CppDummyDll;
using Technology.Shop;

[Token(Token = "0x20004C8")]
public static class PromotedIAPManager
{
	[Token(Token = "0x20004C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594DB0", Offset = "0x594DB0")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x10")]
		public PopupManager pm;

		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x8B1CA0", Offset = "0x8B1CA0", VA = "0x8B1CA0")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x8B1CA8", Offset = "0x8B1CA8", VA = "0x8B1CA8")]
		internal void _003CShowAlreadyOwnedPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x0")]
	private static Offer _pendingPromotedIAP;

	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x8")]
	private static string _pendingPromotedId;

	[Token(Token = "0x6001D43")]
	[Address(RVA = "0xB39EE4", Offset = "0xB39EE4", VA = "0xB39EE4")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6001D44")]
	[Address(RVA = "0xB39EE8", Offset = "0xB39EE8", VA = "0xB39EE8")]
	public static void TryBuyPendingPromotedIAP()
	{
	}

	[Token(Token = "0x6001D45")]
	[Address(RVA = "0xB3A1D4", Offset = "0xB3A1D4", VA = "0xB3A1D4")]
	private static void OnPendingPromotedIAPChanged(object sender, PromotedIAPChangedArgs args)
	{
	}

	[Token(Token = "0x6001D46")]
	[Address(RVA = "0xB3A370", Offset = "0xB3A370", VA = "0xB3A370")]
	private static bool IsItemOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D47")]
	[Address(RVA = "0xB39F08", Offset = "0xB39F08", VA = "0xB39F08")]
	private static bool CanStartPurchase()
	{
		return default(bool);
	}

	[Token(Token = "0x6001D48")]
	[Address(RVA = "0xB3A104", Offset = "0xB3A104", VA = "0xB3A104")]
	private static void BuyPendingPromotedIAP()
	{
	}

	[Token(Token = "0x6001D49")]
	[Address(RVA = "0xB3A42C", Offset = "0xB3A42C", VA = "0xB3A42C")]
	private static void ShowAlreadyOwnedPopup()
	{
	}

	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0xB3A534", Offset = "0xB3A534", VA = "0xB3A534")]
	private static void TryRecacheOffer()
	{
	}

	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0xB3A608", Offset = "0xB3A608", VA = "0xB3A608")]
	private static void OnLoadingViewDisabled(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0xB3A628", Offset = "0xB3A628", VA = "0xB3A628")]
	private static void OnAllShopsRefreshedFirstTime(object sender, ShopEvent e)
	{
	}
}
