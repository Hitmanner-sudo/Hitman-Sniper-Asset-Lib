using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200044B")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5940C8", Offset = "0x5940C8")]
public class DespawnMonitor : FsmStateAction
{
	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter Filter;

	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x58")]
	private List<Spawner> _spawners;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6354", Offset = "0x5B6354")]
	public FsmGameObject NPC;

	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x68")]
	public bool IncludeDead;

	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent OneDespawnedEvent;

	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent AllDespawnedEvent;

	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0xC12740", Offset = "0xC12740", VA = "0xC12740", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0xC127A8", Offset = "0xC127A8", VA = "0xC127A8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A30")]
	[Address(RVA = "0xC12928", Offset = "0xC12928", VA = "0xC12928")]
	private void OnDeath(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6001A31")]
	[Address(RVA = "0xC12A9C", Offset = "0xC12A9C", VA = "0xC12A9C", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A32")]
	[Address(RVA = "0xC12B54", Offset = "0xC12B54", VA = "0xC12B54")]
	public DespawnMonitor()
	{
	}
}
