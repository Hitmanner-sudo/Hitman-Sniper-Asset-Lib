using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Core.Auth;
using Technology.Core.Persistence;
using Technology.Shop;

[Token(Token = "0x2000282")]
[Scope]
[AllowFindObjectOfType]
public class SaveGameManager : GameSingleton<SaveGameManager>, ISaveable
{
	[Serializable]
	[Token(Token = "0x2000283")]
	public class TierIndexByLeaderboardID : ISaveable
	{
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B39C4", Offset = "0x5B39C4")]
		public int TierIndex;

		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B39D4", Offset = "0x5B39D4")]
		public int LeaderboardID;

		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x8B6574", Offset = "0x8B6574", VA = "0x8B6574", Slot = "6")]
		public virtual void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x8B65FC", Offset = "0x8B65FC", VA = "0x8B65FC", Slot = "7")]
		public virtual JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x8B6674", Offset = "0x8B6674", VA = "0x8B6674")]
		public TierIndexByLeaderboardID()
		{
		}
	}

	[Token(Token = "0x2000284")]
	[Flags]
	public enum SaveGameFlags
	{
		[Token(Token = "0x4000E0B")]
		None = 0,
		[Token(Token = "0x4000E0C")]
		DEPRECATED_MuteAudio = 1,
		[Token(Token = "0x4000E0D")]
		LeftHandedControls = 2,
		[Token(Token = "0x4000E0E")]
		ButtonToShoot = 3,
		[Token(Token = "0x4000E0F")]
		LoggedIntoFacebook = 4,
		[Token(Token = "0x4000E10")]
		LoggedIntoFirstPartySocial = 5,
		[Token(Token = "0x4000E11")]
		ArmouryBlueprintsCompletedTutorialShowed = 6,
		[Token(Token = "0x4000E12")]
		FirstArmoryTutorialDone = 7,
		[Token(Token = "0x4000E13")]
		SecondArmoryTutorialDone = 8,
		[Token(Token = "0x4000E14")]
		FirstTargetTutorialDone = 9,
		[Token(Token = "0x4000E15")]
		DEPRECATED_NewTargetUnlockedTutorialShowed = 0xA,
		[Token(Token = "0x4000E16")]
		DEPRECATED_SkipMissionTutorialShowed = 0xB,
		[Token(Token = "0x4000E17")]
		SideMissionTutorialShowed = 0xC,
		[Token(Token = "0x4000E18")]
		ContractScreenDianaVOTutorialShowed = 0xD,
		[Token(Token = "0x4000E19")]
		ContractScreenTargetTutorialShowed = 0xE,
		[Token(Token = "0x4000E1A")]
		TutorialInGameLookAroundDone = 0xF,
		[Token(Token = "0x4000E1B")]
		TutorialInGameEnterScopeDone = 0x10,
		[Token(Token = "0x4000E1C")]
		TutorialInGameZoomInAndOutDone = 0x11,
		[Token(Token = "0x4000E1D")]
		TutorialInGameFindAndIdentifyTheMarkDone = 0x12,
		[Token(Token = "0x4000E1E")]
		TutorialInGameAlignTargetAndShootDone = 0x13,
		[Token(Token = "0x4000E1F")]
		TutorialInGameHoldBreathDone = 0x14,
		[Token(Token = "0x4000E20")]
		TutorialInGameReloadDone = 0x15,
		[Token(Token = "0x4000E21")]
		TutorialInGameCenterOnTagDone = 0x16,
		[Token(Token = "0x4000E22")]
		TutorialInGameMaxTagsDone = 0x17,
		[Token(Token = "0x4000E23")]
		TutorialInGameRivalScoreDone = 0x18,
		[Token(Token = "0x4000E24")]
		TutorialInGamePowerUpDone = 0x19,
		[Token(Token = "0x4000E25")]
		TutorialInGameFindAndIdentifyNewTargetDone = 0x1A,
		[Token(Token = "0x4000E26")]
		GoreOff = 0x1B,
		[Token(Token = "0x4000E27")]
		TutorialInGameKillingTheMarkDone = 0x1C,
		[Token(Token = "0x4000E28")]
		TutorialInGameIncreaseScoreExtractionDone = 0x1D,
		[Token(Token = "0x4000E29")]
		HasEverLoggedIntoFacebook = 0x1E,
		[Token(Token = "0x4000E2A")]
		DEPRECATED_FacebookIncentiveATutorialDone = 0x1F,
		[Token(Token = "0x4000E2B")]
		DEPRECATED_FacebookIncentiveBTutorialDone = 0x20,
		[Token(Token = "0x4000E2C")]
		DEPRECATED_BundlePromptTutorialDone = 0x21,
		[Token(Token = "0x4000E2D")]
		PlayerProfileUpdated = 0x22,
		[Token(Token = "0x4000E2E")]
		CloudSyncActivated = 0x23,
		[Token(Token = "0x4000E2F")]
		LastCloudSyncFailed = 0x24,
		[Token(Token = "0x4000E30")]
		ContractScreenTutorialDone = 0x25,
		[Token(Token = "0x4000E31")]
		FirstBlueprintUnlockedTutorialDone = 0x26,
		[Token(Token = "0x4000E32")]
		ShownContractFinishedPopup = 0x27,
		[Token(Token = "0x4000E33")]
		DEPRECATED_EveryplayRecordingDisabled = 0x28,
		[Token(Token = "0x4000E34")]
		InvertAxis = 0x29,
		[Token(Token = "0x4000E35")]
		DEPRECATED_AllIntelUnlocked = 0x2A,
		[Token(Token = "0x4000E36")]
		ZombieInvasionTankSpawned = 0x2B,
		[Token(Token = "0x4000E37")]
		ZombieInvasionHunterSpawned = 0x2C,
		[Token(Token = "0x4000E38")]
		ZombieInvasionScreamerSpawned = 0x2D,
		[Token(Token = "0x4000E39")]
		DEPRECATED_ChristmasWeaponPopupShown = 0x2E,
		[Token(Token = "0x4000E3A")]
		FPSSamplingDone = 0x2F,
		[Token(Token = "0x4000E3B")]
		TutorialInGameFindAndKillAZombieDone = 0x30,
		[Token(Token = "0x4000E3C")]
		TutorialInGameFindTheSurvivorDone = 0x31,
		[Token(Token = "0x4000E3D")]
		TutorialInGameOpenYourShopDone = 0x32,
		[Token(Token = "0x4000E3E")]
		TutorialInGameProtectTheSurvivorDone = 0x33,
		[Token(Token = "0x4000E3F")]
		ChallengeModeUnlockedTutorialDone = 0x34,
		[Token(Token = "0x4000E40")]
		ChallengeHardModeUnlocked = 0x35,
		[Token(Token = "0x4000E41")]
		ChallengeExpertModeUnlocked = 0x36,
		[Token(Token = "0x4000E42")]
		DEPRECATED_HalfPricePerkUnlocked = 0x37,
		[Token(Token = "0x4000E43")]
		ChallengePageSeen = 0x38,
		[Token(Token = "0x4000E44")]
		FacebookPageVisited = 0x39,
		[Token(Token = "0x4000E45")]
		ShownTutorialMissionsDonePopup = 0x3A,
		[Token(Token = "0x4000E46")]
		TutorialInGameMiniObjectivesDone = 0x3B,
		[Token(Token = "0x4000E47")]
		TutorialInGamePowerUpDeadeyeDone = 0x3C,
		[Token(Token = "0x4000E48")]
		CanGoreBeSetByPlayer = 0x3D,
		[Token(Token = "0x4000E49")]
		ReligiousObjectsOff = 0x3E,
		[Token(Token = "0x4000E4A")]
		BodyBagsOff = 0x3F
	}

	[Token(Token = "0x2000285")]
	public enum MainStatus
	{
		[Token(Token = "0x4000E4C")]
		None = 0,
		[Token(Token = "0x4000E4D")]
		Reconciling = 1,
		[Token(Token = "0x4000E4E")]
		Ready = 2
	}

	[Token(Token = "0x2000286")]
	private enum SubStatus
	{
		[Token(Token = "0x4000E50")]
		None = 0,
		[Token(Token = "0x4000E51")]
		Starting = 1,
		[Token(Token = "0x4000E52")]
		LocalLoadInProgress = 2,
		[Token(Token = "0x4000E53")]
		ConnectingToSquareEnix = 3,
		[Token(Token = "0x4000E54")]
		GettingServerTime = 4,
		[Token(Token = "0x4000E55")]
		OnlineLoadInProgress = 5,
		[Token(Token = "0x4000E56")]
		OnlineSaveInProgress = 6,
		[Token(Token = "0x4000E57")]
		Ready = 7
	}

	[Token(Token = "0x2000287")]
	public enum ReconcileResult
	{
		[Token(Token = "0x4000E59")]
		None = 0,
		[Token(Token = "0x4000E5A")]
		Success_Continue = 1,
		[Token(Token = "0x4000E5B")]
		Success_Replaced = 2,
		[Token(Token = "0x4000E5C")]
		Failure = 3
	}

	[Token(Token = "0x2000288")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592EF0", Offset = "0x592EF0")]
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x10")]
		public int leaderboardID;

		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x8B6020", Offset = "0x8B6020", VA = "0x8B6020")]
		public _003C_003Ec__DisplayClass82_0()
		{
		}

		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x8B6028", Offset = "0x8B6028", VA = "0x8B6028")]
		internal bool _003CGetTierIndex_003Eb__0(TierIndexByLeaderboardID x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000289")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F00", Offset = "0x592F00")]
	private sealed class _003C_003Ec__DisplayClass83_0
	{
		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x10")]
		public int leadeboardID;

		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x8B604C", Offset = "0x8B604C", VA = "0x8B604C")]
		public _003C_003Ec__DisplayClass83_0()
		{
		}

		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x8B6054", Offset = "0x8B6054", VA = "0x8B6054")]
		internal bool _003CSaveTierIndex_003Eb__0(TierIndexByLeaderboardID x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200028A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F10", Offset = "0x592F10")]
	private sealed class _003CStopReconcileAfterTime_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x20")]
		public int seconds;

		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x28")]
		public SaveGameManager _003C_003E4__this;

		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cstart_003E5__2;

		[Token(Token = "0x17000260")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x8B6524", Offset = "0x8B6524", VA = "0x8B6524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000261")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x8B656C", Offset = "0x8B656C", VA = "0x8B656C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x8B635C", Offset = "0x8B635C", VA = "0x8B635C")]
		[DebuggerHidden]
		public _003CStopReconcileAfterTime_003Ed__91(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x8B6388", Offset = "0x8B6388", VA = "0x8B6388", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x8B638C", Offset = "0x8B638C", VA = "0x8B638C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x8B652C", Offset = "0x8B652C", VA = "0x8B652C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200028B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F20", Offset = "0x592F20")]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x10")]
		public EventHandler<ShopEvent> onShopPreviousRefresh;

		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x18")]
		public SaveGameManager _003C_003E4__this;

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x8B6078", Offset = "0x8B6078", VA = "0x8B6078")]
		public _003C_003Ec__DisplayClass98_0()
		{
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x8B6080", Offset = "0x8B6080", VA = "0x8B6080")]
		internal void _003COverwriteWithOnlineSave_003Eb__0(object sender, ShopEvent e)
		{
		}
	}

	[Token(Token = "0x200028C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F30", Offset = "0x592F30")]
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x10")]
		public EventHandler<ShopEvent> onShopPreviousRefresh;

		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x18")]
		public SaveGameManager _003C_003E4__this;

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x8B6248", Offset = "0x8B6248", VA = "0x8B6248")]
		public _003C_003Ec__DisplayClass99_0()
		{
		}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x8B6250", Offset = "0x8B6250", VA = "0x8B6250")]
		internal void _003CReload_003Eb__0(object sender, ShopEvent e)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200028D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F40", Offset = "0x592F40")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x8B6018", Offset = "0x8B6018", VA = "0x8B6018")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SAVE_NAME;

	[Token(Token = "0x4000DE9")]
	private const string STARTER_PACK_INFO_PERSISTENCE_KEY = "StarterPackInfo";

	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string AVAILABLE_CONTRACTS_FIELD_NAME;

	[Token(Token = "0x4000DEB")]
	private const string ONLINE_TOTAL_GAME_TIME_PREF_NAME = "OnlineTotalGameTimePref";

	[Token(Token = "0x4000DEC")]
	private const string TOTAL_GAME_TIME_PREF_NAME = "TotalGameTimePref";

	[Token(Token = "0x4000DED")]
	private const string FIRST_LAUNCH_DONE = "FirstLaunchDone";

	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x28")]
	public static bool ForceNoAwakeStart;

	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B38B4", Offset = "0x5B38B4")]
	public long SaveGameFlagValue;

	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B38C4", Offset = "0x5B38C4")]
	public ContractData[] AvailableContracts;

	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B38D4", Offset = "0x5B38D4")]
	public PlayerProfileData PlayerProfile;

	[NonSerialized]
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B38E4", Offset = "0x5B38E4")]
	public float SFXVolume;

	[NonSerialized]
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B38F4", Offset = "0x5B38F4")]
	public float MusicVolume;

	[NonSerialized]
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3904", Offset = "0x5B3904")]
	public long BasedOnTimeStamp;

	[NonSerialized]
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3914", Offset = "0x5B3914")]
	public int MissionSkipCount;

	[NonSerialized]
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3924", Offset = "0x5B3924")]
	public TierIndexByLeaderboardID[] TierIndexByLeaderboardIDList;

	[NonSerialized]
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3934", Offset = "0x5B3934")]
	public string[] FriendsSID;

	[NonSerialized]
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3944", Offset = "0x5B3944")]
	public long HideEventVisualDate;

	[NonSerialized]
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3954", Offset = "0x5B3954")]
	public long ChristmasWeaponPopupLastSeenDate;

	[NonSerialized]
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3964", Offset = "0x5B3964")]
	public long HalloweenWeaponPopupLastSeenDate;

	[NonSerialized]
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3974", Offset = "0x5B3974")]
	public long ChineseNewYearWeaponPopupLastSeenDate;

	[NonSerialized]
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3984", Offset = "0x5B3984")]
	public long GoldenWeekWeaponPopupLastSeenDate;

	[NonSerialized]
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B3994", Offset = "0x5B3994")]
	public long FourthJulyWeaponPopupLastSeenDate;

	[NonSerialized]
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B39A4", Offset = "0x5B39A4")]
	public long SeasonalSalePopupNextValidDisplayDate;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B39B4", Offset = "0x5B39B4")]
	private bool _useAlternateBuyButton;

	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0xD0")]
	private StarterPackInfo _starterPackInfo;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0xD8")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0xE0")]
	private MainStatus _mainStatus;

	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0xE4")]
	private SubStatus _subStatus;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0xE8")]
	private bool _firstLoad;

	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0xF0")]
	private BlockingOnlineRequestManager.ReqHandle _onlineReqHandle;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0xF8")]
	private Action _reloadCallback;

	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x100")]
	private bool _loadMenuOnReplaced;

	[Token(Token = "0x17000258")]
	public MainStatus Status
	{
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xBA9D68", Offset = "0xBA9D68", VA = "0xBA9D68")]
		get
		{
			return default(MainStatus);
		}
	}

	[Token(Token = "0x17000259")]
	public StarterPackInfo CurrentStarterPackInfo
	{
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0xBA9D70", Offset = "0xBA9D70", VA = "0xBA9D70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0xBA9E18", Offset = "0xBA9E18", VA = "0xBA9E18")]
		set
		{
		}
	}

	[Token(Token = "0x1700025A")]
	public int OnlineTotalGameTime
	{
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0xBA9F14", Offset = "0xBA9F14", VA = "0xBA9F14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0xBA9F60", Offset = "0xBA9F60", VA = "0xBA9F60")]
		set
		{
		}
	}

	[Token(Token = "0x1700025B")]
	public int TotalGameTime
	{
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0xBA9FB8", Offset = "0xBA9FB8", VA = "0xBA9FB8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0xBAA004", Offset = "0xBAA004", VA = "0xBAA004")]
		set
		{
		}
	}

	[Token(Token = "0x1700025C")]
	public bool FirstLaunchDone
	{
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0xBAA05C", Offset = "0xBAA05C", VA = "0xBAA05C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0xBAA0A4", Offset = "0xBAA0A4", VA = "0xBAA0A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700025D")]
	public bool UseAlternateBuyButton
	{
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0xBAA0F8", Offset = "0xBAA0F8", VA = "0xBAA0F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0xBAA100", Offset = "0xBAA100", VA = "0xBAA100")]
		set
		{
		}
	}

	[Token(Token = "0x1700025E")]
	public bool LastCloudSyncFailed
	{
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0xBAABF8", Offset = "0xBAABF8", VA = "0xBAABF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0xBAAC08", Offset = "0xBAAC08", VA = "0xBAAC08")]
		private set
		{
		}
	}

	[Token(Token = "0x1700025F")]
	public bool IsCloudSyncActivated
	{
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0xBAAC28", Offset = "0xBAAC28", VA = "0xBAAC28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1400003A")]
	public static event EventHandler<EventArgs> OnLoadComplete
	{
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0xBA9660", Offset = "0xBA9660", VA = "0xBA9660")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615224", Offset = "0x615224")]
		add
		{
		}
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0xBA9754", Offset = "0xBA9754", VA = "0xBA9754")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615234", Offset = "0x615234")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003B")]
	public static event EventHandler OnLoadOrRecordEmptySaveDone
	{
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0xBA9848", Offset = "0xBA9848", VA = "0xBA9848")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615244", Offset = "0x615244")]
		add
		{
		}
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0xBA9940", Offset = "0xBA9940", VA = "0xBA9940")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615254", Offset = "0x615254")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003C")]
	public static event EventHandler<EventArgs> OnInitializationComplete
	{
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0xBA9A38", Offset = "0xBA9A38", VA = "0xBA9A38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615264", Offset = "0x615264")]
		add
		{
		}
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0xBA9B30", Offset = "0xBA9B30", VA = "0xBA9B30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615274", Offset = "0x615274")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003D")]
	public event Action OnStarterPackInfoChanged
	{
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0xBA9C28", Offset = "0xBA9C28", VA = "0xBA9C28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615284", Offset = "0x615284")]
		add
		{
		}
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0xBA9CC8", Offset = "0xBA9CC8", VA = "0xBA9CC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615294", Offset = "0x615294")]
		remove
		{
		}
	}

	[Token(Token = "0x6000F18")]
	[Address(RVA = "0xBAA10C", Offset = "0xBAA10C", VA = "0xBAA10C")]
	public bool IsSaveGameFlagSet(SaveGameFlags saveGameFlag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F19")]
	[Address(RVA = "0xBAA120", Offset = "0xBAA120", VA = "0xBAA120")]
	public void SetSaveGameFlag(SaveGameFlags saveGameFlag, bool done)
	{
	}

	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0xBAA140", Offset = "0xBAA140", VA = "0xBAA140", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0xBAA2E4", Offset = "0xBAA2E4", VA = "0xBAA2E4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0xBAA70C", Offset = "0xBAA70C", VA = "0xBAA70C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0xBAA988", Offset = "0xBAA988", VA = "0xBAA988")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0xBAAAD8", Offset = "0xBAAAD8", VA = "0xBAAAD8")]
	public void ResetData()
	{
	}

	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0xBAABD8", Offset = "0xBAABD8", VA = "0xBAABD8")]
	public bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F20")]
	[Address(RVA = "0xBAABE8", Offset = "0xBAABE8", VA = "0xBAABE8")]
	public bool IsReconcileInProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F21")]
	[Address(RVA = "0xBAAAC8", Offset = "0xBAAAC8", VA = "0xBAAAC8")]
	private bool IsFirstLocalLoadDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F25")]
	[Address(RVA = "0xBAAC30", Offset = "0xBAAC30", VA = "0xBAAC30")]
	public bool IsNewSaveGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F26")]
	[Address(RVA = "0xBAACD0", Offset = "0xBAACD0", VA = "0xBAACD0")]
	public int GetTierIndex(int leaderboardID)
	{
		return default(int);
	}

	[Token(Token = "0x6000F27")]
	[Address(RVA = "0xBAADD4", Offset = "0xBAADD4", VA = "0xBAADD4")]
	public void SaveTierIndex(int leadeboardID, int tierIndex)
	{
	}

	[Token(Token = "0x6000F28")]
	[Address(RVA = "0xBAA484", Offset = "0xBAA484", VA = "0xBAA484")]
	private void StartInitialLoadAndOnlineSetup()
	{
	}

	[Token(Token = "0x6000F29")]
	[Address(RVA = "0xBAB190", Offset = "0xBAB190", VA = "0xBAB190")]
	public void Save()
	{
	}

	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0xBAB274", Offset = "0xBAB274", VA = "0xBAB274")]
	public void ForceSave()
	{
	}

	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0xBAB364", Offset = "0xBAB364", VA = "0xBAB364")]
	private void PushLastSaveOnline()
	{
	}

	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0xBAB46C", Offset = "0xBAB46C", VA = "0xBAB46C")]
	private void LoadFromCloud()
	{
	}

	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0xBAAFB8", Offset = "0xBAAFB8", VA = "0xBAAFB8")]
	private void Load()
	{
	}

	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0xBAB590", Offset = "0xBAB590", VA = "0xBAB590")]
	public void ReconcileOnline(bool showWaitPopupImmediately, bool loadMenuOnReplaced = true)
	{
	}

	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0xBAB8A4", Offset = "0xBAB8A4", VA = "0xBAB8A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6152A4", Offset = "0x6152A4")]
	private IEnumerator StopReconcileAfterTime(int seconds)
	{
		return null;
	}

	[Token(Token = "0x6000F30")]
	[Address(RVA = "0xBAB920", Offset = "0xBAB920", VA = "0xBAB920")]
	private void OnOnlineLoadSaveSuccess(object sender, PersistenceLoadingEvent persistenceLoadingEvent)
	{
	}

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0xBABCFC", Offset = "0xBABCFC", VA = "0xBABCFC")]
	private void OnOnlineLoadSaveFailure(object sender, PersistenceLoadingEvent persistenceLoadingEvent)
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0xBAC00C", Offset = "0xBAC00C", VA = "0xBAC00C")]
	private void ConnectToSquareEnix()
	{
	}

	[Token(Token = "0x6000F33")]
	[Address(RVA = "0xBAC130", Offset = "0xBAC130", VA = "0xBAC130")]
	private void FetchServerTime()
	{
	}

	[Token(Token = "0x6000F34")]
	[Address(RVA = "0xBAC280", Offset = "0xBAC280", VA = "0xBAC280")]
	private void ChooseBetweenLocalAndOnlinePersistenceData()
	{
	}

	[Token(Token = "0x6000F35")]
	[Address(RVA = "0xBAC734", Offset = "0xBAC734", VA = "0xBAC734")]
	private void CompleteReplaceSavegame()
	{
	}

	[Token(Token = "0x6000F36")]
	[Address(RVA = "0xBAC5D0", Offset = "0xBAC5D0", VA = "0xBAC5D0")]
	private void OverwriteWithOnlineSave(Action onDone)
	{
	}

	[Token(Token = "0x6000F37")]
	[Address(RVA = "0xBAC9EC", Offset = "0xBAC9EC", VA = "0xBAC9EC")]
	public void Reload(Action onDone, Action onBeforeShopRefresh)
	{
	}

	[Token(Token = "0x6000F38")]
	[Address(RVA = "0xBACCC0", Offset = "0xBACCC0", VA = "0xBACCC0")]
	private void OnShopReloadRefresh(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6000F39")]
	[Address(RVA = "0xBACDEC", Offset = "0xBACDEC", VA = "0xBACDEC")]
	private void ResetStatus()
	{
	}

	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0xBAC7D8", Offset = "0xBAC7D8", VA = "0xBAC7D8")]
	private void OnlineRequestDone(ReconcileResult result)
	{
	}

	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0xBACE00", Offset = "0xBACE00", VA = "0xBACE00")]
	public void AccountMergeReplaceWithLocal_Local()
	{
	}

	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0xBACF1C", Offset = "0xBACF1C", VA = "0xBACF1C")]
	public void AccountMergeReplaceWithLocal_PushSave()
	{
	}

	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0xBAD10C", Offset = "0xBAD10C", VA = "0xBAD10C")]
	public void AccountMergeReplaceWithOnline(Action onDone)
	{
	}

	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0xBAD110", Offset = "0xBAD110", VA = "0xBAD110")]
	public static void GetIndexOfCurrentMission(JSONNode data, int availableContractsIndex, out int chapterIndex, out int missionIndex)
	{
	}

	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0xBAD2B8", Offset = "0xBAD2B8", VA = "0xBAD2B8")]
	private void OnInitialSquareEnixConnection(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x6000F40")]
	[Address(RVA = "0xBAD374", Offset = "0xBAD374", VA = "0xBAD374")]
	private void OnSquareEnixMandatoryConnection(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x6000F41")]
	[Address(RVA = "0xBAD580", Offset = "0xBAD580", VA = "0xBAD580")]
	public void OnPostLoadGame(LoadSaveManager.PostLoadArgs args)
	{
	}

	[Token(Token = "0x6000F42")]
	[Address(RVA = "0xBAD63C", Offset = "0xBAD63C", VA = "0xBAD63C")]
	public JSONNode ConvertSavegame(JSONNode data, byte version)
	{
		return null;
	}

	[Token(Token = "0x6000F43")]
	[Address(RVA = "0xBADA88", Offset = "0xBADA88", VA = "0xBADA88")]
	private JSONNode FailToConvertSaveGame(JSONNode data)
	{
		return null;
	}

	[Token(Token = "0x6000F44")]
	[Address(RVA = "0xBAD8DC", Offset = "0xBAD8DC", VA = "0xBAD8DC")]
	private JSONNode ConvertVersion3To4(JSONNode data)
	{
		return null;
	}

	[Token(Token = "0x6000F45")]
	[Address(RVA = "0xBADA90", Offset = "0xBADA90", VA = "0xBADA90")]
	private static JSONArray AddEmptyWeaponDataAtIndex(JSONArray weaponUnlockableArray, int index)
	{
		return null;
	}

	[Token(Token = "0x6000F46")]
	[Address(RVA = "0xBADA14", Offset = "0xBADA14", VA = "0xBADA14")]
	private static JSONNode ConvertVersion4To5(JSONNode data)
	{
		return null;
	}

	[Token(Token = "0x6000F47")]
	[Address(RVA = "0xBADBB8", Offset = "0xBADBB8", VA = "0xBADBB8")]
	private static void ConvertLeaderboardTierIndex(ref JSONNode data)
	{
	}

	[Token(Token = "0x6000F48")]
	[Address(RVA = "0xBAD854", Offset = "0xBAD854", VA = "0xBAD854", Slot = "16")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6000F49")]
	[Address(RVA = "0xBADD8C", Offset = "0xBADD8C", VA = "0xBADD8C", Slot = "17")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0xBADE04", Offset = "0xBADE04", VA = "0xBADE04")]
	public void AddFriendSID(string sid)
	{
	}

	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0xBADEB0", Offset = "0xBADEB0", VA = "0xBADEB0")]
	public IEnumerable<string> GetFriends()
	{
		return null;
	}

	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0xBADF28", Offset = "0xBADF28", VA = "0xBADF28")]
	public SaveGameManager()
	{
	}

	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0xBAE208", Offset = "0xBAE208", VA = "0xBAE208")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615304", Offset = "0x615304")]
	private void _003CStartInitialLoadAndOnlineSetup_003Eb__84_0(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0xBAE20C", Offset = "0xBAE20C", VA = "0xBAE20C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615314", Offset = "0x615314")]
	private void _003CStartInitialLoadAndOnlineSetup_003Eb__84_1(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F50")]
	[Address(RVA = "0xBAE214", Offset = "0xBAE214", VA = "0xBAE214")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615324", Offset = "0x615324")]
	private void _003CReconcileOnline_003Eb__90_0(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F51")]
	[Address(RVA = "0xBAE218", Offset = "0xBAE218", VA = "0xBAE218")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615334", Offset = "0x615334")]
	private void _003CReconcileOnline_003Eb__90_1(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F52")]
	[Address(RVA = "0xBAE220", Offset = "0xBAE220", VA = "0xBAE220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615344", Offset = "0x615344")]
	private void _003CStopReconcileAfterTime_003Eb__91_0()
	{
	}

	[Token(Token = "0x6000F53")]
	[Address(RVA = "0xBAE228", Offset = "0xBAE228", VA = "0xBAE228")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615354", Offset = "0x615354")]
	private void _003COnOnlineLoadSaveSuccess_003Eb__92_0()
	{
	}

	[Token(Token = "0x6000F54")]
	[Address(RVA = "0xBAE230", Offset = "0xBAE230", VA = "0xBAE230")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615364", Offset = "0x615364")]
	private void _003COnOnlineLoadSaveFailure_003Eb__93_0()
	{
	}

	[Token(Token = "0x6000F55")]
	[Address(RVA = "0xBAE238", Offset = "0xBAE238", VA = "0xBAE238")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615374", Offset = "0x615374")]
	private void _003COnOnlineLoadSaveFailure_003Eb__93_1()
	{
	}

	[Token(Token = "0x6000F56")]
	[Address(RVA = "0xBAE240", Offset = "0xBAE240", VA = "0xBAE240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615384", Offset = "0x615384")]
	private void _003CFetchServerTime_003Eb__95_0(bool res)
	{
	}

	[Token(Token = "0x6000F57")]
	[Address(RVA = "0xBAE2C0", Offset = "0xBAE2C0", VA = "0xBAE2C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615394", Offset = "0x615394")]
	private void _003CFetchServerTime_003Eb__95_1()
	{
	}

	[Token(Token = "0x6000F58")]
	[Address(RVA = "0xBAE2C8", Offset = "0xBAE2C8", VA = "0xBAE2C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153A4", Offset = "0x6153A4")]
	private void _003CChooseBetweenLocalAndOnlinePersistenceData_003Eb__96_0()
	{
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0xBAE3D4", Offset = "0xBAE3D4", VA = "0xBAE3D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153B4", Offset = "0x6153B4")]
	private void _003CChooseBetweenLocalAndOnlinePersistenceData_003Eb__96_1()
	{
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0xBAE4A0", Offset = "0xBAE4A0", VA = "0xBAE4A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153C4", Offset = "0x6153C4")]
	private void _003CAccountMergeReplaceWithLocal_PushSave_003Eb__104_0(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0xBAE4A4", Offset = "0xBAE4A4", VA = "0xBAE4A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153D4", Offset = "0x6153D4")]
	private void _003CAccountMergeReplaceWithLocal_PushSave_003Eb__104_1(BlockingOnlineRequestManager.ReqHandle h)
	{
	}

	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0xBAE4AC", Offset = "0xBAE4AC", VA = "0xBAE4AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6153E4", Offset = "0x6153E4")]
	private void _003COnSquareEnixMandatoryConnection_003Eb__108_0()
	{
	}
}
