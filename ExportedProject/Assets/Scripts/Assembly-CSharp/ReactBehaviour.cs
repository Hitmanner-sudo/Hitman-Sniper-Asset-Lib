using Il2CppDummyDll;

[Token(Token = "0x200010A")]
public class ReactBehaviour : AIBehaviour
{
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x38")]
	public AIMemento Memento;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x40")]
	private GameTimer _reactionTimer;

	[Token(Token = "0x600076D")]
	[Address(RVA = "0xB41B04", Offset = "0xB41B04", VA = "0xB41B04", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0xB41CC4", Offset = "0xB41CC4", VA = "0xB41CC4", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0xB41CE0", Offset = "0xB41CE0", VA = "0xB41CE0", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0xB41DFC", Offset = "0xB41DFC", VA = "0xB41DFC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0xB41EB4", Offset = "0xB41EB4", VA = "0xB41EB4", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0xB41F64", Offset = "0xB41F64", VA = "0xB41F64")]
	public ReactBehaviour()
	{
	}
}
