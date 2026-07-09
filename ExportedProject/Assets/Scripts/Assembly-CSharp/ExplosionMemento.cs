using Il2CppDummyDll;

[Token(Token = "0x2000149")]
public class ExplosionMemento : AIMemento
{
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x68")]
	public float DangerRadius;

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0xE1E998", Offset = "0xE1E998", VA = "0xE1E998")]
	public ExplosionMemento(AIEmitter emitter)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0xE1F890", Offset = "0xE1F890", VA = "0xE1F890", Slot = "10")]
	public override AIMemento Push(Memory memory)
	{
		return null;
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0xE1F938", Offset = "0xE1F938", VA = "0xE1F938", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}
}
