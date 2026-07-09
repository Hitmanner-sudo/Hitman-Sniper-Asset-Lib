using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D6")]
public abstract class AttachmentSlotView : View
{
	[Token(Token = "0x20006D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595BD8", Offset = "0x595BD8")]
	private sealed class _003CWaitToHideNewFeedback_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40026A0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40026A1")]
		[FieldOffset(Offset = "0x20")]
		public AttachmentSlotView _003C_003E4__this;

		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170005D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D24")]
			[Address(RVA = "0x92532C", Offset = "0x92532C", VA = "0x92532C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x925374", Offset = "0x925374", VA = "0x925374", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x9251EC", Offset = "0x9251EC", VA = "0x9251EC")]
		[DebuggerHidden]
		public _003CWaitToHideNewFeedback_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x925218", Offset = "0x925218", VA = "0x925218", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x92521C", Offset = "0x92521C", VA = "0x92521C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x925334", Offset = "0x925334", VA = "0x925334", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400268B")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public BlueprintItemView ParentBlueprint;

	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x68")]
	public UITexture ModImage;

	[Token(Token = "0x400268D")]
	[FieldOffset(Offset = "0x70")]
	public UISprite Background;

	[Token(Token = "0x400268E")]
	[FieldOffset(Offset = "0x78")]
	public GameObject NewFeedback;

	[Token(Token = "0x400268F")]
	[FieldOffset(Offset = "0x80")]
	public ButtonHandler Button;

	[Token(Token = "0x4002690")]
	[FieldOffset(Offset = "0x88")]
	public PointyTooltip Tooltip;

	[Token(Token = "0x4002691")]
	[FieldOffset(Offset = "0x90")]
	public GameObject CollectPartEffect1;

	[Token(Token = "0x4002692")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CollectPartEffect2;

	[Token(Token = "0x4002693")]
	[FieldOffset(Offset = "0xA0")]
	public UITexture PartEffect;

	[Token(Token = "0x4002694")]
	[FieldOffset(Offset = "0xA8")]
	public UIForwardEvents UIForwardEvents;

	[NonSerialized]
	[Token(Token = "0x4002695")]
	[FieldOffset(Offset = "0xB0")]
	public WeaponUnlockableSaveData WeaponSaveData;

	[Token(Token = "0x4002696")]
	[FieldOffset(Offset = "0xB8")]
	private bool _hasNewFeedback;

	[Token(Token = "0x4002697")]
	[FieldOffset(Offset = "0xB9")]
	private bool _hasUnseenMod;

	[Token(Token = "0x4002698")]
	[FieldOffset(Offset = "0xBA")]
	private bool _created;

	[Token(Token = "0x4002699")]
	[FieldOffset(Offset = "0xBB")]
	private bool _hidingNewFeedback;

	[Token(Token = "0x400269A")]
	[FieldOffset(Offset = "0xBC")]
	private bool _isInPopup;

	[Token(Token = "0x400269B")]
	[FieldOffset(Offset = "0x0")]
	protected static PointyTooltip LastPointyTooltipDisplayed;

	[Token(Token = "0x400269C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string LOCK_ICON_UI_TAG;

	[Token(Token = "0x400269D")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B995C", Offset = "0x5B995C")]
	private AttachmentsUnlockable _003CAttachmentInSlot_003Ek__BackingField;

	[Token(Token = "0x400269E")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B996C", Offset = "0x5B996C")]
	private bool _003CIsUnlockedByDefault_003Ek__BackingField;

	[Token(Token = "0x170005CD")]
	protected abstract WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002CFC")]
		get;
	}

	[Token(Token = "0x170005CE")]
	protected abstract Func<int, AttachmentsUnlockable> LoadFunction
	{
		[Token(Token = "0x6002CFD")]
		get;
	}

	[Token(Token = "0x170005CF")]
	public bool HasAttachment
	{
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0xC04034", Offset = "0xC04034", VA = "0xC04034")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005D0")]
	public AttachmentsUnlockable AttachmentInSlot
	{
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0xC040A0", Offset = "0xC040A0", VA = "0xC040A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620B40", Offset = "0x620B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0xC040A8", Offset = "0xC040A8", VA = "0xC040A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620B50", Offset = "0x620B50")]
		private set
		{
		}
	}

	[Token(Token = "0x170005D1")]
	public bool IsUnlockedByDefault
	{
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0xC040B0", Offset = "0xC040B0", VA = "0xC040B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620B60", Offset = "0x620B60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0xC040B8", Offset = "0xC040B8", VA = "0xC040B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620B70", Offset = "0x620B70")]
		private set
		{
		}
	}

	[Token(Token = "0x170005D2")]
	protected abstract SniperAnalytics.TooltipClickType TooltipClickType
	{
		[Token(Token = "0x6002D03")]
		get;
	}

	[Token(Token = "0x170005D3")]
	protected virtual ColorModel.ColorModelEnum LockedColor
	{
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0xC040C4", Offset = "0xC040C4", VA = "0xC040C4", Slot = "18")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x170005D4")]
	protected virtual ColorModel.ColorModelEnum UnlockedColor
	{
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0xC040CC", Offset = "0xC040CC", VA = "0xC040CC", Slot = "19")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x170005D5")]
	protected virtual ColorModel.ColorModelEnum UnlockedBackgroundColor
	{
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0xC040D4", Offset = "0xC040D4", VA = "0xC040D4", Slot = "20")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x170005D6")]
	protected virtual ColorModel.ColorModelEnum NextUnlockColor
	{
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0xC040DC", Offset = "0xC040DC", VA = "0xC040DC", Slot = "21")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x170005D7")]
	public virtual int AttachmentIndex
	{
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0xC040E4", Offset = "0xC040E4", VA = "0xC040E4", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002D09")]
	[Address(RVA = "0xC04244", Offset = "0xC04244", VA = "0xC04244")]
	protected AttachmentSlotView()
	{
	}

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0xC04270", Offset = "0xC04270", VA = "0xC04270")]
	public void SetUIForwardEvents(GameObject targetGameObject)
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0xC04300", Offset = "0xC04300", VA = "0xC04300")]
	public void Init()
	{
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0xC04324", Offset = "0xC04324", VA = "0xC04324", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0xC044B8", Offset = "0xC044B8", VA = "0xC044B8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0xC0466C", Offset = "0xC0466C", VA = "0xC0466C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0xC048D0", Offset = "0xC048D0", VA = "0xC048D0", Slot = "23")]
	protected virtual void OnSelfPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002D10")]
	[Address(RVA = "0xC04F04", Offset = "0xC04F04", VA = "0xC04F04", Slot = "24")]
	public virtual TooltipTextData GetLockedToolTipText()
	{
		return null;
	}

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0xC050E8", Offset = "0xC050E8", VA = "0xC050E8", Slot = "25")]
	public virtual void UpdateToolTip()
	{
	}

	[Token(Token = "0x6002D12")]
	[Address(RVA = "0xC04C14", Offset = "0xC04C14", VA = "0xC04C14")]
	public static void DestroyLastTooltip()
	{
	}

	[Token(Token = "0x6002D13")]
	[Address(RVA = "0xC051D0", Offset = "0xC051D0", VA = "0xC051D0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002D14")]
	public abstract bool AttachmentsOverlap(AttachmentsUnlockable other);

	[Token(Token = "0x6002D15")]
	[Address(RVA = "0xC05290", Offset = "0xC05290", VA = "0xC05290", Slot = "27")]
	public virtual void UpdateAttachmentInSlot()
	{
	}

	[Token(Token = "0x6002D16")]
	protected abstract int GetLevelUnlocked();

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0xC0537C", Offset = "0xC0537C", VA = "0xC0537C", Slot = "29")]
	public virtual bool WillUnlockNextLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D18")]
	[Address(RVA = "0xC054EC", Offset = "0xC054EC", VA = "0xC054EC", Slot = "30")]
	public virtual void UpdateIcons()
	{
	}

	[Token(Token = "0x6002D19")]
	[Address(RVA = "0xC0586C", Offset = "0xC0586C", VA = "0xC0586C")]
	public void ShowNewFeedback()
	{
	}

	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0xC05908", Offset = "0xC05908", VA = "0xC05908")]
	public void SetUnlockedByDefault(bool defaultUnlock)
	{
	}

	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0xC05914", Offset = "0xC05914", VA = "0xC05914")]
	public void SetupAsPopup()
	{
	}

	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0xC05920", Offset = "0xC05920", VA = "0xC05920")]
	public void HideNewFeedbackForSlot()
	{
	}

	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0xC059E8", Offset = "0xC059E8", VA = "0xC059E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620B80", Offset = "0x620B80")]
	private IEnumerator WaitToHideNewFeedback()
	{
		return null;
	}

	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0xC04768", Offset = "0xC04768", VA = "0xC04768")]
	private void UnloadResources()
	{
	}

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0xC04D08", Offset = "0xC04D08", VA = "0xC04D08")]
	protected void AnalyticsRegisterClick()
	{
	}
}
