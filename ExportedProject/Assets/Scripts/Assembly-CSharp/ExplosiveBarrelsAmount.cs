using Il2CppDummyDll;

[Token(Token = "0x200041C")]
public class ExplosiveBarrelsAmount : PerkReward
{
	[Token(Token = "0x40016F0")]
	[FieldOffset(Offset = "0x20")]
	public float AmountBonusRatio;

	[Token(Token = "0x1700040B")]
	public override string GetDescription
	{
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x947F48", Offset = "0x947F48", VA = "0x947F48", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001957")]
	[Address(RVA = "0x947FD4", Offset = "0x947FD4", VA = "0x947FD4", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001958")]
	[Address(RVA = "0x947FD8", Offset = "0x947FD8", VA = "0x947FD8", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001959")]
	[Address(RVA = "0x947FDC", Offset = "0x947FDC", VA = "0x947FDC")]
	public ExplosiveBarrelsAmount()
	{
	}
}
