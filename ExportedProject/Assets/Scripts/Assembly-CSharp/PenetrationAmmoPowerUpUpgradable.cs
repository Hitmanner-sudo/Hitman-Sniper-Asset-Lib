using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000349")]
public class PenetrationAmmoPowerUpUpgradable : PowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x200034A")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x1C")]
		public float ActiveTime;

		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x20")]
		public float CooldownTime;

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x8CF268", Offset = "0x8CF268", VA = "0x8CF268")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0xA8")]
	private int _cost;

	[Token(Token = "0x170002E3")]
	public int MaxLevel
	{
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x8FCEE0", Offset = "0x8FCEE0", VA = "0x8FCEE0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002E4")]
	public int GetCost
	{
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x8FCEFC", Offset = "0x8FCEFC", VA = "0x8FCEFC", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x8FCF04", Offset = "0x8FCF04", VA = "0x8FCF04", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x8FCF58", Offset = "0x8FCF58", VA = "0x8FCF58", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x8FCFAC", Offset = "0x8FCFAC", VA = "0x8FCFAC", Slot = "18")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x8FD0B4", Offset = "0x8FD0B4", VA = "0x8FD0B4", Slot = "21")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x8FD120", Offset = "0x8FD120", VA = "0x8FD120")]
	public PenetrationAmmoPowerUpUpgradable()
	{
	}
}
