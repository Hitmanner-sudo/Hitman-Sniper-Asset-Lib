using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045B")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5944A0", Offset = "0x5944A0")]
[Attribute(Name = "TooltipAttribute", RVA = "0x5944A0", Offset = "0x5944A0")]
public class NPCAliveChecker : FsmStateAction
{
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6764", Offset = "0x5B6764")]
	public GameObject[] SpawnerSources;

	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent AllAlive;

	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent AnyAlive;

	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent NoneAlive;

	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0xC5223C", Offset = "0xC5223C", VA = "0xC5223C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0xC523CC", Offset = "0xC523CC", VA = "0xC523CC")]
	public NPCAliveChecker()
	{
	}
}
