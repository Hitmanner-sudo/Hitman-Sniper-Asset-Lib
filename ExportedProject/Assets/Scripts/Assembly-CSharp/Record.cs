using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200013B")]
public class Record : AIMemento
{
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x68")]
	public AIVisionEmitter VisionEmitter;

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x70")]
	public Visibility Visibility;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 LastKnownDirection;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 Velocity;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x90")]
	public Blackboard Properties;

	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x98")]
	public float LastTimeVisible;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x9C")]
	public float SustainedVisibleTime;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0xA0")]
	public Faction VisibleFaction;

	[Token(Token = "0x6000881")]
	[Address(RVA = "0xB435E4", Offset = "0xB435E4", VA = "0xB435E4")]
	public Record(AIVisionEmitter emitter)
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0xB4368C", Offset = "0xB4368C", VA = "0xB4368C")]
	public void UpdateVisibleInfo(AIVisionSensor sensor)
	{
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0xB438DC", Offset = "0xB438DC", VA = "0xB438DC")]
	public void UpdateThreatLevel(AIVisionSensor sensor)
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0xB43988", Offset = "0xB43988", VA = "0xB43988")]
	public void UpdateIsScared(AIVisionSensor sensor)
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0xB439DC", Offset = "0xB439DC", VA = "0xB439DC")]
	public bool WasMurdered()
	{
		return default(bool);
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0xB43AB8", Offset = "0xB43AB8", VA = "0xB43AB8")]
	public void UpdateFrom(Record other)
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0xB43B2C", Offset = "0xB43B2C", VA = "0xB43B2C", Slot = "10")]
	public override AIMemento Push(Memory memory)
	{
		return null;
	}
}
