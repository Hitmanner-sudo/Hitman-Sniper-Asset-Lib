using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FA")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593944", Offset = "0x593944")]
public class GetScoresOfType : FsmStateAction
{
	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B53C4", Offset = "0x5B53C4")]
	public FsmArray ScoreTypes;

	[Token(Token = "0x400162D")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B53D8", Offset = "0x5B53D8")]
	public FsmBool GetTotalScoreType;

	[Token(Token = "0x400162E")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B53EC", Offset = "0x5B53EC")]
	public FsmBool GetHighestScoreType;

	[Token(Token = "0x400162F")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5400", Offset = "0x5B5400")]
	public FsmInt ScoreThreshold;

	[Token(Token = "0x4001630")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5414", Offset = "0x5B5414")]
	public FsmInt OutScore;

	[Token(Token = "0x4001631")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5428", Offset = "0x5B5428")]
	public FsmEvent _ConditionsMetEvent;

	[Token(Token = "0x600185F")]
	[Address(RVA = "0xC7E75C", Offset = "0xC7E75C", VA = "0xC7E75C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001860")]
	[Address(RVA = "0xC7E76C", Offset = "0xC7E76C", VA = "0xC7E76C", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6001861")]
	[Address(RVA = "0xC7EA38", Offset = "0xC7EA38", VA = "0xC7EA38")]
	public GetScoresOfType()
	{
	}
}
