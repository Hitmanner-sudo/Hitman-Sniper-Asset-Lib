using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200045E")]
[Attribute(Name = "TooltipAttribute", RVA = "0x594570", Offset = "0x594570")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594570", Offset = "0x594570")]
public class NPCVisionMonitor : FsmStateAction
{
	[Token(Token = "0x400180B")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6838", Offset = "0x5B6838")]
	public FsmGameObject MonitoredSpawner;

	[Token(Token = "0x400180C")]
	[FieldOffset(Offset = "0x58")]
	private Spawner[] _spawners;

	[Token(Token = "0x400180D")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6884", Offset = "0x5B6884")]
	public NPCFilter SubjectFilter;

	[Token(Token = "0x400180E")]
	[FieldOffset(Offset = "0x68")]
	public FsmGameObject Observer;

	[Token(Token = "0x400180F")]
	[FieldOffset(Offset = "0x70")]
	private List<AIController> _controllers;

	[Token(Token = "0x4001810")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B68BC", Offset = "0x5B68BC")]
	public FsmEvent ViewSatisfied;

	[Token(Token = "0x6001A76")]
	[Address(RVA = "0xC546B4", Offset = "0xC546B4", VA = "0xC546B4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A77")]
	[Address(RVA = "0xC54A58", Offset = "0xC54A58", VA = "0xC54A58", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A78")]
	[Address(RVA = "0xC54CA0", Offset = "0xC54CA0", VA = "0xC54CA0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A79")]
	[Address(RVA = "0xC54D04", Offset = "0xC54D04", VA = "0xC54D04")]
	private void OnSeeSomething(object sender, Memory.MementoAddedArgs args)
	{
	}

	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0xC54EF4", Offset = "0xC54EF4", VA = "0xC54EF4")]
	private void OnNewCharacterSpawned(object sender, Spawner.SpawnerEventArgs args)
	{
	}

	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0xC55074", Offset = "0xC55074", VA = "0xC55074")]
	public NPCVisionMonitor()
	{
	}
}
