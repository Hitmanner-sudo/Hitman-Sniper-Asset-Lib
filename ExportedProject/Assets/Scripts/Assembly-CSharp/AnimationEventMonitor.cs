using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000433")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593C48", Offset = "0x593C48")]
public class AnimationEventMonitor : FsmStateAction
{
	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	public NPCFilter Filter;

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x58")]
	public string EventString;

	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent AnimEventOccured;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x68")]
	private List<Spawner> _spawners;

	[Token(Token = "0x60019B8")]
	[Address(RVA = "0xD45078", Offset = "0xD45078", VA = "0xD45078", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019B9")]
	[Address(RVA = "0xD453EC", Offset = "0xD453EC", VA = "0xD453EC", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019BA")]
	[Address(RVA = "0xD456C0", Offset = "0xD456C0", VA = "0xD456C0")]
	private void OnCharacterSpawned(object sender, Spawner.SpawnerEventArgs args)
	{
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0xD4530C", Offset = "0xD4530C", VA = "0xD4530C")]
	private void RegisterCharacter(ThirdPersonCharacter tpc)
	{
	}

	[Token(Token = "0x60019BC")]
	[Address(RVA = "0xD45758", Offset = "0xD45758", VA = "0xD45758")]
	private void OnAnimEvent(GameObject sender, AnimationEvent ev)
	{
	}

	[Token(Token = "0x60019BD")]
	[Address(RVA = "0xD45868", Offset = "0xD45868", VA = "0xD45868")]
	public AnimationEventMonitor()
	{
	}
}
