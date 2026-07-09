using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003D7")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59369C", Offset = "0x59369C")]
public class AssignmentCheckCompletion : FsmStateAction
{
	[Token(Token = "0x400157A")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent Success;

	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent Incomplete;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B50F8", Offset = "0x5B50F8")]
	public FsmBool AffectMainProgress;

	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B510C", Offset = "0x5B510C")]
	public FsmBool TrackProgress;

	[Token(Token = "0x60017C9")]
	[Address(RVA = "0xC01254", Offset = "0xC01254", VA = "0xC01254", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60017CA")]
	[Address(RVA = "0xC01400", Offset = "0xC01400", VA = "0xC01400")]
	public AssignmentCheckCompletion()
	{
	}
}
