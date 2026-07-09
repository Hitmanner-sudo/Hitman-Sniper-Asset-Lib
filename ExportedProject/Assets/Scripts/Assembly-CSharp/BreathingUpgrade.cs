using Il2CppDummyDll;

[Token(Token = "0x2000395")]
public class BreathingUpgrade : Attachment
{
	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x18")]
	public bool OverrideBreathingAmplitude;

	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0x1C")]
	public float BreathingAmplitude;

	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0x20")]
	public bool OverrideBreathingFrequency;

	[Token(Token = "0x4001421")]
	[FieldOffset(Offset = "0x24")]
	public float BreathingFrequency;

	[Token(Token = "0x4001422")]
	[FieldOffset(Offset = "0x28")]
	public bool OverrideBreathingPhaseBreaker;

	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0x2C")]
	public float BreathingPhaseBreaker;

	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0x30")]
	public bool OverrideBreathingTimeRatio;

	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x34")]
	public float BreathingTimeRatio;

	[Token(Token = "0x17000366")]
	public bool IsBreathingAmplitudeModified
	{
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0xA80BBC", Offset = "0xA80BBC", VA = "0xA80BBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000367")]
	public bool IsBreathingFrequencyModified
	{
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0xA80BDC", Offset = "0xA80BDC", VA = "0xA80BDC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000368")]
	public bool IsBreathingPhaseBreakerModified
	{
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0xA80BFC", Offset = "0xA80BFC", VA = "0xA80BFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000369")]
	public bool IsBreathingTimeRatioModified
	{
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0xA80C1C", Offset = "0xA80C1C", VA = "0xA80C1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60015E6")]
	[Address(RVA = "0xA80C3C", Offset = "0xA80C3C", VA = "0xA80C3C", Slot = "61")]
	public override float BreathingAmplitudeModifier(float value)
	{
		return default(float);
	}

	[Token(Token = "0x60015E7")]
	[Address(RVA = "0xA80C54", Offset = "0xA80C54", VA = "0xA80C54", Slot = "62")]
	public override float BreathingFrequencyModifier(float value)
	{
		return default(float);
	}

	[Token(Token = "0x60015E8")]
	[Address(RVA = "0xA80C6C", Offset = "0xA80C6C", VA = "0xA80C6C", Slot = "63")]
	public override float BreathingPhaseBreakerModifier(float value)
	{
		return default(float);
	}

	[Token(Token = "0x60015E9")]
	[Address(RVA = "0xA80C84", Offset = "0xA80C84", VA = "0xA80C84", Slot = "64")]
	public override float BreathingTimeRatioModifier(float value)
	{
		return default(float);
	}

	[Token(Token = "0x60015EA")]
	[Address(RVA = "0xA80C9C", Offset = "0xA80C9C", VA = "0xA80C9C", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x60015EB")]
	[Address(RVA = "0xA80DC8", Offset = "0xA80DC8", VA = "0xA80DC8")]
	public BreathingUpgrade()
	{
	}
}
