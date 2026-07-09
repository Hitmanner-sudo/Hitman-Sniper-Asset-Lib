using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003E6")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x59378C", Offset = "0x59378C")]
public class AssignmentMonitor : FsmStateAction
{
	[Token(Token = "0x40015B2")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject AssignmentFSM;

	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent Success;

	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent Fail;

	[Token(Token = "0x600180B")]
	[Address(RVA = "0xC023FC", Offset = "0xC023FC", VA = "0xC023FC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600180C")]
	[Address(RVA = "0xC025D0", Offset = "0xC025D0", VA = "0xC025D0", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x600180D")]
	[Address(RVA = "0xC02748", Offset = "0xC02748", VA = "0xC02748")]
	private void OnSubAssignmentSuccess(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600180E")]
	[Address(RVA = "0xC02770", Offset = "0xC02770", VA = "0xC02770")]
	private void OnSubAssignmentFailed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600180F")]
	[Address(RVA = "0xC02798", Offset = "0xC02798", VA = "0xC02798")]
	public AssignmentMonitor()
	{
	}
}
