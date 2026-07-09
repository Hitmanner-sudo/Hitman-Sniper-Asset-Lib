using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200054F")]
public class BlueprintItemController : UIController
{
	[Token(Token = "0x2000550")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5951C4", Offset = "0x5951C4")]
	private sealed class _003CDelayHideTooltip_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintItemController _003C_003E4__this;

		[Token(Token = "0x170004E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600217C")]
			[Address(RVA = "0x927A20", Offset = "0x927A20", VA = "0x927A20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x927A68", Offset = "0x927A68", VA = "0x927A68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002179")]
		[Address(RVA = "0x9278F0", Offset = "0x9278F0", VA = "0x9278F0")]
		[DebuggerHidden]
		public _003CDelayHideTooltip_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600217A")]
		[Address(RVA = "0x92791C", Offset = "0x92791C", VA = "0x92791C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600217B")]
		[Address(RVA = "0x927920", Offset = "0x927920", VA = "0x927920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600217D")]
		[Address(RVA = "0x927A28", Offset = "0x927A28", VA = "0x927A28", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C23")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler EquipButton;

	[Token(Token = "0x4001C24")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler UpgradeButton;

	[Token(Token = "0x4001C25")]
	[FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler BuyButton;

	[Token(Token = "0x4001C26")]
	[FieldOffset(Offset = "0x68")]
	public BlinkButtonHandler OnSaleButton;

	[Token(Token = "0x4001C27")]
	[FieldOffset(Offset = "0x70")]
	public BlinkButtonHandler OnSaleFreeButton;

	[Token(Token = "0x4001C28")]
	[FieldOffset(Offset = "0x78")]
	public BlinkButtonHandler InsufficientFundsButton;

	[Token(Token = "0x4001C29")]
	[FieldOffset(Offset = "0x80")]
	public ButtonHandler ChallengeTokensUnlockableButton;

	[Token(Token = "0x4001C2A")]
	[FieldOffset(Offset = "0x88")]
	public WeaponCustomizationView AbilityCustomizationPopupPrefab;

	[Token(Token = "0x4001C2B")]
	[FieldOffset(Offset = "0x90")]
	public WeaponCustomizationView ModCustomizationPopupPrefab;

	[Token(Token = "0x4001C2C")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private BlinkButtonHandler _upgradeMasteryButton;

	[Token(Token = "0x4001C2D")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private LazyPopupWeaponMastery _singleWeaponFullyUpgradedPopup;

	[Token(Token = "0x4001C2E")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private LazyPopupWeaponMastery _singleWeaponFullyMasteredPopup;

	[NonSerialized]
	[Token(Token = "0x4001C2F")]
	[FieldOffset(Offset = "0xB0")]
	public BlueprintView BlueprintView;

	[Token(Token = "0x4001C30")]
	[FieldOffset(Offset = "0xB8")]
	private int _nextUpgradeIdx;

	[Token(Token = "0x4001C31")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine _hideTooltipCoroutine;

	[Token(Token = "0x4001C32")]
	[FieldOffset(Offset = "0xC8")]
	private PointyTooltip _challengeTokensUnlockableTooltip;

	[Token(Token = "0x4001C33")]
	[FieldOffset(Offset = "0xD0")]
	private float _tooltipShowTime;

	[Token(Token = "0x4001C34")]
	[FieldOffset(Offset = "0xD8")]
	private readonly GameTimer _timer;

	[Token(Token = "0x4001C35")]
	[FieldOffset(Offset = "0xE0")]
	private readonly RestorePurchaseController _restorePurchaseController;

	[Token(Token = "0x4001C36")]
	[FieldOffset(Offset = "0x0")]
	private static WeaponCustomizationView _currentCustomizationView;

	[Token(Token = "0x170004E3")]
	public static bool IsCustomizationPopupOpen
	{
		[Token(Token = "0x6002150")]
		[Address(RVA = "0xC6A17C", Offset = "0xC6A17C", VA = "0xC6A17C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002151")]
	[Address(RVA = "0xC6A200", Offset = "0xC6A200", VA = "0xC6A200")]
	public BlueprintItemController()
	{
	}

	[Token(Token = "0x6002152")]
	[Address(RVA = "0xC6A2EC", Offset = "0xC6A2EC", VA = "0xC6A2EC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002153")]
	[Address(RVA = "0xC6A740", Offset = "0xC6A740", VA = "0xC6A740", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002154")]
	[Address(RVA = "0xC6AA84", Offset = "0xC6AA84", VA = "0xC6AA84")]
	private void OnEquipClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002155")]
	[Address(RVA = "0xC6AA88", Offset = "0xC6AA88", VA = "0xC6AA88")]
	private void EquipWeapon()
	{
	}

	[Token(Token = "0x6002156")]
	[Address(RVA = "0xC6AC74", Offset = "0xC6AC74", VA = "0xC6AC74")]
	private void OnBuyClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002157")]
	[Address(RVA = "0xC6AE68", Offset = "0xC6AE68", VA = "0xC6AE68")]
	private void OnDefaultBuyClicked()
	{
	}

	[Token(Token = "0x6002158")]
	[Address(RVA = "0xC6AD00", Offset = "0xC6AD00", VA = "0xC6AD00")]
	private void OnJustCauseBuyClicked()
	{
	}

	[Token(Token = "0x6002159")]
	[Address(RVA = "0xC6B2A0", Offset = "0xC6B2A0", VA = "0xC6B2A0")]
	private void OnInsufficientFundsClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600215A")]
	[Address(RVA = "0xC6B730", Offset = "0xC6B730", VA = "0xC6B730")]
	private void ShowOfflineInsufficientFundsIndicator()
	{
	}

	[Token(Token = "0x600215B")]
	[Address(RVA = "0xC6B870", Offset = "0xC6B870", VA = "0xC6B870")]
	private void TryCompletePurchaseIfSufficientFunds()
	{
	}

	[Token(Token = "0x600215C")]
	[Address(RVA = "0xC6BCF0", Offset = "0xC6BCF0", VA = "0xC6BCF0")]
	private void OnChallengeTokensUnlockable(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0xC6BE90", Offset = "0xC6BE90", VA = "0xC6BE90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6198A8", Offset = "0x6198A8")]
	private IEnumerator DelayHideTooltip()
	{
		return null;
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0xC6B0F8", Offset = "0xC6B0F8", VA = "0xC6B0F8")]
	private void OnSuccessfullBuy()
	{
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0xC6BEFC", Offset = "0xC6BEFC", VA = "0xC6BEFC")]
	private void RegisterWeaponShopEvents()
	{
	}

	[Token(Token = "0x6002160")]
	[Address(RVA = "0xC6C008", Offset = "0xC6C008", VA = "0xC6C008")]
	private void UnregisterWeaponShopEvents()
	{
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0xC6C10C", Offset = "0xC6C10C", VA = "0xC6C10C")]
	private void OnWeaponPurchaseCompleted(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0xC6B0AC", Offset = "0xC6B0AC", VA = "0xC6B0AC")]
	private void EnableBuyButtons(bool enable)
	{
	}

	[Token(Token = "0x6002163")]
	[Address(RVA = "0xC6C2D0", Offset = "0xC6C2D0", VA = "0xC6C2D0")]
	private void AnalyticsUnlock(WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x6002164")]
	[Address(RVA = "0xC6C42C", Offset = "0xC6C42C", VA = "0xC6C42C")]
	private void OnWeaponPurchaseFailed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002165")]
	[Address(RVA = "0xC6BB1C", Offset = "0xC6BB1C", VA = "0xC6BB1C")]
	private void OnUpgradeClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002166")]
	[Address(RVA = "0xC6B9B8", Offset = "0xC6B9B8", VA = "0xC6B9B8")]
	private void OnUpgradeMasteryClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002167")]
	[Address(RVA = "0xC6C5C0", Offset = "0xC6C5C0", VA = "0xC6C5C0")]
	private void OnConfirmUpgradeWeapon()
	{
	}

	[Token(Token = "0x6002168")]
	[Address(RVA = "0xC6C9DC", Offset = "0xC6C9DC", VA = "0xC6C9DC")]
	private void OnUpgradePurchaseComplete(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002169")]
	[Address(RVA = "0xC6CE50", Offset = "0xC6CE50", VA = "0xC6CE50")]
	private void OnUpgradePurchaseFailed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x600216A")]
	[Address(RVA = "0xC6C8D0", Offset = "0xC6C8D0", VA = "0xC6C8D0")]
	private void RegisterUpgradeShopEvents()
	{
	}

	[Token(Token = "0x600216B")]
	[Address(RVA = "0xC6CD4C", Offset = "0xC6CD4C", VA = "0xC6CD4C")]
	private void UnregisterUpgradeShopEvents()
	{
	}

	[Token(Token = "0x600216C")]
	[Address(RVA = "0xC6CFAC", Offset = "0xC6CFAC", VA = "0xC6CFAC")]
	private void OnConfirmUpgradeMastery(Wallet.CurrencyAmount cost)
	{
	}

	[Token(Token = "0x600216D")]
	[Address(RVA = "0xC6D1F4", Offset = "0xC6D1F4", VA = "0xC6D1F4")]
	private void RegisterMasteryUpgradeEvents()
	{
	}

	[Token(Token = "0x600216E")]
	[Address(RVA = "0xC6D300", Offset = "0xC6D300", VA = "0xC6D300")]
	private void UnregisterMasteryUpgradeEvents()
	{
	}

	[Token(Token = "0x600216F")]
	[Address(RVA = "0xC6D404", Offset = "0xC6D404", VA = "0xC6D404")]
	private void OnUpgradeMasterySuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002170")]
	[Address(RVA = "0xC6D7EC", Offset = "0xC6D7EC", VA = "0xC6D7EC")]
	private void OnUpgradeMasteryFailed(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002171")]
	[Address(RVA = "0xC6D95C", Offset = "0xC6D95C", VA = "0xC6D95C")]
	private void ShowMasteryPopup(LazyPopupWeaponMastery lazyPopup)
	{
	}

	[Token(Token = "0x6002172")]
	[Address(RVA = "0xC6DC7C", Offset = "0xC6DC7C", VA = "0xC6DC7C")]
	private void ShowCustomzationPopup(GameObject prefab, int indexToSelect)
	{
	}

	[Token(Token = "0x6002173")]
	[Address(RVA = "0xC6DFBC", Offset = "0xC6DFBC", VA = "0xC6DFBC")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002174")]
	[Address(RVA = "0xC6E0C4", Offset = "0xC6E0C4", VA = "0xC6E0C4")]
	private void OnSelectedCustomizableIconChanged(SelectedSlot selectedSlot)
	{
	}

	[Token(Token = "0x6002175")]
	[Address(RVA = "0xC6E228", Offset = "0xC6E228", VA = "0xC6E228")]
	public static void CloseCurrentCustomizationPopup()
	{
	}

	[Token(Token = "0x6002176")]
	[Address(RVA = "0xC6E2B4", Offset = "0xC6E2B4", VA = "0xC6E2B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619908", Offset = "0x619908")]
	private void _003C_002Ector_003Eb__22_0()
	{
	}

	[Token(Token = "0x6002177")]
	[Address(RVA = "0xC6E2B8", Offset = "0xC6E2B8", VA = "0xC6E2B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619918", Offset = "0x619918")]
	private void _003COnUpgradePurchaseComplete_003Eb__45_0()
	{
	}

	[Token(Token = "0x6002178")]
	[Address(RVA = "0xC6E2C0", Offset = "0xC6E2C0", VA = "0xC6E2C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619928", Offset = "0x619928")]
	private void _003COnUpgradeMasterySuccess_003Eb__52_0()
	{
	}
}
