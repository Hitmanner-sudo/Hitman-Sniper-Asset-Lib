using Il2CppDummyDll;

[Token(Token = "0x20000E1")]
public class AttractorBehaviour : AIBehaviour
{
	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x38")]
	public Attractor Attractor;

	[Token(Token = "0x600069A")]
	[Address(RVA = "0xC071D8", Offset = "0xC071D8", VA = "0xC071D8", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0xC07284", Offset = "0xC07284", VA = "0xC07284", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0xC0739C", Offset = "0xC0739C", VA = "0xC0739C", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0xC0745C", Offset = "0xC0745C", VA = "0xC0745C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0xC07518", Offset = "0xC07518", VA = "0xC07518", Slot = "4")]
	public override bool Equals(AIBehaviour other)
	{
		return default(bool);
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xC07604", Offset = "0xC07604", VA = "0xC07604")]
	public AttractorBehaviour()
	{
	}
}
