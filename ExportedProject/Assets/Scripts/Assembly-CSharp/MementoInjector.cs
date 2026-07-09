using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000457")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5943E0", Offset = "0x5943E0")]
[Attribute(Name = "TooltipAttribute", RVA = "0x5943E0", Offset = "0x5943E0")]
public class MementoInjector : FsmStateAction
{
	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6638", Offset = "0x5B6638")]
	[RequiredField]
	public FsmGameObject Spawner;

	[Token(Token = "0x40017F0")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6684", Offset = "0x5B6684")]
	[RequiredField]
	public AIMemento Memento;

	[Token(Token = "0x40017F1")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B66D0", Offset = "0x5B66D0")]
	public FsmGameObject Origin;

	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent DoneInjecting;

	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x9B7C8C", Offset = "0x9B7C8C", VA = "0x9B7C8C", Slot = "32")]
	public sealed override void OnEnter()
	{
	}

	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x9B7E8C", Offset = "0x9B7E8C", VA = "0x9B7E8C")]
	public void Inject(Character character)
	{
	}

	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x9B820C", Offset = "0x9B820C", VA = "0x9B820C")]
	public MementoInjector()
	{
	}
}
