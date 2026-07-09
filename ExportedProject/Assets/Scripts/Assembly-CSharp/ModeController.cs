using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000553")]
public class ModeController : UIController
{
	[Token(Token = "0x2000554")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595234", Offset = "0x595234")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x4001C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModeController _003C_003E4__this;

		[Token(Token = "0x4001C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BlockingOnlineRequestManager blockingOnlineRequestManager;

		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x8C83A8", Offset = "0x8C83A8", VA = "0x8C83A8")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x8C83B0", Offset = "0x8C83B0", VA = "0x8C83B0")]
		internal void _003COnApplicationPause_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000555")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595244", Offset = "0x595244")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Offer, bool> _003C_003E9__22_0;

		[Token(Token = "0x4001C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__56_2;

		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x8C8280", Offset = "0x8C8280", VA = "0x8C8280")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x8C8288", Offset = "0x8C8288", VA = "0x8C8288")]
		internal bool _003COnApplicationPause_003Eb__22_0(Offer r)
		{
			return default(bool);
		}

		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x8C8328", Offset = "0x8C8328", VA = "0x8C8328")]
		internal void _003CCheckForQualityPopup_003Eb__56_2()
		{
		}
	}

	[Token(Token = "0x2000556")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595254", Offset = "0x595254")]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		[Token(Token = "0x4001C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selectedQuality;

		[Token(Token = "0x4001C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action exitApp;

		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x8C84B8", Offset = "0x8C84B8", VA = "0x8C84B8")]
		public _003C_003Ec__DisplayClass56_0()
		{
		}

		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x8C84C0", Offset = "0x8C84C0", VA = "0x8C84C0")]
		internal void _003CCheckForQualityPopup_003Eb__0()
		{
		}

		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x8C85E0", Offset = "0x8C85E0", VA = "0x8C85E0")]
		internal void _003CCheckForQualityPopup_003Eb__1()
		{
		}
	}

	[Token(Token = "0x4001C40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler EnterOptionsButton;

	[Token(Token = "0x4001C41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler AddGoldButton;

	[Token(Token = "0x4001C42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler AddTokensButton;

	[Token(Token = "0x4001C43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ButtonHandler StarterPackButton;

	[Token(Token = "0x4001C44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonHandler JustCausePopupButton;

	[Token(Token = "0x4001C45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public BlinkButtonHandler AchievementsButton;

	[Token(Token = "0x4001C46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UIAlignedList TopNavBarLeftUIAlignedList;

	[Token(Token = "0x4001C47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UIAlignedList TopNavBarRightUIAlignedList;

	[Token(Token = "0x4001C48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public PopupAddCurrencies AddCurrenciesPopupPrefab;

	[Token(Token = "0x4001C49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public PopupStarterPackView StarterPackPopupPrefab;

	[Token(Token = "0x4001C4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public PopupInsufficientFunds InsufficientFundsPopupPrefab;

	[Token(Token = "0x4001C4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public PopupJustCauseRifle JustCauseRiflePopupPrefab;

	[Token(Token = "0x4001C4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private OfferReference _starterPackOffer;

	[Token(Token = "0x4001C4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private OfferReference _justCauseRifleOffer;

	[Token(Token = "0x4001C4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool _doingCloudReconcile;

	[Token(Token = "0x4001C4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	private bool _destroyed;

	[Token(Token = "0x4001C50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private BlockingOnlineRequestManager.ReqHandle _onlineReqHandle;

	[Token(Token = "0x600218C")]
	[Address(RVA = "0xA1EE50", Offset = "0xA1EE50", VA = "0xA1EE50", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600218D")]
	[Address(RVA = "0xA1EF5C", Offset = "0xA1EF5C", VA = "0xA1EF5C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600218E")]
	[Address(RVA = "0xA1EFD8", Offset = "0xA1EFD8", VA = "0xA1EFD8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0xA1FB0C", Offset = "0xA1FB0C", VA = "0xA1FB0C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0xA204F8", Offset = "0xA204F8", VA = "0xA204F8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0xA20524", Offset = "0xA20524", VA = "0xA20524")]
	protected void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6002192")]
	[Address(RVA = "0xA207F4", Offset = "0xA207F4", VA = "0xA207F4", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002193")]
	[Address(RVA = "0xA20ADC", Offset = "0xA20ADC", VA = "0xA20ADC")]
	private void StartShopRefresh(BlockingOnlineRequestManager.ReqHandle handle)
	{
	}

	[Token(Token = "0x6002194")]
	[Address(RVA = "0xA20BC8", Offset = "0xA20BC8", VA = "0xA20BC8")]
	private void CancelShopRefresh(BlockingOnlineRequestManager.ReqHandle handle)
	{
	}

	[Token(Token = "0x6002195")]
	[Address(RVA = "0xA20C5C", Offset = "0xA20C5C", VA = "0xA20C5C")]
	private void OnShopReloadRefresh(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002196")]
	[Address(RVA = "0xA20DA8", Offset = "0xA20DA8", VA = "0xA20DA8")]
	private static bool IsNotProgressionLootBox(LootBox lootbox)
	{
		return default(bool);
	}

	[Token(Token = "0x6002197")]
	[Address(RVA = "0xA2081C", Offset = "0xA2081C", VA = "0xA2081C")]
	private void HandleAndroidHardwareButtons()
	{
	}

	[Token(Token = "0x6002198")]
	[Address(RVA = "0xA20FBC", Offset = "0xA20FBC", VA = "0xA20FBC")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0xA20FB8", Offset = "0xA20FB8", VA = "0xA20FB8")]
	private void OnEnterOptionsBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0xA210AC", Offset = "0xA210AC", VA = "0xA210AC")]
	private void OpenOptionsPopup()
	{
	}

	[Token(Token = "0x600219B")]
	[Address(RVA = "0xA212AC", Offset = "0xA212AC", VA = "0xA212AC")]
	private void OnLeaveOptions()
	{
	}

	[Token(Token = "0x600219C")]
	[Address(RVA = "0xA21748", Offset = "0xA21748", VA = "0xA21748")]
	private void OnAddGoldBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600219D")]
	[Address(RVA = "0xA219DC", Offset = "0xA219DC", VA = "0xA219DC")]
	private void OnAddTokensBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600219E")]
	[Address(RVA = "0xA21750", Offset = "0xA21750", VA = "0xA21750")]
	public void OpenCurrencyShopPopup(bool startAtTokens = false)
	{
	}

	[Token(Token = "0x600219F")]
	[Address(RVA = "0xA219E4", Offset = "0xA219E4", VA = "0xA219E4")]
	public void ShowInsufficientFundsIndicators(Wallet.CurrencyAmount desiredFunds, Action fundsPurchasedCallback, Action showOfflineInsufficientFundsInficator, SniperAnalytics.InsufficientFundsSource attemptedPurchaseType, [Optional] string attemptedPurchaseItem)
	{
	}

	[Token(Token = "0x60021A0")]
	[Address(RVA = "0xA21C14", Offset = "0xA21C14", VA = "0xA21C14")]
	private void BlinkAddCurrencyButton(Wallet.Currency currencyType)
	{
	}

	[Token(Token = "0x60021A1")]
	[Address(RVA = "0xA21D0C", Offset = "0xA21D0C", VA = "0xA21D0C")]
	private void OnStarterPackButtonClick(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021A2")]
	[Address(RVA = "0xA21F50", Offset = "0xA21F50", VA = "0xA21F50")]
	private void OnJustCausePopupButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021A3")]
	[Address(RVA = "0xA221B8", Offset = "0xA221B8", VA = "0xA221B8")]
	public void OpenJustCauseRiflePopup()
	{
	}

	[Token(Token = "0x60021A4")]
	[Address(RVA = "0xA22328", Offset = "0xA22328", VA = "0xA22328")]
	private void SetStarterPackInfo()
	{
	}

	[Token(Token = "0x60021A5")]
	[Address(RVA = "0xA21D10", Offset = "0xA21D10", VA = "0xA21D10")]
	public void OpenStarterPackShopPopup()
	{
	}

	[Token(Token = "0x60021A6")]
	[Address(RVA = "0xA22410", Offset = "0xA22410", VA = "0xA22410")]
	private void OnAchievementsBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021A7")]
	[Address(RVA = "0xA225D8", Offset = "0xA225D8", VA = "0xA225D8")]
	private static void OnPopupCancel()
	{
	}

	[Token(Token = "0x60021A8")]
	[Address(RVA = "0xA21280", Offset = "0xA21280", VA = "0xA21280")]
	private void OnPopupEnter()
	{
	}

	[Token(Token = "0x60021A9")]
	[Address(RVA = "0xA212D0", Offset = "0xA212D0", VA = "0xA212D0")]
	private void OnPopupExit()
	{
	}

	[Token(Token = "0x60021AA")]
	[Address(RVA = "0xA1F654", Offset = "0xA1F654", VA = "0xA1F654")]
	private void OnMenuLockChanged(bool locked)
	{
	}

	[Token(Token = "0x60021AB")]
	[Address(RVA = "0xA22728", Offset = "0xA22728", VA = "0xA22728")]
	private void EnableButtons(bool enable)
	{
	}

	[Token(Token = "0x60021AC")]
	[Address(RVA = "0xA224D8", Offset = "0xA224D8", VA = "0xA224D8")]
	private void AddSocialListeners()
	{
	}

	[Token(Token = "0x60021AD")]
	[Address(RVA = "0xA201EC", Offset = "0xA201EC", VA = "0xA201EC")]
	private void RemoveSocialListeners()
	{
	}

	[Token(Token = "0x60021AE")]
	[Address(RVA = "0xA22B78", Offset = "0xA22B78", VA = "0xA22B78")]
	private void OnFirstPartySocialLoginSuccessEvent(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x60021AF")]
	[Address(RVA = "0xA22C20", Offset = "0xA22C20", VA = "0xA22C20")]
	private void OnFirstPartySocialLogOutEvent(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x60021B0")]
	[Address(RVA = "0xA22B90", Offset = "0xA22B90", VA = "0xA22B90")]
	private void DoFirstPartySocialRefresh()
	{
	}

	[Token(Token = "0x60021B1")]
	[Address(RVA = "0xA22C24", Offset = "0xA22C24", VA = "0xA22C24")]
	private void OnFadingInDoneCallBack(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60021B2")]
	[Address(RVA = "0xA22CB8", Offset = "0xA22CB8", VA = "0xA22CB8")]
	private void OnFadingOutDoneCallBack(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60021B3")]
	[Address(RVA = "0xA213B8", Offset = "0xA213B8", VA = "0xA213B8")]
	private void CheckForQualityPopup()
	{
	}

	[Token(Token = "0x60021B4")]
	[Address(RVA = "0xA22984", Offset = "0xA22984", VA = "0xA22984")]
	private void EnableOptionsButtons()
	{
	}

	[Token(Token = "0x60021B5")]
	[Address(RVA = "0xA1F8E0", Offset = "0xA1F8E0", VA = "0xA1F8E0")]
	public void UpdateJustCauseRifleVisual()
	{
	}

	[Token(Token = "0x60021B6")]
	[Address(RVA = "0xA22D14", Offset = "0xA22D14", VA = "0xA22D14")]
	private void OnSocialManagerStatusChanged(object sender, SocialManager.StatusEvent e)
	{
	}

	[Token(Token = "0x60021B7")]
	[Address(RVA = "0xA22D74", Offset = "0xA22D74", VA = "0xA22D74")]
	private void OnDeepLinkFriendCountChanged()
	{
	}

	[Token(Token = "0x60021B8")]
	[Address(RVA = "0xA1FA8C", Offset = "0xA1FA8C", VA = "0xA1FA8C")]
	private void OnHelpshiftNotificationCountChanged(int count)
	{
	}

	[Token(Token = "0x60021B9")]
	[Address(RVA = "0xA22E74", Offset = "0xA22E74", VA = "0xA22E74")]
	public ModeController()
	{
	}

	[Token(Token = "0x60021BA")]
	[Address(RVA = "0xA22F34", Offset = "0xA22F34", VA = "0xA22F34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619988", Offset = "0x619988")]
	private void _003COnShopReloadRefresh_003Eb__26_0()
	{
	}
}
