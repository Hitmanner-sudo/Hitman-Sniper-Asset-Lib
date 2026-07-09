using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003AA")]
public class WeaponData : ScriptableObject
{
	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _aimingSpeed;

	[Token(Token = "0x40014BC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _fireRate;

	[Token(Token = "0x40014BD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _ammunitionCount;

	[Token(Token = "0x40014BE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _activateTagDuration;

	[Token(Token = "0x40014BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _tagCount;

	[Token(Token = "0x40014C0")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _indicatorFocusDuration;

	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _skipBoltCycle;

	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _boltCycleDelay;

	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B4BEC", Offset = "0x5B4BEC")]
	private float _powerUpDiscount;

	[Token(Token = "0x40014C4")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B4C2C", Offset = "0x5B4C2C")]
	private float _powerUpCooldownModifier;

	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _ruleCount;

	[Token(Token = "0x40014C6")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _xPBoostRatio;

	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _automaticReload;

	[Token(Token = "0x40014C8")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GestureConfig _inScopeGestureConfig;

	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GestureConfig _outOfScopeGestureConfig;

	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "ClampAttribute", RVA = "0x5B4CBC", Offset = "0x5B4CBC")]
	public float SlowmoFireRatePercentage;

	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x68")]
	public ScopeData Scope;

	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x70")]
	public BreathingData Breathing;

	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x78")]
	public OffsetsData Offsets;

	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x80")]
	public SwayData Sway;

	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x88")]
	public InertiaData Inertia;

	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x90")]
	public TaggingData Tagging;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x98")]
	public WeaponSoundData WeaponSounds;

	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0xA0")]
	public BulletData Bullet;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0xA8")]
	public ScoreData Score;

	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0xB0")]
	public DropData Drop;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0xB8")]
	public RecoilData[] CameraRecoils;

	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0xC0")]
	public RecoilData[] MeshRecoils;

	[NonSerialized]
	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0xC8")]
	public GameplayConfig.FireRateGradeData UpgradedFireRateGradeData;

	[NonSerialized]
	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0xD0")]
	public int UpgradedAmmoCount;

	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0xD4")]
	private float _aimingSpeedModifier;

	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0xD8")]
	private float _fireRateModifier;

	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0xDC")]
	private int _ammunitionCountModifier;

	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0xE0")]
	private float _activateTagDurationModifier;

	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0xE4")]
	private int _tagCountModifier;

	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0xE8")]
	private float _indicatorFocusDurationModifier;

	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0xEC")]
	private bool _skipBoltCycleModifier;

	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0xF0")]
	private float _powerUpDiscountModifier;

	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0xF4")]
	private int _ruleCountExtraModifier;

	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0xF8")]
	private float _xPBoostRatioModifier;

	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0xFC")]
	private bool _automaticReloadModifier;

	[Token(Token = "0x40014E4")]
	[FieldOffset(Offset = "0x100")]
	public AnimationCurve RecoilZoomCurve;

	[Token(Token = "0x40014E5")]
	[FieldOffset(Offset = "0x108")]
	public ReloadSequence ReloadSequence;

	[Token(Token = "0x17000398")]
	public float AimingSpeed
	{
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x987D80", Offset = "0x987D80", VA = "0x987D80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000399")]
	public int AmmunitionCount
	{
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x980BE4", Offset = "0x980BE4", VA = "0x980BE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700039A")]
	public float ActivateTagDuration
	{
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x987D90", Offset = "0x987D90", VA = "0x987D90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700039B")]
	public int TagCount
	{
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x980C10", Offset = "0x980C10", VA = "0x980C10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700039C")]
	public float IndicatorFocusDuration
	{
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x987DA0", Offset = "0x987DA0", VA = "0x987DA0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700039D")]
	public float BoltCycleDelay
	{
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x987DB0", Offset = "0x987DB0", VA = "0x987DB0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700039E")]
	public float RecoveryTime
	{
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x987DD8", Offset = "0x987DD8", VA = "0x987DD8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700039F")]
	public float PowerUpDiscount
	{
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x987DF0", Offset = "0x987DF0", VA = "0x987DF0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003A0")]
	public float PowerUpCooldownModifier
	{
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x987E00", Offset = "0x987E00", VA = "0x987E00")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x987E08", Offset = "0x987E08", VA = "0x987E08")]
		set
		{
		}
	}

	[Token(Token = "0x170003A1")]
	public int RuleCountExtra
	{
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x987E10", Offset = "0x987E10", VA = "0x987E10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003A2")]
	public float XPBoostRatio
	{
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x987E20", Offset = "0x987E20", VA = "0x987E20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003A3")]
	public bool AutomaticReload
	{
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x987E30", Offset = "0x987E30", VA = "0x987E30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003A4")]
	public GestureConfig InScopeGestureConfig
	{
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x987E50", Offset = "0x987E50", VA = "0x987E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A5")]
	public GestureConfig OutOfScopeGestureConfig
	{
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x987E58", Offset = "0x987E58", VA = "0x987E58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A6")]
	private float BaseFireRate
	{
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x987E60", Offset = "0x987E60", VA = "0x987E60")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003A7")]
	public float FireRate
	{
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x982F08", Offset = "0x982F08", VA = "0x982F08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x987E7C", Offset = "0x987E7C", VA = "0x987E7C")]
		set
		{
		}
	}

	[Token(Token = "0x170003A8")]
	public bool SkipBoltCycle
	{
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x987EA0", Offset = "0x987EA0", VA = "0x987EA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x987EC0", Offset = "0x987EC0", VA = "0x987EC0")]
		set
		{
		}
	}

	[Token(Token = "0x170003A9")]
	public bool SkipBoltCycleAnimation
	{
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x987ECC", Offset = "0x987ECC", VA = "0x987ECC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x987F18", Offset = "0x987F18", VA = "0x987F18")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x987FB8", Offset = "0x987FB8", VA = "0x987FB8")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x9885D0", Offset = "0x9885D0", VA = "0x9885D0")]
	public WeaponData()
	{
	}
}
