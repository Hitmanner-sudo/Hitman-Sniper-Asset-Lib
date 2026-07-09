using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000334")]
public class ExplosiveAmmoPowerUpUpgradable : ExplosiveAmmoPowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x2000335")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x1C")]
		public float ExplosionDamage;

		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x20")]
		public float ExplosionRadius;

		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x24")]
		public float ExplosionImpulse;

		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x28")]
		public float ExplosionCuriousDistance;

		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x2C")]
		public float ExplosionSuspiciousDistance;

		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x30")]
		public DamageOverTime DotToApply;

		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x38")]
		public LazyPowerUp SpawnOnImpactPowerUp;

		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x40")]
		public float CooldownTime;

		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x44")]
		public bool OneUseOnly;

		[Token(Token = "0x600137C")]
		[Address(RVA = "0x870038", Offset = "0x870038", VA = "0x870038")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private string _explosionDamageLoc;

	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private string _explosionRadiusLoc;

	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private string _spawnOnImpactPowerUpLoc;

	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private SoundContainer _explosionSound;

	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0x108")]
	private LazyPowerUp _spawnOnImpactPowerUp;

	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x110")]
	private int _cost;

	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x118")]
	private PowerUp _activatedSpawnOnImpactPowerUp;

	[Token(Token = "0x170002D9")]
	public int MaxLevel
	{
		[Token(Token = "0x6001375")]
		[Address(RVA = "0xE204F4", Offset = "0xE204F4", VA = "0xE204F4", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002DA")]
	public int GetCost
	{
		[Token(Token = "0x6001376")]
		[Address(RVA = "0xE20510", Offset = "0xE20510", VA = "0xE20510", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0xE20518", Offset = "0xE20518", VA = "0xE20518", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0xE2068C", Offset = "0xE2068C", VA = "0xE2068C", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0xE207A8", Offset = "0xE207A8", VA = "0xE207A8", Slot = "18")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x600137A")]
	[Address(RVA = "0xE20890", Offset = "0xE20890", VA = "0xE20890", Slot = "21")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x600137B")]
	[Address(RVA = "0xE20B40", Offset = "0xE20B40", VA = "0xE20B40")]
	public ExplosiveAmmoPowerUpUpgradable()
	{
	}
}
