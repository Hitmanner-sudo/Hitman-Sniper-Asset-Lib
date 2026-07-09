using Il2CppDummyDll;

[Token(Token = "0x2000147")]
public class DeathMemento : VistaMemento
{
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x68")]
	public Damage Damage;

	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x70")]
	private bool _accidental;

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0xAE4E30", Offset = "0xAE4E30", VA = "0xAE4E30")]
	public DeathMemento(AIEmitter emitter, Damage damage)
	{
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0xAE4F80", Offset = "0xAE4F80", VA = "0xAE4F80", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0xAE5138", Offset = "0xAE5138", VA = "0xAE5138", Slot = "10")]
	public override AIMemento Push(Memory memory)
	{
		return null;
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0xAE527C", Offset = "0xAE527C", VA = "0xAE527C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612978", Offset = "0x612978")]
	private bool _003CCanBeDetectedBy_003Eb__3_0(AIMemento x)
	{
		return default(bool);
	}
}
