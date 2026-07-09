using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003F9")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59390C", Offset = "0x59390C")]
public class GetMissionData : FsmStateAction
{
	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B539C", Offset = "0x5B539C")]
	public FsmInt OutNumMissionsCompleted;

	[Token(Token = "0x400162B")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B53B0", Offset = "0x5B53B0")]
	public FsmInt OutCurrentMissionId;

	[Token(Token = "0x600185D")]
	[Address(RVA = "0x10647A4", Offset = "0x10647A4", VA = "0x10647A4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600185E")]
	[Address(RVA = "0x10648E8", Offset = "0x10648E8", VA = "0x10648E8")]
	public GetMissionData()
	{
	}
}
