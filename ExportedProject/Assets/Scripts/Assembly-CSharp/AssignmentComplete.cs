using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003D8")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5936D4", Offset = "0x5936D4")]
public class AssignmentComplete : FsmStateAction
{
	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x50")]
	public FsmBool Success;

	[Token(Token = "0x60017CB")]
	[Address(RVA = "0xC01408", Offset = "0xC01408", VA = "0xC01408", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60017CC")]
	[Address(RVA = "0xC0143C", Offset = "0xC0143C", VA = "0xC0143C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60017CD")]
	[Address(RVA = "0xC0154C", Offset = "0xC0154C", VA = "0xC0154C")]
	public AssignmentComplete()
	{
	}
}
