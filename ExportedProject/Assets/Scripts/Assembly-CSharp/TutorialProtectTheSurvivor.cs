using Il2CppDummyDll;

[Token(Token = "0x20002D3")]
public class TutorialProtectTheSurvivor : TutorialToLearnLogic
{
	[Token(Token = "0x4000FA5")]
	private const float TOOLTIP_DURATION = 4f;

	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x28")]
	private GameTimer _waitTimer;

	[Token(Token = "0x600115D")]
	[Address(RVA = "0xCA96D0", Offset = "0xCA96D0", VA = "0xCA96D0")]
	public TutorialProtectTheSurvivor(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600115E")]
	[Address(RVA = "0xCA96FC", Offset = "0xCA96FC", VA = "0xCA96FC", Slot = "7")]
	protected override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600115F")]
	[Address(RVA = "0xCA97D4", Offset = "0xCA97D4", VA = "0xCA97D4", Slot = "8")]
	protected override void DoStart()
	{
	}

	[Token(Token = "0x6001160")]
	[Address(RVA = "0xCA98F0", Offset = "0xCA98F0", VA = "0xCA98F0", Slot = "9")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x6001161")]
	[Address(RVA = "0xCA9954", Offset = "0xCA9954", VA = "0xCA9954", Slot = "10")]
	protected override void DoStop()
	{
	}

	[Token(Token = "0x6001162")]
	[Address(RVA = "0xCA9A6C", Offset = "0xCA9A6C", VA = "0xCA9A6C", Slot = "5")]
	public override bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001163")]
	[Address(RVA = "0xCA9B10", Offset = "0xCA9B10", VA = "0xCA9B10", Slot = "11")]
	protected override void SetCompleted(bool completed)
	{
	}
}
