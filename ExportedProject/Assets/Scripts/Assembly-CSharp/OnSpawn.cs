using System.Collections.Generic;
using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000462")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594640", Offset = "0x594640")]
public class OnSpawn : FsmStateAction
{
	[Token(Token = "0x4001816")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B6908", Offset = "0x5B6908")]
	public FsmGameObject[] Spawners;

	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x58")]
	private List<Spawner> _spawners;

	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6940", Offset = "0x5B6940")]
	public FsmGameObject CharacterSpawned;

	[Token(Token = "0x4001819")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent SendEvent;

	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x9F6B54", Offset = "0x9F6B54", VA = "0x9F6B54", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x9F6B60", Offset = "0x9F6B60", VA = "0x9F6B60", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x9F6D38", Offset = "0x9F6D38", VA = "0x9F6D38", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x9F6E48", Offset = "0x9F6E48", VA = "0x9F6E48")]
	private void SpawnCallback(object sender, Spawner.SpawnerEventArgs args)
	{
	}

	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x9F6EB4", Offset = "0x9F6EB4", VA = "0x9F6EB4")]
	public OnSpawn()
	{
	}
}
