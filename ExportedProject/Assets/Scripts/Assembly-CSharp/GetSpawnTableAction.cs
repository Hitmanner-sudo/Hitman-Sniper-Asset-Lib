using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FB")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59397C", Offset = "0x59397C")]
public class GetSpawnTableAction : FsmStateAction
{
	[Token(Token = "0x4001632")]
	[FieldOffset(Offset = "0x50")]
	public SpawnTableModel TableModel;

	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0x58")]
	public SpawnTableModel.SpawnType SpawnType;

	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0x60")]
	public FsmFloat WaveTime;

	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0x68")]
	public FsmBool ScaleWithTime;

	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0x70")]
	public FsmFloat Scale;

	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5460", Offset = "0x5B5460")]
	public FsmFloat OutSpawnQuantity;

	[Token(Token = "0x6001862")]
	[Address(RVA = "0xC7EC64", Offset = "0xC7EC64", VA = "0xC7EC64", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001863")]
	[Address(RVA = "0xC7EC9C", Offset = "0xC7EC9C", VA = "0xC7EC9C", Slot = "30")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6001864")]
	[Address(RVA = "0xC7ECA4", Offset = "0xC7ECA4", VA = "0xC7ECA4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001865")]
	[Address(RVA = "0xC7EE9C", Offset = "0xC7EE9C", VA = "0xC7EE9C")]
	public GetSpawnTableAction()
	{
	}
}
