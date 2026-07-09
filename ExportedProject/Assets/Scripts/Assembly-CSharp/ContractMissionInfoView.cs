using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000658")]
public class ContractMissionInfoView : View
{
	[Token(Token = "0x2000659")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957E8", Offset = "0x5957E8")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0x10")]
		public ContractMissionInfoView _003C_003E4__this;

		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0x18")]
		public int cost;

		[Token(Token = "0x6002943")]
		[Address(RVA = "0x864C94", Offset = "0x864C94", VA = "0x864C94")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6002944")]
		[Address(RVA = "0x864C9C", Offset = "0x864C9C", VA = "0x864C9C")]
		internal void _003COnAutoCompleteMissionFinished_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200065A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957F8", Offset = "0x5957F8")]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0x10")]
		public ContractMissionInfoView _003C_003E4__this;

		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0x18")]
		public int cost;

		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x20")]
		public Action onConfirm;

		[Token(Token = "0x6002945")]
		[Address(RVA = "0x864D1C", Offset = "0x864D1C", VA = "0x864D1C")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x6002946")]
		[Address(RVA = "0x864D24", Offset = "0x864D24", VA = "0x864D24")]
		internal void _003CSetUpPurchaseConfirmation_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200065B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595808", Offset = "0x595808")]
	private sealed class _003CDelayHideTooltip_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400232C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0x20")]
		public ContractMissionInfoView _003C_003E4__this;

		[Token(Token = "0x17000556")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600294A")]
			[Address(RVA = "0x864FB8", Offset = "0x864FB8", VA = "0x864FB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000557")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600294C")]
			[Address(RVA = "0x865000", Offset = "0x865000", VA = "0x865000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002947")]
		[Address(RVA = "0x864E88", Offset = "0x864E88", VA = "0x864E88")]
		[DebuggerHidden]
		public _003CDelayHideTooltip_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002948")]
		[Address(RVA = "0x864EB4", Offset = "0x864EB4", VA = "0x864EB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002949")]
		[Address(RVA = "0x864EB8", Offset = "0x864EB8", VA = "0x864EB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600294B")]
		[Address(RVA = "0x864FC0", Offset = "0x864FC0", VA = "0x864FC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200065C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595818", Offset = "0x595818")]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x10")]
		public ContractMissionInfoView _003C_003E4__this;

		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x18")]
		public bool menusLocked;

		[Token(Token = "0x600294D")]
		[Address(RVA = "0x864D50", Offset = "0x864D50", VA = "0x864D50")]
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		[Token(Token = "0x600294E")]
		[Address(RVA = "0x864D58", Offset = "0x864D58", VA = "0x864D58")]
		internal void _003CCheckForTutorialMissionDonePopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200065D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595828", Offset = "0x595828")]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x10")]
		public ContractMissionInfoView _003C_003E4__this;

		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0x18")]
		public bool menusLocked;

		[Token(Token = "0x600294F")]
		[Address(RVA = "0x864DEC", Offset = "0x864DEC", VA = "0x864DEC")]
		public _003C_003Ec__DisplayClass59_0()
		{
		}

		[Token(Token = "0x6002950")]
		[Address(RVA = "0x864DF4", Offset = "0x864DF4", VA = "0x864DF4")]
		internal void _003CCheckForContractFinishedPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler CompleteNowButton;

	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CompleteNowGroup;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x70")]
	public UILabel CompleteNowCostLabel;

	[Token(Token = "0x4002313")]
	[FieldOffset(Offset = "0x78")]
	public UILocalize ChapterLocalize;

	[Token(Token = "0x4002314")]
	[FieldOffset(Offset = "0x80")]
	public UITexture ContractLocationTexture;

	[Token(Token = "0x4002315")]
	[FieldOffset(Offset = "0x88")]
	public UITexture ContractLocationTexturePhone;

	[Token(Token = "0x4002316")]
	[FieldOffset(Offset = "0x90")]
	public bool CanAdvanceMissions;

	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x98")]
	public ContractAssignmentView PrimaryAssignmentView;

	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0xA0")]
	public PopupOverlayView TutorialMissionsDonePopupPrefab;

	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0xA8")]
	public PointyTooltip PointyTooltip;

	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0xB0")]
	private ContractAssignmentView _currentlyAnimatingAssignment;

	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0xB8")]
	private bool _created;

	[Token(Token = "0x400231C")]
	[FieldOffset(Offset = "0xB9")]
	private bool _isChangingMissions;

	[Token(Token = "0x400231D")]
	[FieldOffset(Offset = "0xBA")]
	private bool _wantsGroupActive;

	[Token(Token = "0x400231E")]
	[FieldOffset(Offset = "0xBB")]
	private bool _wantsMenusUnlocked;

	[Token(Token = "0x400231F")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine _hideTooltipCoroutine;

	[Token(Token = "0x4002320")]
	[FieldOffset(Offset = "0xC8")]
	private float _tooltipShowTime;

	[Token(Token = "0x4002321")]
	[FieldOffset(Offset = "0xD0")]
	private GameTimer _timer;

	[Token(Token = "0x14000098")]
	public static event EventHandler<EventArgs> OnAnimationsCompleted
	{
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x8EA03C", Offset = "0x8EA03C", VA = "0x8EA03C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB28", Offset = "0x61DB28")]
		add
		{
		}
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x8EAE74", Offset = "0x8EAE74", VA = "0x8EAE74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB38", Offset = "0x61DB38")]
		remove
		{
		}
	}

	[Token(Token = "0x14000099")]
	public static event EventHandler<EventArgs> OnChangeMissionCompleted
	{
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x8EE894", Offset = "0x8EE894", VA = "0x8EE894")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB48", Offset = "0x61DB48")]
		add
		{
		}
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x8EE954", Offset = "0x8EE954", VA = "0x8EE954")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB58", Offset = "0x61DB58")]
		remove
		{
		}
	}

	[Token(Token = "0x1400009A")]
	public static event EventHandler<EventArgs> OnAnimationsStarting
	{
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x8EA0F8", Offset = "0x8EA0F8", VA = "0x8EA0F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB68", Offset = "0x61DB68")]
		add
		{
		}
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x8EAF30", Offset = "0x8EAF30", VA = "0x8EAF30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB78", Offset = "0x61DB78")]
		remove
		{
		}
	}

	[Token(Token = "0x1400009B")]
	public static event EventHandler<EventArgs> OnAnimationsStopping
	{
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x8EA1B8", Offset = "0x8EA1B8", VA = "0x8EA1B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB88", Offset = "0x61DB88")]
		add
		{
		}
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x8EAFF0", Offset = "0x8EAFF0", VA = "0x8EAFF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DB98", Offset = "0x61DB98")]
		remove
		{
		}
	}

	[Token(Token = "0x6002923")]
	[Address(RVA = "0x8EEA14", Offset = "0x8EEA14", VA = "0x8EEA14", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002924")]
	[Address(RVA = "0x8EEB60", Offset = "0x8EEB60", VA = "0x8EEB60", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002925")]
	[Address(RVA = "0x8EF954", Offset = "0x8EF954", VA = "0x8EF954", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x8EFD2C", Offset = "0x8EFD2C", VA = "0x8EFD2C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002927")]
	[Address(RVA = "0x8EFED4", Offset = "0x8EFED4", VA = "0x8EFED4", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002928")]
	[Address(RVA = "0x8EF058", Offset = "0x8EF058", VA = "0x8EF058")]
	private void UpdateContractImage()
	{
	}

	[Token(Token = "0x6002929")]
	[Address(RVA = "0x8EF208", Offset = "0x8EF208", VA = "0x8EF208")]
	private void OnMissionChanged(MissionData mission)
	{
	}

	[Token(Token = "0x600292A")]
	[Address(RVA = "0x8EF70C", Offset = "0x8EF70C", VA = "0x8EF70C")]
	private void UpdateChapterLocalizeText()
	{
	}

	[Token(Token = "0x600292B")]
	[Address(RVA = "0x8EFFDC", Offset = "0x8EFFDC", VA = "0x8EFFDC")]
	private void SetContractImage(LazyUITexture currentContractTexture, UITexture texture)
	{
	}

	[Token(Token = "0x600292C")]
	[Address(RVA = "0x8F05E4", Offset = "0x8F05E4", VA = "0x8F05E4")]
	private AssignmentModel ReplaceAssignment(AssignmentData assignment, MissionData mission)
	{
		return null;
	}

	[Token(Token = "0x600292D")]
	[Address(RVA = "0x8EB19C", Offset = "0x8EB19C", VA = "0x8EB19C")]
	public void PlayAssignmentAnimations()
	{
	}

	[Token(Token = "0x600292E")]
	[Address(RVA = "0x8F0918", Offset = "0x8F0918", VA = "0x8F0918")]
	public void OnPopupsFinished()
	{
	}

	[Token(Token = "0x600292F")]
	[Address(RVA = "0x8F0C1C", Offset = "0x8F0C1C", VA = "0x8F0C1C")]
	private void OnAssignmentProgressFinished(object sender, ContractAssignmentView.OnProgressFinishedArgs args)
	{
	}

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x8F0C20", Offset = "0x8F0C20", VA = "0x8F0C20")]
	private void OnAssignmentAnimCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x8F0C24", Offset = "0x8F0C24", VA = "0x8F0C24")]
	private void OnAssignmentCompleted(object sender, MissionManager.AssignmentUpdateEventArgs args)
	{
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x8F06E4", Offset = "0x8F06E4", VA = "0x8F06E4")]
	public void CheckMissionCompletion()
	{
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x8F0D14", Offset = "0x8F0D14", VA = "0x8F0D14")]
	private void OnAutoCompleteMissionFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x8F0DE0", Offset = "0x8F0DE0", VA = "0x8F0DE0")]
	private void SetUpPurchaseConfirmation(int cost, Action onConfirm, bool showPopupIfInsufficientFunds = true)
	{
	}

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x8F1164", Offset = "0x8F1164", VA = "0x8F1164")]
	private void ShowOfflineInsufficientFundsIndicator()
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x8F12E8", Offset = "0x8F12E8", VA = "0x8F12E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DBA8", Offset = "0x61DBA8")]
	private IEnumerator DelayHideTooltip()
	{
		return null;
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x8F1354", Offset = "0x8F1354", VA = "0x8F1354")]
	private void OnConfirmPurchase(int cost, Offer offer)
	{
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x8F0B9C", Offset = "0x8F0B9C", VA = "0x8F0B9C")]
	private int GetMissionAutoCompleteCost()
	{
		return default(int);
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x8F15C4", Offset = "0x8F15C4", VA = "0x8F15C4")]
	private void RegisterShopEvents()
	{
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x8F16A0", Offset = "0x8F16A0", VA = "0x8F16A0")]
	private void UnregisterShopEvents()
	{
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x8F1774", Offset = "0x8F1774", VA = "0x8F1774")]
	private void OnMissionSkipPurchaseCompleted(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x8F1C08", Offset = "0x8F1C08", VA = "0x8F1C08")]
	private void OnMissionSkipPurchaseFailure(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x8F1C0C", Offset = "0x8F1C0C", VA = "0x8F1C0C")]
	public void UpdateAssignmentProgression()
	{
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x8F00FC", Offset = "0x8F00FC", VA = "0x8F00FC")]
	public void SetAnimsFinished(bool finished, bool lockMenus = true)
	{
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x8F1C9C", Offset = "0x8F1C9C", VA = "0x8F1C9C")]
	private void CheckForTutorialMissionDonePopup()
	{
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x8F2098", Offset = "0x8F2098", VA = "0x8F2098")]
	private void CheckForContractFinishedPopup()
	{
	}

	[Token(Token = "0x6002941")]
	[Address(RVA = "0x8F23B4", Offset = "0x8F23B4", VA = "0x8F23B4")]
	private static void OnMissionsPopupCompleted(SaveGameManager.SaveGameFlags saveGameFlags)
	{
	}

	[Token(Token = "0x6002942")]
	[Address(RVA = "0x8F24A4", Offset = "0x8F24A4", VA = "0x8F24A4")]
	public ContractMissionInfoView()
	{
	}
}
