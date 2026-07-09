using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000360")]
public class SplitShotPowerUpUpgradable : PowerUp, UpgradablePowerUp
{
	[Serializable]
	[Token(Token = "0x2000361")]
	private class PowerUpLevels : PowerUpLevelsBase
	{
		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x1C")]
		public float CooldownTime;

		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x20")]
		public bool OneUseOnly;

		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x24")]
		public int EnemiesToTrackNumber;

		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x28")]
		public float EnemiesToTrackDistance;

		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x2C")]
		public bool EnemiesToTrackShowHighlight;

		[Token(Token = "0x600145F")]
		[Address(RVA = "0xA52604", Offset = "0xA52604", VA = "0xA52604")]
		public PowerUpLevels()
		{
		}
	}

	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private PowerUpLevels[] _powerUpLevels;

	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private string _numberOfSplitShootLoc;

	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0xB0")]
	private int _enemiesToTrackNumber;

	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0xB4")]
	private float _enemiesToTrackDistance;

	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0xB8")]
	private bool _enemiesToTrackShowHighlight;

	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0xBC")]
	private int _cost;

	[Token(Token = "0x170002FD")]
	public int MaxLevel
	{
		[Token(Token = "0x6001458")]
		[Address(RVA = "0xD24C84", Offset = "0xD24C84", VA = "0xD24C84", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002FE")]
	public int GetCost
	{
		[Token(Token = "0x6001459")]
		[Address(RVA = "0xD24CA0", Offset = "0xD24CA0", VA = "0xD24CA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600145A")]
	[Address(RVA = "0xD24CA8", Offset = "0xD24CA8", VA = "0xD24CA8", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x600145B")]
	[Address(RVA = "0xD24D28", Offset = "0xD24D28", VA = "0xD24D28", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600145C")]
	[Address(RVA = "0xD24DA8", Offset = "0xD24DA8", VA = "0xD24DA8", Slot = "18")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x600145D")]
	[Address(RVA = "0xD24E70", Offset = "0xD24E70", VA = "0xD24E70", Slot = "21")]
	public List<List<string>> GetLevelStats()
	{
		return null;
	}

	[Token(Token = "0x600145E")]
	[Address(RVA = "0xD25054", Offset = "0xD25054", VA = "0xD25054")]
	public SplitShotPowerUpUpgradable()
	{
	}
}
