using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200046D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5948C8", Offset = "0x5948C8")]
public class SceneLoadedMonitor : FsmStateAction
{
	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent SceneLoaded;

	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0xBB2B60", Offset = "0xBB2B60", VA = "0xBB2B60", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0xBB2BDC", Offset = "0xBB2BDC", VA = "0xBB2BDC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0xBB2C58", Offset = "0xBB2C58", VA = "0xBB2C58")]
	private void OnLoadingViewDisable(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0xBB2D0C", Offset = "0xBB2D0C", VA = "0xBB2D0C")]
	public SceneLoadedMonitor()
	{
	}
}
