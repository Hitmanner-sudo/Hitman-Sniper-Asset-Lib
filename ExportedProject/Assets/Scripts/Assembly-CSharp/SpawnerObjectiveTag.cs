using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20002A6")]
public class SpawnerObjectiveTag : ObjectiveTagNPCBase
{
	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x94")]
	public float MinDistance;

	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x98")]
	public float MaxDistance;

	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0xA0")]
	public List<Faction> FactionNeeded;

	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0xA8")]
	private bool _playerSpawned;

	[Token(Token = "0x600102B")]
	[Address(RVA = "0xA73F24", Offset = "0xA73F24", VA = "0xA73F24", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0xA7400C", Offset = "0xA7400C", VA = "0xA7400C", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0xA7413C", Offset = "0xA7413C", VA = "0xA7413C", Slot = "19")]
	protected override bool ShouldRegisterNPC()
	{
		return default(bool);
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0xA74178", Offset = "0xA74178", VA = "0xA74178")]
	private void OnPlayerAdded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0xA74248", Offset = "0xA74248", VA = "0xA74248")]
	private bool IsDistanceValid(Spawner spawner)
	{
		return default(bool);
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0xA743FC", Offset = "0xA743FC", VA = "0xA743FC")]
	private void OnCharacterSpawned(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0xA745AC", Offset = "0xA745AC", VA = "0xA745AC")]
	public SpawnerObjectiveTag()
	{
	}

	[Token(Token = "0x6001032")]
	[Address(RVA = "0xA7462C", Offset = "0xA7462C", VA = "0xA7462C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615984", Offset = "0x615984")]
	private bool _003COnPlayerAdded_003Eb__7_0(AIController r)
	{
		return default(bool);
	}
}
