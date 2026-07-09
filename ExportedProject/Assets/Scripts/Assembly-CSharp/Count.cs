using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000440")]
[Attribute(Name = "TooltipAttribute", RVA = "0x593F00", Offset = "0x593F00")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593F00", Offset = "0x593F00")]
public class Count : FsmStateAction
{
	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent CountReached;

	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent CountNotReached;

	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5E34", Offset = "0x5B5E34")]
	[RequiredField]
	public FsmInt CountUpTo;

	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5E70", Offset = "0x5B5E70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5E70", Offset = "0x5B5E70")]
	public FsmInt CurrentCount;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5EC0", Offset = "0x5B5EC0")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5EC0", Offset = "0x5B5EC0")]
	public FsmFloat MaximumDuration;

	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5F10", Offset = "0x5B5F10")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5F10", Offset = "0x5B5F10")]
	public FsmArray Events;

	[Token(Token = "0x60019FA")]
	[Address(RVA = "0xD80438", Offset = "0xD80438", VA = "0xD80438", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019FB")]
	[Address(RVA = "0xD80748", Offset = "0xD80748", VA = "0xD80748")]
	public Count()
	{
	}
}
