using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000346")]
public class MassConfusionPowerUpUpgradable : PowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x2000347")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x4001207")]
		[FieldOffset(Offset = "0x1C")]
		public float ActiveTime;

		[Token(Token = "0x4001208")]
		[FieldOffset(Offset = "0x20")]
		public float CooldownTime;

		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0x24")]
		public bool AffectSpecialZombies;

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x8C5D6C", Offset = "0x8C5D6C", VA = "0x8C5D6C")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private string _activeTimeLoc;

	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private string _affectSpecialZombiesLoc;

	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0xB8")]
	private float _activeTime;

	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0xBC")]
	private bool _affectSpecialZombies;

	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0xC0")]
	private int _cost;

	[Token(Token = "0x170002E1")]
	public int MaxLevel
	{
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x9AFA90", Offset = "0x9AFA90", VA = "0x9AFA90", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002E2")]
	public int GetCost
	{
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x9AFAAC", Offset = "0x9AFAAC", VA = "0x9AFAAC", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x9AFAB4", Offset = "0x9AFAB4", VA = "0x9AFAB4", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x9AFB3C", Offset = "0x9AFB3C", VA = "0x9AFB3C", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x9AFBBC", Offset = "0x9AFBBC", VA = "0x9AFBBC", Slot = "18")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x9AFCD8", Offset = "0x9AFCD8", VA = "0x9AFCD8", Slot = "21")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x9AFEFC", Offset = "0x9AFEFC", VA = "0x9AFEFC")]
	public MassConfusionPowerUpUpgradable()
	{
	}
}
