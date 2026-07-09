using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000213")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x592AD4", Offset = "0x592AD4")]
public class UntrackTargetAction : FsmStateAction
{
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x50")]
	public Faction[] Factions;

	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x58")]
	public Spawner[] SpawnerList;

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0xB9CBCC", Offset = "0xB9CBCC", VA = "0xB9CBCC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0xB9CC44", Offset = "0xB9CC44", VA = "0xB9CC44", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0xB9CDFC", Offset = "0xB9CDFC", VA = "0xB9CDFC")]
	public UntrackTargetAction()
	{
	}
}
