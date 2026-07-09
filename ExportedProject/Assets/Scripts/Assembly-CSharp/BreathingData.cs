using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200036D")]
public class BreathingData : ScriptableObject
{
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _BreathingAmplitude;

	[NonSerialized]
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x1C")]
	private float _BreathingAmplitudeModifier;

	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _BreathingFrequency;

	[NonSerialized]
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x24")]
	private float _BreathingFrequencyModifier;

	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _BreathingPhaseBreaker;

	[NonSerialized]
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x2C")]
	private float _BreathingPhaseBreakerModifier;

	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _BreathingTimeRatio;

	[NonSerialized]
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x34")]
	private float _BreathingTimeRatioModifier;

	[Token(Token = "0x1700030F")]
	public float BreathingAmplitude
	{
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0xA80A48", Offset = "0xA80A48", VA = "0xA80A48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0xA80A54", Offset = "0xA80A54", VA = "0xA80A54")]
		set
		{
		}
	}

	[Token(Token = "0x17000310")]
	public float BreathingFrequency
	{
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0xA80A64", Offset = "0xA80A64", VA = "0xA80A64")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0xA80A70", Offset = "0xA80A70", VA = "0xA80A70")]
		set
		{
		}
	}

	[Token(Token = "0x17000311")]
	public float BreathingPhaseBreaker
	{
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0xA80A80", Offset = "0xA80A80", VA = "0xA80A80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0xA80A8C", Offset = "0xA80A8C", VA = "0xA80A8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000312")]
	public float BreathingTimeRatio
	{
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0xA80A9C", Offset = "0xA80A9C", VA = "0xA80A9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0xA80AA8", Offset = "0xA80AA8", VA = "0xA80AA8")]
		set
		{
		}
	}

	[Token(Token = "0x60014D2")]
	[Address(RVA = "0xA80AB8", Offset = "0xA80AB8", VA = "0xA80AB8")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x60014D3")]
	[Address(RVA = "0xA80ACC", Offset = "0xA80ACC", VA = "0xA80ACC")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x60014D4")]
	[Address(RVA = "0xA80B8C", Offset = "0xA80B8C", VA = "0xA80B8C")]
	public BreathingData()
	{
	}
}
