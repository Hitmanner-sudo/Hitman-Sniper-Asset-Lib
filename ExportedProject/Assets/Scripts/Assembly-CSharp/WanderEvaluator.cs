using Il2CppDummyDll;

[Token(Token = "0x2000117")]
public class WanderEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x20")]
	public float m_WanderRadius;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x24")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x28")]
	private WanderBehaviour Wander;

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x97E51C", Offset = "0x97E51C", VA = "0x97E51C", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x97E540", Offset = "0x97E540", VA = "0x97E540")]
	public WanderEvaluator()
	{
	}
}
