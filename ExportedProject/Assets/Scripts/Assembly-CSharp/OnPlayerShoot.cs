using System;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000461")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594608", Offset = "0x594608")]
public class OnPlayerShoot : FsmStateAction
{
	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent _OnShootEvent;

	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x9F6954", Offset = "0x9F6954", VA = "0x9F6954", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x9F695C", Offset = "0x9F695C", VA = "0x9F695C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A88")]
	[Address(RVA = "0x9F69D8", Offset = "0x9F69D8", VA = "0x9F69D8", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x9F6A54", Offset = "0x9F6A54", VA = "0x9F6A54")]
	private void OnBulletShot(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x9F6B4C", Offset = "0x9F6B4C", VA = "0x9F6B4C")]
	public OnPlayerShoot()
	{
	}
}
