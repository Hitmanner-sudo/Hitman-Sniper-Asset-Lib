using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E7")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5937C4", Offset = "0x5937C4")]
public class AssignmentMonitorAandAvoidB : FsmStateAction
{
	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x50")]
	public FsmGameObject DoAssignmentFsm;

	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x58")]
	public FsmGameObject AvoidAssignmentFsm;

	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent Success;

	[Token(Token = "0x40015B8")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent Fail;

	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0x70")]
	private bool _didSucceed;

	[Token(Token = "0x40015BA")]
	[FieldOffset(Offset = "0x71")]
	private bool _didFail;

	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0x78")]
	private readonly Dictionary<GameObject, AssignmentHandler> _fsmToHandlers;

	[Token(Token = "0x6001810")]
	[Address(RVA = "0xC027A0", Offset = "0xC027A0", VA = "0xC027A0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001811")]
	[Address(RVA = "0xC02958", Offset = "0xC02958", VA = "0xC02958", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6001812")]
	[Address(RVA = "0xC02990", Offset = "0xC02990", VA = "0xC02990", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001813")]
	[Address(RVA = "0xC028A0", Offset = "0xC028A0", VA = "0xC028A0")]
	private void InitAssignment(GameObject subFsm, EventHandler onSuccess)
	{
	}

	[Token(Token = "0x6001814")]
	[Address(RVA = "0xC02A8C", Offset = "0xC02A8C", VA = "0xC02A8C")]
	private void ExitAssignment(GameObject subFsm, EventHandler onSuccess)
	{
	}

	[Token(Token = "0x6001815")]
	[Address(RVA = "0xC02BC8", Offset = "0xC02BC8", VA = "0xC02BC8")]
	private void OnDoAssignmentSuccess(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001816")]
	[Address(RVA = "0xC02BD4", Offset = "0xC02BD4", VA = "0xC02BD4")]
	private void OnAvoidAssignmentSuccess(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001817")]
	[Address(RVA = "0xC02C00", Offset = "0xC02C00", VA = "0xC02C00")]
	public AssignmentMonitorAandAvoidB()
	{
	}
}
