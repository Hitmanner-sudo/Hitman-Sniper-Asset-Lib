using System;
using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x20005A9")]
public class HUDModel : DataModel
{
	[Token(Token = "0x20005AA")]
	public enum PauseMenuState
	{
		[Token(Token = "0x4001E37")]
		Hidden = 0,
		[Token(Token = "0x4001E38")]
		DEPRECATED_Progress = 1,
		[Token(Token = "0x4001E39")]
		StartGameInfoOnly = 2,
		[Token(Token = "0x4001E3A")]
		Paused = 3,
		[Token(Token = "0x4001E3B")]
		GameResultInfoOnly = 4,
		[Token(Token = "0x4001E3C")]
		UpgradePageStart = 5,
		[Token(Token = "0x4001E3D")]
		UpgradePagePaused = 6
	}

	[Token(Token = "0x20005AB")]
	public enum SpecialAlertUIConfig
	{
		[Token(Token = "0x4001E3F")]
		NONE = -1,
		[Token(Token = "0x4001E40")]
		ZombieInvasion_tank = 0,
		[Token(Token = "0x4001E41")]
		ZombieInvasion_screamer = 1,
		[Token(Token = "0x4001E42")]
		ZombieInvasion_hunter = 2,
		[Token(Token = "0x4001E43")]
		BigWaveComing = 3,
		[Token(Token = "0x4001E44")]
		TruckRepairing = 4,
		[Token(Token = "0x4001E45")]
		TruckRepaired = 5,
		[Token(Token = "0x4001E46")]
		ProtecteeUnderAttack = 6,
		[Token(Token = "0x4001E47")]
		ProtecteeDie = 7,
		[Token(Token = "0x4001E48")]
		FinalWaveComing = 8,
		[Token(Token = "0x4001E49")]
		COUNT = 9
	}

	[Token(Token = "0x20005AC")]
	public class PowerUpUpgraded
	{
		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x18")]
		public int NewLevel;

		[Token(Token = "0x60023E4")]
		[Address(RVA = "0xB1EA68", Offset = "0xB1EA68", VA = "0xB1EA68")]
		public PowerUpUpgraded(string id, int newLevel)
		{
		}
	}

	[Token(Token = "0x4001DC4")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string IN_SCOPE_HUD_VIEW;

	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string OUT_SCOPE_HUD_VIEW;

	[Token(Token = "0x4001DC6")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ASSIGNMENT_MESSAGE_DISPLAY_TIME;

	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SCORE_TO_BEAT_DISPLAY_TIME;

	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string LEADERBOARD_REFRESH_INTERVAL;

	[Token(Token = "0x4001DC9")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string LEADERBOARD_MAX_REFRESH_COUNT;

	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string ALERT_LEVEL_DISPLAY_TIME;

	[Token(Token = "0x4001DCB")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ALERT_LEVEL_CONFIGS;

	[Token(Token = "0x4001DCC")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string SPECIAL_ALERT_CONFIGS;

	[Token(Token = "0x4001DCD")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string PAUSE_MENU_ENTER_DURATION;

	[Token(Token = "0x4001DCE")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string SHOW_INFO_DURATION;

	[Token(Token = "0x4001DCF")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string MIN_SHOW_INFO_DURATION;

	[Token(Token = "0x4001DD0")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string GAME_SCORE;

	[Token(Token = "0x4001DD1")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string IS_GAME_FINISHED;

	[Token(Token = "0x4001DD2")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string IS_CONTRACT_COMPLETED;

	[Token(Token = "0x4001DD3")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string IS_NEW_RECORD;

	[Token(Token = "0x4001DD4")]
	[FieldOffset(Offset = "0x80")]
	public static readonly string IN_TALLY_VIEW;

	[Token(Token = "0x4001DD5")]
	[FieldOffset(Offset = "0x88")]
	public static readonly string SCORE_DETAIL;

	[Token(Token = "0x4001DD6")]
	[FieldOffset(Offset = "0x90")]
	public static readonly string SHOW_SCORE_TO_BEAT;

	[Token(Token = "0x4001DD7")]
	[FieldOffset(Offset = "0x98")]
	public static readonly string SCORE_TO_BEAT;

	[Token(Token = "0x4001DD8")]
	[FieldOffset(Offset = "0xA0")]
	public static readonly string NEXT_SCORE_TO_BEAT;

	[Token(Token = "0x4001DD9")]
	[FieldOffset(Offset = "0xA8")]
	public static readonly string SHOW_RIVAL_SCORE_TOOLTIP;

	[Token(Token = "0x4001DDA")]
	[FieldOffset(Offset = "0xB0")]
	public static readonly string SET_RIVAL_SCORE_TOOLTIP_TEXT;

	[Token(Token = "0x4001DDB")]
	[FieldOffset(Offset = "0xB8")]
	public static readonly string SHOW_EXTRACTION_TOOLTIP;

	[Token(Token = "0x4001DDC")]
	[FieldOffset(Offset = "0xC0")]
	public static readonly string SET_EXTRACTION_TOOLTIP_TEXT;

	[Token(Token = "0x4001DDD")]
	[FieldOffset(Offset = "0xC8")]
	public static readonly string GOAL_TEXT;

	[Token(Token = "0x4001DDE")]
	[FieldOffset(Offset = "0xD0")]
	public static readonly string SUBOBJECTIVE_TEXT;

	[Token(Token = "0x4001DDF")]
	[FieldOffset(Offset = "0xD8")]
	public static readonly string SHOOT_ICONS_ON_LEFT;

	[Token(Token = "0x4001DE0")]
	[FieldOffset(Offset = "0xE0")]
	public static readonly string ALERT_LEVEL;

	[Token(Token = "0x4001DE1")]
	[FieldOffset(Offset = "0xE8")]
	public static readonly string SUBTITLE_TEXT;

	[Token(Token = "0x4001DE2")]
	[FieldOffset(Offset = "0xF0")]
	public static readonly string TOOLTIP_TEXT;

	[Token(Token = "0x4001DE3")]
	[FieldOffset(Offset = "0xF8")]
	public static readonly string TOOLTIP_TEXTURE;

	[Token(Token = "0x4001DE4")]
	[FieldOffset(Offset = "0x100")]
	public static readonly string TOOLTIP_ATLAS_INFO;

	[Token(Token = "0x4001DE5")]
	[FieldOffset(Offset = "0x108")]
	public static readonly string POPUP_TITLE;

	[Token(Token = "0x4001DE6")]
	[FieldOffset(Offset = "0x110")]
	public static readonly string POPUP_MESSAGE;

	[Token(Token = "0x4001DE7")]
	[FieldOffset(Offset = "0x118")]
	public static readonly string POPUP_TEXTURE;

	[Token(Token = "0x4001DE8")]
	[FieldOffset(Offset = "0x120")]
	public static readonly string PAUSE_MENU_STATE;

	[Token(Token = "0x4001DE9")]
	[FieldOffset(Offset = "0x128")]
	public static readonly string IGC_DISPLAYED;

	[Token(Token = "0x4001DEA")]
	[FieldOffset(Offset = "0x130")]
	public static readonly string SCORE_DISPLAYED;

	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x138")]
	public static readonly string TIMER_DISPLAYED;

	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0x140")]
	public static readonly string AMMO_COUNTER_DISPLAYED;

	[Token(Token = "0x4001DED")]
	[FieldOffset(Offset = "0x148")]
	public static readonly string MISSION_DETAIL_AT_START_DISPLAYED;

	[Token(Token = "0x4001DEE")]
	[FieldOffset(Offset = "0x150")]
	public static readonly string PAUSE_MENU_QUIT_BUTTON_DISPLAYED;

	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x158")]
	public static readonly string GAME_TIMER;

	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x160")]
	public static readonly string SHOW_ROGUE_ARRIVAL_TIMER;

	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x168")]
	public static readonly string SHOW_OBJECTIVES;

	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x170")]
	public static readonly string SPECIAL_ALERT_DISPLAY;

	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x178")]
	public static readonly string POWERUP_ID_TO_UPDATE;

	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x180")]
	public static readonly string SHOW_SHOP_BUTTON_PULSE;

	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x188")]
	public static readonly string MINIMUM_COST_NEXT_UPGRADE;

	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x190")]
	public static readonly string SPECIAL_ALERT_ARG1;

	[Token(Token = "0x4001DF7")]
	[FieldOffset(Offset = "0x198")]
	public static readonly string SHOW_CLICKSHOP_TOOLTIP;

	[Token(Token = "0x4001DF8")]
	[FieldOffset(Offset = "0x1A0")]
	public static readonly string SHOW_PAUSE_BUTTON_GO;

	[Token(Token = "0x4001DF9")]
	[FieldOffset(Offset = "0x1A8")]
	public static readonly string ROGUE_ARRIVAL_TIMER_ANCHOR;

	[Token(Token = "0x4001DFA")]
	[FieldOffset(Offset = "0x1B0")]
	public static readonly string HIGHLIGHT_TARGET;

	[Token(Token = "0x4001DFB")]
	[FieldOffset(Offset = "0x1B8")]
	public static readonly string HIGHLIGHT_ACTIVE;

	[Token(Token = "0x4001DFC")]
	[FieldOffset(Offset = "0x1C0")]
	public static readonly string BLOCK_ALL_INPUT;

	[Token(Token = "0x4001DFD")]
	[FieldOffset(Offset = "0x48")]
	public LazyView InScopeHUDView;

	[Token(Token = "0x4001DFE")]
	[FieldOffset(Offset = "0x50")]
	public LazyView OutScopeHUDView;

	[Token(Token = "0x4001DFF")]
	[FieldOffset(Offset = "0x58")]
	public float AssignmentMessageDisplayTime;

	[Token(Token = "0x4001E00")]
	[FieldOffset(Offset = "0x5C")]
	public float ScoreToBeatDisplayTime;

	[Token(Token = "0x4001E01")]
	[FieldOffset(Offset = "0x60")]
	public float LeaderboardRefreshInterval;

	[Token(Token = "0x4001E02")]
	[FieldOffset(Offset = "0x64")]
	public int LeaderboardMaxRefreshCount;

	[Token(Token = "0x4001E03")]
	[FieldOffset(Offset = "0x68")]
	public PowerUpUpgraded PowerUpToUpdate;

	[Token(Token = "0x4001E04")]
	[FieldOffset(Offset = "0x70")]
	public float AlertLevelDisplayTime;

	[Token(Token = "0x4001E05")]
	[FieldOffset(Offset = "0x78")]
	public AlertLevelUIConfig[] AlertLevelConfigs;

	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0x80")]
	public AlertLevelUIConfig[] SpecialAlertConfigs;

	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x88")]
	public float PauseMenuEnterDuration;

	[Token(Token = "0x4001E08")]
	[FieldOffset(Offset = "0x8C")]
	public float ShowInfoDuration;

	[Token(Token = "0x4001E09")]
	[FieldOffset(Offset = "0x90")]
	public float MinShowInfoDuration;

	[Token(Token = "0x4001E0A")]
	[FieldOffset(Offset = "0x94")]
	public bool ShowPauseButtonPulse;

	[Token(Token = "0x4001E0B")]
	[FieldOffset(Offset = "0x98")]
	private int _minCostNextUpgrade;

	[NonSerialized]
	[Token(Token = "0x4001E0C")]
	[FieldOffset(Offset = "0x9C")]
	private int _gameScore;

	[NonSerialized]
	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0xA0")]
	private bool _isGameFinished;

	[NonSerialized]
	[Token(Token = "0x4001E0E")]
	[FieldOffset(Offset = "0xA1")]
	private bool _isContractCompleted;

	[NonSerialized]
	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0xA2")]
	private bool _isNewRecord;

	[NonSerialized]
	[Token(Token = "0x4001E10")]
	[FieldOffset(Offset = "0xA3")]
	private bool _inTallyView;

	[NonSerialized]
	[Token(Token = "0x4001E11")]
	[FieldOffset(Offset = "0xA8")]
	private ScoreDetail _score;

	[NonSerialized]
	[Token(Token = "0x4001E12")]
	[FieldOffset(Offset = "0xB0")]
	private bool _showScoreToBeat;

	[NonSerialized]
	[Token(Token = "0x4001E13")]
	[FieldOffset(Offset = "0xB8")]
	private LeaderboardRecord _scoreToBeat;

	[NonSerialized]
	[Token(Token = "0x4001E14")]
	[FieldOffset(Offset = "0xC0")]
	private LeaderboardRecord _nextScoreToBeat;

	[NonSerialized]
	[Token(Token = "0x4001E15")]
	[FieldOffset(Offset = "0xC8")]
	private bool _showRivalScoreTooltip;

	[NonSerialized]
	[Token(Token = "0x4001E16")]
	[FieldOffset(Offset = "0xD0")]
	private string _setRivalScoreTooltipText;

	[NonSerialized]
	[Token(Token = "0x4001E17")]
	[FieldOffset(Offset = "0xD8")]
	private bool _showExtractionTooltip;

	[NonSerialized]
	[Token(Token = "0x4001E18")]
	[FieldOffset(Offset = "0xE0")]
	private string _setExtractionTooltipText;

	[NonSerialized]
	[Token(Token = "0x4001E19")]
	[FieldOffset(Offset = "0xE8")]
	private string _goalText;

	[NonSerialized]
	[Token(Token = "0x4001E1A")]
	[FieldOffset(Offset = "0xF0")]
	private string _subobjectiveText;

	[NonSerialized]
	[Token(Token = "0x4001E1B")]
	[FieldOffset(Offset = "0xF8")]
	private bool _shootIconsOnLeft;

	[NonSerialized]
	[Token(Token = "0x4001E1C")]
	[FieldOffset(Offset = "0xFC")]
	private AlertLevel _alertLevel;

	[NonSerialized]
	[Token(Token = "0x4001E1D")]
	[FieldOffset(Offset = "0x100")]
	private string _subtitleText;

	[NonSerialized]
	[Token(Token = "0x4001E1E")]
	[FieldOffset(Offset = "0x108")]
	private string _tooltipText;

	[NonSerialized]
	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0x110")]
	private Texture _tooltipTexture;

	[NonSerialized]
	[Token(Token = "0x4001E20")]
	[FieldOffset(Offset = "0x118")]
	private UIManager.AtlasInfo _tooltipAtlasInfo;

	[NonSerialized]
	[Token(Token = "0x4001E21")]
	[FieldOffset(Offset = "0x120")]
	private string _popupTitle;

	[NonSerialized]
	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x128")]
	private string _popupMessage;

	[NonSerialized]
	[Token(Token = "0x4001E23")]
	[FieldOffset(Offset = "0x130")]
	private Texture _popupTexture;

	[NonSerialized]
	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x138")]
	private PauseMenuState _pauseMenuState;

	[NonSerialized]
	[Token(Token = "0x4001E25")]
	[FieldOffset(Offset = "0x13C")]
	private bool _IGCDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0x13D")]
	private bool _scoreDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E27")]
	[FieldOffset(Offset = "0x13E")]
	private bool _timerDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x13F")]
	private bool _ammoCounterDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E29")]
	[FieldOffset(Offset = "0x140")]
	private bool _missionDetailAtStartDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x141")]
	private bool _pauseMenuQuitButtonDisplayed;

	[NonSerialized]
	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x148")]
	private GameTimer _gameTimer;

	[NonSerialized]
	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x150")]
	private bool _showRogueArrivalTimer;

	[NonSerialized]
	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x151")]
	private bool _showObjectives;

	[NonSerialized]
	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x154")]
	public SpecialAlertUIConfig SpecialAlertDisplay;

	[NonSerialized]
	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x158")]
	public string SpecialAlertArg1;

	[NonSerialized]
	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x160")]
	private bool _showClickShopTooltip;

	[NonSerialized]
	[Token(Token = "0x4001E31")]
	[FieldOffset(Offset = "0x161")]
	private bool _showPauseButtonGO;

	[NonSerialized]
	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x168")]
	private GameObject _rogueArrivalTimerAnchor;

	[NonSerialized]
	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x170")]
	private GameObject _highlightTarget;

	[NonSerialized]
	[Token(Token = "0x4001E34")]
	[FieldOffset(Offset = "0x178")]
	private bool _highlightActive;

	[NonSerialized]
	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x179")]
	private bool _blockAllInput;

	[Token(Token = "0x600237B")]
	[Address(RVA = "0xC9246C", Offset = "0xC9246C", VA = "0xC9246C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0xC942DC", Offset = "0xC942DC", VA = "0xC942DC")]
	public HUDModel()
	{
	}

	[Token(Token = "0x600237E")]
	[Address(RVA = "0xC94B7C", Offset = "0xC94B7C", VA = "0xC94B7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A550", Offset = "0x61A550")]
	private object _003CBindAllVariables_003Eb__117_0()
	{
		return null;
	}

	[Token(Token = "0x600237F")]
	[Address(RVA = "0xC94B84", Offset = "0xC94B84", VA = "0xC94B84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A560", Offset = "0x61A560")]
	private object _003CBindAllVariables_003Eb__117_1()
	{
		return null;
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0xC94B8C", Offset = "0xC94B8C", VA = "0xC94B8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A570", Offset = "0x61A570")]
	private bool _003CBindAllVariables_003Eb__117_2()
	{
		return default(bool);
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0xC94B94", Offset = "0xC94B94", VA = "0xC94B94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A580", Offset = "0x61A580")]
	private void _003CBindAllVariables_003Eb__117_3(bool b)
	{
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0xC94BA0", Offset = "0xC94BA0", VA = "0xC94BA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A590", Offset = "0x61A590")]
	private bool _003CBindAllVariables_003Eb__117_4()
	{
		return default(bool);
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0xC94BA8", Offset = "0xC94BA8", VA = "0xC94BA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5A0", Offset = "0x61A5A0")]
	private void _003CBindAllVariables_003Eb__117_5(bool b)
	{
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0xC94BB4", Offset = "0xC94BB4", VA = "0xC94BB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5B0", Offset = "0x61A5B0")]
	private bool _003CBindAllVariables_003Eb__117_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0xC94BBC", Offset = "0xC94BBC", VA = "0xC94BBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5C0", Offset = "0x61A5C0")]
	private void _003CBindAllVariables_003Eb__117_7(bool b)
	{
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0xC94BC8", Offset = "0xC94BC8", VA = "0xC94BC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5D0", Offset = "0x61A5D0")]
	private bool _003CBindAllVariables_003Eb__117_8()
	{
		return default(bool);
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0xC94BD0", Offset = "0xC94BD0", VA = "0xC94BD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5E0", Offset = "0x61A5E0")]
	private void _003CBindAllVariables_003Eb__117_9(bool b)
	{
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0xC94BDC", Offset = "0xC94BDC", VA = "0xC94BDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A5F0", Offset = "0x61A5F0")]
	private int _003CBindAllVariables_003Eb__117_10()
	{
		return default(int);
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0xC94BE4", Offset = "0xC94BE4", VA = "0xC94BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A600", Offset = "0x61A600")]
	private void _003CBindAllVariables_003Eb__117_11(int i)
	{
	}

	[Token(Token = "0x600238A")]
	[Address(RVA = "0xC94BEC", Offset = "0xC94BEC", VA = "0xC94BEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A610", Offset = "0x61A610")]
	private object _003CBindAllVariables_003Eb__117_12()
	{
		return null;
	}

	[Token(Token = "0x600238B")]
	[Address(RVA = "0xC94BF4", Offset = "0xC94BF4", VA = "0xC94BF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A620", Offset = "0x61A620")]
	private void _003CBindAllVariables_003Eb__117_13(object s)
	{
	}

	[Token(Token = "0x600238C")]
	[Address(RVA = "0xC94C80", Offset = "0xC94C80", VA = "0xC94C80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A630", Offset = "0x61A630")]
	private bool _003CBindAllVariables_003Eb__117_14()
	{
		return default(bool);
	}

	[Token(Token = "0x600238D")]
	[Address(RVA = "0xC94C88", Offset = "0xC94C88", VA = "0xC94C88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A640", Offset = "0x61A640")]
	private void _003CBindAllVariables_003Eb__117_15(bool b)
	{
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0xC94C94", Offset = "0xC94C94", VA = "0xC94C94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A650", Offset = "0x61A650")]
	private float _003CBindAllVariables_003Eb__117_16()
	{
		return default(float);
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0xC94C9C", Offset = "0xC94C9C", VA = "0xC94C9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A660", Offset = "0x61A660")]
	private object _003CBindAllVariables_003Eb__117_17()
	{
		return null;
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0xC94CA4", Offset = "0xC94CA4", VA = "0xC94CA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A670", Offset = "0x61A670")]
	private void _003CBindAllVariables_003Eb__117_18(object r)
	{
	}

	[Token(Token = "0x6002391")]
	[Address(RVA = "0xC94D30", Offset = "0xC94D30", VA = "0xC94D30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A680", Offset = "0x61A680")]
	private object _003CBindAllVariables_003Eb__117_19()
	{
		return null;
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0xC94D38", Offset = "0xC94D38", VA = "0xC94D38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A690", Offset = "0x61A690")]
	private void _003CBindAllVariables_003Eb__117_20(object r)
	{
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0xC94DC4", Offset = "0xC94DC4", VA = "0xC94DC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6A0", Offset = "0x61A6A0")]
	private float _003CBindAllVariables_003Eb__117_21()
	{
		return default(float);
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0xC94DCC", Offset = "0xC94DCC", VA = "0xC94DCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6B0", Offset = "0x61A6B0")]
	private int _003CBindAllVariables_003Eb__117_22()
	{
		return default(int);
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0xC94DD4", Offset = "0xC94DD4", VA = "0xC94DD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6C0", Offset = "0x61A6C0")]
	private bool _003CBindAllVariables_003Eb__117_23()
	{
		return default(bool);
	}

	[Token(Token = "0x6002396")]
	[Address(RVA = "0xC94DDC", Offset = "0xC94DDC", VA = "0xC94DDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6D0", Offset = "0x61A6D0")]
	private void _003CBindAllVariables_003Eb__117_24(bool b)
	{
	}

	[Token(Token = "0x6002397")]
	[Address(RVA = "0xC94DE8", Offset = "0xC94DE8", VA = "0xC94DE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6E0", Offset = "0x61A6E0")]
	private object _003CBindAllVariables_003Eb__117_25()
	{
		return null;
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0xC94DF0", Offset = "0xC94DF0", VA = "0xC94DF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A6F0", Offset = "0x61A6F0")]
	private void _003CBindAllVariables_003Eb__117_26(object s)
	{
	}

	[Token(Token = "0x6002399")]
	[Address(RVA = "0xC94E60", Offset = "0xC94E60", VA = "0xC94E60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A700", Offset = "0x61A700")]
	private bool _003CBindAllVariables_003Eb__117_27()
	{
		return default(bool);
	}

	[Token(Token = "0x600239A")]
	[Address(RVA = "0xC94E68", Offset = "0xC94E68", VA = "0xC94E68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A710", Offset = "0x61A710")]
	private void _003CBindAllVariables_003Eb__117_28(bool b)
	{
	}

	[Token(Token = "0x600239B")]
	[Address(RVA = "0xC94E74", Offset = "0xC94E74", VA = "0xC94E74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A720", Offset = "0x61A720")]
	private object _003CBindAllVariables_003Eb__117_29()
	{
		return null;
	}

	[Token(Token = "0x600239C")]
	[Address(RVA = "0xC94E7C", Offset = "0xC94E7C", VA = "0xC94E7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A730", Offset = "0x61A730")]
	private void _003CBindAllVariables_003Eb__117_30(object s)
	{
	}

	[Token(Token = "0x600239D")]
	[Address(RVA = "0xC94EEC", Offset = "0xC94EEC", VA = "0xC94EEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A740", Offset = "0x61A740")]
	private object _003CBindAllVariables_003Eb__117_31()
	{
		return null;
	}

	[Token(Token = "0x600239E")]
	[Address(RVA = "0xC94EF4", Offset = "0xC94EF4", VA = "0xC94EF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A750", Offset = "0x61A750")]
	private void _003CBindAllVariables_003Eb__117_32(object s)
	{
	}

	[Token(Token = "0x600239F")]
	[Address(RVA = "0xC94F64", Offset = "0xC94F64", VA = "0xC94F64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A760", Offset = "0x61A760")]
	private object _003CBindAllVariables_003Eb__117_33()
	{
		return null;
	}

	[Token(Token = "0x60023A0")]
	[Address(RVA = "0xC94F6C", Offset = "0xC94F6C", VA = "0xC94F6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A770", Offset = "0x61A770")]
	private void _003CBindAllVariables_003Eb__117_34(object s)
	{
	}

	[Token(Token = "0x60023A1")]
	[Address(RVA = "0xC94FDC", Offset = "0xC94FDC", VA = "0xC94FDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A780", Offset = "0x61A780")]
	private float _003CBindAllVariables_003Eb__117_35()
	{
		return default(float);
	}

	[Token(Token = "0x60023A2")]
	[Address(RVA = "0xC94FE4", Offset = "0xC94FE4", VA = "0xC94FE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A790", Offset = "0x61A790")]
	private float _003CBindAllVariables_003Eb__117_36()
	{
		return default(float);
	}

	[Token(Token = "0x60023A3")]
	[Address(RVA = "0xC94FEC", Offset = "0xC94FEC", VA = "0xC94FEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7A0", Offset = "0x61A7A0")]
	private object _003CBindAllVariables_003Eb__117_37()
	{
		return null;
	}

	[Token(Token = "0x60023A4")]
	[Address(RVA = "0xC94FF4", Offset = "0xC94FF4", VA = "0xC94FF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7B0", Offset = "0x61A7B0")]
	private object _003CBindAllVariables_003Eb__117_38()
	{
		return null;
	}

	[Token(Token = "0x60023A5")]
	[Address(RVA = "0xC94FFC", Offset = "0xC94FFC", VA = "0xC94FFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7C0", Offset = "0x61A7C0")]
	private object _003CBindAllVariables_003Eb__117_39()
	{
		return null;
	}

	[Token(Token = "0x60023A6")]
	[Address(RVA = "0xC9505C", Offset = "0xC9505C", VA = "0xC9505C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7D0", Offset = "0x61A7D0")]
	private void _003CBindAllVariables_003Eb__117_40(object a)
	{
	}

	[Token(Token = "0x60023A7")]
	[Address(RVA = "0xC950E0", Offset = "0xC950E0", VA = "0xC950E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7E0", Offset = "0x61A7E0")]
	private object _003CBindAllVariables_003Eb__117_41()
	{
		return null;
	}

	[Token(Token = "0x60023A8")]
	[Address(RVA = "0xC950E8", Offset = "0xC950E8", VA = "0xC950E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A7F0", Offset = "0x61A7F0")]
	private void _003CBindAllVariables_003Eb__117_42(object s)
	{
	}

	[Token(Token = "0x60023A9")]
	[Address(RVA = "0xC95158", Offset = "0xC95158", VA = "0xC95158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A800", Offset = "0x61A800")]
	private object _003CBindAllVariables_003Eb__117_43()
	{
		return null;
	}

	[Token(Token = "0x60023AA")]
	[Address(RVA = "0xC95160", Offset = "0xC95160", VA = "0xC95160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A810", Offset = "0x61A810")]
	private void _003CBindAllVariables_003Eb__117_44(object s)
	{
	}

	[Token(Token = "0x60023AB")]
	[Address(RVA = "0xC951D0", Offset = "0xC951D0", VA = "0xC951D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A820", Offset = "0x61A820")]
	private object _003CBindAllVariables_003Eb__117_45()
	{
		return null;
	}

	[Token(Token = "0x60023AC")]
	[Address(RVA = "0xC951D8", Offset = "0xC951D8", VA = "0xC951D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A830", Offset = "0x61A830")]
	private void _003CBindAllVariables_003Eb__117_46(object t)
	{
	}

	[Token(Token = "0x60023AD")]
	[Address(RVA = "0xC95264", Offset = "0xC95264", VA = "0xC95264")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A840", Offset = "0x61A840")]
	private object _003CBindAllVariables_003Eb__117_47()
	{
		return null;
	}

	[Token(Token = "0x60023AE")]
	[Address(RVA = "0xC9526C", Offset = "0xC9526C", VA = "0xC9526C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A850", Offset = "0x61A850")]
	private void _003CBindAllVariables_003Eb__117_48(object u)
	{
	}

	[Token(Token = "0x60023AF")]
	[Address(RVA = "0xC952F8", Offset = "0xC952F8", VA = "0xC952F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A860", Offset = "0x61A860")]
	private object _003CBindAllVariables_003Eb__117_49()
	{
		return null;
	}

	[Token(Token = "0x60023B0")]
	[Address(RVA = "0xC95300", Offset = "0xC95300", VA = "0xC95300")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A870", Offset = "0x61A870")]
	private void _003CBindAllVariables_003Eb__117_50(object s)
	{
	}

	[Token(Token = "0x60023B1")]
	[Address(RVA = "0xC95370", Offset = "0xC95370", VA = "0xC95370")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A880", Offset = "0x61A880")]
	private object _003CBindAllVariables_003Eb__117_51()
	{
		return null;
	}

	[Token(Token = "0x60023B2")]
	[Address(RVA = "0xC95378", Offset = "0xC95378", VA = "0xC95378")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A890", Offset = "0x61A890")]
	private void _003CBindAllVariables_003Eb__117_52(object s)
	{
	}

	[Token(Token = "0x60023B3")]
	[Address(RVA = "0xC953E8", Offset = "0xC953E8", VA = "0xC953E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8A0", Offset = "0x61A8A0")]
	private object _003CBindAllVariables_003Eb__117_53()
	{
		return null;
	}

	[Token(Token = "0x60023B4")]
	[Address(RVA = "0xC953F0", Offset = "0xC953F0", VA = "0xC953F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8B0", Offset = "0x61A8B0")]
	private void _003CBindAllVariables_003Eb__117_54(object t)
	{
	}

	[Token(Token = "0x60023B5")]
	[Address(RVA = "0xC9547C", Offset = "0xC9547C", VA = "0xC9547C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8C0", Offset = "0x61A8C0")]
	private object _003CBindAllVariables_003Eb__117_55()
	{
		return null;
	}

	[Token(Token = "0x60023B6")]
	[Address(RVA = "0xC954DC", Offset = "0xC954DC", VA = "0xC954DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8D0", Offset = "0x61A8D0")]
	private void _003CBindAllVariables_003Eb__117_56(object b)
	{
	}

	[Token(Token = "0x60023B7")]
	[Address(RVA = "0xC95560", Offset = "0xC95560", VA = "0xC95560")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8E0", Offset = "0x61A8E0")]
	private float _003CBindAllVariables_003Eb__117_57()
	{
		return default(float);
	}

	[Token(Token = "0x60023B8")]
	[Address(RVA = "0xC95568", Offset = "0xC95568", VA = "0xC95568")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A8F0", Offset = "0x61A8F0")]
	private float _003CBindAllVariables_003Eb__117_58()
	{
		return default(float);
	}

	[Token(Token = "0x60023B9")]
	[Address(RVA = "0xC95570", Offset = "0xC95570", VA = "0xC95570")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A900", Offset = "0x61A900")]
	private float _003CBindAllVariables_003Eb__117_59()
	{
		return default(float);
	}

	[Token(Token = "0x60023BA")]
	[Address(RVA = "0xC95578", Offset = "0xC95578", VA = "0xC95578")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A910", Offset = "0x61A910")]
	private bool _003CBindAllVariables_003Eb__117_60()
	{
		return default(bool);
	}

	[Token(Token = "0x60023BB")]
	[Address(RVA = "0xC95580", Offset = "0xC95580", VA = "0xC95580")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A920", Offset = "0x61A920")]
	private void _003CBindAllVariables_003Eb__117_61(bool b)
	{
	}

	[Token(Token = "0x60023BC")]
	[Address(RVA = "0xC9558C", Offset = "0xC9558C", VA = "0xC9558C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A930", Offset = "0x61A930")]
	private bool _003CBindAllVariables_003Eb__117_62()
	{
		return default(bool);
	}

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0xC95594", Offset = "0xC95594", VA = "0xC95594")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A940", Offset = "0x61A940")]
	private void _003CBindAllVariables_003Eb__117_63(bool b)
	{
	}

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0xC955A0", Offset = "0xC955A0", VA = "0xC955A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A950", Offset = "0x61A950")]
	private bool _003CBindAllVariables_003Eb__117_64()
	{
		return default(bool);
	}

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0xC955A8", Offset = "0xC955A8", VA = "0xC955A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A960", Offset = "0x61A960")]
	private void _003CBindAllVariables_003Eb__117_65(bool b)
	{
	}

	[Token(Token = "0x60023C0")]
	[Address(RVA = "0xC955B4", Offset = "0xC955B4", VA = "0xC955B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A970", Offset = "0x61A970")]
	private bool _003CBindAllVariables_003Eb__117_66()
	{
		return default(bool);
	}

	[Token(Token = "0x60023C1")]
	[Address(RVA = "0xC955BC", Offset = "0xC955BC", VA = "0xC955BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A980", Offset = "0x61A980")]
	private void _003CBindAllVariables_003Eb__117_67(bool b)
	{
	}

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0xC955C8", Offset = "0xC955C8", VA = "0xC955C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A990", Offset = "0x61A990")]
	private bool _003CBindAllVariables_003Eb__117_68()
	{
		return default(bool);
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0xC955D0", Offset = "0xC955D0", VA = "0xC955D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9A0", Offset = "0x61A9A0")]
	private void _003CBindAllVariables_003Eb__117_69(bool b)
	{
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0xC955DC", Offset = "0xC955DC", VA = "0xC955DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9B0", Offset = "0x61A9B0")]
	private bool _003CBindAllVariables_003Eb__117_70()
	{
		return default(bool);
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0xC955E4", Offset = "0xC955E4", VA = "0xC955E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9C0", Offset = "0x61A9C0")]
	private void _003CBindAllVariables_003Eb__117_71(bool b)
	{
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0xC955F0", Offset = "0xC955F0", VA = "0xC955F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9D0", Offset = "0x61A9D0")]
	private bool _003CBindAllVariables_003Eb__117_72()
	{
		return default(bool);
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0xC955F8", Offset = "0xC955F8", VA = "0xC955F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9E0", Offset = "0x61A9E0")]
	private void _003CBindAllVariables_003Eb__117_73(bool b)
	{
	}

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0xC95604", Offset = "0xC95604", VA = "0xC95604")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A9F0", Offset = "0x61A9F0")]
	private object _003CBindAllVariables_003Eb__117_74()
	{
		return null;
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0xC9560C", Offset = "0xC9560C", VA = "0xC9560C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA00", Offset = "0x61AA00")]
	private void _003CBindAllVariables_003Eb__117_75(object g)
	{
	}

	[Token(Token = "0x60023CA")]
	[Address(RVA = "0xC95698", Offset = "0xC95698", VA = "0xC95698")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA10", Offset = "0x61AA10")]
	private bool _003CBindAllVariables_003Eb__117_76()
	{
		return default(bool);
	}

	[Token(Token = "0x60023CB")]
	[Address(RVA = "0xC956A0", Offset = "0xC956A0", VA = "0xC956A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA20", Offset = "0x61AA20")]
	private void _003CBindAllVariables_003Eb__117_77(bool b)
	{
	}

	[Token(Token = "0x60023CC")]
	[Address(RVA = "0xC956AC", Offset = "0xC956AC", VA = "0xC956AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA30", Offset = "0x61AA30")]
	private bool _003CBindAllVariables_003Eb__117_78()
	{
		return default(bool);
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0xC956B4", Offset = "0xC956B4", VA = "0xC956B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA40", Offset = "0x61AA40")]
	private void _003CBindAllVariables_003Eb__117_79(bool b)
	{
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0xC956C0", Offset = "0xC956C0", VA = "0xC956C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA50", Offset = "0x61AA50")]
	private object _003CBindAllVariables_003Eb__117_80()
	{
		return null;
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0xC95720", Offset = "0xC95720", VA = "0xC95720")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA60", Offset = "0x61AA60")]
	private void _003CBindAllVariables_003Eb__117_81(object s)
	{
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0xC957A4", Offset = "0xC957A4", VA = "0xC957A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA70", Offset = "0x61AA70")]
	private object _003CBindAllVariables_003Eb__117_82()
	{
		return null;
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0xC957AC", Offset = "0xC957AC", VA = "0xC957AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA80", Offset = "0x61AA80")]
	private void _003CBindAllVariables_003Eb__117_83(object b)
	{
	}

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0xC95838", Offset = "0xC95838", VA = "0xC95838")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AA90", Offset = "0x61AA90")]
	private bool _003CBindAllVariables_003Eb__117_84()
	{
		return default(bool);
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0xC95840", Offset = "0xC95840", VA = "0xC95840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAA0", Offset = "0x61AAA0")]
	private void _003CBindAllVariables_003Eb__117_85(bool b)
	{
	}

	[Token(Token = "0x60023D4")]
	[Address(RVA = "0xC9584C", Offset = "0xC9584C", VA = "0xC9584C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAB0", Offset = "0x61AAB0")]
	private int _003CBindAllVariables_003Eb__117_86()
	{
		return default(int);
	}

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0xC95854", Offset = "0xC95854", VA = "0xC95854")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAC0", Offset = "0x61AAC0")]
	private void _003CBindAllVariables_003Eb__117_87(int a)
	{
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0xC9585C", Offset = "0xC9585C", VA = "0xC9585C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAD0", Offset = "0x61AAD0")]
	private object _003CBindAllVariables_003Eb__117_88()
	{
		return null;
	}

	[Token(Token = "0x60023D7")]
	[Address(RVA = "0xC95864", Offset = "0xC95864", VA = "0xC95864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAE0", Offset = "0x61AAE0")]
	private void _003CBindAllVariables_003Eb__117_89(object a)
	{
	}

	[Token(Token = "0x60023D8")]
	[Address(RVA = "0xC958D4", Offset = "0xC958D4", VA = "0xC958D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AAF0", Offset = "0x61AAF0")]
	private bool _003CBindAllVariables_003Eb__117_90()
	{
		return default(bool);
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0xC958DC", Offset = "0xC958DC", VA = "0xC958DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB00", Offset = "0x61AB00")]
	private void _003CBindAllVariables_003Eb__117_91(bool a)
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0xC958E8", Offset = "0xC958E8", VA = "0xC958E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB10", Offset = "0x61AB10")]
	private bool _003CBindAllVariables_003Eb__117_92()
	{
		return default(bool);
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0xC958F0", Offset = "0xC958F0", VA = "0xC958F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB20", Offset = "0x61AB20")]
	private void _003CBindAllVariables_003Eb__117_93(bool a)
	{
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0xC958FC", Offset = "0xC958FC", VA = "0xC958FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB30", Offset = "0x61AB30")]
	private object _003CBindAllVariables_003Eb__117_94()
	{
		return null;
	}

	[Token(Token = "0x60023DD")]
	[Address(RVA = "0xC95904", Offset = "0xC95904", VA = "0xC95904")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB40", Offset = "0x61AB40")]
	private void _003CBindAllVariables_003Eb__117_95(object a)
	{
	}

	[Token(Token = "0x60023DE")]
	[Address(RVA = "0xC95974", Offset = "0xC95974", VA = "0xC95974")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB50", Offset = "0x61AB50")]
	private object _003CBindAllVariables_003Eb__117_96()
	{
		return null;
	}

	[Token(Token = "0x60023DF")]
	[Address(RVA = "0xC9597C", Offset = "0xC9597C", VA = "0xC9597C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB60", Offset = "0x61AB60")]
	private void _003CBindAllVariables_003Eb__117_97(object o)
	{
	}

	[Token(Token = "0x60023E0")]
	[Address(RVA = "0xC959EC", Offset = "0xC959EC", VA = "0xC959EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB70", Offset = "0x61AB70")]
	private bool _003CBindAllVariables_003Eb__117_98()
	{
		return default(bool);
	}

	[Token(Token = "0x60023E1")]
	[Address(RVA = "0xC959F4", Offset = "0xC959F4", VA = "0xC959F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB80", Offset = "0x61AB80")]
	private void _003CBindAllVariables_003Eb__117_99(bool b)
	{
	}

	[Token(Token = "0x60023E2")]
	[Address(RVA = "0xC95A00", Offset = "0xC95A00", VA = "0xC95A00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AB90", Offset = "0x61AB90")]
	private bool _003CBindAllVariables_003Eb__117_100()
	{
		return default(bool);
	}

	[Token(Token = "0x60023E3")]
	[Address(RVA = "0xC95A08", Offset = "0xC95A08", VA = "0xC95A08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ABA0", Offset = "0x61ABA0")]
	private void _003CBindAllVariables_003Eb__117_101(bool b)
	{
	}
}
