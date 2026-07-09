using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000436")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593D18", Offset = "0x593D18")]
public class BreakableMonitor : FsmStateAction
{
	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x49")]
	public bool mustBeOnNPC;

	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x50")]
	public NPCFilter OwnerNPCFilter;

	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5CF0", Offset = "0x5B5CF0")]
	public string BreakableNameFilter;

	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x60")]
	public FsmString BreakableNameFilterVar;

	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5D28", Offset = "0x5B5D28")]
	public Breakable[] Breakables;

	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x70")]
	public FsmGameObject[] FSMBreakables;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x78")]
	public FsmEvent _ConditionsMetEvent;

	[Token(Token = "0x60019C9")]
	[Address(RVA = "0xA80678", Offset = "0xA80678", VA = "0xA80678", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0xA806D8", Offset = "0xA806D8", VA = "0xA806D8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0xA80788", Offset = "0xA80788", VA = "0xA80788")]
	private void OnObjectBroken(object sender, Breakable.BreakEvent args)
	{
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0xA809C4", Offset = "0xA809C4", VA = "0xA809C4", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0xA809C8", Offset = "0xA809C8", VA = "0xA809C8")]
	public BreakableMonitor()
	{
	}
}
