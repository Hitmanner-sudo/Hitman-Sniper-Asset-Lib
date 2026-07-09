using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Security;
using Technology.Shop;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000269")]
public class Reward
{
	[Token(Token = "0x200026A")]
	public enum MaxScoreType
	{
		[Token(Token = "0x4000D5E")]
		NoMax = 0,
		[Token(Token = "0x4000D5F")]
		QuickMax = 1,
		[Token(Token = "0x4000D60")]
		StealthMax = 2,
		[Token(Token = "0x4000D61")]
		HeadshotMax = 3,
		[Token(Token = "0x4000D62")]
		ExplosiveMax = 4
	}

	[Token(Token = "0x200026B")]
	public enum ScoreModifierType
	{
		[Token(Token = "0x4000D64")]
		NoModifier = 0,
		[Token(Token = "0x4000D65")]
		Environmental = 1,
		[Token(Token = "0x4000D66")]
		Accidental = 2,
		[Token(Token = "0x4000D67")]
		XRay = 3,
		[Token(Token = "0x4000D68")]
		BodyDisposal = 4,
		[Token(Token = "0x4000D69")]
		Rogue = 5,
		[Token(Token = "0x4000D6A")]
		Moving = 6,
		[Token(Token = "0x4000D6B")]
		MinZoom = 7,
		[Token(Token = "0x4000D6C")]
		Manipulation = 8,
		[Token(Token = "0x4000D6D")]
		HeadShot = 9,
		[Token(Token = "0x4000D6E")]
		QuickKill = 10,
		[Token(Token = "0x4000D6F")]
		Stealth = 11,
		[Token(Token = "0x4000D70")]
		Enemy = 12,
		[Token(Token = "0x4000D71")]
		Lure = 13,
		[Token(Token = "0x4000D72")]
		ZombieKiller = 14,
		[Token(Token = "0x4000D73")]
		TankKiller = 15,
		[Token(Token = "0x4000D74")]
		HunterKiller = 16,
		[Token(Token = "0x4000D75")]
		ScreamerKiller = 17,
		[Token(Token = "0x4000D76")]
		NoHoldBreath = 18,
		[Token(Token = "0x4000D77")]
		Domino = 19,
		[Token(Token = "0x4000D78")]
		Explosion = 20
	}

	[Token(Token = "0x200026C")]
	public enum CurrencyModifierType
	{
		[Token(Token = "0x4000D7A")]
		NoModifier = 0,
		[Token(Token = "0x4000D7B")]
		ChestBonus = 1,
		[Token(Token = "0x4000D7C")]
		CurrencyBonus = 2
	}

	[Token(Token = "0x4000D52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string _localizedName;

	[Token(Token = "0x4000D53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SecureIntWrapper SecuredScore;

	[Token(Token = "0x4000D54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SecureIntWrapper SecuredCurrency;

	[Token(Token = "0x4000D55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Wallet.Currency CurrencyType;

	[Token(Token = "0x4000D56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MaxScoreType MaxScore;

	[Token(Token = "0x4000D57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ScoreModifierType ScoreModifier;

	[Token(Token = "0x4000D58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CurrencyModifierType[] CurrencyModifier;

	[Token(Token = "0x4000D59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool IsScaredKill;

	[Token(Token = "0x4000D5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B37A4", Offset = "0x5B37A4")]
	private int _003CRewardedTimes_003Ek__BackingField;

	[Token(Token = "0x4000D5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B37B4", Offset = "0x5B37B4")]
	private int _003CTotalScore_003Ek__BackingField;

	[Token(Token = "0x4000D5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B37C4", Offset = "0x5B37C4")]
	private int _003CTotalCurrency_003Ek__BackingField;

	[Token(Token = "0x17000249")]
	public SecureLocalInt Score
	{
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x967828", Offset = "0x967828", VA = "0x967828")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024A")]
	public SecureLocalInt Currency
	{
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x967844", Offset = "0x967844", VA = "0x967844")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024B")]
	public string Name
	{
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x967860", Offset = "0x967860", VA = "0x967860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024C")]
	public int RewardedTimes
	{
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x9678C8", Offset = "0x9678C8", VA = "0x9678C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615124", Offset = "0x615124")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x9678D0", Offset = "0x9678D0", VA = "0x9678D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615134", Offset = "0x615134")]
		private set
		{
		}
	}

	[Token(Token = "0x1700024D")]
	public int TotalScore
	{
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x9678D8", Offset = "0x9678D8", VA = "0x9678D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615144", Offset = "0x615144")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x9678E0", Offset = "0x9678E0", VA = "0x9678E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615154", Offset = "0x615154")]
		private set
		{
		}
	}

	[Token(Token = "0x1700024E")]
	public int TotalCurrency
	{
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x9678E8", Offset = "0x9678E8", VA = "0x9678E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615164", Offset = "0x615164")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x9678F0", Offset = "0x9678F0", VA = "0x9678F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615174", Offset = "0x615174")]
		private set
		{
		}
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x9678F8", Offset = "0x9678F8", VA = "0x9678F8")]
	public Reward()
	{
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x967988", Offset = "0x967988", VA = "0x967988")]
	private int GetScoreMax()
	{
		return default(int);
	}

	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x967C2C", Offset = "0x967C2C", VA = "0x967C2C")]
	private int GetScoreModifier([Optional] RogueData RogueDataObject)
	{
		return default(int);
	}

	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x9680F0", Offset = "0x9680F0", VA = "0x9680F0")]
	private int GetZombieRewardModifier(ZombieReward.ZombieType type)
	{
		return default(int);
	}

	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x9682CC", Offset = "0x9682CC", VA = "0x9682CC")]
	private float GetScoreMultiplier([Optional] RogueData RogueDataObject)
	{
		return default(float);
	}

	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x968860", Offset = "0x968860", VA = "0x968860")]
	private float GetScoreRewardMultiplier(ScoreReward.ScoreRewardType scoreRewardType)
	{
		return default(float);
	}

	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x9689D8", Offset = "0x9689D8", VA = "0x9689D8")]
	private int GetCurrencyModifier()
	{
		return default(int);
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x968C1C", Offset = "0x968C1C", VA = "0x968C1C")]
	private float GetWeaponScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x968CB0", Offset = "0x968CB0", VA = "0x968CB0")]
	public int GetScore([Optional] RogueData RogueDataObject)
	{
		return default(int);
	}

	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x968DA8", Offset = "0x968DA8", VA = "0x968DA8")]
	private int GetCurrency()
	{
		return default(int);
	}

	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x968EAC", Offset = "0x968EAC", VA = "0x968EAC")]
	public void Apply([Optional] RogueData RogueDataObject)
	{
	}

	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x968FD8", Offset = "0x968FD8", VA = "0x968FD8")]
	public void Reset()
	{
	}
}
