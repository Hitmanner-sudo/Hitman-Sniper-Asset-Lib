using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200052D")]
public class PerkItemController : UIController
{
	[Token(Token = "0x200052E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595040", Offset = "0x595040")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x10")]
		public PerkItemController _003C_003E4__this;

		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x18")]
		public Perk perk;

		[Token(Token = "0x600205B")]
		[Address(RVA = "0x8CF3A4", Offset = "0x8CF3A4", VA = "0x8CF3A4")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600205C")]
		[Address(RVA = "0x8CF3AC", Offset = "0x8CF3AC", VA = "0x8CF3AC")]
		internal void _003CDoPurchaseLogic_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200052F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595050", Offset = "0x595050")]
	private sealed class _003CDelayHideTooltip_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0x20")]
		public PerkItemController _003C_003E4__this;

		[Token(Token = "0x170004D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x8CF530", Offset = "0x8CF530", VA = "0x8CF530", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x8CF578", Offset = "0x8CF578", VA = "0x8CF578", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600205D")]
		[Address(RVA = "0x8CF400", Offset = "0x8CF400", VA = "0x8CF400")]
		[DebuggerHidden]
		public _003CDelayHideTooltip_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600205E")]
		[Address(RVA = "0x8CF42C", Offset = "0x8CF42C", VA = "0x8CF42C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600205F")]
		[Address(RVA = "0x8CF430", Offset = "0x8CF430", VA = "0x8CF430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002061")]
		[Address(RVA = "0x8CF538", Offset = "0x8CF538", VA = "0x8CF538", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000530")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595060", Offset = "0x595060")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x10")]
		public string offerID;

		[Token(Token = "0x6002063")]
		[Address(RVA = "0x8CF3D4", Offset = "0x8CF3D4", VA = "0x8CF3D4")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6002064")]
		[Address(RVA = "0x8CF3DC", Offset = "0x8CF3DC", VA = "0x8CF3DC")]
		internal bool _003COnConfirmPurchase_003Eb__0(Offer o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001B7B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ButtonHandler _backgroundButtonHandler;

	[Token(Token = "0x4001B7C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _barBackgroundButtonHandler;

	[Token(Token = "0x4001B7D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ButtonHandler _increaseProgressButtonHandler;

	[Token(Token = "0x4001B7E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ButtonHandler _decreaseProgressButtonHandler;

	[Token(Token = "0x4001B7F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PointyTooltip _pointyTooltip;

	[Token(Token = "0x4001B80")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int _tooltipSpaceBetweenSections;

	[Token(Token = "0x4001B81")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private Vector2 _tooltipTopPosition;

	[Token(Token = "0x4001B82")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private Vector2 _tooltipBottomPosition;

	[Token(Token = "0x4001B83")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private SoundContainer _onClaimClickSound;

	[Token(Token = "0x4001B84")]
	[FieldOffset(Offset = "0x98")]
	private Perk _perk;

	[Token(Token = "0x4001B85")]
	[FieldOffset(Offset = "0xA0")]
	private Coroutine _hideTooltipCoroutine;

	[Token(Token = "0x4001B86")]
	[FieldOffset(Offset = "0xA8")]
	private float _tooltipShowTime;

	[Token(Token = "0x4001B87")]
	[FieldOffset(Offset = "0xB0")]
	private GameTimer _timer;

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x8FE1A4", Offset = "0x8FE1A4", VA = "0x8FE1A4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x8FE348", Offset = "0x8FE348", VA = "0x8FE348", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x8FE65C", Offset = "0x8FE65C", VA = "0x8FE65C")]
	private void OnBackgroundButtonPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x8FE9C4", Offset = "0x8FE9C4", VA = "0x8FE9C4")]
	private void OnBarBackgroundStartButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x8FEABC", Offset = "0x8FEABC", VA = "0x8FEABC")]
	private void DoPurchaseLogic(Perk perk, bool showPopupIfInsufficientFunds = true)
	{
	}

	[Token(Token = "0x600204F")]
	[Address(RVA = "0x8FF1C4", Offset = "0x8FF1C4", VA = "0x8FF1C4")]
	private void ShowOfflineInsufficientFundsIndicator()
	{
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x8FF63C", Offset = "0x8FF63C", VA = "0x8FF63C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619338", Offset = "0x619338")]
	private IEnumerator DelayHideTooltip()
	{
		return null;
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x8FEE70", Offset = "0x8FEE70", VA = "0x8FEE70")]
	private void OnConfirmPurchase(int cost, string offerID)
	{
	}

	[Token(Token = "0x6002052")]
	[Address(RVA = "0x8FF6A8", Offset = "0x8FF6A8", VA = "0x8FF6A8")]
	private void RegisterShopEvents()
	{
	}

	[Token(Token = "0x6002053")]
	[Address(RVA = "0x8FF784", Offset = "0x8FF784", VA = "0x8FF784")]
	private void UnregisterShopEvents()
	{
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x8FF858", Offset = "0x8FF858", VA = "0x8FF858")]
	private void OnPerkPurchaseCompleted(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x8FF9CC", Offset = "0x8FF9CC", VA = "0x8FF9CC")]
	private void OnPerkPurchaseFailure(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x8FE720", Offset = "0x8FE720", VA = "0x8FE720")]
	private void DisplayTooltip(Perk perk)
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x8FF350", Offset = "0x8FF350", VA = "0x8FF350")]
	private void RepositionArrowLocation()
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x8FF9F0", Offset = "0x8FF9F0", VA = "0x8FF9F0")]
	private void OnIncreaseProgressButtonPressed(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x8FF9F4", Offset = "0x8FF9F4", VA = "0x8FF9F4")]
	private void OnDecreaseProgressButtonPressed(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x8FF9F8", Offset = "0x8FF9F8", VA = "0x8FF9F8")]
	public PerkItemController()
	{
	}
}
