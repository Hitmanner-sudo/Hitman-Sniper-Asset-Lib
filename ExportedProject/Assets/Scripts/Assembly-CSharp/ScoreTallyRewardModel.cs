using System;
using Il2CppDummyDll;

[Token(Token = "0x20005D4")]
public class ScoreTallyRewardModel : DataModel
{
	[Token(Token = "0x4001F74")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string REWARD_CLAIMED;

	[NonSerialized]
	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0x48")]
	private bool _rewardClaimed;

	[Token(Token = "0x600255A")]
	[Address(RVA = "0xB61160", Offset = "0xB61160", VA = "0xB61160", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0xB61294", Offset = "0xB61294", VA = "0xB61294")]
	public ScoreTallyRewardModel()
	{
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0xB61300", Offset = "0xB61300", VA = "0xB61300")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC30", Offset = "0x61BC30")]
	private bool _003CBindAllVariables_003Eb__2_0()
	{
		return default(bool);
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0xB61308", Offset = "0xB61308", VA = "0xB61308")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BC40", Offset = "0x61BC40")]
	private void _003CBindAllVariables_003Eb__2_1(bool b)
	{
	}
}
