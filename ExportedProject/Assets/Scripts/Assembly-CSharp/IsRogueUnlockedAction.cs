using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FF")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593A5C", Offset = "0x593A5C")]
public class IsRogueUnlockedAction : FsmStateAction
{
	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x50")]
	public string RogueDataPath;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent IsUnlocked;

	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent IsLocked;

	[Token(Token = "0x6001872")]
	[Address(RVA = "0x10BEE2C", Offset = "0x10BEE2C", VA = "0x10BEE2C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001873")]
	[Address(RVA = "0x10BEF30", Offset = "0x10BEF30", VA = "0x10BEF30")]
	public IsRogueUnlockedAction()
	{
	}
}
