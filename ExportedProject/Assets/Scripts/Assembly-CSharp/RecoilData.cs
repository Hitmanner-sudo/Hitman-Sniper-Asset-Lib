using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000387")]
public abstract class RecoilData : ScriptableObject
{
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x18")]
	public float JumpTime;

	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x1C")]
	public float HoldTime;

	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x20")]
	public float RecoveryTime;

	[NonSerialized]
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x24")]
	public float UpgradedRecoveryTime;

	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve BlendIn;

	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve BlendOut;

	[Token(Token = "0x17000342")]
	public float FinalHoldTime
	{
		[Token(Token = "0x6001576")]
		[Address(RVA = "0xB425AC", Offset = "0xB425AC", VA = "0xB425AC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000343")]
	public float FinalRecoveryTime
	{
		[Token(Token = "0x6001577")]
		[Address(RVA = "0xB425B4", Offset = "0xB425B4", VA = "0xB425B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001578")]
	public abstract RecoilItem CreateRecoilItem();

	[Token(Token = "0x6001579")]
	[Address(RVA = "0xB425CC", Offset = "0xB425CC", VA = "0xB425CC")]
	protected RecoilData()
	{
	}
}
