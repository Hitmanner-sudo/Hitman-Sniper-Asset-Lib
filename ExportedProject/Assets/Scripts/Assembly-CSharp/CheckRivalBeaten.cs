using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200043A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x593DF8", Offset = "0x593DF8")]
public class CheckRivalBeaten : FsmStateAction
{
	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent OnRivalBeatenEvent;

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0xAFF330", Offset = "0xAFF330", VA = "0xAFF330", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019DE")]
	[Address(RVA = "0xAFF338", Offset = "0xAFF338", VA = "0xAFF338", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0xAFF3B4", Offset = "0xAFF3B4", VA = "0xAFF3B4")]
	private void OnRivalBeaten(object sender, EventArgs empty)
	{
	}

	[Token(Token = "0x60019E0")]
	[Address(RVA = "0xAFF3F0", Offset = "0xAFF3F0", VA = "0xAFF3F0", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019E1")]
	[Address(RVA = "0xAFF46C", Offset = "0xAFF46C", VA = "0xAFF46C")]
	public CheckRivalBeaten()
	{
	}
}
