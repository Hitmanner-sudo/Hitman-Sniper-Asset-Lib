using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x20006E9")]
public class BlueprintView : MainMenuPageView
{
	[Serializable]
	[Token(Token = "0x20006EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595CB8", Offset = "0x595CB8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002779")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400277A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<WeaponUnlockableSaveData, bool> _003C_003E9__35_0;

		[Token(Token = "0x400277B")]
		[FieldOffset(Offset = "0x10")]
		public static Func<BlueprintItemView, bool> _003C_003E9__59_0;

		[Token(Token = "0x400277C")]
		[FieldOffset(Offset = "0x18")]
		public static EventHandler<ButtonHandler.ButtonHandlerEventArgs> _003C_003E9__66_0;

		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ModItemSlotView, bool> _003C_003E9__68_0;

		[Token(Token = "0x400277E")]
		[FieldOffset(Offset = "0x28")]
		public static Func<PowerUpItemSlotView, bool> _003C_003E9__69_0;

		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x30")]
		public static Func<WeaponUnlockable.RequiredPartInfo, bool> _003C_003E9__71_0;

		[Token(Token = "0x4002780")]
		[FieldOffset(Offset = "0x38")]
		public static Func<BlueprintItemView, WeaponUnlockable> _003C_003E9__71_1;

		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x40")]
		public static Func<BlueprintPartIconView, bool> _003C_003E9__73_0;

		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x9299EC", Offset = "0x9299EC", VA = "0x9299EC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x9299F4", Offset = "0x9299F4", VA = "0x9299F4")]
		internal bool _003CGetFeedbackCount_003Eb__35_0(WeaponUnlockableSaveData save)
		{
			return default(bool);
		}

		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x929A14", Offset = "0x929A14", VA = "0x929A14")]
		internal bool _003CFirstNewlyCompletedWeapon_003Eb__59_0(BlueprintItemView b)
		{
			return default(bool);
		}

		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x929A30", Offset = "0x929A30", VA = "0x929A30")]
		internal void _003CHighlightUpgradeButton_003Eb__66_0(object o, ButtonHandler.ButtonHandlerEventArgs a)
		{
		}

		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x929AB0", Offset = "0x929AB0", VA = "0x929AB0")]
		internal bool _003COnUpgradeTutorialCompleted_003Eb__68_0(ModItemSlotView m)
		{
			return default(bool);
		}

		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x929B28", Offset = "0x929B28", VA = "0x929B28")]
		internal bool _003COnModTutorialCompleted_003Eb__69_0(PowerUpItemSlotView a)
		{
			return default(bool);
		}

		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x929BA0", Offset = "0x929BA0", VA = "0x929BA0")]
		internal bool _003CGetFirstWeaponWithParts_003Eb__71_0(WeaponUnlockable.RequiredPartInfo rpi)
		{
			return default(bool);
		}

		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x929CD4", Offset = "0x929CD4", VA = "0x929CD4")]
		internal WeaponUnlockable _003CGetFirstWeaponWithParts_003Eb__71_1(BlueprintItemView b)
		{
			return null;
		}

		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x929CEC", Offset = "0x929CEC", VA = "0x929CEC")]
		internal bool _003COnSecondTutorialWeaponCentered_003Eb__73_0(BlueprintPartIconView p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595CC8", Offset = "0x595CC8")]
	private sealed class _003CLoadBlueprintsAfterProfileInit_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002782")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002783")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002784")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintView _003C_003E4__this;

		[Token(Token = "0x170005FB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E42")]
			[Address(RVA = "0x92AE54", Offset = "0x92AE54", VA = "0x92AE54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E44")]
			[Address(RVA = "0x92AE9C", Offset = "0x92AE9C", VA = "0x92AE9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x92ABEC", Offset = "0x92ABEC", VA = "0x92ABEC")]
		[DebuggerHidden]
		public _003CLoadBlueprintsAfterProfileInit_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x92AC18", Offset = "0x92AC18", VA = "0x92AC18", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x92AC1C", Offset = "0x92AC1C", VA = "0x92AC1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x92AE5C", Offset = "0x92AE5C", VA = "0x92AE5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595CD8", Offset = "0x595CD8")]
	private sealed class _003CLoadBlueprints_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002785")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002786")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintView _003C_003E4__this;

		[Token(Token = "0x170005FD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E48")]
			[Address(RVA = "0x92AB9C", Offset = "0x92AB9C", VA = "0x92AB9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x92ABE4", Offset = "0x92ABE4", VA = "0x92ABE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x92A800", Offset = "0x92A800", VA = "0x92A800")]
		[DebuggerHidden]
		public _003CLoadBlueprints_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x92A82C", Offset = "0x92A82C", VA = "0x92A82C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x92A830", Offset = "0x92A830", VA = "0x92A830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x92ABA4", Offset = "0x92ABA4", VA = "0x92ABA4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595CE8", Offset = "0x595CE8")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x10")]
		public LazyWeaponUnlockable lazyWeapon;

		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x929E04", Offset = "0x929E04", VA = "0x929E04")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x929E0C", Offset = "0x929E0C", VA = "0x929E0C")]
		internal bool _003CCreateBlueprintItem_003Eb__0(LazyWeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595CF8", Offset = "0x595CF8")]
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x10")]
		public WeaponUnlockable weaponUnlockable;

		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x929E68", Offset = "0x929E68", VA = "0x929E68")]
		public _003C_003Ec__DisplayClass53_0()
		{
		}

		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x929E70", Offset = "0x929E70", VA = "0x929E70")]
		internal bool _003CGetRealBlueprintIndex_003Eb__0(BlueprintItemView b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D08", Offset = "0x595D08")]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x10")]
		public Action onFinished;

		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x18")]
		public BlueprintView _003C_003E4__this;

		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x20")]
		public int blueprintIndex;

		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x28")]
		public SpringPanel springPanel;

		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x30")]
		public SpringPanel.OnFinished onSpringPanelFinished;

		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x929EF4", Offset = "0x929EF4", VA = "0x929EF4")]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x929EFC", Offset = "0x929EFC", VA = "0x929EFC")]
		internal void _003CScrollToWeapon_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20006F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D18", Offset = "0x595D18")]
	private sealed class _003C_003Ec__DisplayClass57_1
	{
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x10")]
		public EventHandler<EventArgs> onFadingOutDoneGoToWeapon;

		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002E51")]
		[Address(RVA = "0x929F80", Offset = "0x929F80", VA = "0x929F80")]
		public _003C_003Ec__DisplayClass57_1()
		{
		}

		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x929F88", Offset = "0x929F88", VA = "0x929F88")]
		internal void _003CScrollToWeapon_003Eb__1(object s, EventArgs a)
		{
		}
	}

	[Token(Token = "0x20006F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D28", Offset = "0x595D28")]
	private sealed class _003CHighlightUpgradeButton_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintView _003C_003E4__this;

		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x28")]
		private BlueprintItemView _003Cview_003E5__2;

		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x170005FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E56")]
			[Address(RVA = "0x92A7B0", Offset = "0x92A7B0", VA = "0x92A7B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000600")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E58")]
			[Address(RVA = "0x92A7F8", Offset = "0x92A7F8", VA = "0x92A7F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x92A2F4", Offset = "0x92A2F4", VA = "0x92A2F4")]
		[DebuggerHidden]
		public _003CHighlightUpgradeButton_003Ed__66(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E54")]
		[Address(RVA = "0x92A320", Offset = "0x92A320", VA = "0x92A320", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x92A324", Offset = "0x92A324", VA = "0x92A324", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x92A7B8", Offset = "0x92A7B8", VA = "0x92A7B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D38", Offset = "0x595D38")]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0x10")]
		public NavigationBarItem contractNavBar;

		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x18")]
		public EventHandler<ButtonHandler.ButtonHandlerEventArgs> fadeTooltipFunction;

		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x929FEC", Offset = "0x929FEC", VA = "0x929FEC")]
		public _003C_003Ec__DisplayClass70_0()
		{
		}

		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x929FF4", Offset = "0x929FF4", VA = "0x929FF4")]
		internal void _003COnAbilityTutorialCompleted_003Eb__0(object s, ButtonHandler.ButtonHandlerEventArgs a)
		{
		}
	}

	[Token(Token = "0x20006F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D48", Offset = "0x595D48")]
	private sealed class _003C_003Ec__DisplayClass71_0
	{
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x10")]
		public Func<WeaponUnlockable.RequiredPartInfo, bool> hasCollectedAtLeastAPart;

		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x92A090", Offset = "0x92A090", VA = "0x92A090")]
		public _003C_003Ec__DisplayClass71_0()
		{
		}

		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x92A098", Offset = "0x92A098", VA = "0x92A098")]
		internal bool _003CGetFirstWeaponWithParts_003Eb__2(WeaponUnlockable w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20006F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D58", Offset = "0x595D58")]
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		[Token(Token = "0x4002799")]
		[FieldOffset(Offset = "0x10")]
		public ButtonHandler button;

		[Token(Token = "0x400279A")]
		[FieldOffset(Offset = "0x18")]
		public BlueprintView _003C_003E4__this;

		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x92A140", Offset = "0x92A140", VA = "0x92A140")]
		public _003C_003Ec__DisplayClass73_0()
		{
		}

		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x92A148", Offset = "0x92A148", VA = "0x92A148")]
		internal void _003COnSecondTutorialWeaponCentered_003Eb__1()
		{
		}
	}

	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9A2C", Offset = "0x5B9A2C")]
	private static BlueprintView _003CInstance_003Ek__BackingField;

	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x98")]
	public UIGrid WeaponsGrid;

	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid WeaponNavDotGrid;

	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0xA8")]
	public UIDraggablePanel WeaponsPanel;

	[Token(Token = "0x4002769")]
	[FieldOffset(Offset = "0xB0")]
	public BlueprintItemView Unlockable_WeaponUI;

	[Token(Token = "0x400276A")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite ArrowLeft;

	[Token(Token = "0x400276B")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite ArrowRight;

	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0xC8")]
	public BlinkButtonHandler LeftArrow;

	[Token(Token = "0x400276D")]
	[FieldOffset(Offset = "0xD0")]
	public BlinkButtonHandler RightArrow;

	[Token(Token = "0x400276E")]
	[FieldOffset(Offset = "0xD8")]
	public Light KeyLight;

	[Token(Token = "0x400276F")]
	[FieldOffset(Offset = "0xE0")]
	public Light BackLight;

	[Token(Token = "0x4002770")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject NavDotPrefab;

	[NonSerialized]
	[Token(Token = "0x4002771")]
	[FieldOffset(Offset = "0xF0")]
	public bool HasUnseenMods;

	[NonSerialized]
	[Token(Token = "0x4002772")]
	[FieldOffset(Offset = "0xF1")]
	public bool HasUnseenPowerUps;

	[Token(Token = "0x4002773")]
	[FieldOffset(Offset = "0xF8")]
	private readonly List<WeaponUnlockable> _weapons;

	[Token(Token = "0x4002774")]
	[FieldOffset(Offset = "0x100")]
	private readonly List<BlueprintNavDotView> _navdots;

	[Token(Token = "0x4002775")]
	[FieldOffset(Offset = "0x108")]
	private bool _tickedOnce;

	[Token(Token = "0x4002776")]
	[FieldOffset(Offset = "0x10C")]
	private int _currentItemIdx;

	[Token(Token = "0x4002777")]
	[FieldOffset(Offset = "0x110")]
	private bool _armoryOpened;

	[Token(Token = "0x4002778")]
	[FieldOffset(Offset = "0x118")]
	private List<BlueprintItemView> _blueprintViews;

	[Token(Token = "0x170005F8")]
	public static BlueprintView Instance
	{
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0xA7791C", Offset = "0xA7791C", VA = "0xA7791C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6212C0", Offset = "0x6212C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0xA77968", Offset = "0xA77968", VA = "0xA77968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6212D0", Offset = "0x6212D0")]
		private set
		{
		}
	}

	[Token(Token = "0x170005F9")]
	public BlueprintItemView CurrentBlueprintItem
	{
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0xA779B8", Offset = "0xA779B8", VA = "0xA779B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FA")]
	public List<BlueprintItemView> BlueprintViews
	{
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0xA77A44", Offset = "0xA77A44", VA = "0xA77A44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E00")]
	[Address(RVA = "0xA77A4C", Offset = "0xA77A4C", VA = "0xA77A4C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002E01")]
	[Address(RVA = "0xA77C18", Offset = "0xA77C18", VA = "0xA77C18", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002E02")]
	[Address(RVA = "0xA77DA8", Offset = "0xA77DA8", VA = "0xA77DA8")]
	private void SetIsHidden()
	{
	}

	[Token(Token = "0x6002E03")]
	[Address(RVA = "0xA77FB0", Offset = "0xA77FB0", VA = "0xA77FB0")]
	private bool ValidateWeaponGridFunction(Transform t)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0xA78094", Offset = "0xA78094", VA = "0xA78094")]
	private bool ValidateNavDotGridFunction(Transform t)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E05")]
	[Address(RVA = "0xA7822C", Offset = "0xA7822C", VA = "0xA7822C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002E06")]
	[Address(RVA = "0xA78504", Offset = "0xA78504", VA = "0xA78504", Slot = "16")]
	public override void LoadView()
	{
	}

	[Token(Token = "0x6002E07")]
	[Address(RVA = "0xA786B0", Offset = "0xA786B0", VA = "0xA786B0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002E08")]
	[Address(RVA = "0xA78AAC", Offset = "0xA78AAC", VA = "0xA78AAC")]
	private int GetFeedbackCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002E09")]
	[Address(RVA = "0xA78CF4", Offset = "0xA78CF4", VA = "0xA78CF4")]
	public void RefreshOnSaleNavBarLabel()
	{
	}

	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0xA77B88", Offset = "0xA77B88", VA = "0xA77B88")]
	private void RegisterWeaponShopEvents()
	{
	}

	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0xA78A1C", Offset = "0xA78A1C", VA = "0xA78A1C")]
	private void UnregisterWeaponShopEvents()
	{
	}

	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0xA78F6C", Offset = "0xA78F6C", VA = "0xA78F6C")]
	private void OnOfferRefreshSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0xA78F70", Offset = "0xA78F70", VA = "0xA78F70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6212E0", Offset = "0x6212E0")]
	private IEnumerator LoadBlueprintsAfterProfileInit()
	{
		return null;
	}

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0xA78644", Offset = "0xA78644", VA = "0xA78644")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621340", Offset = "0x621340")]
	private IEnumerator LoadBlueprints()
	{
		return null;
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0xA78FDC", Offset = "0xA78FDC", VA = "0xA78FDC")]
	private void CreateBlueprintsFromTier(WeaponTier tier, PlayerProfileData profile)
	{
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0xA79070", Offset = "0xA79070", VA = "0xA79070")]
	private void CreateBlueprintItem(LazyWeaponUnlockable lazyWeapon, PlayerProfileData profile)
	{
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0xA79B44", Offset = "0xA79B44", VA = "0xA79B44", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0xA77E48", Offset = "0xA77E48", VA = "0xA77E48")]
	private void OnCurrentPageChanged(ModesModel.MenuPages menuPages)
	{
	}

	[Token(Token = "0x6002E13")]
	[Address(RVA = "0xA79C44", Offset = "0xA79C44", VA = "0xA79C44")]
	private void GoToSpecificWeapon(WeaponUnlockable weaponUnlockable)
	{
	}

	[Token(Token = "0x6002E14")]
	[Address(RVA = "0xA7942C", Offset = "0xA7942C", VA = "0xA7942C")]
	private BlueprintItemView CreateBlueprintItem(int idx, WeaponUnlockable unlockable)
	{
		return null;
	}

	[Token(Token = "0x6002E15")]
	[Address(RVA = "0xA79754", Offset = "0xA79754", VA = "0xA79754")]
	private BlueprintNavDotView CreateNavDot(int idx, WeaponUnlockable unlockable, BlueprintItemView blueprintItemView)
	{
		return null;
	}

	[Token(Token = "0x6002E16")]
	[Address(RVA = "0xA79F44", Offset = "0xA79F44", VA = "0xA79F44", Slot = "18")]
	public override void PageVisibilityChanged(bool active)
	{
	}

	[Token(Token = "0x6002E17")]
	[Address(RVA = "0xA79FE0", Offset = "0xA79FE0", VA = "0xA79FE0", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002E18")]
	[Address(RVA = "0xA7A360", Offset = "0xA7A360", VA = "0xA7A360")]
	private int GetPreviousPanel(int closestItemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6002E19")]
	[Address(RVA = "0xA7A3FC", Offset = "0xA7A3FC", VA = "0xA7A3FC")]
	private int GetNextPanel(int closestItemIndex, int blueprintMaxCount)
	{
		return default(int);
	}

	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0xA79DD8", Offset = "0xA79DD8", VA = "0xA79DD8")]
	private int GetRealBlueprintIndex(WeaponUnlockable weaponUnlockable)
	{
		return default(int);
	}

	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0xA7A4AC", Offset = "0xA7A4AC", VA = "0xA7A4AC")]
	private void UpdateArrows()
	{
	}

	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0xA7A5C4", Offset = "0xA7A5C4", VA = "0xA7A5C4")]
	public void OnEquippedWeaponChanged()
	{
	}

	[Token(Token = "0x6002E1D")]
	[Address(RVA = "0xA7A6E4", Offset = "0xA7A6E4", VA = "0xA7A6E4")]
	public void RefreshNavDotsUnlocked()
	{
	}

	[Token(Token = "0x6002E1E")]
	[Address(RVA = "0xA7A928", Offset = "0xA7A928", VA = "0xA7A928")]
	public void ScrollToWeapon(WeaponUnlockable weapon, bool changePage, bool doBeforeFade, Action onFinished, bool doWithoutSpring = false)
	{
	}

	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0xA7ACFC", Offset = "0xA7ACFC", VA = "0xA7ACFC")]
	private void GoToBlueprintIndex(ref SpringPanel springPanel, int blueprintIndex, SpringPanel.OnFinished onFinished)
	{
	}

	[Token(Token = "0x6002E20")]
	[Address(RVA = "0xA7ADD0", Offset = "0xA7ADD0", VA = "0xA7ADD0")]
	public WeaponUnlockable FirstNewlyCompletedWeapon()
	{
		return null;
	}

	[Token(Token = "0x6002E21")]
	[Address(RVA = "0xA7AF4C", Offset = "0xA7AF4C", VA = "0xA7AF4C")]
	private bool HasIntelForAttachment(List<RogueData> rogues, int attachmentIntel)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E22")]
	[Address(RVA = "0xA7B0B8", Offset = "0xA7B0B8", VA = "0xA7B0B8")]
	private bool ModIsAvailable(int unlockableIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E23")]
	[Address(RVA = "0xA7B1C8", Offset = "0xA7B1C8", VA = "0xA7B1C8")]
	private bool AbilityIsAvailable(int unlockableIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E24")]
	[Address(RVA = "0xA7B2D8", Offset = "0xA7B2D8", VA = "0xA7B2D8")]
	public void UpdateNewModsFeedback()
	{
	}

	[Token(Token = "0x6002E25")]
	[Address(RVA = "0xA7B3F8", Offset = "0xA7B3F8", VA = "0xA7B3F8")]
	public void UpdateNewPowerUpsFeedback()
	{
	}

	[Token(Token = "0x6002E26")]
	[Address(RVA = "0xA7B600", Offset = "0xA7B600", VA = "0xA7B600")]
	public void OnFirstArmoryTutorialStart(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E27")]
	[Address(RVA = "0xA7B6C8", Offset = "0xA7B6C8", VA = "0xA7B6C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6213A0", Offset = "0x6213A0")]
	private IEnumerator HighlightUpgradeButton()
	{
		return null;
	}

	[Token(Token = "0x6002E28")]
	[Address(RVA = "0xA7B734", Offset = "0xA7B734", VA = "0xA7B734")]
	private void DisableButtonCollider(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002E29")]
	[Address(RVA = "0xA7B914", Offset = "0xA7B914", VA = "0xA7B914")]
	private void OnUpgradeTutorialCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0xA7BD24", Offset = "0xA7BD24", VA = "0xA7BD24")]
	private void OnModTutorialCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0xA7C1D4", Offset = "0xA7C1D4", VA = "0xA7C1D4")]
	private void OnAbilityTutorialCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0xA7C6C4", Offset = "0xA7C6C4", VA = "0xA7C6C4")]
	private WeaponUnlockable GetFirstWeaponWithParts()
	{
		return null;
	}

	[Token(Token = "0x6002E2D")]
	[Address(RVA = "0xA7C948", Offset = "0xA7C948", VA = "0xA7C948")]
	public void OnSecondArmoryTutorialStart(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E2E")]
	[Address(RVA = "0xA7CB24", Offset = "0xA7CB24", VA = "0xA7CB24")]
	private void OnSecondTutorialWeaponCentered()
	{
	}

	[Token(Token = "0x6002E2F")]
	[Address(RVA = "0xA7CE2C", Offset = "0xA7CE2C", VA = "0xA7CE2C")]
	private void OnPartCollectedTutorialCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E30")]
	[Address(RVA = "0xA7D258", Offset = "0xA7D258", VA = "0xA7D258")]
	private void OnCollectAllPartsTutorialCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002E31")]
	[Address(RVA = "0xA7D4B8", Offset = "0xA7D4B8", VA = "0xA7D4B8")]
	public void MoveRight(object sender, ButtonHandler.ButtonHandlerEventArgs buttonBlinkFinishedHandlerEventArgs)
	{
	}

	[Token(Token = "0x6002E32")]
	[Address(RVA = "0xA7D6BC", Offset = "0xA7D6BC", VA = "0xA7D6BC")]
	public void MoveLeft(object sender, ButtonHandler.ButtonHandlerEventArgs buttonBlinkFinishedHandlerEventArgs)
	{
	}

	[Token(Token = "0x6002E33")]
	[Address(RVA = "0xA7D8B4", Offset = "0xA7D8B4", VA = "0xA7D8B4")]
	public void RefreshUnlockedState(int weaponIdx)
	{
	}

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0xA7DA04", Offset = "0xA7DA04", VA = "0xA7DA04")]
	public BlueprintView()
	{
	}
}
