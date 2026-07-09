using Il2CppDummyDll;

[Token(Token = "0x200039C")]
public class SwayUpgrade : Attachment
{
	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x18")]
	public float FrequencyRatio;

	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x1C")]
	public float AmplitudeRatio;

	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0x20")]
	public float DampingRatio;

	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0x24")]
	public float DisableSwayAfterTouchTimerRatio;

	[Token(Token = "0x600162E")]
	[Address(RVA = "0xB49AA0", Offset = "0xB49AA0", VA = "0xB49AA0", Slot = "33")]
	public override float FrequencyXModifier(float frequencyX)
	{
		return default(float);
	}

	[Token(Token = "0x600162F")]
	[Address(RVA = "0xB49AB4", Offset = "0xB49AB4", VA = "0xB49AB4", Slot = "34")]
	public override float FrequencyYModifier(float frequencyY)
	{
		return default(float);
	}

	[Token(Token = "0x6001630")]
	[Address(RVA = "0xB49AC8", Offset = "0xB49AC8", VA = "0xB49AC8", Slot = "35")]
	public override float AmplitudeXModifier(float amplitudeX)
	{
		return default(float);
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0xB49ADC", Offset = "0xB49ADC", VA = "0xB49ADC", Slot = "36")]
	public override float AmplitudeYModifier(float amplitudeY)
	{
		return default(float);
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0xB49AF0", Offset = "0xB49AF0", VA = "0xB49AF0", Slot = "37")]
	public override float DampingModifier(float damping)
	{
		return default(float);
	}

	[Token(Token = "0x6001633")]
	[Address(RVA = "0xB49B04", Offset = "0xB49B04", VA = "0xB49B04", Slot = "38")]
	public override float DisableSwayAfterTouchTimer(float disableSwayAfterTouchTimer)
	{
		return default(float);
	}

	[Token(Token = "0x6001634")]
	[Address(RVA = "0xB49B18", Offset = "0xB49B18", VA = "0xB49B18", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x6001635")]
	[Address(RVA = "0xB49C08", Offset = "0xB49C08", VA = "0xB49C08")]
	public SwayUpgrade()
	{
	}
}
