using Il2CppDummyDll;

[Token(Token = "0x2000155")]
public class WitnessedDamage : VistaMemento
{
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x68")]
	public Damage Damage;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x70")]
	private bool _accidental;

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x87FABC", Offset = "0x87FABC", VA = "0x87FABC")]
	public WitnessedDamage(AIEmitter emitter, Damage damage)
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x87FBC0", Offset = "0x87FBC0", VA = "0x87FBC0", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x87FCE8", Offset = "0x87FCE8", VA = "0x87FCE8", Slot = "10")]
	public override AIMemento Push(Memory memory)
	{
		return null;
	}
}
