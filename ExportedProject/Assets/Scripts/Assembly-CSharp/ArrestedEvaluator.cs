using Il2CppDummyDll;

[Token(Token = "0x20000E0")]
public class ArrestedEvaluator : AttractorEvaluator
{
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x38")]
	private ArrestedBehaviour _behaviour;

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xBFFD38", Offset = "0xBFFD38", VA = "0xBFFD38", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xBFFD84", Offset = "0xBFFD84", VA = "0xBFFD84")]
	public ArrestedEvaluator()
	{
	}
}
