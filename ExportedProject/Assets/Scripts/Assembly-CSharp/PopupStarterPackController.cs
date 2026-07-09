using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200053A")]
public class PopupStarterPackController : UIController
{
	[Token(Token = "0x4001BB2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _buyButton;

	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OfferReference _offer;

	[Token(Token = "0x4001BB4")]
	[FieldOffset(Offset = "0x60")]
	private int[] _initialCreditQuantities;

	[Token(Token = "0x600208D")]
	[Address(RVA = "0x93B6D4", Offset = "0x93B6D4", VA = "0x93B6D4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0x93B7C8", Offset = "0x93B7C8", VA = "0x93B7C8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600208F")]
	[Address(RVA = "0x93B8C0", Offset = "0x93B8C0", VA = "0x93B8C0")]
	private void OnBuyButtonPressed(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002090")]
	[Address(RVA = "0x93BB28", Offset = "0x93BB28", VA = "0x93BB28")]
	private void RegisterShopEvents()
	{
	}

	[Token(Token = "0x6002091")]
	[Address(RVA = "0x93BCD4", Offset = "0x93BCD4", VA = "0x93BCD4")]
	private void UnregisterShopEvents()
	{
	}

	[Token(Token = "0x6002092")]
	[Address(RVA = "0x93BE78", Offset = "0x93BE78", VA = "0x93BE78")]
	private void OnPurchaseSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002093")]
	[Address(RVA = "0x93C170", Offset = "0x93C170", VA = "0x93C170")]
	private void OnPurchaseCompleted(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x93C2CC", Offset = "0x93C2CC", VA = "0x93C2CC")]
	private static void OnPurchaseSucceeded(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x93C3A4", Offset = "0x93C3A4", VA = "0x93C3A4")]
	private static void OnPurchaseFailed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x93C468", Offset = "0x93C468", VA = "0x93C468")]
	public PopupStarterPackController()
	{
	}
}
