using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000460")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5945D0", Offset = "0x5945D0")]
public class OnGlobalSpawn : FsmStateAction
{
	[Token(Token = "0x4001812")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter Filter;

	[Token(Token = "0x4001813")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B68F4", Offset = "0x5B68F4")]
	public FsmGameObject CharacterSpawned;

	[Token(Token = "0x4001814")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent SendEvent;

	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x9F6734", Offset = "0x9F6734", VA = "0x9F6734", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x9F6794", Offset = "0x9F6794", VA = "0x9F6794", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x9F6824", Offset = "0x9F6824", VA = "0x9F6824", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x9F68B4", Offset = "0x9F68B4", VA = "0x9F68B4")]
	private void SpawnCallback(object sender, Spawner.SpawnerEventArgs args)
	{
	}

	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x9F694C", Offset = "0x9F694C", VA = "0x9F694C")]
	public OnGlobalSpawn()
	{
	}
}
