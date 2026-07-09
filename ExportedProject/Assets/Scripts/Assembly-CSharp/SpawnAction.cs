using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200040F")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593B40", Offset = "0x593B40")]
public class SpawnAction : FsmStateAction
{
	[Token(Token = "0x2000410")]
	public enum SpawnMethods
	{
		[Token(Token = "0x40016C2")]
		SpawnAll = 0,
		[Token(Token = "0x40016C3")]
		SpawnOneRandom = 1,
		[Token(Token = "0x40016C4")]
		SpawnOneRandomUnique = 2
	}

	[Token(Token = "0x40016B4")]
	[FieldOffset(Offset = "0x50")]
	[ReadOnly]
	public Spawner[] ValidSpawners;

	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x58")]
	public FsmGameObject[] FSMSpawners;

	[Token(Token = "0x40016B6")]
	[FieldOffset(Offset = "0x60")]
	public FsmInt SpawnSpecificIndex;

	[Token(Token = "0x40016B7")]
	[FieldOffset(Offset = "0x68")]
	public SpawnMethods SpawnMethod;

	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x70")]
	public FsmFloat Delay;

	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0x78")]
	public bool SearchSpawnerInChildrens;

	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0x80")]
	public FsmGameObject SpawnAroundGameObject;

	[Token(Token = "0x40016BB")]
	[FieldOffset(Offset = "0x88")]
	public FsmFloat MinRange;

	[Token(Token = "0x40016BC")]
	[FieldOffset(Offset = "0x90")]
	public FsmFloat MaxRange;

	[Token(Token = "0x40016BD")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B58AC", Offset = "0x5B58AC")]
	public bool IsDynamic;

	[Token(Token = "0x40016BE")]
	[FieldOffset(Offset = "0xA0")]
	private int[] _randomIndex;

	[Token(Token = "0x40016BF")]
	[FieldOffset(Offset = "0xA8")]
	private int _randomSpawnerIndex;

	[Token(Token = "0x40016C0")]
	[FieldOffset(Offset = "0xB0")]
	[ReadOnly]
	public Spawner[] AllSpawners;

	[Token(Token = "0x6001907")]
	[Address(RVA = "0xA71B10", Offset = "0xA71B10", VA = "0xA71B10", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001908")]
	[Address(RVA = "0xA71B58", Offset = "0xA71B58", VA = "0xA71B58", Slot = "30")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0xA71C1C", Offset = "0xA71C1C", VA = "0xA71C1C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0xA71CC0", Offset = "0xA71CC0", VA = "0xA71CC0")]
	private void SetSpawners()
	{
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0xA71F80", Offset = "0xA71F80", VA = "0xA71F80")]
	private void PopulateRandomIndexTable()
	{
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0xA71D00", Offset = "0xA71D00", VA = "0xA71D00")]
	private Spawner[] GetValidSpawners()
	{
		return null;
	}

	[Token(Token = "0x600190D")]
	[Address(RVA = "0xA72048", Offset = "0xA72048", VA = "0xA72048")]
	private void ShuffleSpawners()
	{
	}

	[Token(Token = "0x600190E")]
	[Address(RVA = "0xA71C64", Offset = "0xA71C64", VA = "0xA71C64")]
	private void Spawn()
	{
	}

	[Token(Token = "0x600190F")]
	[Address(RVA = "0xA72094", Offset = "0xA72094", VA = "0xA72094")]
	private void SpawnAll()
	{
	}

	[Token(Token = "0x6001910")]
	[Address(RVA = "0xA7219C", Offset = "0xA7219C", VA = "0xA7219C")]
	private void SpawnOneRandom()
	{
	}

	[Token(Token = "0x6001911")]
	[Address(RVA = "0xA722D4", Offset = "0xA722D4", VA = "0xA722D4")]
	private void SpawnOneRandomUnique()
	{
	}

	[Token(Token = "0x6001912")]
	[Address(RVA = "0xA7247C", Offset = "0xA7247C", VA = "0xA7247C")]
	private void ClearSpawners()
	{
	}

	[Token(Token = "0x6001913")]
	[Address(RVA = "0xA71BA0", Offset = "0xA71BA0", VA = "0xA71BA0")]
	private void AssignGameObjectTable()
	{
	}

	[Token(Token = "0x6001914")]
	[Address(RVA = "0xA72500", Offset = "0xA72500", VA = "0xA72500")]
	public SpawnAction()
	{
	}
}
