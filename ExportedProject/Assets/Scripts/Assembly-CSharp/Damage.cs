using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A5")]
public class Damage
{
	[Token(Token = "0x20001A6")]
	public enum Types
	{
		[Token(Token = "0x40008FC")]
		Unknown = 0,
		[Token(Token = "0x40008FD")]
		Bullet = 1,
		[Token(Token = "0x40008FE")]
		LeanFall = 2,
		[Token(Token = "0x40008FF")]
		Explosion = 3,
		[Token(Token = "0x4000900")]
		Collision = 4,
		[Token(Token = "0x4000901")]
		Heal = 5,
		[Token(Token = "0x4000902")]
		Environment = 6,
		[Token(Token = "0x4000903")]
		Electricity = 7,
		[Token(Token = "0x4000904")]
		Wind = 8,
		[Token(Token = "0x4000905")]
		ExplosiveBulletBlast = 9,
		[Token(Token = "0x4000906")]
		ExplosiveBulletImpact = 10,
		[Token(Token = "0x4000907")]
		PenetratingBullet = 11,
		[Token(Token = "0x4000908")]
		DamageOverTimeFire = 12,
		[Token(Token = "0x4000909")]
		DamageOverTimeGas = 13,
		[Token(Token = "0x400090A")]
		FreezeAndKillBullet = 14,
		[Token(Token = "0x400090B")]
		DamageOverTimeFireAccidental = 15,
		[Token(Token = "0x400090C")]
		Collision_Body = 16
	}

	[Token(Token = "0x20001A7")]
	public enum BodyPart
	{
		[Token(Token = "0x400090E")]
		Unspecified = 0,
		[Token(Token = "0x400090F")]
		LeftArm = 1,
		[Token(Token = "0x4000910")]
		RightArm = 2,
		[Token(Token = "0x4000911")]
		LeftLeg = 3,
		[Token(Token = "0x4000912")]
		RightLeg = 4,
		[Token(Token = "0x4000913")]
		Torso = 5,
		[Token(Token = "0x4000914")]
		Hips = 6,
		[Token(Token = "0x4000915")]
		Head = 7,
		[Token(Token = "0x4000916")]
		Count = 8,
		[Token(Token = "0x4000917")]
		Doted = 9
	}

	[Token(Token = "0x20001A8")]
	public class Hit
	{
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x10")]
		public Damage Damage;

		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x18")]
		public DamageCollider DamageCollider;

		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x20")]
		public Collider Collider;

		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 Position;

		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x34")]
		public bool Killed;

		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x38")]
		public int HitIndex;

		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x3C")]
		public float Amount;

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x86A110", Offset = "0x86A110", VA = "0x86A110")]
		public Hit()
		{
		}
	}

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x10")]
	public int HitIndex;

	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x14")]
	public float Timestamp;

	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x18")]
	public float Amount;

	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x1C")]
	public float TotalDamagePerBullet;

	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x20")]
	public Types Type;

	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x28")]
	public Character CharacterInstigator;

	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x30")]
	public Faction InstigatorFaction;

	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 Position;

	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 Direction;

	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 Normal;

	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x5C")]
	public BodyPart Part;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x60")]
	public float Impulse;

	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x64")]
	public bool FromHoldBreath;

	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x65")]
	public bool SpawnEffects;

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x66")]
	public bool FromHollowPoint;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x67")]
	public bool FromMinZoom;

	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x68")]
	public bool FromSplitShot;

	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x69")]
	public bool FromDot;

	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x6A")]
	public bool FromPinShot;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x6B")]
	public bool FromPushShot;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x6C")]
	public bool FromPossessShot;

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x6D")]
	public bool WasFocusedByTag;

	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x6E")]
	public bool IsTagged;

	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x6F")]
	public bool IsCurrencyOnKillActivated;

	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x70")]
	public bool IsChallengeTokenOnKillActivated;

	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x74")]
	public float ExplosionRadius;

	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x78")]
	public bool NoFriendlyFire;

	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x79")]
	public bool FromAttractiveBulletExplosion;

	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x80")]
	public long ID;

	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x88")]
	public float TravelDistance;

	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x90")]
	public List<string> ActivePowerUps;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x98")]
	public List<Hit> History;

	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject _instigator;

	[Token(Token = "0x170001CC")]
	public GameObject Instigator
	{
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xADF3B0", Offset = "0xADF3B0", VA = "0xADF3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xADF3B8", Offset = "0xADF3B8", VA = "0xADF3B8")]
		set
		{
		}
	}

	[Token(Token = "0x170001CD")]
	public bool FromPlayer
	{
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xADFC0C", Offset = "0xADFC0C", VA = "0xADFC0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CE")]
	public bool IsAccidental
	{
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xADFCC4", Offset = "0xADFCC4", VA = "0xADFCC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CF")]
	public bool IsBulletImpact
	{
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xADFCE8", Offset = "0xADFCE8", VA = "0xADFCE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001D0")]
	public bool IsHeadshot
	{
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xADFD1C", Offset = "0xADFD1C", VA = "0xADFD1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000B22")]
	[Address(RVA = "0xADF26C", Offset = "0xADF26C", VA = "0xADF26C")]
	public Damage()
	{
	}

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0xADF484", Offset = "0xADF484", VA = "0xADF484")]
	public void ApplyDamage(DamageCollider target, DamageOverTime dot)
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0xADFD50", Offset = "0xADFD50", VA = "0xADFD50")]
	public Damage GetMemberwiseClone()
	{
		return null;
	}
}
