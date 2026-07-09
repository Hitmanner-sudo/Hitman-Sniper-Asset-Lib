using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x200064D")]
public class ContractInfoView : MainMenuPageView
{
	[Token(Token = "0x200064E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595748", Offset = "0x595748")]
	private sealed class _003CShowPopupsAfterDelay_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x28")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x40022F8")]
		[FieldOffset(Offset = "0x30")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x17000552")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x864C44", Offset = "0x864C44", VA = "0x864C44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000553")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x864C8C", Offset = "0x864C8C", VA = "0x864C8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x864710", Offset = "0x864710", VA = "0x864710")]
		[DebuggerHidden]
		public _003CShowPopupsAfterDelay_003Ed__57(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x86473C", Offset = "0x86473C", VA = "0x86473C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x864740", Offset = "0x864740", VA = "0x864740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x864C4C", Offset = "0x864C4C", VA = "0x864C4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200064F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595758", Offset = "0x595758")]
	private sealed class _003CDisplayTargetTooltip_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022FA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022FB")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		[Token(Token = "0x17000554")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x8646C0", Offset = "0x8646C0", VA = "0x8646C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000555")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x864708", Offset = "0x864708", VA = "0x864708", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002900")]
		[Address(RVA = "0x8644E4", Offset = "0x8644E4", VA = "0x8644E4")]
		[DebuggerHidden]
		public _003CDisplayTargetTooltip_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002901")]
		[Address(RVA = "0x864510", Offset = "0x864510", VA = "0x864510", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002902")]
		[Address(RVA = "0x864514", Offset = "0x864514", VA = "0x864514", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002904")]
		[Address(RVA = "0x8646C8", Offset = "0x8646C8", VA = "0x8646C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000650")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595768", Offset = "0x595768")]
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x10")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x18")]
		public LazyReferenceUsageWrapper<PlayerProgressionData> progressionDataWrapper;

		[Token(Token = "0x6002906")]
		[Address(RVA = "0x863DF4", Offset = "0x863DF4", VA = "0x863DF4")]
		public _003C_003Ec__DisplayClass62_0()
		{
		}

		[Token(Token = "0x6002907")]
		[Address(RVA = "0x863DFC", Offset = "0x863DFC", VA = "0x863DFC")]
		internal bool _003CCheckForProgressionLootbox_003Eb__0(LootBox lootBox)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000651")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595778", Offset = "0x595778")]
	private sealed class _003C_003Ec__DisplayClass62_1
	{
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x10")]
		public LootBoxDroppedItem[] items;

		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass62_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002908")]
		[Address(RVA = "0x863E6C", Offset = "0x863E6C", VA = "0x863E6C")]
		public _003C_003Ec__DisplayClass62_1()
		{
		}

		[Token(Token = "0x6002909")]
		[Address(RVA = "0x863E74", Offset = "0x863E74", VA = "0x863E74")]
		internal void _003CCheckForProgressionLootbox_003Eb__2()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000652")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595788", Offset = "0x595788")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LootBox, string> _003C_003E9__62_1;

		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LootBoxDroppedUnlockable, Unlockable> _003C_003E9__64_0;

		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x18")]
		public static Func<LootBoxDroppedUnlockable, Unlockable> _003C_003E9__64_1;

		[Token(Token = "0x600290B")]
		[Address(RVA = "0x863DA0", Offset = "0x863DA0", VA = "0x863DA0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600290C")]
		[Address(RVA = "0x863DA8", Offset = "0x863DA8", VA = "0x863DA8")]
		internal string _003CCheckForProgressionLootbox_003Eb__62_1(LootBox lootBox)
		{
			return null;
		}

		[Token(Token = "0x600290D")]
		[Address(RVA = "0x863DC4", Offset = "0x863DC4", VA = "0x863DC4")]
		internal Unlockable _003COnRankUpLootBoxCollected_003Eb__64_0(LootBoxDroppedUnlockable u)
		{
			return null;
		}

		[Token(Token = "0x600290E")]
		[Address(RVA = "0x863DDC", Offset = "0x863DDC", VA = "0x863DDC")]
		internal Unlockable _003COnRankUpLootBoxCollected_003Eb__64_1(LootBoxDroppedUnlockable u)
		{
			return null;
		}
	}

	[Token(Token = "0x2000653")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595798", Offset = "0x595798")]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardConfiguration leaderboardConfig;

		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x18")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x600290F")]
		[Address(RVA = "0x863EA4", Offset = "0x863EA4", VA = "0x863EA4")]
		public _003C_003Ec__DisplayClass63_0()
		{
		}

		[Token(Token = "0x6002910")]
		[Address(RVA = "0x863EAC", Offset = "0x863EAC", VA = "0x863EAC")]
		internal bool _003CCheckForLeaderboardLootbox_003Eb__0(LootBox box)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000654")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957A8", Offset = "0x5957A8")]
	private sealed class _003C_003Ec__DisplayClass63_1
	{
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x10")]
		public LootBoxDroppedItem[] items;

		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass63_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002911")]
		[Address(RVA = "0x863EC8", Offset = "0x863EC8", VA = "0x863EC8")]
		public _003C_003Ec__DisplayClass63_1()
		{
		}

		[Token(Token = "0x6002912")]
		[Address(RVA = "0x863ED0", Offset = "0x863ED0", VA = "0x863ED0")]
		internal void _003CCheckForLeaderboardLootbox_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000655")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957B8", Offset = "0x5957B8")]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		[Token(Token = "0x4002309")]
		[FieldOffset(Offset = "0x10")]
		public WeaponUnlockable unlockable;

		[Token(Token = "0x400230A")]
		[FieldOffset(Offset = "0x18")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x6002913")]
		[Address(RVA = "0x863F00", Offset = "0x863F00", VA = "0x863F00")]
		public _003C_003Ec__DisplayClass67_0()
		{
		}

		[Token(Token = "0x6002914")]
		[Address(RVA = "0x863F08", Offset = "0x863F08", VA = "0x863F08")]
		internal void _003CWeaponCancelCallback_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000656")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957C8", Offset = "0x5957C8")]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x400230B")]
		[FieldOffset(Offset = "0x10")]
		public WeaponUnlockable unlockable;

		[Token(Token = "0x400230C")]
		[FieldOffset(Offset = "0x18")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6002915")]
		[Address(RVA = "0x863FB4", Offset = "0x863FB4", VA = "0x863FB4")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6002916")]
		[Address(RVA = "0x863FBC", Offset = "0x863FBC", VA = "0x863FBC")]
		internal void _003CWeaponOkCallback_003Eb__0()
		{
		}

		[Token(Token = "0x6002917")]
		[Address(RVA = "0x8641B8", Offset = "0x8641B8", VA = "0x8641B8")]
		internal void _003CWeaponOkCallback_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000657")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5957D8", Offset = "0x5957D8")]
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x10")]
		public NavigationBarItem armoryNavBar;

		[Token(Token = "0x400230F")]
		[FieldOffset(Offset = "0x18")]
		public ContractInfoView _003C_003E4__this;

		[Token(Token = "0x6002918")]
		[Address(RVA = "0x8641C4", Offset = "0x8641C4", VA = "0x8641C4")]
		public _003C_003Ec__DisplayClass74_0()
		{
		}

		[Token(Token = "0x6002919")]
		[Address(RVA = "0x8641CC", Offset = "0x8641CC", VA = "0x8641CC")]
		internal void _003CShowArmoryTooltip_003Eb__0()
		{
		}

		[Token(Token = "0x600291A")]
		[Address(RVA = "0x8643A0", Offset = "0x8643A0", VA = "0x8643A0")]
		internal void _003CShowArmoryTooltip_003Eb__1(object o, ButtonHandler.ButtonHandlerEventArgs a)
		{
		}
	}

	[Token(Token = "0x40022D5")]
	private const float CONTRACT_TARGET_TOOLTIP_DURATION = 10f;

	[Token(Token = "0x40022D6")]
	private const float CONTRACT_TARGET_TOOLTIP_DELAY = 1f;

	[Token(Token = "0x40022D7")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8ABC", Offset = "0x5B8ABC")]
	private static ContractInfoView _003CInstance_003Ek__BackingField;

	[Token(Token = "0x40022DA")]
	[FieldOffset(Offset = "0x98")]
	public float PopupDelay;

	[Token(Token = "0x40022DB")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject StartButton;

	[Token(Token = "0x40022DC")]
	[FieldOffset(Offset = "0xA8")]
	public LeaderboardView LeaderboardPrefab;

	[Token(Token = "0x40022DD")]
	[FieldOffset(Offset = "0xB0")]
	public Transform LeaderboardHolder;

	[Token(Token = "0x40022DE")]
	[FieldOffset(Offset = "0xB8")]
	public ContractMissionInfoView MissionInfo;

	[Token(Token = "0x40022DF")]
	[FieldOffset(Offset = "0xC0")]
	public TutorialEntryPoint[] PossibleEntryPoints;

	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0xC8")]
	public Action OnPopupsFinished;

	[Token(Token = "0x40022E1")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private OfferReference _missionAutoCompleteOffer;

	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0xD8")]
	public PopupChallengeModeUnlocked PopupChallengeModeUnlockedPrefab;

	[Token(Token = "0x40022E3")]
	[FieldOffset(Offset = "0xE0")]
	public Collider BackgroundCollider;

	[Token(Token = "0x40022E4")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel DisplayEventVisualButtonUILabel;

	[Token(Token = "0x40022E5")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject FacebookLikeGO;

	[Token(Token = "0x40022E6")]
	[FieldOffset(Offset = "0xF8")]
	private Coroutine _showPopupCoroutine;

	[Token(Token = "0x40022E7")]
	[FieldOffset(Offset = "0x100")]
	private GameObject _leaderboard;

	[Token(Token = "0x40022E8")]
	[FieldOffset(Offset = "0x108")]
	private bool _tutorialsHaveBeenChecked;

	[Token(Token = "0x40022E9")]
	[FieldOffset(Offset = "0x109")]
	private bool _animsStopped;

	[Token(Token = "0x40022EA")]
	[FieldOffset(Offset = "0x10A")]
	private bool _animsCompleted;

	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x10B")]
	private bool _delayedExpired;

	[Token(Token = "0x40022EC")]
	[FieldOffset(Offset = "0x10C")]
	private bool _navbarSlideCompleted;

	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x10D")]
	private bool _isChallengeModeUnlockedTooltipUp;

	[Token(Token = "0x40022EE")]
	[FieldOffset(Offset = "0x110")]
	private CheckInboxItems _checkInboxItems;

	[Token(Token = "0x40022EF")]
	[FieldOffset(Offset = "0x118")]
	private float waitBeforeCheckEmail;

	[Token(Token = "0x40022F0")]
	[FieldOffset(Offset = "0x11C")]
	private float currentWait;

	[Token(Token = "0x40022F1")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private GameObject _suggestionWarning;

	[Token(Token = "0x40022F2")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private DailyRewardButtonView _dailyRewardCollectButton;

	[Token(Token = "0x40022F3")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private UIAlignedList _topRightButtons;

	[Token(Token = "0x17000550")]
	public static ContractInfoView Instance
	{
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x8E997C", Offset = "0x8E997C", VA = "0x8E997C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D958", Offset = "0x61D958")]
		get
		{
			return null;
		}
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x8E99C8", Offset = "0x8E99C8", VA = "0x8E99C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D968", Offset = "0x61D968")]
		private set
		{
		}
	}

	[Token(Token = "0x17000551")]
	public Offer MissionAutoCompleteOffer
	{
		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x8E9D18", Offset = "0x8E9D18", VA = "0x8E9D18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000096")]
	public static event EventHandler<EventArgs> OnContractAnimationsCompleted
	{
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x8E9A18", Offset = "0x8E9A18", VA = "0x8E9A18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D978", Offset = "0x61D978")]
		add
		{
		}
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x8E9AD8", Offset = "0x8E9AD8", VA = "0x8E9AD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D988", Offset = "0x61D988")]
		remove
		{
		}
	}

	[Token(Token = "0x14000097")]
	public static event EventHandler OnRankIncreaseClaimed
	{
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x8E9B98", Offset = "0x8E9B98", VA = "0x8E9B98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D998", Offset = "0x61D998")]
		add
		{
		}
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x8E9C58", Offset = "0x8E9C58", VA = "0x8E9C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D9A8", Offset = "0x61D9A8")]
		remove
		{
		}
	}

	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x8E9D34", Offset = "0x8E9D34", VA = "0x8E9D34", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x8EA278", Offset = "0x8EA278", VA = "0x8EA278")]
	private void CallbackAfterInboxUpdateSucceded()
	{
	}

	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x8EA4CC", Offset = "0x8EA4CC", VA = "0x8EA4CC")]
	private void CheackForInbox()
	{
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x8EA4E8", Offset = "0x8EA4E8", VA = "0x8EA4E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x8EA550", Offset = "0x8EA550", VA = "0x8EA550", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x8EA998", Offset = "0x8EA998", VA = "0x8EA998")]
	private void OnShowNavBarsChanged(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x8EAA38", Offset = "0x8EAA38", VA = "0x8EAA38", Slot = "15")]
	protected override void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x8EAA84", Offset = "0x8EAA84", VA = "0x8EAA84", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x8EAB6C", Offset = "0x8EAB6C", VA = "0x8EAB6C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x8EB0B0", Offset = "0x8EB0B0", VA = "0x8EB0B0")]
	private void OnFirstMenuCentered(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x8E8C04", Offset = "0x8E8C04", VA = "0x8E8C04")]
	public void CheckForFacebookLike()
	{
	}

	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x8EB5CC", Offset = "0x8EB5CC", VA = "0x8EB5CC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x8EA8F4", Offset = "0x8EA8F4", VA = "0x8EA8F4")]
	private void OnShowWeaponSuggestionChanged(bool visible)
	{
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x8EB868", Offset = "0x8EB868", VA = "0x8EB868")]
	private void OnNoNetworkError()
	{
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x8EBC68", Offset = "0x8EBC68", VA = "0x8EBC68")]
	private void OnAnimationsStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x8EBCA4", Offset = "0x8EBCA4", VA = "0x8EBCA4")]
	private void OnAnimationsStopped(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x8EBCB0", Offset = "0x8EBCB0", VA = "0x8EBCB0")]
	private void OnAnimationsCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x8EBE40", Offset = "0x8EBE40", VA = "0x8EBE40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D9B8", Offset = "0x61D9B8")]
	private IEnumerator ShowPopupsAfterDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x8EBF34", Offset = "0x8EBF34", VA = "0x8EBF34")]
	private void TryNotifyPopupsFinished()
	{
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x8EBEBC", Offset = "0x8EBEBC", VA = "0x8EBEBC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61DA18", Offset = "0x61DA18")]
	private IEnumerator DisplayTargetTooltip(float delay, float duration)
	{
		return null;
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x8EC0C8", Offset = "0x8EC0C8", VA = "0x8EC0C8")]
	public void CheckForUnlocks(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x8EA2B4", Offset = "0x8EA2B4", VA = "0x8EA2B4")]
	public void CheckForUnlocks()
	{
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x8EC0CC", Offset = "0x8EC0CC", VA = "0x8EC0CC")]
	private bool CheckForProgressionLootbox(IEnumerable<LootBox> lootBoxes)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x8EC6C0", Offset = "0x8EC6C0", VA = "0x8EC6C0")]
	private bool CheckForLeaderboardLootbox(ReadOnlyCollection<LootBox> lootBoxes)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x8ED020", Offset = "0x8ED020", VA = "0x8ED020")]
	private void OnRankUpLootBoxCollected(LootBoxDroppedItem[] droppedItems)
	{
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x8ED7D4", Offset = "0x8ED7D4", VA = "0x8ED7D4")]
	private bool CheckForTutorialsToShow()
	{
		return default(bool);
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x8EC9D0", Offset = "0x8EC9D0", VA = "0x8EC9D0")]
	private bool CheckForCompletedWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x8ED964", Offset = "0x8ED964", VA = "0x8ED964")]
	public Action WeaponCancelCallback(WeaponUnlockable unlockable)
	{
		return null;
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x8ED8AC", Offset = "0x8ED8AC", VA = "0x8ED8AC")]
	public Action WeaponOkCallback(WeaponUnlockable unlockable)
	{
		return null;
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x8ECF30", Offset = "0x8ECF30", VA = "0x8ECF30")]
	private static bool CheckForSpecialPopup()
	{
		return default(bool);
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x8EDA1C", Offset = "0x8EDA1C", VA = "0x8EDA1C")]
	private static void EquipWeapon(WeaponUnlockable unlockable)
	{
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x8EDB8C", Offset = "0x8EDB8C", VA = "0x8EDB8C")]
	private void FirstArmoryTutorialStart()
	{
	}

	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x8EDDC0", Offset = "0x8EDDC0", VA = "0x8EDDC0")]
	private void SecondArmoryTutorialStart()
	{
	}

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x8EDD10", Offset = "0x8EDD10", VA = "0x8EDD10")]
	private void ShowArmoryTooltip()
	{
	}

	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x8EDF44", Offset = "0x8EDF44", VA = "0x8EDF44")]
	private void ShowArmoryTooltip(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x8EE164", Offset = "0x8EE164", VA = "0x8EE164")]
	private void PrepareForTargetsTutorial()
	{
	}

	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x8ED5EC", Offset = "0x8ED5EC", VA = "0x8ED5EC")]
	private void FirstTargetTutorialStart()
	{
	}

	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x8EE1D8", Offset = "0x8EE1D8", VA = "0x8EE1D8")]
	private void FirstContractScreenTutorialStart()
	{
	}

	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x8EE324", Offset = "0x8EE324", VA = "0x8EE324")]
	private void ChallengeModeUnlockedTutorialStart()
	{
	}

	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x8EE6AC", Offset = "0x8EE6AC", VA = "0x8EE6AC")]
	private void OnChallengeModeUnlockedPopupClosed()
	{
	}

	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x8EBAF4", Offset = "0x8EBAF4", VA = "0x8EBAF4")]
	private void OnCurrentPageChanged()
	{
	}

	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x8EBB90", Offset = "0x8EBB90", VA = "0x8EBB90")]
	private void OnDisplayEventVisualChanged(bool display)
	{
	}

	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x8EBA48", Offset = "0x8EBA48", VA = "0x8EBA48")]
	private void UpdateDisplayStartButton()
	{
	}

	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x8EE7F0", Offset = "0x8EE7F0", VA = "0x8EE7F0")]
	public ContractInfoView()
	{
	}

	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x8EE808", Offset = "0x8EE808", VA = "0x8EE808")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61DA78", Offset = "0x61DA78")]
	private void _003COnNoNetworkError_003Eb__53_0()
	{
	}
}
