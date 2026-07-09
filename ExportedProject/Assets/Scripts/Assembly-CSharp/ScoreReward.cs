using Il2CppDummyDll;

[Token(Token = "0x200041F")]
public class ScoreReward : PerkReward
{
	[Token(Token = "0x2000420")]
	public enum ScoreRewardType
	{
		[Token(Token = "0x40016F7")]
		Headshot = 0,
		[Token(Token = "0x40016F8")]
		NoHoldBreath = 1
	}

	[Token(Token = "0x40016F4")]
	[FieldOffset(Offset = "0x20")]
	public float RewardBonusRatio;

	[Token(Token = "0x40016F5")]
	[FieldOffset(Offset = "0x24")]
	public ScoreRewardType Type;

	[Token(Token = "0x1700040E")]
	public override string GetDescription
	{
		[Token(Token = "0x6001963")]
		[Address(RVA = "0xB5E5F0", Offset = "0xB5E5F0", VA = "0xB5E5F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001964")]
	[Address(RVA = "0xB5E67C", Offset = "0xB5E67C", VA = "0xB5E67C", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001965")]
	[Address(RVA = "0xB5E680", Offset = "0xB5E680", VA = "0xB5E680", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0xB5E684", Offset = "0xB5E684", VA = "0xB5E684")]
	public ScoreReward()
	{
	}
}
