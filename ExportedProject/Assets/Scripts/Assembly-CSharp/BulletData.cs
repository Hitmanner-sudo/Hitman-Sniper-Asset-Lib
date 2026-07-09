using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000377")]
public class BulletData : ScriptableObject
{
	[Token(Token = "0x2000378")]
	public class SpawnOnImpactObject
	{
		[Token(Token = "0x4001362")]
		[FieldOffset(Offset = "0x10")]
		public GameObject ObjectToSpawn;

		[Token(Token = "0x4001363")]
		[FieldOffset(Offset = "0x18")]
		public Action<GameObject, long, Bullet.Hit> PreEnabledFunction;

		[Token(Token = "0x4001364")]
		[FieldOffset(Offset = "0x20")]
		public Action<GameObject, long, Bullet.Hit> PostEnabledFunction;

		[Token(Token = "0x6001542")]
		[Address(RVA = "0x85FBC0", Offset = "0x85FBC0", VA = "0x85FBC0")]
		public SpawnOnImpactObject(GameObject objectToSpawn, Action<GameObject, long, Bullet.Hit> preEnabledFunction, Action<GameObject, long, Bullet.Hit> postEnabledFunction)
		{
		}
	}

	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int _damage;

	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _impactForce;

	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _gravity;

	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _drag;

	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _radius;

	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _explosive;

	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _explosionDamage;

	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _explosionRadius;

	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _explosionImpulse;

	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _explosionCuriousDistance;

	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _explosionSuspiciousDistance;

	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _currencyOnKill;

	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool _challengeTokenOnKill;

	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool _uniformExplosion;

	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DefaultBulletHole;

	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x58")]
	public List<BulletHoleDesc> BulletHoles;

	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> SpawnOnStopGameObjects;

	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x68")]
	public DamageOverTime DOTToApplyOnHit;

	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x70")]
	public DamageOverTime DotToApply;

	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x78")]
	public bool EmitsFlyByMemento;

	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0x79")]
	public bool EmitsRicochetMemento;

	[Token(Token = "0x400133B")]
	[FieldOffset(Offset = "0x7A")]
	public bool SpawnBulletHole;

	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0x7B")]
	public bool PinShot;

	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x7C")]
	public bool PushShot;

	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x7D")]
	public bool StopOnCharacterHit;

	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x7E")]
	public bool PlaySoundOnImpact;

	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x80")]
	public List<string> ActivePowerUps;

	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x88")]
	public GameObject OverrideSpark;

	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x90")]
	public GameObject OverrideProjectile;

	[NonSerialized]
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x98")]
	public List<SpawnOnImpactObject> SpawnOnImpactGameObjects;

	[NonSerialized]
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0xA0")]
	public List<BulletDamageDesc> DamageMultipliers;

	[NonSerialized]
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0xA8")]
	public int SplitShot;

	[NonSerialized]
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0xAC")]
	public bool FreezeAndKill;

	[NonSerialized]
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0xAD")]
	public bool NoFriendlyFire;

	[NonSerialized]
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0xB0")]
	public VolleyPowerUp.VolleyData VolleyData;

	[NonSerialized]
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0xB8")]
	public bool PenetrateEverything;

	[NonSerialized]
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0xC0")]
	public GuidedArrowData GuidedArrowData;

	[NonSerialized]
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0xC8")]
	public bool SpawnAlignOnCollision;

	[NonSerialized]
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0xC9")]
	public bool ApplyDOTOnHit;

	[NonSerialized]
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0xCA")]
	public bool HollowPoint;

	[NonSerialized]
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0xCC")]
	public float OddsToApplyFreezeAndKill;

	[NonSerialized]
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0xD0")]
	public float OddsToApplyDOTOnHit;

	[NonSerialized]
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0xD8")]
	public SoundContainer SpecificSoundOnShoot;

	[NonSerialized]
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0xE0")]
	public bool PossessShot;

	[NonSerialized]
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0xE8")]
	public CunningPowerUp.CunningData CunningData;

	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0xF0")]
	private float _speedModifier;

	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0xF4")]
	private int _damageModifier;

	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0xF8")]
	private float _impactForceModifier;

	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0xFC")]
	private float _gravityModifier;

	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x100")]
	private float _dragModifier;

	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x104")]
	private float _radiusModifier;

	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x108")]
	private bool _explosiveModifier;

	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x10C")]
	private float _explosionDamageModifier;

	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x110")]
	private float _explosionRadiusModifier;

	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x114")]
	private float _explosionImpulseModifier;

	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x118")]
	private bool _currencyOnKillModifier;

	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x119")]
	private bool _challengeTokenOnKillModifier;

	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x120")]
	private GameObject _overrideExplosionEffect;

	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x128")]
	private SoundContainer _overrideExplosionSound;

	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x130")]
	private bool _uniformExplosionModifier;

	[Token(Token = "0x1700031F")]
	public float Drag
	{
		[Token(Token = "0x600151C")]
		[Address(RVA = "0xA818B8", Offset = "0xA818B8", VA = "0xA818B8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000320")]
	public float Speed
	{
		[Token(Token = "0x600151F")]
		[Address(RVA = "0xA817E8", Offset = "0xA817E8", VA = "0xA817E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001520")]
		[Address(RVA = "0xA85CA0", Offset = "0xA85CA0", VA = "0xA85CA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000321")]
	public float Gravity
	{
		[Token(Token = "0x6001521")]
		[Address(RVA = "0xA81884", Offset = "0xA81884", VA = "0xA81884")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001522")]
		[Address(RVA = "0xA85CB0", Offset = "0xA85CB0", VA = "0xA85CB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000322")]
	public int Damage
	{
		[Token(Token = "0x6001523")]
		[Address(RVA = "0xA8181C", Offset = "0xA8181C", VA = "0xA8181C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001524")]
		[Address(RVA = "0xA85CC0", Offset = "0xA85CC0", VA = "0xA85CC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000323")]
	public float ImpactForce
	{
		[Token(Token = "0x6001525")]
		[Address(RVA = "0xA81850", Offset = "0xA81850", VA = "0xA81850")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001526")]
		[Address(RVA = "0xA85CD0", Offset = "0xA85CD0", VA = "0xA85CD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000324")]
	public float Radius
	{
		[Token(Token = "0x6001527")]
		[Address(RVA = "0xA818EC", Offset = "0xA818EC", VA = "0xA818EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001528")]
		[Address(RVA = "0xA85CE0", Offset = "0xA85CE0", VA = "0xA85CE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000325")]
	public bool Explosive
	{
		[Token(Token = "0x6001529")]
		[Address(RVA = "0xA827B8", Offset = "0xA827B8", VA = "0xA827B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600152A")]
		[Address(RVA = "0xA85CF0", Offset = "0xA85CF0", VA = "0xA85CF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000326")]
	public float ExplosionDamage
	{
		[Token(Token = "0x600152B")]
		[Address(RVA = "0xA83800", Offset = "0xA83800", VA = "0xA83800")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600152C")]
		[Address(RVA = "0xA85CFC", Offset = "0xA85CFC", VA = "0xA85CFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000327")]
	public float ExplosionRadius
	{
		[Token(Token = "0x600152D")]
		[Address(RVA = "0xA837F0", Offset = "0xA837F0", VA = "0xA837F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600152E")]
		[Address(RVA = "0xA85D30", Offset = "0xA85D30", VA = "0xA85D30")]
		set
		{
		}
	}

	[Token(Token = "0x17000328")]
	public float ExplosionImpulse
	{
		[Token(Token = "0x600152F")]
		[Address(RVA = "0xA83810", Offset = "0xA83810", VA = "0xA83810")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001530")]
		[Address(RVA = "0xA85D64", Offset = "0xA85D64", VA = "0xA85D64")]
		set
		{
		}
	}

	[Token(Token = "0x17000329")]
	public float ExplosionCuriousDistance
	{
		[Token(Token = "0x6001531")]
		[Address(RVA = "0xA85D98", Offset = "0xA85D98", VA = "0xA85D98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001532")]
		[Address(RVA = "0xA85DA0", Offset = "0xA85DA0", VA = "0xA85DA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700032A")]
	public float ExplosionSuspiciousDistance
	{
		[Token(Token = "0x6001533")]
		[Address(RVA = "0xA85DCC", Offset = "0xA85DCC", VA = "0xA85DCC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001534")]
		[Address(RVA = "0xA85DD4", Offset = "0xA85DD4", VA = "0xA85DD4")]
		set
		{
		}
	}

	[Token(Token = "0x1700032B")]
	public GameObject ExplosionEffect
	{
		[Token(Token = "0x6001535")]
		[Address(RVA = "0xA83840", Offset = "0xA83840", VA = "0xA83840")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001536")]
		[Address(RVA = "0xA85E00", Offset = "0xA85E00", VA = "0xA85E00")]
		set
		{
		}
	}

	[Token(Token = "0x1700032C")]
	public SoundContainer ExplosionSound
	{
		[Token(Token = "0x6001537")]
		[Address(RVA = "0xA838C0", Offset = "0xA838C0", VA = "0xA838C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001538")]
		[Address(RVA = "0xA85E08", Offset = "0xA85E08", VA = "0xA85E08")]
		set
		{
		}
	}

	[Token(Token = "0x1700032D")]
	public bool CurrencyOnKill
	{
		[Token(Token = "0x6001539")]
		[Address(RVA = "0xA84344", Offset = "0xA84344", VA = "0xA84344")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153A")]
		[Address(RVA = "0xA85E10", Offset = "0xA85E10", VA = "0xA85E10")]
		set
		{
		}
	}

	[Token(Token = "0x1700032E")]
	public bool ChallengeTokenOnKill
	{
		[Token(Token = "0x600153B")]
		[Address(RVA = "0xA84364", Offset = "0xA84364", VA = "0xA84364")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153C")]
		[Address(RVA = "0xA85E1C", Offset = "0xA85E1C", VA = "0xA85E1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700032F")]
	public bool UniformExplosion
	{
		[Token(Token = "0x600153D")]
		[Address(RVA = "0xA83820", Offset = "0xA83820", VA = "0xA83820")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153E")]
		[Address(RVA = "0xA85E28", Offset = "0xA85E28", VA = "0xA85E28")]
		set
		{
		}
	}

	[Token(Token = "0x600151B")]
	[Address(RVA = "0xA81644", Offset = "0xA81644", VA = "0xA81644")]
	public BulletData GetMemberwiseClone()
	{
		return null;
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0xA85C90", Offset = "0xA85C90", VA = "0xA85C90")]
	public void ChangeBaseDamage(int newDamage)
	{
	}

	[Token(Token = "0x600151E")]
	[Address(RVA = "0xA85C98", Offset = "0xA85C98", VA = "0xA85C98")]
	public void ChangeBaseSpeed(float newSpeed)
	{
	}

	[Token(Token = "0x600153F")]
	[Address(RVA = "0xA85E34", Offset = "0xA85E34", VA = "0xA85E34")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x6001540")]
	[Address(RVA = "0xA85F30", Offset = "0xA85F30", VA = "0xA85F30")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x6001541")]
	[Address(RVA = "0xA860A4", Offset = "0xA860A4", VA = "0xA860A4")]
	public BulletData()
	{
	}
}
