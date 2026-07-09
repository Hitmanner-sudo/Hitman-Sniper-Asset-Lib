using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200044E")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594148", Offset = "0x594148")]
[Attribute(Name = "TooltipAttribute", RVA = "0x594148", Offset = "0x594148")]
public class DropListInjector : FsmStateAction
{
	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6378", Offset = "0x5B6378")]
	public FsmGameObject Spawner;

	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x58")]
	[RequiredField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B63C4", Offset = "0x5B63C4")]
	public DropList DropList;

	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent DoneInjecting;

	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0xC204FC", Offset = "0xC204FC", VA = "0xC204FC", Slot = "32")]
	public sealed override void OnEnter()
	{
	}

	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0xC206E4", Offset = "0xC206E4", VA = "0xC206E4")]
	public DropListInjector()
	{
	}
}
