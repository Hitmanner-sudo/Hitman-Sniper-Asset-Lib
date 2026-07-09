using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000464")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5946B0", Offset = "0x5946B0")]
public class PerkRewardInfo : FsmStateAction
{
	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0x50")]
	public PerkReward PerkReward;

	[Token(Token = "0x400181D")]
	[FieldOffset(Offset = "0x58")]
	public FsmBool OutPerkRewardEnabled;

	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x901A18", Offset = "0x901A18", VA = "0x901A18", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x901B6C", Offset = "0x901B6C", VA = "0x901B6C")]
	public PerkRewardInfo()
	{
	}
}
