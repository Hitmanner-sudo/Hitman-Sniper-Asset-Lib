using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200030B")]
public class ReloadArrowData
{
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget ArrowObject;

	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x18")]
	public float InitDelay;

	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0x1C")]
	public float TimeTillFullAlpha;

	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x20")]
	public float TimeTillSlowMo;

	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0x24")]
	public float SlowMoDuration;

	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x28")]
	public float PersistSuccessDuration;

	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x2C")]
	public float PersistFailDuration;

	[NonSerialized]
	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x30")]
	public bool FadingArrow;

	[NonSerialized]
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x31")]
	public bool FadedArrow;

	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x9630FC", Offset = "0x9630FC", VA = "0x9630FC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x963104", Offset = "0x963104", VA = "0x963104")]
	public ReloadArrowData()
	{
	}
}
