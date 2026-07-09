using Il2CppDummyDll;

[Token(Token = "0x2000417")]
public class ChestReward : PerkReward
{
	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0x20")]
	public int RewardBonus;

	[Token(Token = "0x17000408")]
	public override string GetDescription
	{
		[Token(Token = "0x6001942")]
		[Address(RVA = "0xB00548", Offset = "0xB00548", VA = "0xB00548", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001943")]
	[Address(RVA = "0xB005C8", Offset = "0xB005C8", VA = "0xB005C8", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001944")]
	[Address(RVA = "0xB005CC", Offset = "0xB005CC", VA = "0xB005CC", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001945")]
	[Address(RVA = "0xB005D0", Offset = "0xB005D0", VA = "0xB005D0")]
	public ChestReward()
	{
	}
}
