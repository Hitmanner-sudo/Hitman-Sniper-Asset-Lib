using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5937FC", Offset = "0x5937FC")]
public class AssignmentMonitorAandB : FsmStateAction
{
	[Token(Token = "0x40015BC")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject AssignmentFSM1;

	[Token(Token = "0x40015BD")]
	[FieldOffset(Offset = "0x58")]
	public FsmGameObject AssignmentFSM2;

	[Token(Token = "0x40015BE")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent Success;

	[Token(Token = "0x40015BF")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent Fail;

	[Token(Token = "0x40015C0")]
	[FieldOffset(Offset = "0x70")]
	private bool _completed1;

	[Token(Token = "0x40015C1")]
	[FieldOffset(Offset = "0x71")]
	private bool _completed2;

	[Token(Token = "0x6001818")]
	[Address(RVA = "0xC02C7C", Offset = "0xC02C7C", VA = "0xC02C7C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001819")]
	[Address(RVA = "0xC02E88", Offset = "0xC02E88", VA = "0xC02E88")]
	private void InitAssignment(GameObject subFsm, EventHandler onSuccess, EventHandler onFail)
	{
	}

	[Token(Token = "0x600181A")]
	[Address(RVA = "0xC02F84", Offset = "0xC02F84", VA = "0xC02F84")]
	private void ExitAssignment(GameObject subFsm, EventHandler onSuccess, EventHandler onFail)
	{
	}

	[Token(Token = "0x600181B")]
	[Address(RVA = "0xC03014", Offset = "0xC03014", VA = "0xC03014", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x600181C")]
	[Address(RVA = "0xC0321C", Offset = "0xC0321C", VA = "0xC0321C")]
	private void OnSubAssignment1Success(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600181D")]
	[Address(RVA = "0xC03254", Offset = "0xC03254", VA = "0xC03254")]
	private void OnSubAssignment2Success(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600181E")]
	[Address(RVA = "0xC0328C", Offset = "0xC0328C", VA = "0xC0328C")]
	private void OnSubAssignmentFailed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600181F")]
	[Address(RVA = "0xC032B4", Offset = "0xC032B4", VA = "0xC032B4")]
	public AssignmentMonitorAandB()
	{
	}
}
