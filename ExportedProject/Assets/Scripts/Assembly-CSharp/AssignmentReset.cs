using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003EB")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59387C", Offset = "0x59387C")]
public class AssignmentReset : FsmStateAction
{
	[Token(Token = "0x40015C7")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5230", Offset = "0x5B5230")]
	public FsmBool AffectMainProgress;

	[Token(Token = "0x6001826")]
	[Address(RVA = "0xC0372C", Offset = "0xC0372C", VA = "0xC0372C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001827")]
	[Address(RVA = "0xC038B0", Offset = "0xC038B0", VA = "0xC038B0")]
	public AssignmentReset()
	{
	}
}
