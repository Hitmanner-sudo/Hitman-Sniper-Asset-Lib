using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000434")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593C80", Offset = "0x593C80")]
public class ArrestMonitor : FsmStateAction
{
	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter ArresteeFilter;

	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5C40", Offset = "0x5B5C40")]
	public FsmGameObject Arrester;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5C54", Offset = "0x5B5C54")]
	public FsmGameObject Arrestee;

	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent SendEvent;

	[Token(Token = "0x60019BE")]
	[Address(RVA = "0xBFF26C", Offset = "0xBFF26C", VA = "0xBFF26C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019BF")]
	[Address(RVA = "0xBFF2CC", Offset = "0xBFF2CC", VA = "0xBFF2CC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019C0")]
	[Address(RVA = "0xBFF35C", Offset = "0xBFF35C", VA = "0xBFF35C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019C1")]
	[Address(RVA = "0xBFF3EC", Offset = "0xBFF3EC", VA = "0xBFF3EC")]
	private void OnBehaviourChange(object sender, AIController.BehaviourEventArgs args)
	{
	}

	[Token(Token = "0x60019C2")]
	[Address(RVA = "0xBFF574", Offset = "0xBFF574", VA = "0xBFF574")]
	public ArrestMonitor()
	{
	}
}
