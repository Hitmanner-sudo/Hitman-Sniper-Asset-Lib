using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000450")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5941E0", Offset = "0x5941E0")]
[Attribute(Name = "TitleAttribute", RVA = "0x5941E0", Offset = "0x5941E0")]
public class EquipItemAction : FsmStateAction
{
	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6410", Offset = "0x5B6410")]
	[RequiredField]
	public FsmGameObject Receiver;

	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x58")]
	[RequiredField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B645C", Offset = "0x5B645C")]
	public FsmGameObject InventoryItem;

	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B64A8", Offset = "0x5B64A8")]
	public FsmBool EquipItem;

	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B64E0", Offset = "0x5B64E0")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B64E0", Offset = "0x5B64E0")]
	public FsmGameObject InventoryItemEquipped;

	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6530", Offset = "0x5B6530")]
	public FsmFloat UnequipItemDelay;

	[Token(Token = "0x6001A41")]
	[Address(RVA = "0xE16094", Offset = "0xE16094", VA = "0xE16094", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A42")]
	[Address(RVA = "0xE160D4", Offset = "0xE160D4", VA = "0xE160D4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0xE16258", Offset = "0xE16258", VA = "0xE16258")]
	private void DoEquipItem(ThirdPersonCharacter thirdPersonCharacter)
	{
	}

	[Token(Token = "0x6001A44")]
	[Address(RVA = "0xE16390", Offset = "0xE16390", VA = "0xE16390")]
	private void DoUnequipItem(ThirdPersonCharacter thirdPersonCharacter)
	{
	}

	[Token(Token = "0x6001A45")]
	[Address(RVA = "0xE1642C", Offset = "0xE1642C", VA = "0xE1642C")]
	public EquipItemAction()
	{
	}
}
