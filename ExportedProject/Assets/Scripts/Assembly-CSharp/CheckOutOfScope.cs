using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000439")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x593DC0", Offset = "0x593DC0")]
public class CheckOutOfScope : FsmStateAction
{
	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent _AlreadyOutOfScopeEvent;

	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent _OnOutOfScopeEvent;

	[Token(Token = "0x60019D8")]
	[Address(RVA = "0xAFF0FC", Offset = "0xAFF0FC", VA = "0xAFF0FC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019D9")]
	[Address(RVA = "0xAFF104", Offset = "0xAFF104", VA = "0xAFF104", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019DA")]
	[Address(RVA = "0xAFF270", Offset = "0xAFF270", VA = "0xAFF270")]
	private void OnExitScope(object sender, EventArgs empty)
	{
	}

	[Token(Token = "0x60019DB")]
	[Address(RVA = "0xAFF2AC", Offset = "0xAFF2AC", VA = "0xAFF2AC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019DC")]
	[Address(RVA = "0xAFF328", Offset = "0xAFF328", VA = "0xAFF328")]
	public CheckOutOfScope()
	{
	}
}
