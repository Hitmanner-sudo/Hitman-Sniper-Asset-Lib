using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000473")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594A40", Offset = "0x594A40")]
public class ToggleNavigationLayer : FsmStateAction
{
	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x50")]
	public FsmBool Blocked;

	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x58")]
	public int Mask;

	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0xACFF58", Offset = "0xACFF58", VA = "0xACFF58", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0xACFF64", Offset = "0xACFF64", VA = "0xACFF64", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0xAD0068", Offset = "0xAD0068", VA = "0xAD0068")]
	public ToggleNavigationLayer()
	{
	}
}
