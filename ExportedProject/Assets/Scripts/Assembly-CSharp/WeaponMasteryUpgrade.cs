using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20003AD")]
public struct WeaponMasteryUpgrade
{
	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x0")]
	public static readonly WeaponMasteryUpgrade None;

	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private Wallet.CurrencyAmount _cost;

	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private float _scoreMultiplier;

	[Token(Token = "0x170003AA")]
	public Wallet.CurrencyAmount Cost
	{
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x98B6C0", Offset = "0x98B6C0", VA = "0x98B6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AB")]
	public float ScoreMultiplier
	{
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x98B6C8", Offset = "0x98B6C8", VA = "0x98B6C8")]
		get
		{
			return default(float);
		}
	}
}
