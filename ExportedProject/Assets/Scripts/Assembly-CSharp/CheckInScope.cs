using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000438")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x593D88", Offset = "0x593D88")]
public class CheckInScope : FsmStateAction
{
	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent AlreadyInScopeEvent;

	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent OnEnterScopeEvent;

	[Token(Token = "0x60019D3")]
	[Address(RVA = "0xAFDC64", Offset = "0xAFDC64", VA = "0xAFDC64", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019D4")]
	[Address(RVA = "0xAFDC6C", Offset = "0xAFDC6C", VA = "0xAFDC6C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019D5")]
	[Address(RVA = "0xAFDDD8", Offset = "0xAFDDD8", VA = "0xAFDDD8")]
	private void OnEnterScope(object sender, EventArgs empty)
	{
	}

	[Token(Token = "0x60019D6")]
	[Address(RVA = "0xAFDE14", Offset = "0xAFDE14", VA = "0xAFDE14", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019D7")]
	[Address(RVA = "0xAFDE90", Offset = "0xAFDE90", VA = "0xAFDE90")]
	public CheckInScope()
	{
	}
}
