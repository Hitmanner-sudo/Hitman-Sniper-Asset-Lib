using Il2CppDummyDll;

[Token(Token = "0x20000F9")]
public class ForceIdleEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x400057E")]
	public const string FORCE_IDLE_STATE_KEY = "ForceIdleState";

	[Token(Token = "0x400057F")]
	public const string FORCE_IDLE_COUNT = "ForceIdleStateCount";

	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x20")]
	public bool OnlyMovingCharacter;

	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x28")]
	private ForceIdleBehaviour ForceIdle;

	[Token(Token = "0x6000709")]
	[Address(RVA = "0x95A134", Offset = "0x95A134", VA = "0x95A134", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0x95A2C0", Offset = "0x95A2C0", VA = "0x95A2C0")]
	public ForceIdleEvaluator()
	{
	}
}
