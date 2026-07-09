using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C1")]
public class WeaponTier : ScriptableObject
{
	[Token(Token = "0x4002B80")]
	private const string NAME_LOCALIZATION_KEY = "LOC_WeaponTiers_Tier";

	[Token(Token = "0x4002B81")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _tierIconSpriteName;

	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _fullyMasteredScoreMultiplier;

	[Token(Token = "0x4002B83")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private WeaponMasteryUpgrade[] _masteryLevels;

	[Token(Token = "0x4002B84")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LazyWeaponUnlockable[] _weapons;

	[Token(Token = "0x4002B85")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _tierLevel;

	[Token(Token = "0x1700068C")]
	public float FullyMasteredScoreMultiplier
	{
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x878994", Offset = "0x878994", VA = "0x878994")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068D")]
	public WeaponMasteryUpgrade[] MasteryLevels
	{
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x87899C", Offset = "0x87899C", VA = "0x87899C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700068E")]
	public int NumMasteryLevels
	{
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x8789A4", Offset = "0x8789A4", VA = "0x8789A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700068F")]
	public LazyWeaponUnlockable[] Weapons
	{
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x8789C0", Offset = "0x8789C0", VA = "0x8789C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000690")]
	public int TierLevel
	{
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x8789C8", Offset = "0x8789C8", VA = "0x8789C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000691")]
	public string Name
	{
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x8789D0", Offset = "0x8789D0", VA = "0x8789D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000692")]
	public string NameRomanNumerals
	{
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x878A90", Offset = "0x878A90", VA = "0x878A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000693")]
	public string TierIconSpriteName
	{
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x878B5C", Offset = "0x878B5C", VA = "0x878B5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003312")]
	[Address(RVA = "0x878B64", Offset = "0x878B64", VA = "0x878B64")]
	public bool IsTierFullyUpgraded()
	{
		return default(bool);
	}

	[Token(Token = "0x6003313")]
	[Address(RVA = "0x878E3C", Offset = "0x878E3C", VA = "0x878E3C")]
	public bool IsTierFullyMastered()
	{
		return default(bool);
	}

	[Token(Token = "0x6003314")]
	[Address(RVA = "0x879130", Offset = "0x879130", VA = "0x879130")]
	public float GetCurrentFullyMasteredScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x879368", Offset = "0x879368", VA = "0x879368")]
	public float GetMaxFullyMasteredScoreMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6003316")]
	[Address(RVA = "0x879390", Offset = "0x879390", VA = "0x879390")]
	public WeaponTier()
	{
	}
}
