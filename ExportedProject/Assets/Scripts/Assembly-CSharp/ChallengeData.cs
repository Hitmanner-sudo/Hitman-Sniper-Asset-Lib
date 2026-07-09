using System;
using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x20003EF")]
public class ChallengeData : ContractData
{
	[Serializable]
	[Token(Token = "0x20003F0")]
	public class WeaponPowerUp
	{
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x10")]
		public string AssetPath;

		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x18")]
		public int Cost;

		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x1C")]
		public int CurrentLevel;

		[Token(Token = "0x6001839")]
		[Address(RVA = "0x8615D0", Offset = "0x8615D0", VA = "0x8615D0")]
		public bool IsUnlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x600183A")]
		[Address(RVA = "0x8615E0", Offset = "0x8615E0", VA = "0x8615E0")]
		public WeaponPowerUp()
		{
		}

		[Token(Token = "0x600183B")]
		[Address(RVA = "0x8615E8", Offset = "0x8615E8", VA = "0x8615E8")]
		public WeaponPowerUp(string path, int level)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003F1")]
	public struct DefaultPowerUp
	{
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x0")]
		public LazyPowerUp PowerUp;

		[NonSerialized]
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x8")]
		public int StartingLevel;
	}

	[Token(Token = "0x40015CC")]
	[FieldOffset(Offset = "0x164")]
	public int StartingCurrencyBalance;

	[Token(Token = "0x40015CD")]
	[FieldOffset(Offset = "0x168")]
	public LazyWeaponUnlockable ContractSpecificWeapon;

	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0x170")]
	public bool OverriteWeaponStatsWithSaveGame;

	[Token(Token = "0x40015CF")]
	[FieldOffset(Offset = "0x171")]
	public bool OverriteWeaponPowerUpsWithSaveGame;

	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0x178")]
	public DefaultPowerUp[] DefaultPowerUps;

	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0x180")]
	public ChallengeUpgradeCost StatUpgradeCost;

	[Token(Token = "0x40015D2")]
	[FieldOffset(Offset = "0x188")]
	public RogueData[] SurvivorsData;

	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0x190")]
	public ChallengeUpgradeCost HealCost;

	[Token(Token = "0x40015D4")]
	[FieldOffset(Offset = "0x198")]
	public ToggledMod[] ToggledMods;

	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x1A0")]
	public float AddSpeedByMinute;

	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0x1A8")]
	public ZombieLevelProperties[] Difficulties;

	[NonSerialized]
	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x1B0")]
	public int StartingCurrencyBalanceBonus;

	[NonSerialized]
	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0x1B4")]
	public int DefaultClipSizeGrade;

	[NonSerialized]
	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x1B8")]
	public int DefaultFireRateGrade;

	[NonSerialized]
	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x1BC")]
	public int DefaultDamageGrade;

	[NonSerialized]
	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0x1C0")]
	public int DefaultSwayGrade;

	[NonSerialized]
	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0x1C4")]
	public int DefaultBulletSpeedGrade;

	[NonSerialized]
	[Token(Token = "0x40015DD")]
	[FieldOffset(Offset = "0x1C8")]
	public WeaponPowerUp[] WeaponPowerUps;

	[NonSerialized]
	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x1D0")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5280", Offset = "0x5B5280")]
	private int _currentDifficulty;

	[Token(Token = "0x170003DB")]
	public override GameEventsManager.GameEndResult GetMainTargetDespawnEndGameType
	{
		[Token(Token = "0x600182E")]
		[Address(RVA = "0xAF3408", Offset = "0xAF3408", VA = "0xAF3408", Slot = "6")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003DC")]
	public override GameEventsManager.GameEndResult GetMainTargetDeathEndGameType
	{
		[Token(Token = "0x600182F")]
		[Address(RVA = "0xAF3410", Offset = "0xAF3410", VA = "0xAF3410", Slot = "7")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003DD")]
	public override GameEventsManager.GameEndResult GetMissionTimerExpiresEndGameType
	{
		[Token(Token = "0x6001830")]
		[Address(RVA = "0xAF3418", Offset = "0xAF3418", VA = "0xAF3418", Slot = "8")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003DE")]
	public ContractDataModel.DifficultyType CurrentDifficulty
	{
		[Token(Token = "0x6001831")]
		[Address(RVA = "0xAF3420", Offset = "0xAF3420", VA = "0xAF3420")]
		get
		{
			return default(ContractDataModel.DifficultyType);
		}
		[Token(Token = "0x6001832")]
		[Address(RVA = "0xAF3428", Offset = "0xAF3428", VA = "0xAF3428")]
		set
		{
		}
	}

	[Token(Token = "0x6001833")]
	[Address(RVA = "0xAF3430", Offset = "0xAF3430", VA = "0xAF3430", Slot = "10")]
	public override void DoFirstInit()
	{
	}

	[Token(Token = "0x6001834")]
	[Address(RVA = "0xAF35A4", Offset = "0xAF35A4", VA = "0xAF35A4")]
	public void ResetForNewCampaign()
	{
	}

	[Token(Token = "0x6001835")]
	[Address(RVA = "0xAF3458", Offset = "0xAF3458", VA = "0xAF3458")]
	public void SetPowerUpsToDefault()
	{
	}

	[Token(Token = "0x6001836")]
	[Address(RVA = "0xAF3644", Offset = "0xAF3644", VA = "0xAF3644", Slot = "12")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001837")]
	[Address(RVA = "0xAF3728", Offset = "0xAF3728", VA = "0xAF3728", Slot = "11")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001838")]
	[Address(RVA = "0xAF37C0", Offset = "0xAF37C0", VA = "0xAF37C0")]
	public ChallengeData()
	{
	}
}
