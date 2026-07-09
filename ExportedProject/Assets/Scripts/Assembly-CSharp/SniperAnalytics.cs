using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Analytics;
using Technology.Core.Auth;
using Technology.Core.ServiceOperations;
using Technology.Shop;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000821")]
public class SniperAnalytics : Analytics<SniperAnalytics>
{
	[Token(Token = "0x2000822")]
	public enum SocialSource
	{
		[Token(Token = "0x4002D54")]
		Facebook = 0
	}

	[Token(Token = "0x2000823")]
	public enum SocialAction
	{
		[Token(Token = "0x4002D56")]
		Login = 0,
		[Token(Token = "0x4002D57")]
		Logoff = 1,
		[Token(Token = "0x4002D58")]
		Share = 2,
		[Token(Token = "0x4002D59")]
		Invite = 3,
		[Token(Token = "0x4002D5A")]
		Like = 4
	}

	[Token(Token = "0x2000824")]
	public enum EveryplayAction
	{
		[Token(Token = "0x4002D5C")]
		Upload = 0,
		[Token(Token = "0x4002D5D")]
		WatchedFriend = 1,
		[Token(Token = "0x4002D5E")]
		WatchedTiered = 2
	}

	[Token(Token = "0x2000825")]
	public enum ItemGrantedContext
	{
		[Token(Token = "0x4002D60")]
		CommunityManager = 0,
		[Token(Token = "0x4002D61")]
		DeltaDNA = 1
	}

	[Token(Token = "0x2000826")]
	public enum ShopPopup
	{
		[Token(Token = "0x4002D63")]
		CurrencyShop = 0,
		[Token(Token = "0x4002D64")]
		StarterPackShop = 1
	}

	[Token(Token = "0x2000827")]
	public enum SettingID
	{
		[Token(Token = "0x4002D66")]
		LeftHanded = 0,
		[Token(Token = "0x4002D67")]
		ShootButton = 1,
		[Token(Token = "0x4002D68")]
		InvertedY = 2,
		[Token(Token = "0x4002D69")]
		BloodEffects = 3
	}

	[Token(Token = "0x2000828")]
	public enum CurrencyGrantContext
	{
		[Token(Token = "0x4002D6B")]
		Roulette = 0,
		[Token(Token = "0x4002D6C")]
		Gameplay = 1,
		[Token(Token = "0x4002D6D")]
		AssignmentReward = 2,
		[Token(Token = "0x4002D6E")]
		TallyBonus = 3
	}

	[Token(Token = "0x2000829")]
	public enum TooltipClickType
	{
		[Token(Token = "0x4002D70")]
		Perk = 0,
		[Token(Token = "0x4002D71")]
		Ability = 1,
		[Token(Token = "0x4002D72")]
		GunStat = 2
	}

	[Token(Token = "0x200082A")]
	public enum GunUnlockType
	{
		[Token(Token = "0x4002D74")]
		PartsCollection = 0,
		[Token(Token = "0x4002D75")]
		Progression = 1,
		[Token(Token = "0x4002D76")]
		Purchase = 2,
		[Token(Token = "0x4002D77")]
		RequirementsFulfilled = 3
	}

	[Token(Token = "0x200082B")]
	public enum ZombieType
	{
		[Token(Token = "0x4002D79")]
		GoldenZombie = 0,
		[Token(Token = "0x4002D7A")]
		BansheeZombie = 1,
		[Token(Token = "0x4002D7B")]
		JuggernautZombie = 2,
		[Token(Token = "0x4002D7C")]
		BeastZombie = 3,
		[Token(Token = "0x4002D7D")]
		NormalZombie = 4
	}

	[Token(Token = "0x200082C")]
	public enum MainMenuSource
	{
		[Token(Token = "0x4002D7F")]
		SplashScreen = 0,
		[Token(Token = "0x4002D80")]
		GamePlay = 1,
		[Token(Token = "0x4002D81")]
		None = 2
	}

	[Token(Token = "0x200082D")]
	public enum InsufficientFundsSource
	{
		[Token(Token = "0x4002D83")]
		None = 0,
		[Token(Token = "0x4002D84")]
		Perk = 1,
		[Token(Token = "0x4002D85")]
		MissionSkip = 2,
		[Token(Token = "0x4002D86")]
		Upgrade = 3
	}

	[Token(Token = "0x200082E")]
	public enum WeaponSuggestionChoice
	{
		[Token(Token = "0x4002D88")]
		CANCEL = 0,
		[Token(Token = "0x4002D89")]
		CONTINUE_ANYWAY = 1,
		[Token(Token = "0x4002D8A")]
		BUY = 2,
		[Token(Token = "0x4002D8B")]
		EQUIP_UPGRADE = 3,
		[Token(Token = "0x4002D8C")]
		EQUIP_PLAY = 4
	}

	[Token(Token = "0x200082F")]
	private static class Events
	{
		[Token(Token = "0x4002D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly EventKey FirstLaunch;

		[Token(Token = "0x4002D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly EventKey GameStart;

		[Token(Token = "0x4002D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly EventKey GameQuit;

		[Token(Token = "0x4002D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly EventKey MontenegroEnd;

		[Token(Token = "0x4002D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly EventKey ZombieEnd;

		[Token(Token = "0x4002D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly EventKey MissionSkipped;

		[Token(Token = "0x4002D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly EventKey EnterMenu;

		[Token(Token = "0x4002D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly EventKey EnterShopPopup;

		[Token(Token = "0x4002D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly EventKey Sale;

		[Token(Token = "0x4002D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly EventKey Social;

		[Token(Token = "0x4002D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly EventKey Everyplay;

		[Token(Token = "0x4002D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly EventKey Leaderboard;

		[Token(Token = "0x4002D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly EventKey FriendConverted;

		[Token(Token = "0x4002D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly EventKey AppsFlyerLinkShared;

		[Token(Token = "0x4002D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly EventKey Settings;

		[Token(Token = "0x4002D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly EventKey ItemGranted;

		[Token(Token = "0x4002D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly EventKey LootClaimed;

		[Token(Token = "0x4002D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly EventKey BonusTriggered;

		[Token(Token = "0x4002D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly EventKey EnemyKilled;

		[Token(Token = "0x4002DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static readonly EventKey BodyDisposal;

		[Token(Token = "0x4002DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static readonly EventKey Reload;

		[Token(Token = "0x4002DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static readonly EventKey ZombieUpgradeClicked;

		[Token(Token = "0x4002DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly EventKey ZombieUpgradePurchased;

		[Token(Token = "0x4002DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly EventKey Heal;

		[Token(Token = "0x4002DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static readonly EventKey SoftCurrencyPurchased;

		[Token(Token = "0x4002DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static readonly EventKey SoftCurrencyPurchaseFailed;

		[Token(Token = "0x4002DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static readonly EventKey StarterPackPurchased;

		[Token(Token = "0x4002DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static readonly EventKey StarterPackPurchaseFailed;

		[Token(Token = "0x4002DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static readonly EventKey GunUnlocked;

		[Token(Token = "0x4002DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static readonly EventKey GunUnlockFailed;

		[Token(Token = "0x4002DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static readonly EventKey GunUpgraded;

		[Token(Token = "0x4002DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static readonly EventKey GunUpgradeFailed;

		[Token(Token = "0x4002DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static readonly EventKey GunInfoClicked;

		[Token(Token = "0x4002DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static readonly EventKey GunCustomized;

		[Token(Token = "0x4002DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static readonly EventKey GunTierFullyMastered;

		[Token(Token = "0x4002DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static readonly EventKey InsufficientFunds;

		[Token(Token = "0x4002DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static readonly EventKey PerkCompleted;

		[Token(Token = "0x4002DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static readonly EventKey PerkUnlocked;

		[Token(Token = "0x4002DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static readonly EventKey ScoreToBeatTapped;

		[Token(Token = "0x4002DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static readonly EventKey ChoosePersistence;

		[Token(Token = "0x4002DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static readonly EventKey PopupViewed;

		[Token(Token = "0x4002DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly EventKey WeaponSuggestionPopup;

		[Token(Token = "0x4002DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static readonly EventKey GDPRPopupShown;

		[Token(Token = "0x4002DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static readonly EventKey DDNATransaction;

		[Token(Token = "0x4002DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static readonly EventKey CampaignReceived;

		[Token(Token = "0x4002DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static readonly EventKey MissionStarted;

		[Token(Token = "0x4002DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static readonly EventKey MissionFailed;

		[Token(Token = "0x4002DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static readonly EventKey MissionCompleted;

		[Token(Token = "0x4002DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static readonly EventKey ReportCrash;

		[Token(Token = "0x4002DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static readonly EventKey SocialConnectionError;

		[Token(Token = "0x4002DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static readonly EventKey ResetMissionProgression;

		[Token(Token = "0x4002DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static readonly EventKey SurveyStarted;

		[Token(Token = "0x4002DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static readonly EventKey SurveyComplete;

		[Token(Token = "0x4002DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static readonly EventKey DeathValleyDownload;
	}

	[Token(Token = "0x2000830")]
	private static class Fields
	{
		[Token(Token = "0x4002DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Schema EventTimeStamp;

		[Token(Token = "0x4002DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Schema LocalTimeStamp;

		[Token(Token = "0x4002DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Schema SeqNum;

		[Token(Token = "0x4002DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Schema SessionSeqNum;

		[Token(Token = "0x4002DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Schema ViewSeqNum;

		[Token(Token = "0x4002DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Schema ModeSeqNum;

		[Token(Token = "0x4002DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Schema PopupSeqNum;

		[Token(Token = "0x4002DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Schema SCGold;

		[Token(Token = "0x4002DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Schema SCTokens;

		[Token(Token = "0x4002DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Schema InGameTokens;

		[Token(Token = "0x4002DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly Schema ProgressionID;

		[Token(Token = "0x4002DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly Schema ModeID;

		[Token(Token = "0x4002DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly Schema SocialUid;

		[Token(Token = "0x4002DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly Schema AdvertisingID;

		[Token(Token = "0x4002DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly Schema OnlineTimeTotal;

		[Token(Token = "0x4002DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static readonly Schema OfflineTimeTotal;

		[Token(Token = "0x4002DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static readonly Schema GameLanguage;

		[Token(Token = "0x4002DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly Schema DeviceType;

		[Token(Token = "0x4002DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly Schema DeviceModel;

		[Token(Token = "0x4002DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static readonly Schema OperatingSystem;

		[Token(Token = "0x4002DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static readonly Schema CPUCount;

		[Token(Token = "0x4002DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static readonly Schema GraphicsDeviceName;

		[Token(Token = "0x4002DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly Schema MemorySize;

		[Token(Token = "0x4002DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly Schema FromPause;

		[Token(Token = "0x4002DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static readonly Schema SKU;

		[Token(Token = "0x4002DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static readonly Schema EndType;

		[Token(Token = "0x4002DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static readonly Schema Time;

		[Token(Token = "0x4002DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static readonly Schema Score;

		[Token(Token = "0x4002DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static readonly Schema Weapon;

		[Token(Token = "0x4002DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static readonly Schema ShotsFired;

		[Token(Token = "0x4002DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static readonly Schema FPS;

		[Token(Token = "0x4002DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static readonly Schema MultipleKills;

		[Token(Token = "0x4002DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static readonly Schema LeaderboardRank;

		[Token(Token = "0x4002DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static readonly Schema RogueKilled;

		[Token(Token = "0x4002DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static readonly Schema ObjectiveAchieved;

		[Token(Token = "0x4002DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static readonly Schema SubObjectiveAchieved;

		[Token(Token = "0x4002DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static readonly Schema GoldFromRoulette;

		[Token(Token = "0x4002DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static readonly Schema GoldFromAssignment;

		[Token(Token = "0x4002DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static readonly Schema GoldFromGun;

		[Token(Token = "0x4002DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static readonly Schema IsTutorial;

		[Token(Token = "0x4002DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static readonly Schema DifficultySetting;

		[Token(Token = "0x4002DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly Schema WaveIDAtDeath;

		[Token(Token = "0x4002DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static readonly Schema TokensEarnedFromKills;

		[Token(Token = "0x4002DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static readonly Schema TokensEarnedFromPerkBonuses;

		[Token(Token = "0x4002DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static readonly Schema Headshots;

		[Token(Token = "0x4002DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static readonly Schema MinZoom;

		[Token(Token = "0x4002DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static readonly Schema NoHoldBreath;

		[Token(Token = "0x4002DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static readonly Schema NormalKills;

		[Token(Token = "0x4002DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static readonly Schema GoldenKills;

		[Token(Token = "0x4002DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static readonly Schema BansheeKills;

		[Token(Token = "0x4002DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static readonly Schema JuggernautKills;

		[Token(Token = "0x4002DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static readonly Schema BeastKills;

		[Token(Token = "0x4002DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static readonly Schema ExplosiveAmmoAbility;

		[Token(Token = "0x4002DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static readonly Schema SplitShotAbility;

		[Token(Token = "0x4002DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static readonly Schema MassConfusionAbility;

		[Token(Token = "0x4002DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static readonly Schema AttractiveBulletAbility;

		[Token(Token = "0x4002DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static readonly Schema MenuID;

		[Token(Token = "0x4002DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static readonly Schema MenuSource;

		[Token(Token = "0x4002DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public static readonly Schema MenuTransitionCount;

		[Token(Token = "0x4002DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public static readonly Schema TokenSaleOn;

		[Token(Token = "0x4002DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static readonly Schema GoldSaleOn;

		[Token(Token = "0x4002E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public static readonly Schema WeaponSaleOn;

		[Token(Token = "0x4002E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static readonly Schema PopupID;

		[Token(Token = "0x4002E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static readonly Schema ShopState;

		[Token(Token = "0x4002E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public static readonly Schema Price;

		[Token(Token = "0x4002E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public static readonly Schema SecurityStatus;

		[Token(Token = "0x4002E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public static readonly Schema TransactionID;

		[Token(Token = "0x4002E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public static readonly Schema Receipt;

		[Token(Token = "0x4002E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public static readonly Schema OriginalPurchaseDate;

		[Token(Token = "0x4002E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public static readonly Schema PurchaseDate;

		[Token(Token = "0x4002E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public static readonly Schema IsOriginalPurchase;

		[Token(Token = "0x4002E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public static readonly Schema ProductID;

		[Token(Token = "0x4002E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public static readonly Schema ProductName;

		[Token(Token = "0x4002E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public static readonly Schema ProductType;

		[Token(Token = "0x4002E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public static readonly Schema IsSeasonal;

		[Token(Token = "0x4002E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public static readonly Schema Action;

		[Token(Token = "0x4002E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public static readonly Schema Source;

		[Token(Token = "0x4002E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public static readonly Schema FriendsInvited;

		[Token(Token = "0x4002E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public static readonly Schema ItemID;

		[Token(Token = "0x4002E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public static readonly Schema Amount;

		[Token(Token = "0x4002E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public static readonly Schema Context;

		[Token(Token = "0x4002E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public static readonly Schema LootBoxName;

		[Token(Token = "0x4002E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public static readonly Schema LootGUID;

		[Token(Token = "0x4002E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public static readonly Schema LootType;

		[Token(Token = "0x4002E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public static readonly Schema LootQuantity;

		[Token(Token = "0x4002E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public static readonly Schema BonusID;

		[Token(Token = "0x4002E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public static readonly Schema Ammunition;

		[Token(Token = "0x4002E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public static readonly Schema EnemyID;

		[Token(Token = "0x4002E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public static readonly Schema IsHeadshot;

		[Token(Token = "0x4002E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public static readonly Schema IsMinZoom;

		[Token(Token = "0x4002E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public static readonly Schema IsNoHoldBreath;

		[Token(Token = "0x4002E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public static readonly Schema IsExtraction;

		[Token(Token = "0x4002E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public static readonly Schema IsLongShot;

		[Token(Token = "0x4002E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public static readonly Schema IsRogue;

		[Token(Token = "0x4002E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		public static readonly Schema IsQuick;

		[Token(Token = "0x4002E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public static readonly Schema IsUndetected;

		[Token(Token = "0x4002E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		public static readonly Schema IsOneShot;

		[Token(Token = "0x4002E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		public static readonly Schema IsMoving;

		[Token(Token = "0x4002E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		public static readonly Schema IsLured;

		[Token(Token = "0x4002E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public static readonly Schema IsInterrupted;

		[Token(Token = "0x4002E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public static readonly Schema IsExplosive;

		[Token(Token = "0x4002E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public static readonly Schema IsAccidental;

		[Token(Token = "0x4002E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public static readonly Schema IsXRay;

		[Token(Token = "0x4002E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public static readonly Schema IsCurrencyOnKill;

		[Token(Token = "0x4002E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public static readonly Schema IsChallengeTokenOnKill;

		[Token(Token = "0x4002E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public static readonly Schema IsRunning;

		[Token(Token = "0x4002E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public static readonly Schema IsDomino;

		[Token(Token = "0x4002E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public static readonly Schema AlertLevel;

		[Token(Token = "0x4002E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public static readonly Schema CurrencyType;

		[Token(Token = "0x4002E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public static readonly Schema CurrencyName;

		[Token(Token = "0x4002E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		public static readonly Schema GunID;

		[Token(Token = "0x4002E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		public static readonly Schema UnlockSource;

		[Token(Token = "0x4002E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public static readonly Schema GunLevel;

		[Token(Token = "0x4002E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		public static readonly Schema GunMasteryLevel;

		[Token(Token = "0x4002E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		public static readonly Schema WeaponTierId;

		[Token(Token = "0x4002E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public static readonly Schema LevelUnlocked;

		[Token(Token = "0x4002E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public static readonly Schema InfoType;

		[Token(Token = "0x4002E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public static readonly Schema InfoID;

		[Token(Token = "0x4002E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public static readonly Schema CustomizedAbilities;

		[Token(Token = "0x4002E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public static readonly Schema CustomizedPerks;

		[Token(Token = "0x4002E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public static readonly Schema SCPackID;

		[Token(Token = "0x4002E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		public static readonly Schema UpgradeID;

		[Token(Token = "0x4002E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public static readonly Schema UpgradeType;

		[Token(Token = "0x4002E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public static readonly Schema HealAmount;

		[Token(Token = "0x4002E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		public static readonly Schema TabShown;

		[Token(Token = "0x4002E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		public static readonly Schema PlayersShown;

		[Token(Token = "0x4002E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		public static readonly Schema Tier;

		[Token(Token = "0x4002E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public static readonly Schema Position;

		[Token(Token = "0x4002E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		public static readonly Schema PerkID;

		[Token(Token = "0x4002E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		public static readonly Schema ConvertedFriendUID;

		[Token(Token = "0x4002E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		public static readonly Schema ChosenPersistence;

		[Token(Token = "0x4002E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		public static readonly Schema LocalUid;

		[Token(Token = "0x4002E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		public static readonly Schema CloudUid;

		[Token(Token = "0x4002E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		public static readonly Schema LocalUserID;

		[Token(Token = "0x4002E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		public static readonly Schema CloudUserID;

		[Token(Token = "0x4002E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		public static readonly Schema PopupType;

		[Token(Token = "0x4002E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		public static readonly Schema PopupChoice;

		[Token(Token = "0x4002E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		public static readonly Schema PopupTitle;

		[Token(Token = "0x4002E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		public static readonly Schema PopupDescription;

		[Token(Token = "0x4002E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		public static readonly Schema TimeViewed;

		[Token(Token = "0x4002E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		public static readonly Schema IsInsufficientFunds;

		[Token(Token = "0x4002E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		public static readonly Schema CampaignTransactionID;

		[Token(Token = "0x4002E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		public static readonly Schema SuggestedWeapon1;

		[Token(Token = "0x4002E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		public static readonly Schema SuggestedWeapon2;

		[Token(Token = "0x4002E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		public static readonly Schema SelectedOption;

		[Token(Token = "0x4002E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		public static readonly Schema MissingCurrencyAmount;

		[Token(Token = "0x4002E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		public static readonly Schema MissingCurrencyType;

		[Token(Token = "0x4002E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		public static readonly Schema SuggestedPack;

		[Token(Token = "0x4002E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		public static readonly Schema FailedPurchase;

		[Token(Token = "0x4002E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		public static readonly Schema FailedPurchaseItem;

		[Token(Token = "0x4002E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		public static readonly Schema Reason;

		[Token(Token = "0x4002E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		public static readonly Schema Reaction;

		[Token(Token = "0x4002E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public static readonly Schema Status;

		[Token(Token = "0x4002E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		public static readonly Schema MissionName;

		[Token(Token = "0x4002E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		public static readonly Schema DDNAIsTutorial;

		[Token(Token = "0x4002E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		public static readonly Schema TerminationReason;

		[Token(Token = "0x4002E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		public static readonly Schema DDNATransactionName;

		[Token(Token = "0x4002E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		public static readonly Schema DDNATransactionID;

		[Token(Token = "0x4002E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		public static readonly Schema DDNATransactionReceiptSignature;

		[Token(Token = "0x4002E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		public static readonly Schema DDNAProductID;

		[Token(Token = "0x4002E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		public static readonly Schema DDNAIsSeasonal;

		[Token(Token = "0x4002E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		public static readonly Schema DDNATransactionServer;

		[Token(Token = "0x4002E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		public static readonly Schema DDNATransactionReceipt;

		[Token(Token = "0x4002E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		public static readonly Schema DDNATransactionType;

		[Token(Token = "0x4002E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		public static readonly Schema DDNAProductsReceived;

		[Token(Token = "0x4002E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		public static readonly Schema DDNAProductsSpent;

		[Token(Token = "0x4002E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		public static readonly Schema BundleContents;

		[Token(Token = "0x4002E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		public static readonly Schema SurveyCollectorId;

		[Token(Token = "0x4002E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		public static readonly Schema SurveyCompletedSuccess;

		[Token(Token = "0x4002E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		public static readonly Schema BuildID;

		[Token(Token = "0x4002E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		public static readonly Schema ErrorMessage;

		[Token(Token = "0x4002E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		public static readonly Schema StackTrace;

		[Token(Token = "0x4002E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		public static readonly Schema PlayerUid;

		[Token(Token = "0x4002E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		public static readonly Schema SocialID;

		[Token(Token = "0x4002E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		public static readonly Schema LoadedScene;

		[Token(Token = "0x4002E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		public static readonly Schema ElapsedTime;

		[Token(Token = "0x4002E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		public static readonly Schema LookAtX;

		[Token(Token = "0x4002E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		public static readonly Schema LookAtY;

		[Token(Token = "0x4002E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		public static readonly Schema InScope;

		[Token(Token = "0x4002E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		public static readonly Schema GameState;

		[Token(Token = "0x4002E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		public static readonly Schema TotalMemory;

		[Token(Token = "0x4002E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		public static readonly Schema InstallationID;

		[Token(Token = "0x4002E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		public static readonly Schema GPUName;

		[Token(Token = "0x4002E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		public static readonly Schema MainMissionID;

		[Token(Token = "0x4002E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		public static readonly Schema PrimaryKills;

		[Token(Token = "0x4002E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		public static readonly Schema TertiaryKills;

		[Token(Token = "0x4002E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		public static readonly Schema RoguesKilled;

		[Token(Token = "0x4002E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		public static readonly Schema TotalKills;

		[Token(Token = "0x4002E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		public static readonly Schema TotalShots;

		[Token(Token = "0x4002E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		public static readonly Schema WeaponName;

		[Token(Token = "0x4002E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		public static readonly Schema StackTraceHash;

		[Token(Token = "0x4002E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		public static readonly Schema SentFromStart;

		[Token(Token = "0x4002E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		public static readonly Schema UnityHandledError;

		[Token(Token = "0x4002E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		public static readonly Schema DeathValleyDownloadState;

		[Token(Token = "0x4002E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		public static readonly Schema DeathValleyDownloadScene;

		[Token(Token = "0x4002E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		public static readonly Schema ErrorCode;

		[Token(Token = "0x4002E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		public static readonly Schema AuthType;

		[Token(Token = "0x4002E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		internal static readonly Schema IsPauseSettings;
	}

	[Token(Token = "0x2000831")]
	private class GunInfoItem
	{
		[Token(Token = "0x4002E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB640", Offset = "0x5BB640")]
		private string _003CGunName_003Ek__BackingField;

		[Token(Token = "0x4002E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB650", Offset = "0x5BB650")]
		private string _003CInfoItemName_003Ek__BackingField;

		[Token(Token = "0x170006D2")]
		public string GunName
		{
			[Token(Token = "0x60035AB")]
			[Address(RVA = "0xA4914C", Offset = "0xA4914C", VA = "0xA4914C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231F0", Offset = "0x6231F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60035AC")]
			[Address(RVA = "0xA49154", Offset = "0xA49154", VA = "0xA49154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623200", Offset = "0x623200")]
			set
			{
			}
		}

		[Token(Token = "0x170006D3")]
		public string InfoItemName
		{
			[Token(Token = "0x60035AD")]
			[Address(RVA = "0xA4915C", Offset = "0xA4915C", VA = "0xA4915C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623210", Offset = "0x623210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60035AE")]
			[Address(RVA = "0xA49164", Offset = "0xA49164", VA = "0xA49164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623220", Offset = "0x623220")]
			set
			{
			}
		}

		[Token(Token = "0x60035AF")]
		[Address(RVA = "0xA4916C", Offset = "0xA4916C", VA = "0xA4916C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x60035B0")]
		[Address(RVA = "0xA49298", Offset = "0xA49298", VA = "0xA49298", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60035B1")]
		[Address(RVA = "0xA492EC", Offset = "0xA492EC", VA = "0xA492EC")]
		public GunInfoItem()
		{
		}
	}

	[Token(Token = "0x2000832")]
	private class MenuTransition
	{
		[Token(Token = "0x4002E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB660", Offset = "0x5BB660")]
		private string _003CSource_003Ek__BackingField;

		[Token(Token = "0x4002E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB670", Offset = "0x5BB670")]
		private string _003CDestination_003Ek__BackingField;

		[Token(Token = "0x170006D4")]
		public string Source
		{
			[Token(Token = "0x60035B2")]
			[Address(RVA = "0xA492F4", Offset = "0xA492F4", VA = "0xA492F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623230", Offset = "0x623230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60035B3")]
			[Address(RVA = "0xA492FC", Offset = "0xA492FC", VA = "0xA492FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623240", Offset = "0x623240")]
			set
			{
			}
		}

		[Token(Token = "0x170006D5")]
		public string Destination
		{
			[Token(Token = "0x60035B4")]
			[Address(RVA = "0xA49304", Offset = "0xA49304", VA = "0xA49304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623250", Offset = "0x623250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60035B5")]
			[Address(RVA = "0xA4930C", Offset = "0xA4930C", VA = "0xA4930C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623260", Offset = "0x623260")]
			set
			{
			}
		}

		[Token(Token = "0x60035B6")]
		[Address(RVA = "0xA49314", Offset = "0xA49314", VA = "0xA49314", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x60035B7")]
		[Address(RVA = "0xA49440", Offset = "0xA49440", VA = "0xA49440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60035B8")]
		[Address(RVA = "0xA49494", Offset = "0xA49494", VA = "0xA49494")]
		public MenuTransition()
		{
		}
	}

	[Token(Token = "0x2000833")]
	private class DelayedGameEndEvent
	{
		[Serializable]
		[Token(Token = "0x2000834")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596740", Offset = "0x596740")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002E94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002E95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<EventAttribute, bool> _003C_003E9__17_0;

			[Token(Token = "0x4002E96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<EventAttribute, string> _003C_003E9__18_0;

			[Token(Token = "0x4002E97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<EventAttribute, object> _003C_003E9__18_1;

			[Token(Token = "0x60035C5")]
			[Address(RVA = "0xA46F14", Offset = "0xA46F14", VA = "0xA46F14")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60035C6")]
			[Address(RVA = "0xA46F1C", Offset = "0xA46F1C", VA = "0xA46F1C")]
			internal bool _003CSetPlayerRank_003Eb__17_0(EventAttribute a)
			{
				return default(bool);
			}

			[Token(Token = "0x60035C7")]
			[Address(RVA = "0xA46FA0", Offset = "0xA46FA0", VA = "0xA46FA0")]
			internal string _003CCacheDDNAMissionEvents_003Eb__18_0(EventAttribute e)
			{
				return null;
			}

			[Token(Token = "0x60035C8")]
			[Address(RVA = "0xA46FAC", Offset = "0xA46FAC", VA = "0xA46FAC")]
			internal object _003CCacheDDNAMissionEvents_003Eb__18_1(EventAttribute e)
			{
				return null;
			}
		}

		[Token(Token = "0x4002E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EventKey _schema;

		[Token(Token = "0x4002E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EventAttribute[] _attributes;

		[Token(Token = "0x4002E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> _ddnaMissionEvents;

		[Token(Token = "0x4002E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LeaderboardRecord _playerRecord;

		[Token(Token = "0x4002E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _schemaSet;

		[Token(Token = "0x4002E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _attributesSet;

		[Token(Token = "0x4002E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool _playerRecordSet;

		[Token(Token = "0x170006D6")]
		public EventKey Schema
		{
			[Token(Token = "0x60035B9")]
			[Address(RVA = "0x8C0294", Offset = "0x8C0294", VA = "0x8C0294")]
			set
			{
			}
		}

		[Token(Token = "0x170006D7")]
		public EventAttribute[] Attributes
		{
			[Token(Token = "0x60035BA")]
			[Address(RVA = "0x8C02F8", Offset = "0x8C02F8", VA = "0x8C02F8")]
			set
			{
			}
		}

		[Token(Token = "0x170006D8")]
		public LeaderboardRecord PlayerRecord
		{
			[Token(Token = "0x60035BB")]
			[Address(RVA = "0x8C0308", Offset = "0x8C0308", VA = "0x8C0308")]
			set
			{
			}
		}

		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x8C0318", Offset = "0x8C0318", VA = "0x8C0318")]
		public void RegisterScorePosted()
		{
		}

		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x8C0454", Offset = "0x8C0454", VA = "0x8C0454")]
		private void OnScorePosted(bool success)
		{
		}

		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x8C0744", Offset = "0x8C0744", VA = "0x8C0744")]
		private void OnGetScoreComplete(LeaderboardRecord record)
		{
		}

		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x8C02A4", Offset = "0x8C02A4", VA = "0x8C02A4")]
		private void TrySendEvent()
		{
		}

		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x8C0754", Offset = "0x8C0754", VA = "0x8C0754")]
		private void SetPlayerRank()
		{
		}

		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x8C0984", Offset = "0x8C0984", VA = "0x8C0984")]
		private void CacheDDNAMissionEvents()
		{
		}

		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x8C0B5C", Offset = "0x8C0B5C", VA = "0x8C0B5C")]
		private void SendEvent()
		{
		}

		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x8C0BF8", Offset = "0x8C0BF8", VA = "0x8C0BF8")]
		public DelayedGameEndEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000835")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596750", Offset = "0x596750")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<ScoreTallyView.TallyItem> _003C_003E9__108_0;

		[Token(Token = "0x4002E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<LeaderboardRecord> _003C_003E9__122_0;

		[Token(Token = "0x4002E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Converter<string, DataModel> _003C_003E9__154_0;

		[Token(Token = "0x4002E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<EventAttribute, bool> _003C_003E9__192_0;

		[Token(Token = "0x4002E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<char, bool> _003C_003E9__276_0;

		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x8C0134", Offset = "0x8C0134", VA = "0x8C0134")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x8C013C", Offset = "0x8C013C", VA = "0x8C013C")]
		internal bool _003CGetZombieEndAttributes_003Eb__108_0(ScoreTallyView.TallyItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x8C0148", Offset = "0x8C0148", VA = "0x8C0148")]
		internal bool _003CGetLeaderboardEventAttributes_003Eb__122_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x8C0164", Offset = "0x8C0164", VA = "0x8C0164")]
		internal DataModel _003CInit_003Eb__154_0(string s)
		{
			return null;
		}

		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x8C01E0", Offset = "0x8C01E0", VA = "0x8C01E0")]
		internal bool _003CGamePlayEnd_003Eb__192_0(EventAttribute a)
		{
			return default(bool);
		}

		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x8C026C", Offset = "0x8C026C", VA = "0x8C026C")]
		internal bool _003CModifyAbilityPerkNames_003Eb__276_0(char c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002D1A")]
	private const int DEFAULT_ATTRIBUTES_COUNT = 16;

	[Token(Token = "0x4002D1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB580", Offset = "0x5BB580")]
	private Dictionary<ScoreTallyView.TallyItem, short> _003CTallyItemsScore_003Ek__BackingField;

	[Token(Token = "0x4002D1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB590", Offset = "0x5BB590")]
	private Dictionary<string, int> _003CRoguesKilledIntelLevel_003Ek__BackingField;

	[Token(Token = "0x4002D1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5A0", Offset = "0x5BB5A0")]
	private int _003CRouletteGold_003Ek__BackingField;

	[Token(Token = "0x4002D1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5B0", Offset = "0x5BB5B0")]
	private int _003CBonusGold_003Ek__BackingField;

	[Token(Token = "0x4002D1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5C0", Offset = "0x5BB5C0")]
	private int _003CAssignmentGold_003Ek__BackingField;

	[Token(Token = "0x4002D20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5D0", Offset = "0x5BB5D0")]
	private int _003CKillTokens_003Ek__BackingField;

	[Token(Token = "0x4002D21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5E0", Offset = "0x5BB5E0")]
	private int _003CBonusTokens_003Ek__BackingField;

	[Token(Token = "0x4002D22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB5F0", Offset = "0x5BB5F0")]
	private int _003CWaveIDAtDeath_003Ek__BackingField;

	[Token(Token = "0x4002D23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB600", Offset = "0x5BB600")]
	private int _003CCurrentProgress_003Ek__BackingField;

	[Token(Token = "0x4002D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB610", Offset = "0x5BB610")]
	private int _003CCurrentProgress2_003Ek__BackingField;

	[Token(Token = "0x4002D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB620", Offset = "0x5BB620")]
	private string _003CLastPlayedZombieDifficulty_003Ek__BackingField;

	[Token(Token = "0x4002D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool _inPopup;

	[Token(Token = "0x4002D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool _firstLaunch;

	[Token(Token = "0x4002D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	private bool _inGame;

	[Token(Token = "0x4002D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
	private bool _isExtraction;

	[Token(Token = "0x4002D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, short> _abilitiesUsed;

	[Token(Token = "0x4002D2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<object> _itemsClicked;

	[Token(Token = "0x4002D2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _lbClickedZombieFriends;

	[Token(Token = "0x4002D2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool _lbClickedZombieGlobal;

	[Token(Token = "0x4002D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	private bool _lbClickedMontenegroFriends;

	[Token(Token = "0x4002D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
	private bool _lbClickedMontenegroGlobal;

	[Token(Token = "0x4002D30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<SettingID, bool> _settingsChanged;

	[Token(Token = "0x4002D31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private AnalyticsPersistenceManager _analyticsPersistence;

	[Token(Token = "0x4002D32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private SaveGameManager _saveGameManager;

	[Token(Token = "0x4002D33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private PlayerProfileData _playerProfile;

	[Token(Token = "0x4002D34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Shop _shop;

	[Token(Token = "0x4002D35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private MissionManager _missionManager;

	[Token(Token = "0x4002D36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameEventsManager _gameEventsManager;

	[Token(Token = "0x4002D37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameStats _gameStats;

	[Token(Token = "0x4002D38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool _calculateFrames;

	[Token(Token = "0x4002D39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int _frameCount;

	[Token(Token = "0x4002D3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly ModelContainer _modelContainer;

	[Token(Token = "0x4002D3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float _completionStartTime;

	[Token(Token = "0x4002D3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool _applicationStarted;

	[Token(Token = "0x4002D3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public MainMenuSource MenuSource;

	[Token(Token = "0x4002D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass _AdvertisingIdClient;

	[Token(Token = "0x4002D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int _ManagedThreadId;

	[Token(Token = "0x4002D41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly List<string> _seasonalGuns;

	[Token(Token = "0x4002D42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly Dictionary<ScoreTallyView.TallyItem, Schema> _killTypeFields;

	[Token(Token = "0x4002D43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly List<Schema> _detailedKillTypeFields;

	[Token(Token = "0x4002D44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly Schema[] _zombieKillTypes;

	[Token(Token = "0x4002D45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly Dictionary<ScoreTallyView.TallyItem, ZombieType> _tallyZombieType;

	[Token(Token = "0x4002D46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private DelayedGameEndEvent _pendingGameEndEvent;

	[Token(Token = "0x4002D47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Dictionary<MenuTransition, Dictionary<Schema, object>> _menuEvents;

	[Token(Token = "0x4002D48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Dictionary<Target, Dictionary<Schema, object>> _enemiesKilled;

	[Token(Token = "0x4002D49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Dictionary<Target, HashSet<string>> _enemiesPowerUpsUsed;

	[Token(Token = "0x4002D4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private List<Dictionary<Schema, object>> _bodyDisposals;

	[Token(Token = "0x4002D4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private List<Dictionary<Schema, object>> _healEvents;

	[Token(Token = "0x4002D4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<Dictionary<Schema, object>> _upgradesPurchased;

	[Token(Token = "0x4002D4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<Dictionary<Schema, object>> _upgradesClicked;

	[Token(Token = "0x4002D4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<Dictionary<Schema, object>> _bonusesTriggered;

	[Token(Token = "0x4002D4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<Dictionary<Schema, object>> _reloads;

	[Token(Token = "0x4002D50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<Dictionary<Schema, object>> _perksCompleted;

	[Token(Token = "0x4002D51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private List<Dictionary<Schema, object>> _scoreToBeatTaps;

	[Token(Token = "0x4002D52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private IDictionary<string, int> _iso4217;

	[Token(Token = "0x170006C6")]
	public bool IsSettingChanged
	{
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x849600", Offset = "0x849600", VA = "0x849600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006C7")]
	public Dictionary<ScoreTallyView.TallyItem, short> TallyItemsScore
	{
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x849660", Offset = "0x849660", VA = "0x849660")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623070", Offset = "0x623070")]
		get
		{
			return null;
		}
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x849668", Offset = "0x849668", VA = "0x849668")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623080", Offset = "0x623080")]
		set
		{
		}
	}

	[Token(Token = "0x170006C8")]
	public Dictionary<string, int> RoguesKilledIntelLevel
	{
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x849670", Offset = "0x849670", VA = "0x849670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623090", Offset = "0x623090")]
		get
		{
			return null;
		}
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x849678", Offset = "0x849678", VA = "0x849678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230A0", Offset = "0x6230A0")]
		private set
		{
		}
	}

	[Token(Token = "0x170006C9")]
	public int RouletteGold
	{
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x849680", Offset = "0x849680", VA = "0x849680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230B0", Offset = "0x6230B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x849688", Offset = "0x849688", VA = "0x849688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230C0", Offset = "0x6230C0")]
		set
		{
		}
	}

	[Token(Token = "0x170006CA")]
	public int BonusGold
	{
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x849690", Offset = "0x849690", VA = "0x849690")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230D0", Offset = "0x6230D0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x849698", Offset = "0x849698", VA = "0x849698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230E0", Offset = "0x6230E0")]
		set
		{
		}
	}

	[Token(Token = "0x170006CB")]
	public int AssignmentGold
	{
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x8496A0", Offset = "0x8496A0", VA = "0x8496A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6230F0", Offset = "0x6230F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x8496A8", Offset = "0x8496A8", VA = "0x8496A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623100", Offset = "0x623100")]
		set
		{
		}
	}

	[Token(Token = "0x170006CC")]
	public int KillTokens
	{
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x8496B0", Offset = "0x8496B0", VA = "0x8496B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623110", Offset = "0x623110")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x8496B8", Offset = "0x8496B8", VA = "0x8496B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623120", Offset = "0x623120")]
		set
		{
		}
	}

	[Token(Token = "0x170006CD")]
	public int BonusTokens
	{
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x8496C0", Offset = "0x8496C0", VA = "0x8496C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623130", Offset = "0x623130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x8496C8", Offset = "0x8496C8", VA = "0x8496C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623140", Offset = "0x623140")]
		set
		{
		}
	}

	[Token(Token = "0x170006CE")]
	public int WaveIDAtDeath
	{
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x8496D0", Offset = "0x8496D0", VA = "0x8496D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623150", Offset = "0x623150")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x8496D8", Offset = "0x8496D8", VA = "0x8496D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623160", Offset = "0x623160")]
		set
		{
		}
	}

	[Token(Token = "0x170006CF")]
	public int CurrentProgress
	{
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x8496E0", Offset = "0x8496E0", VA = "0x8496E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623170", Offset = "0x623170")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x8496E8", Offset = "0x8496E8", VA = "0x8496E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623180", Offset = "0x623180")]
		set
		{
		}
	}

	[Token(Token = "0x170006D0")]
	public int CurrentProgress2
	{
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x8496F0", Offset = "0x8496F0", VA = "0x8496F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623190", Offset = "0x623190")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x8496F8", Offset = "0x8496F8", VA = "0x8496F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231A0", Offset = "0x6231A0")]
		set
		{
		}
	}

	[Token(Token = "0x170006D1")]
	public string LastPlayedZombieDifficulty
	{
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x849700", Offset = "0x849700", VA = "0x849700")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231B0", Offset = "0x6231B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x849708", Offset = "0x849708", VA = "0x849708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231C0", Offset = "0x6231C0")]
		set
		{
		}
	}

	[Token(Token = "0x140000AE")]
	public event Action OnSessionReset
	{
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x849710", Offset = "0x849710", VA = "0x849710")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231D0", Offset = "0x6231D0")]
		add
		{
		}
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x8497B0", Offset = "0x8497B0", VA = "0x8497B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6231E0", Offset = "0x6231E0")]
		remove
		{
		}
	}

	[Token(Token = "0x60034FB")]
	[Address(RVA = "0x849850", Offset = "0x849850", VA = "0x849850", Slot = "4")]
	protected override EventAttribute[] GetDefaultAttributes()
	{
		return null;
	}

	[Token(Token = "0x60034FC")]
	[Address(RVA = "0x84AB84", Offset = "0x84AB84", VA = "0x84AB84")]
	private void AddDefaultAttributesToDict(Dictionary<Schema, object> specificAttributes)
	{
	}

	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x84AA48", Offset = "0x84AA48", VA = "0x84AA48")]
	public string GetMode()
	{
		return null;
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x84AC4C", Offset = "0x84AC4C", VA = "0x84AC4C")]
	private static EventAttribute[] GetGameSpecificDefaultAttributes()
	{
		return null;
	}

	[Token(Token = "0x60034FF")]
	[Address(RVA = "0x84AC94", Offset = "0x84AC94", VA = "0x84AC94")]
	private static EventAttribute[] GetGameStartAttribute(bool fromPause)
	{
		return null;
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0x84B218", Offset = "0x84B218", VA = "0x84B218")]
	private static EventAttribute[] GetDeathValleyDownloadStateChangedAttributes(string state, string scene)
	{
		return null;
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0x84B380", Offset = "0x84B380", VA = "0x84B380")]
	private static EventAttribute[] GetPopupViewedAttributes(string type, string choice, float timeViewed, string title, string description, long campaignTransactionID, [Optional][DefaultParameterValue(0)] int missingCurrency, [Optional] string missingCurrencyType, [Optional][DefaultParameterValue(0)] InsufficientFundsSource attemptedPurchase, [Optional] string attemptedPurchaseItem, [Optional] string suggestedPack)
	{
		return null;
	}

	[Token(Token = "0x6003502")]
	[Address(RVA = "0x84BA00", Offset = "0x84BA00", VA = "0x84BA00")]
	private static EventAttribute[] GetFriendConvertedAttributes(string friendUID)
	{
		return null;
	}

	[Token(Token = "0x6003503")]
	[Address(RVA = "0x84BB14", Offset = "0x84BB14", VA = "0x84BB14")]
	private static EventAttribute[] GetChoosePersistenceAttributes(string selectedPersistence, string localUserID, string cloudUserID, string localUid, string cloudUid)
	{
		return null;
	}

	[Token(Token = "0x6003504")]
	[Address(RVA = "0x84BD74", Offset = "0x84BD74", VA = "0x84BD74")]
	public bool IsMontenegro()
	{
		return default(bool);
	}

	[Token(Token = "0x6003505")]
	[Address(RVA = "0x84BE58", Offset = "0x84BE58", VA = "0x84BE58")]
	public EventAttribute[] GetGamePlayEndAttributes([Optional] string contractEndType, bool isMontenegro = true)
	{
		return null;
	}

	[Token(Token = "0x6003506")]
	[Address(RVA = "0x84CA7C", Offset = "0x84CA7C", VA = "0x84CA7C")]
	private EventAttribute[] GetMontenegroEndAttributes(bool killedTarget)
	{
		return null;
	}

	[Token(Token = "0x6003507")]
	[Address(RVA = "0x84CF84", Offset = "0x84CF84", VA = "0x84CF84")]
	private EventAttribute[] GetZombieEndAttributes()
	{
		return null;
	}

	[Token(Token = "0x6003508")]
	[Address(RVA = "0x84DBDC", Offset = "0x84DBDC", VA = "0x84DBDC")]
	private static EventAttribute[] GetMissionSkippedAttributes(string currencyType, string currencyName, int cost)
	{
		return null;
	}

	[Token(Token = "0x6003509")]
	[Address(RVA = "0x84DDB8", Offset = "0x84DDB8", VA = "0x84DDB8")]
	public string RenameMenuTab(string tab)
	{
		return null;
	}

	[Token(Token = "0x600350A")]
	[Address(RVA = "0x84DF24", Offset = "0x84DF24", VA = "0x84DF24")]
	private static EventAttribute[] GetShopPopupAttributes(ShopPopup popup)
	{
		return null;
	}

	[Token(Token = "0x600350B")]
	[Address(RVA = "0x84E128", Offset = "0x84E128", VA = "0x84E128")]
	private static EventAttribute[] GetSoftCurrencyPurchasedAttributes(Offer offer)
	{
		return null;
	}

	[Token(Token = "0x600350C")]
	[Address(RVA = "0x84E4B8", Offset = "0x84E4B8", VA = "0x84E4B8")]
	private static EventAttribute[] GetSoftCurrencyPurchaseAttemptAttributes(string item)
	{
		return null;
	}

	[Token(Token = "0x600350D")]
	[Address(RVA = "0x84E390", Offset = "0x84E390", VA = "0x84E390")]
	private static void GetCurrencyPriceInfo(Offer offer, out string currencyType, out string currencyName, out float price)
	{
	}

	[Token(Token = "0x600350E")]
	[Address(RVA = "0x84E5CC", Offset = "0x84E5CC", VA = "0x84E5CC")]
	private static EventAttribute[] GetStarterPackPurchasedAttributes(Offer offer)
	{
		return null;
	}

	[Token(Token = "0x600350F")]
	[Address(RVA = "0x84E7E8", Offset = "0x84E7E8", VA = "0x84E7E8")]
	private EventAttribute[] GetSocialEventAttributes(SocialAction action, SocialSource source, [Optional] IEnumerable<string> friendsInvitedIDs)
	{
		return null;
	}

	[Token(Token = "0x6003510")]
	[Address(RVA = "0x84EB74", Offset = "0x84EB74", VA = "0x84EB74")]
	private static EventAttribute[] GetEveryplayEventAttributes(EveryplayAction action)
	{
		return null;
	}

	[Token(Token = "0x6003511")]
	[Address(RVA = "0x84ECD4", Offset = "0x84ECD4", VA = "0x84ECD4")]
	private static void GetPurchaseDateInfo(string receipt, out string originalPurchaseDate, out string purchaseDate)
	{
	}

	[Token(Token = "0x6003512")]
	[Address(RVA = "0x84F0DC", Offset = "0x84F0DC", VA = "0x84F0DC")]
	private EventAttribute[] GetSaleAttributes(Transaction transaction, Offer offer)
	{
		return null;
	}

	[Token(Token = "0x6003513")]
	[Address(RVA = "0x84FE90", Offset = "0x84FE90", VA = "0x84FE90")]
	private static bool IsSeasonalWeapon(string productName)
	{
		return default(bool);
	}

	[Token(Token = "0x6003514")]
	[Address(RVA = "0x84F948", Offset = "0x84F948", VA = "0x84F948")]
	private void UpdatePurchaseStats(string productName, string productType)
	{
	}

	[Token(Token = "0x6003515")]
	[Address(RVA = "0x84FF1C", Offset = "0x84FF1C", VA = "0x84FF1C")]
	private EventAttribute[] GetLeaderboardEventAttributes()
	{
		return null;
	}

	[Token(Token = "0x6003516")]
	[Address(RVA = "0x850574", Offset = "0x850574", VA = "0x850574")]
	private static EventAttribute[] GetItemGrantedAttributes(string item, int amount, string source)
	{
		return null;
	}

	[Token(Token = "0x6003517")]
	[Address(RVA = "0x850750", Offset = "0x850750", VA = "0x850750")]
	private static EventAttribute[] GetLootClaimedAttributes(string boxName, string lootGUID, LootBoxDroppedItem item)
	{
		return null;
	}

	[Token(Token = "0x6003518")]
	[Address(RVA = "0x8509A0", Offset = "0x8509A0", VA = "0x8509A0")]
	private static EventAttribute[] GetPerkAttributes(string perk)
	{
		return null;
	}

	[Token(Token = "0x6003519")]
	[Address(RVA = "0x850AB4", Offset = "0x850AB4", VA = "0x850AB4")]
	private static EventAttribute[] GetGunCustomizedAttributes(BlueprintItemView blueprint)
	{
		return null;
	}

	[Token(Token = "0x600351A")]
	[Address(RVA = "0x8512A8", Offset = "0x8512A8", VA = "0x8512A8")]
	private static EventAttribute[] GetGunTierFullyMasteredAttributes(int tierId)
	{
		return null;
	}

	[Token(Token = "0x600351B")]
	[Address(RVA = "0x8513E4", Offset = "0x8513E4", VA = "0x8513E4")]
	private static EventAttribute[] GetGunAttributes(string gun)
	{
		return null;
	}

	[Token(Token = "0x600351C")]
	[Address(RVA = "0x851530", Offset = "0x851530", VA = "0x851530")]
	private static EventAttribute[] GetGunAttributes(string gun, int level, int masteryLevel)
	{
		return null;
	}

	[Token(Token = "0x600351D")]
	[Address(RVA = "0x851760", Offset = "0x851760", VA = "0x851760")]
	private static EventAttribute[] GetGunAttributes(GunUnlockType unlockSource, string gun, string currencyType, string currencyName, object price)
	{
		return null;
	}

	[Token(Token = "0x600351E")]
	[Address(RVA = "0x851A70", Offset = "0x851A70", VA = "0x851A70")]
	private static EventAttribute[] GetGunAttributes(string gun, int level, string currencyType, string currencyName, object price, int masteryLevel)
	{
		return null;
	}

	[Token(Token = "0x600351F")]
	[Address(RVA = "0x851D98", Offset = "0x851D98", VA = "0x851D98")]
	private static EventAttribute[] GetGunInfoAttributes(string infoType, string infoID, int levelUnlocked, string gun, int level, int masteryLevel)
	{
		return null;
	}

	[Token(Token = "0x6003520")]
	[Address(RVA = "0x8520CC", Offset = "0x8520CC", VA = "0x8520CC")]
	private EventAttribute[] GetSettingsAttributes(bool isPause = false)
	{
		return null;
	}

	[Token(Token = "0x6003521")]
	[Address(RVA = "0x852440", Offset = "0x852440", VA = "0x852440")]
	public static string GetInstallationID()
	{
		return null;
	}

	[Token(Token = "0x6003522")]
	[Address(RVA = "0x84B208", Offset = "0x84B208", VA = "0x84B208")]
	public static string GetDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x6003523")]
	[Address(RVA = "0x852510", Offset = "0x852510", VA = "0x852510")]
	public static string GetDeviceGPUName()
	{
		return null;
	}

	[Token(Token = "0x6003524")]
	[Address(RVA = "0x84A398", Offset = "0x84A398", VA = "0x84A398")]
	public static string GetAdvertisingID()
	{
		return null;
	}

	[Token(Token = "0x6003525")]
	[Address(RVA = "0x84B210", Offset = "0x84B210", VA = "0x84B210")]
	public static string GetOS()
	{
		return null;
	}

	[Token(Token = "0x6003526")]
	[Address(RVA = "0x852518", Offset = "0x852518", VA = "0x852518")]
	public static string GetBuildID()
	{
		return null;
	}

	[Token(Token = "0x6003527")]
	[Address(RVA = "0x84A924", Offset = "0x84A924", VA = "0x84A924")]
	public static short GetMainMissionID(MissionManager missionManager)
	{
		return default(short);
	}

	[Token(Token = "0x6003528")]
	[Address(RVA = "0x84DB48", Offset = "0x84DB48", VA = "0x84DB48")]
	public bool GetIsTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x6003529")]
	[Address(RVA = "0x84A614", Offset = "0x84A614", VA = "0x84A614")]
	public static string GetPlayerSocialID()
	{
		return null;
	}

	[Token(Token = "0x600352A")]
	[Address(RVA = "0x852620", Offset = "0x852620", VA = "0x852620")]
	public static bool IsLoadedCurrentWeapon(PlayerProfileData playerProfileData)
	{
		return default(bool);
	}

	[Token(Token = "0x600352B")]
	[Address(RVA = "0x84C950", Offset = "0x84C950", VA = "0x84C950")]
	public static string GetWeaponName(PlayerProfileData playerProfileData)
	{
		return null;
	}

	[Token(Token = "0x600352C")]
	[Address(RVA = "0x8526B0", Offset = "0x8526B0", VA = "0x8526B0")]
	public static int GetWeaponLevel(PlayerProfileData playerProfileData)
	{
		return default(int);
	}

	[Token(Token = "0x600352D")]
	[Address(RVA = "0x852788", Offset = "0x852788", VA = "0x852788")]
	public static WeaponUnlockable GetWeapon(PlayerProfileData playerProfileData)
	{
		return null;
	}

	[Token(Token = "0x600352E")]
	[Address(RVA = "0x852818", Offset = "0x852818", VA = "0x852818")]
	private static EventAttribute[] GetReportCrashAttributes(CrashHandlerError crashHandlerError)
	{
		return null;
	}

	[Token(Token = "0x600352F")]
	[Address(RVA = "0x853290", Offset = "0x853290", VA = "0x853290", Slot = "5")]
	protected override void SetTerminationMeasures()
	{
	}

	[Token(Token = "0x6003530")]
	[Address(RVA = "0x853354", Offset = "0x853354", VA = "0x853354", Slot = "6")]
	protected override void OnApplicationPaused()
	{
	}

	[Token(Token = "0x6003531")]
	[Address(RVA = "0x84A6B8", Offset = "0x84A6B8", VA = "0x84A6B8")]
	public void SetTotalGameTimeVariables()
	{
	}

	[Token(Token = "0x6003532")]
	[Address(RVA = "0x8533EC", Offset = "0x8533EC", VA = "0x8533EC", Slot = "8")]
	protected override void OnApplicationResumed()
	{
	}

	[Token(Token = "0x6003533")]
	[Address(RVA = "0x8537BC", Offset = "0x8537BC", VA = "0x8537BC", Slot = "7")]
	protected override void OnApplicationReset()
	{
	}

	[Token(Token = "0x6003534")]
	[Address(RVA = "0x85395C", Offset = "0x85395C", VA = "0x85395C")]
	public SniperAnalytics()
	{
	}

	[Token(Token = "0x6003535")]
	[Address(RVA = "0x8541C4", Offset = "0x8541C4", VA = "0x8541C4")]
	private void Init()
	{
	}

	[Token(Token = "0x6003536")]
	[Address(RVA = "0x854FE8", Offset = "0x854FE8", VA = "0x854FE8")]
	public void ScenarioTriggered(RewardActionBase reward)
	{
	}

	[Token(Token = "0x6003537")]
	[Address(RVA = "0x8551FC", Offset = "0x8551FC", VA = "0x8551FC", Slot = "9")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003538")]
	[Address(RVA = "0x855260", Offset = "0x855260", VA = "0x855260", Slot = "14")]
	protected override void Destroy()
	{
	}

	[Token(Token = "0x6003539")]
	[Address(RVA = "0x85530C", Offset = "0x85530C", VA = "0x85530C")]
	public void OnOfferPurchasedFromGameplay(Offer offer)
	{
	}

	[Token(Token = "0x600353A")]
	[Address(RVA = "0x8553D0", Offset = "0x8553D0", VA = "0x8553D0")]
	private void OnOfferPurchaseSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x600353B")]
	[Address(RVA = "0x8554B4", Offset = "0x8554B4", VA = "0x8554B4")]
	private void OnReceiptValidationComplete(object sender, TransactionValidateEvent args)
	{
	}

	[Token(Token = "0x600353C")]
	[Address(RVA = "0x8556FC", Offset = "0x8556FC", VA = "0x8556FC")]
	public void ExtractionStarted()
	{
	}

	[Token(Token = "0x600353D")]
	[Address(RVA = "0x85570C", Offset = "0x85570C", VA = "0x85570C")]
	private void BindFacebookLoginEvents()
	{
	}

	[Token(Token = "0x600353E")]
	[Address(RVA = "0x855814", Offset = "0x855814", VA = "0x855814")]
	private void UnbindFacebookLoginEvents()
	{
	}

	[Token(Token = "0x600353F")]
	[Address(RVA = "0x855914", Offset = "0x855914", VA = "0x855914")]
	private void OnSocialConnectSuccess(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6003540")]
	[Address(RVA = "0x8559F8", Offset = "0x8559F8", VA = "0x8559F8")]
	private void OnSocialConnectFailed(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6003541")]
	[Address(RVA = "0x8559FC", Offset = "0x8559FC", VA = "0x8559FC")]
	private void OnSocialLinkCancelled(object sender, SocialManager.LinkEvent e)
	{
	}

	[Token(Token = "0x6003542")]
	[Address(RVA = "0x855EA8", Offset = "0x855EA8", VA = "0x855EA8")]
	private void BindFacebookLogoutEvents()
	{
	}

	[Token(Token = "0x6003543")]
	[Address(RVA = "0x855F70", Offset = "0x855F70", VA = "0x855F70")]
	private void UnbindFacebookLogoutEvents()
	{
	}

	[Token(Token = "0x6003544")]
	[Address(RVA = "0x856030", Offset = "0x856030", VA = "0x856030")]
	private void OnLogout(object sender, AuthenticationEvent args)
	{
	}

	[Token(Token = "0x6003545")]
	[Address(RVA = "0x856080", Offset = "0x856080", VA = "0x856080")]
	public void ApplicationInit()
	{
	}

	[Token(Token = "0x6003546")]
	[Address(RVA = "0x856084", Offset = "0x856084", VA = "0x856084")]
	public void ApplicationStart()
	{
	}

	[Token(Token = "0x6003547")]
	[Address(RVA = "0x856128", Offset = "0x856128", VA = "0x856128")]
	public void DoArmorySecurityChecks()
	{
	}

	[Token(Token = "0x6003548")]
	[Address(RVA = "0x856184", Offset = "0x856184", VA = "0x856184")]
	public void StartMonitoringFacebookLogin()
	{
	}

	[Token(Token = "0x6003549")]
	[Address(RVA = "0x856188", Offset = "0x856188", VA = "0x856188")]
	public void StartMonitoringFacebookLogout()
	{
	}

	[Token(Token = "0x600354A")]
	[Address(RVA = "0x85618C", Offset = "0x85618C", VA = "0x85618C")]
	public void SendFirstLaunch()
	{
	}

	[Token(Token = "0x600354B")]
	[Address(RVA = "0x85385C", Offset = "0x85385C", VA = "0x85385C")]
	private void SendGameStart(bool appResumed)
	{
	}

	[Token(Token = "0x600354C")]
	[Address(RVA = "0x853294", Offset = "0x853294", VA = "0x853294")]
	public void GameQuit()
	{
	}

	[Token(Token = "0x600354D")]
	[Address(RVA = "0x853510", Offset = "0x853510", VA = "0x853510")]
	public void ContractStart(bool fromPause = false)
	{
	}

	[Token(Token = "0x600354E")]
	[Address(RVA = "0x856230", Offset = "0x856230", VA = "0x856230")]
	public void IncrementViewSequenceNumber()
	{
	}

	[Token(Token = "0x600354F")]
	[Address(RVA = "0x8566AC", Offset = "0x8566AC", VA = "0x8566AC")]
	public void DeathValleyDownloadStateChanged(string state, string sceneName)
	{
	}

	[Token(Token = "0x6003550")]
	[Address(RVA = "0x85677C", Offset = "0x85677C", VA = "0x85677C")]
	public void GDPRPopupShown()
	{
	}

	[Token(Token = "0x6003551")]
	[Address(RVA = "0x856800", Offset = "0x856800", VA = "0x856800")]
	public void PopupViewed(string type, string choice, float timeViewed, string title, string description, long campaignTransactionID = 0L)
	{
	}

	[Token(Token = "0x6003552")]
	[Address(RVA = "0x856920", Offset = "0x856920", VA = "0x856920")]
	public void PopupViewed(string type, string choice, float timeViewed, string title, string description, int missingCurrency, string missingCurrencyType, string suggestedPack, InsufficientFundsSource attemptedPurchaseType, string attemptedPurchaseItem, long campaignTransactionID = 0L)
	{
	}

	[Token(Token = "0x6003553")]
	[Address(RVA = "0x856AC4", Offset = "0x856AC4", VA = "0x856AC4")]
	public void WeaponSuggestionPopup(WeaponUnlockable[] weapons, WeaponSuggestionChoice choice, [Optional] WeaponUnlockable selectedWeapon)
	{
	}

	[Token(Token = "0x6003554")]
	[Address(RVA = "0x856FEC", Offset = "0x856FEC", VA = "0x856FEC")]
	public void ChoosePersistence(string selectedPersistence, string localDDNAUid, string cloudDDNAUid, string localUid, string cloudUid)
	{
	}

	[Token(Token = "0x6003555")]
	[Address(RVA = "0x8570E4", Offset = "0x8570E4", VA = "0x8570E4")]
	public void FriendConverted(string friendUID)
	{
	}

	[Token(Token = "0x6003556")]
	[Address(RVA = "0x8571AC", Offset = "0x8571AC", VA = "0x8571AC")]
	public void AppsFlyerLinkShared()
	{
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0x857230", Offset = "0x857230", VA = "0x857230")]
	public void ItemGranted(string item, int quantity, ItemGrantedContext context)
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0x857364", Offset = "0x857364", VA = "0x857364")]
	public void ItemsGranted(Dictionary<string, int> validAttachments, ItemGrantedContext context)
	{
	}

	[Token(Token = "0x6003559")]
	[Address(RVA = "0x8575B8", Offset = "0x8575B8", VA = "0x8575B8")]
	public void LootClaimed(string boxName, List<LootBoxDroppedItem> droppedItems)
	{
	}

	[Token(Token = "0x600355A")]
	[Address(RVA = "0x8577CC", Offset = "0x8577CC", VA = "0x8577CC")]
	public void GamePlayEnd([Optional] string contractEndType, bool shouldIncrementViewSequenceNumber = true)
	{
	}

	[Token(Token = "0x600355B")]
	[Address(RVA = "0x857B30", Offset = "0x857B30", VA = "0x857B30")]
	public void ResetPendingGameEndEvent(bool isScoreAccepted)
	{
	}

	[Token(Token = "0x600355C")]
	[Address(RVA = "0x857C08", Offset = "0x857C08", VA = "0x857C08")]
	public void MissionSkipped(int skipCost)
	{
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0x857D48", Offset = "0x857D48", VA = "0x857D48")]
	public void SendMenuEvents()
	{
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0x858248", Offset = "0x858248", VA = "0x858248")]
	public void MenuEvent(string origin, string destination)
	{
	}

	[Token(Token = "0x600355F")]
	[Address(RVA = "0x858D90", Offset = "0x858D90", VA = "0x858D90")]
	public void ShopPopupEvent(ShopPopup popup)
	{
	}

	[Token(Token = "0x6003560")]
	[Address(RVA = "0x858E9C", Offset = "0x858E9C", VA = "0x858E9C")]
	public void SoftCurrencyPurchased(Offer offer)
	{
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0x858F64", Offset = "0x858F64", VA = "0x858F64")]
	public void SoftCurrencyPurchaseFailure(string item)
	{
	}

	[Token(Token = "0x6003562")]
	[Address(RVA = "0x85902C", Offset = "0x85902C", VA = "0x85902C")]
	public void StarterPackPurchased(Offer offer)
	{
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0x8590F4", Offset = "0x8590F4", VA = "0x8590F4")]
	public void StarterPackPurchaseFailed()
	{
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0x859178", Offset = "0x859178", VA = "0x859178")]
	public void LeavePopup()
	{
	}

	[Token(Token = "0x6003565")]
	[Address(RVA = "0x855944", Offset = "0x855944", VA = "0x855944")]
	public void SocialEvent(SocialAction action, SocialSource source, [Optional] IEnumerable<string> friendsInvitedIDs)
	{
	}

	[Token(Token = "0x6003566")]
	[Address(RVA = "0x859180", Offset = "0x859180", VA = "0x859180")]
	public void EveryplayEvent(EveryplayAction action)
	{
	}

	[Token(Token = "0x6003567")]
	[Address(RVA = "0x859248", Offset = "0x859248", VA = "0x859248")]
	public void ResetProgressionEvent()
	{
	}

	[Token(Token = "0x6003568")]
	[Address(RVA = "0x8592CC", Offset = "0x8592CC", VA = "0x8592CC")]
	private static string GetMontenegroEnemyName(Target enemy)
	{
		return null;
	}

	[Token(Token = "0x6003569")]
	[Address(RVA = "0x8547D8", Offset = "0x8547D8", VA = "0x8547D8")]
	private void ResetMissionStats()
	{
	}

	[Token(Token = "0x600356A")]
	[Address(RVA = "0x857ACC", Offset = "0x857ACC", VA = "0x857ACC")]
	private void SendInGamePlayEvents()
	{
	}

	[Token(Token = "0x600356B")]
	[Address(RVA = "0x85650C", Offset = "0x85650C", VA = "0x85650C")]
	private void ClearInGamePlayEvents()
	{
	}

	[Token(Token = "0x600356C")]
	[Address(RVA = "0x859778", Offset = "0x859778", VA = "0x859778")]
	private void SendEventsOfAType(EventKey eventName, List<Dictionary<Schema, object>> parameters)
	{
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0x857F44", Offset = "0x857F44", VA = "0x857F44")]
	private static EventAttribute[] DictionaryToEventAttribute(Dictionary<Schema, object> parameters)
	{
		return null;
	}

	[Token(Token = "0x600356E")]
	[Address(RVA = "0x8598DC", Offset = "0x8598DC", VA = "0x8598DC")]
	private Dictionary<Schema, object> BuildEnemyKilledAttributes(Target enemy)
	{
		return null;
	}

	[Token(Token = "0x600356F")]
	[Address(RVA = "0x859EAC", Offset = "0x859EAC", VA = "0x859EAC")]
	private void FillEnemyKilledAttributes(Target enemy, ScoreTallyView.TallyItem[] tallyItems, string rewardName)
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0x859330", Offset = "0x859330", VA = "0x859330")]
	private void SendEnemiesKilled()
	{
	}

	[Token(Token = "0x6003571")]
	[Address(RVA = "0x85A884", Offset = "0x85A884", VA = "0x85A884")]
	private void FillPowerUpsUsed()
	{
	}

	[Token(Token = "0x6003572")]
	[Address(RVA = "0x85AC94", Offset = "0x85AC94", VA = "0x85AC94")]
	public void EnemyKilledByPowerUp(Target enemy, List<string> powerups)
	{
	}

	[Token(Token = "0x6003573")]
	[Address(RVA = "0x85AEB4", Offset = "0x85AEB4", VA = "0x85AEB4")]
	public void EnemyKilled(Target enemy, ScoreTallyView.TallyItem[] tallyItems, string rewardName)
	{
	}

	[Token(Token = "0x6003574")]
	[Address(RVA = "0x8593F0", Offset = "0x8593F0", VA = "0x8593F0")]
	private void SendBodyDisposals()
	{
	}

	[Token(Token = "0x6003575")]
	[Address(RVA = "0x85AFE0", Offset = "0x85AFE0", VA = "0x85AFE0")]
	private static string GetEnemyName(ThirdPersonCharacter enemy)
	{
		return null;
	}

	[Token(Token = "0x6003576")]
	[Address(RVA = "0x85B030", Offset = "0x85B030", VA = "0x85B030")]
	public void BodyDisposal(ThirdPersonCharacter enemy)
	{
	}

	[Token(Token = "0x6003577")]
	[Address(RVA = "0x8595B8", Offset = "0x8595B8", VA = "0x8595B8")]
	public void SendHealEvents()
	{
	}

	[Token(Token = "0x6003578")]
	[Address(RVA = "0x85B1D8", Offset = "0x85B1D8", VA = "0x85B1D8")]
	public void Heal(float healAmount, float cost)
	{
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0x859628", Offset = "0x859628", VA = "0x859628")]
	public void SendZombieUpgradePurchases()
	{
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0x85B40C", Offset = "0x85B40C", VA = "0x85B40C")]
	public void ZombieUpgradePurchased(TooltipClickType type, string upgradeID, float cost)
	{
	}

	[Token(Token = "0x600357B")]
	[Address(RVA = "0x859698", Offset = "0x859698", VA = "0x859698")]
	public void SendZombieUpgradeClicked()
	{
	}

	[Token(Token = "0x600357C")]
	[Address(RVA = "0x85B6DC", Offset = "0x85B6DC", VA = "0x85B6DC")]
	public void ZombieUpgradeClicked(TooltipClickType type, string upgradeID)
	{
	}

	[Token(Token = "0x600357D")]
	[Address(RVA = "0x859460", Offset = "0x859460", VA = "0x859460")]
	public void SendBonusesTriggered()
	{
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0x8550B0", Offset = "0x8550B0", VA = "0x8550B0")]
	public void BonusTriggered(string scenarioTriggered)
	{
	}

	[Token(Token = "0x600357F")]
	[Address(RVA = "0x859708", Offset = "0x859708", VA = "0x859708")]
	public void SendReloads()
	{
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0x85B9A8", Offset = "0x85B9A8", VA = "0x85B9A8")]
	public void Reload(int ammunition)
	{
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0x8594D0", Offset = "0x8594D0", VA = "0x8594D0")]
	public void SendPerksCompleted()
	{
	}

	[Token(Token = "0x6003582")]
	[Address(RVA = "0x85BBF8", Offset = "0x85BBF8", VA = "0x85BBF8")]
	public void PerkCompleted(string perkCompleted)
	{
	}

	[Token(Token = "0x6003583")]
	[Address(RVA = "0x859548", Offset = "0x859548", VA = "0x859548")]
	public void SendScoreToBeatTaps()
	{
	}

	[Token(Token = "0x6003584")]
	[Address(RVA = "0x85BD08", Offset = "0x85BD08", VA = "0x85BD08")]
	public void ScoreToBeatTapped()
	{
	}

	[Token(Token = "0x6003585")]
	[Address(RVA = "0x85BDAC", Offset = "0x85BDAC", VA = "0x85BDAC")]
	public void GunInfoClicked(TooltipClickType infoType, string infoID, int levelUnlocked, string gun, int levelIdx, int masteryLevelIdx)
	{
	}

	[Token(Token = "0x6003586")]
	[Address(RVA = "0x85BF8C", Offset = "0x85BF8C", VA = "0x85BF8C")]
	public void GunUpgraded(string gunUpgraded, int level, string currencyType, string currencyName, float price, int masteryLevel)
	{
	}

	[Token(Token = "0x6003587")]
	[Address(RVA = "0x85C0C0", Offset = "0x85C0C0", VA = "0x85C0C0")]
	public void SurveyStarted(string collectorId)
	{
	}

	[Token(Token = "0x6003588")]
	[Address(RVA = "0x85C22C", Offset = "0x85C22C", VA = "0x85C22C")]
	public void SurveyCompleted(string collectorId, bool success)
	{
	}

	[Token(Token = "0x6003589")]
	[Address(RVA = "0x85C418", Offset = "0x85C418", VA = "0x85C418")]
	public void GunUpgradeFailed(WeaponUnlockable gunUpgraded, int levelIdx, int masteryIdx)
	{
	}

	[Token(Token = "0x600358A")]
	[Address(RVA = "0x85C510", Offset = "0x85C510", VA = "0x85C510")]
	public void GunUnlocked(WeaponUnlockable weaponUnlockable, GunUnlockType unlockType = GunUnlockType.Purchase)
	{
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0x85C840", Offset = "0x85C840", VA = "0x85C840")]
	public void GunUnlockedFromGunParts(string gunUnlocked)
	{
	}

	[Token(Token = "0x600358C")]
	[Address(RVA = "0x85C94C", Offset = "0x85C94C", VA = "0x85C94C")]
	public void GunUnlockFailed(WeaponUnlockable gunUnlocked)
	{
	}

	[Token(Token = "0x600358D")]
	[Address(RVA = "0x85CA2C", Offset = "0x85CA2C", VA = "0x85CA2C")]
	public void GunCustomized(BlueprintItemView blueprint)
	{
	}

	[Token(Token = "0x600358E")]
	[Address(RVA = "0x85CAF4", Offset = "0x85CAF4", VA = "0x85CAF4")]
	public void WeaponTierFullyMastered(WeaponTier tier)
	{
	}

	[Token(Token = "0x600358F")]
	[Address(RVA = "0x85CBC4", Offset = "0x85CBC4", VA = "0x85CBC4")]
	public void PerkUnlocked(string perkUnlocked)
	{
	}

	[Token(Token = "0x6003590")]
	[Address(RVA = "0x85BAEC", Offset = "0x85BAEC", VA = "0x85BAEC")]
	public void UpdatePerksInfo()
	{
	}

	[Token(Token = "0x6003591")]
	[Address(RVA = "0x85CC94", Offset = "0x85CC94", VA = "0x85CC94")]
	public void SendSettingsEvent(bool isPause = false)
	{
	}

	[Token(Token = "0x6003592")]
	[Address(RVA = "0x85CD30", Offset = "0x85CD30", VA = "0x85CD30")]
	public void SettingChanged(SettingID button, bool setting)
	{
	}

	[Token(Token = "0x6003593")]
	[Address(RVA = "0x85CDFC", Offset = "0x85CDFC", VA = "0x85CDFC")]
	public void Leaderboard()
	{
	}

	[Token(Token = "0x6003594")]
	[Address(RVA = "0x8555C4", Offset = "0x8555C4", VA = "0x8555C4")]
	private void Sale(Transaction transaction, Offer offer)
	{
	}

	[Token(Token = "0x6003595")]
	[Address(RVA = "0x85CFF0", Offset = "0x85CFF0", VA = "0x85CFF0")]
	public void SendDDNAMissionEvents(Dictionary<string, object> rawAttributes)
	{
	}

	[Token(Token = "0x6003596")]
	[Address(RVA = "0x8562BC", Offset = "0x8562BC", VA = "0x8562BC")]
	public void MissionStarted(short mission, bool isTutorial)
	{
	}

	[Token(Token = "0x6003597")]
	[Address(RVA = "0x85D4C8", Offset = "0x85D4C8", VA = "0x85D4C8")]
	public void CampaignReceived(long id, string status, string reason, string reaction)
	{
	}

	[Token(Token = "0x6003598")]
	[Address(RVA = "0x85D7B8", Offset = "0x85D7B8", VA = "0x85D7B8")]
	public void TransactionEvent(string aServer, string aReceipt, string aIDSignature, Offer aOffer)
	{
	}

	[Token(Token = "0x6003599")]
	[Address(RVA = "0x85E31C", Offset = "0x85E31C", VA = "0x85E31C")]
	public void EnterMainMenu(short previousProgressionID)
	{
	}

	[Token(Token = "0x600359A")]
	[Address(RVA = "0x84F854", Offset = "0x84F854", VA = "0x84F854")]
	private static string GetItemTypeByName(string aItemName)
	{
		return null;
	}

	[Token(Token = "0x600359B")]
	[Address(RVA = "0x85E59C", Offset = "0x85E59C", VA = "0x85E59C")]
	public void ReportCrash(CrashHandlerError crashHandlerError)
	{
	}

	[Token(Token = "0x600359C")]
	[Address(RVA = "0x855E04", Offset = "0x855E04", VA = "0x855E04")]
	private void SendEventWithOnlineTest(EventKey key, params EventAttribute[] attributes)
	{
	}

	[Token(Token = "0x600359D")]
	[Address(RVA = "0x855CC8", Offset = "0x855CC8", VA = "0x855CC8")]
	private EventAttribute[] GetAttributes(EventAttribute[] specificAttributes, bool addExtendedDefaultAttributes = true)
	{
		return null;
	}

	[Token(Token = "0x600359E")]
	[Address(RVA = "0x85E718", Offset = "0x85E718", VA = "0x85E718")]
	public void AddAbilityUsed(string abilityUsed)
	{
	}

	[Token(Token = "0x600359F")]
	[Address(RVA = "0x85E824", Offset = "0x85E824", VA = "0x85E824")]
	public void AddRogueKilled(RogueData rogueData)
	{
	}

	[Token(Token = "0x60035A0")]
	[Address(RVA = "0x84C790", Offset = "0x84C790", VA = "0x84C790")]
	private bool IsTargetKilled(MissionManager missionManager)
	{
		return default(bool);
	}

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x85B8C0", Offset = "0x85B8C0", VA = "0x85B8C0")]
	public static string ModifyBonusNames(string originalname)
	{
		return null;
	}

	[Token(Token = "0x60035A2")]
	[Address(RVA = "0x841354", Offset = "0x841354", VA = "0x841354")]
	public static string ModifyWeaponNames(string originalname)
	{
		return null;
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x851124", Offset = "0x851124", VA = "0x851124")]
	private static string ModifyAbilityPerkNames(string originalname)
	{
		return null;
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x85E0A8", Offset = "0x85E0A8", VA = "0x85E0A8")]
	private int ConvertCurrency(string code, decimal value)
	{
		return default(int);
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x8548D4", Offset = "0x8548D4", VA = "0x8548D4")]
	private void SetupDDNACurrencyConverter()
	{
	}

	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x85E90C", Offset = "0x85E90C", VA = "0x85E90C", Slot = "12")]
	public override void Flush([Optional] Action<OSRequestState> response, bool isAsync = true)
	{
	}

	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x85E690", Offset = "0x85E690", VA = "0x85E690")]
	private void SendEvent(EventKey key, params EventAttribute[] attributes)
	{
	}
}
