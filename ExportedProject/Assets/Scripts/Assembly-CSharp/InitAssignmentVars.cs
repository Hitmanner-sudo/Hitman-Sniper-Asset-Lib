using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FE")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593A24", Offset = "0x593A24")]
public class InitAssignmentVars : FsmStateAction
{
	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5500", Offset = "0x5B5500")]
	public FsmFloat OutTimer;

	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5514", Offset = "0x5B5514")]
	public FsmFloat OutThreshold;

	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5528", Offset = "0x5B5528")]
	public FsmFloat OutDistance;

	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B553C", Offset = "0x5B553C")]
	public FsmInt OutScore;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5550", Offset = "0x5B5550")]
	public FsmInt OutKills;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5564", Offset = "0x5B5564")]
	public FsmInt OutTargetValue;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5578", Offset = "0x5B5578")]
	public FsmInt OutTargetValue2;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B558C", Offset = "0x5B558C")]
	public FsmString OutName;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B55A0", Offset = "0x5B55A0")]
	public FsmArray OutScoreTypes;

	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B55B4", Offset = "0x5B55B4")]
	public FsmBool OutGetTotalScoreType;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B55C8", Offset = "0x5B55C8")]
	public FsmBool OutGetHighestScoreType;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0xA8")]
	public List<NamedVariable> _Variables;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0xB0")]
	public List<string> _Named;

	[Token(Token = "0x6001870")]
	[Address(RVA = "0xB12D5C", Offset = "0xB12D5C", VA = "0xB12D5C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001871")]
	[Address(RVA = "0xB12E00", Offset = "0xB12E00", VA = "0xB12E00")]
	public InitAssignmentVars()
	{
	}
}
