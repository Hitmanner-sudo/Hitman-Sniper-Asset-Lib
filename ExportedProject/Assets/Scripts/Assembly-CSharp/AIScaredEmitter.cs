using Il2CppDummyDll;

[Token(Token = "0x200012E")]
public class AIScaredEmitter : AIVisionEmitter
{
	[Token(Token = "0x6000833")]
	[Address(RVA = "0xA9657C", Offset = "0xA9657C", VA = "0xA9657C", Slot = "20")]
	public override bool GetVisibleIsScared(AIVisionSensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0xA96584", Offset = "0xA96584", VA = "0xA96584")]
	public AIScaredEmitter()
	{
	}
}
