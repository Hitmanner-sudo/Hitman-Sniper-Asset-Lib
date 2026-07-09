using System;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200072F")]
public class PopupInsufficientFunds : PopupOverlayViewBase
{
	[Token(Token = "0x400289F")]
	private const string MISSING_CURRENCY_STRING_FORMAT = "[{0}]{1}[-]";

	[Token(Token = "0x40028A0")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private string _descriptionLocKey;

	[Token(Token = "0x40028A1")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private UIGrid _currencyItemUIGrid;

	[Token(Token = "0x40028A2")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject _currencyItemPrefab;

	[Token(Token = "0x40028A3")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject _watchAdItemPrefab;

	[Token(Token = "0x40028A4")]
	[FieldOffset(Offset = "0xE0")]
	private SniperAnalytics.InsufficientFundsSource _attemptedPurchaseType;

	[Token(Token = "0x40028A5")]
	[FieldOffset(Offset = "0xE8")]
	private string _attemptedPurchaseItem;

	[Token(Token = "0x40028A6")]
	[FieldOffset(Offset = "0xF0")]
	private int _missingCurrencyAmount;

	[Token(Token = "0x40028A7")]
	[FieldOffset(Offset = "0xF8")]
	private string _missingCurrencyType;

	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x100")]
	private string _suggestedPack;

	[Token(Token = "0x40028A9")]
	[FieldOffset(Offset = "0x108")]
	private CurrencyItemController _itemController;

	[Token(Token = "0x40028AA")]
	[FieldOffset(Offset = "0x110")]
	private InsufficientFundsWatchAdItemController _watchAdController;

	[Token(Token = "0x40028AB")]
	[FieldOffset(Offset = "0x118")]
	private Action _fundsPurchasedCallback;

	[Token(Token = "0x40028AC")]
	[FieldOffset(Offset = "0x120")]
	private Action _cancelCallback;

	[Token(Token = "0x40028AD")]
	[FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA03C", Offset = "0x5BA03C")]
	private bool _003CCanBeShown_003Ek__BackingField;

	[Token(Token = "0x1700062D")]
	public bool CanBeShown
	{
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x93307C", Offset = "0x93307C", VA = "0x93307C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621990", Offset = "0x621990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x933084", Offset = "0x933084", VA = "0x933084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6219A0", Offset = "0x6219A0")]
		private set
		{
		}
	}

	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x933090", Offset = "0x933090", VA = "0x933090")]
	public void SetupPopupOverlay(Wallet.CurrencyAmount desiredFunds, SniperAnalytics.InsufficientFundsSource purchaseType, string purchaseItem, Action cancelCallback, Action exitCallback, Action fundsPurchasedCallback)
	{
	}

	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x933D3C", Offset = "0x933D3C", VA = "0x933D3C")]
	public void InsufficientFundsPurchasedCallback()
	{
	}

	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x93364C", Offset = "0x93364C", VA = "0x93364C")]
	private CurrencyItemModel SelectBestCurrencyPack(int missingCurrencyAmount, Wallet.Currency currencyType)
	{
		return null;
	}

	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x933DA8", Offset = "0x933DA8", VA = "0x933DA8")]
	private bool IsBetterOffer(Offer firstOffer, Offer secondOffer, int missingCurrencyAmount, Wallet.Currency currencyType)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x933E18", Offset = "0x933E18", VA = "0x933E18")]
	private int GetCreditValue(Offer offer, Wallet.Currency currencyType)
	{
		return default(int);
	}

	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x933B8C", Offset = "0x933B8C", VA = "0x933B8C")]
	public void CreateCurrencyItem(CurrencyItemModel currencyItemModel, GameObject parent, GameObject prefab)
	{
	}

	[Token(Token = "0x6002FE8")]
	[Address(RVA = "0x933894", Offset = "0x933894", VA = "0x933894")]
	private static bool CanWatchAd(Wallet.CurrencyAmount missingCurrencyAmount)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FE9")]
	[Address(RVA = "0x933958", Offset = "0x933958", VA = "0x933958")]
	private void CreateWatchAdItem(Wallet.CurrencyAmount missingCurrencyAmount)
	{
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x933F94", Offset = "0x933F94", VA = "0x933F94")]
	private void OnPurchaseComplete(bool purchaseSucceeded)
	{
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x9340D4", Offset = "0x9340D4", VA = "0x9340D4")]
	private void OnAdClosed(bool success)
	{
	}

	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x9342E8", Offset = "0x9342E8", VA = "0x9342E8")]
	private void OnAdFailedToOpen(string error)
	{
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x9346B4", Offset = "0x9346B4", VA = "0x9346B4")]
	private void OnPopupCancel()
	{
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x9347A4", Offset = "0x9347A4", VA = "0x9347A4", Slot = "16")]
	protected override void PopupViewed(string choice)
	{
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x9349EC", Offset = "0x9349EC", VA = "0x9349EC")]
	public PopupInsufficientFunds()
	{
	}
}
