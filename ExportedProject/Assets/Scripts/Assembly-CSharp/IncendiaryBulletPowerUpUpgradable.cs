using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200033C")]
public class IncendiaryBulletPowerUpUpgradable : SpawnOnImpactPowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x200033D")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x1C")]
		public float Radius;

		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x24")]
		public float DamagePerSecond;

		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x28")]
		public float DOTDuration;

		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x2C")]
		public float CooldownTime;

		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x30")]
		public bool OneUseOnly;

		[Token(Token = "0x60013B7")]
		[Address(RVA = "0xB25650", Offset = "0xB25650", VA = "0xB25650")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0xC0")]
	private float _effectDuration;

	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0xC4")]
	private float _effectRadius;

	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0xC8")]
	private float _effectDamageOverTime;

	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0xCC")]
	private float _effectDOTDuration;

	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0xD0")]
	private int _cost;

	[Token(Token = "0x170002DF")]
	public int MaxLevel
	{
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0xB0AD08", Offset = "0xB0AD08", VA = "0xB0AD08", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002E0")]
	public int GetCost
	{
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0xB0AD24", Offset = "0xB0AD24", VA = "0xB0AD24", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60013B3")]
	[Address(RVA = "0xB0AD2C", Offset = "0xB0AD2C", VA = "0xB0AD2C", Slot = "21")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0xB0ADFC", Offset = "0xB0ADFC", VA = "0xB0ADFC", Slot = "19")]
	protected override void PreEnabledFunction(GameObject spawnedGameObject, long bulletID, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0xB0AFB4", Offset = "0xB0AFB4", VA = "0xB0AFB4", Slot = "24")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0xB0B020", Offset = "0xB0B020", VA = "0xB0B020")]
	public IncendiaryBulletPowerUpUpgradable()
	{
	}
}
