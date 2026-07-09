using Il2CppDummyDll;

[Token(Token = "0x200012D")]
public class VistaMemento : AIMemento
{
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x9791C0", Offset = "0x9791C0", VA = "0x9791C0")]
	public VistaMemento(AIEmitter emitter)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x979240", Offset = "0x979240", VA = "0x979240", Slot = "9")]
	public override bool CanBeDetectedBy(AISensor sensor)
	{
		return default(bool);
	}
}
