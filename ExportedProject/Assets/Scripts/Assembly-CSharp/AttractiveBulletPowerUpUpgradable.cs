using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200032B")]
public class AttractiveBulletPowerUpUpgradable : SpawnOnImpactPowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x200032C")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x1C")]
		public float ExplosionRadius;

		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x20")]
		public float ExplosionDamage;

		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x24")]
		public float SoundCuriousDistance;

		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x28")]
		public DamageOverTime DotToApply;

		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x30")]
		public float Delay;

		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x38")]
		public LazyGameObject GameObjectToSpawnOnImpact;

		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x40")]
		public float CooldownTime;

		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x44")]
		public bool OneUseOnly;

		[Token(Token = "0x600135C")]
		[Address(RVA = "0x92537C", Offset = "0x92537C", VA = "0x92537C")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private string _soundCuriousDistanceLoc;

	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private string _explosionRadiusLoc;

	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string _explosionDamageLoc;

	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0xD8")]
	private float _explosionDamage;

	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0xDC")]
	private float _explosionRadius;

	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0xE0")]
	private float _soundCuriousDistance;

	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0xE8")]
	private DamageOverTime _damageOverTime;

	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0xF0")]
	private float _delay;

	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0xF4")]
	private int _cost;

	[Token(Token = "0x170002D5")]
	public int MaxLevel
	{
		[Token(Token = "0x6001356")]
		[Address(RVA = "0xC05AD8", Offset = "0xC05AD8", VA = "0xC05AD8", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002D6")]
	public int GetCost
	{
		[Token(Token = "0x6001357")]
		[Address(RVA = "0xC05AF4", Offset = "0xC05AF4", VA = "0xC05AF4", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0xC05AFC", Offset = "0xC05AFC", VA = "0xC05AFC", Slot = "21")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0xC05BDC", Offset = "0xC05BDC", VA = "0xC05BDC", Slot = "19")]
	protected override void PreEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x600135A")]
	[Address(RVA = "0xC05D48", Offset = "0xC05D48", VA = "0xC05D48", Slot = "24")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x600135B")]
	[Address(RVA = "0xC05FDC", Offset = "0xC05FDC", VA = "0xC05FDC")]
	public AttractiveBulletPowerUpUpgradable()
	{
	}
}
