using Il2CppDummyDll;

[Token(Token = "0x200041D")]
public class MoreChest : PerkReward
{
	[Token(Token = "0x40016F1")]
	[FieldOffset(Offset = "0x20")]
	public int ChestAmount;

	[Token(Token = "0x1700040C")]
	public override string GetDescription
	{
		[Token(Token = "0x600195A")]
		[Address(RVA = "0xA2C518", Offset = "0xA2C518", VA = "0xA2C518", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0xA2C598", Offset = "0xA2C598", VA = "0xA2C598", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x600195C")]
	[Address(RVA = "0xA2C59C", Offset = "0xA2C59C", VA = "0xA2C59C", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600195D")]
	[Address(RVA = "0xA2C5A0", Offset = "0xA2C5A0", VA = "0xA2C5A0")]
	public MoreChest()
	{
	}
}
