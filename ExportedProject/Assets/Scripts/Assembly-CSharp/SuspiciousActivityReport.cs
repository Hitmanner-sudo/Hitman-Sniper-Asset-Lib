using Il2CppDummyDll;

[Token(Token = "0x20000E9")]
internal class SuspiciousActivityReport : AIMemento
{
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x68")]
	private AIBehaviour _sourceBehaviour;

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xD30280", Offset = "0xD30280", VA = "0xD30280")]
	public SuspiciousActivityReport(AIEmitter emitter, AIBehaviour source)
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xD30308", Offset = "0xD30308", VA = "0xD30308", Slot = "11")]
	public override void OnForget()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xD3034C", Offset = "0xD3034C", VA = "0xD3034C", Slot = "12")]
	public override void OnThreatLevelAdjusted(ThreatLevel oldLevel, ThreatLevel newLevel)
	{
	}
}
