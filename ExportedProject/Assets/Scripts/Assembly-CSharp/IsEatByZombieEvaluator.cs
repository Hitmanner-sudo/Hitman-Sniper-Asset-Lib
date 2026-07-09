using Il2CppDummyDll;

[Token(Token = "0x2000100")]
public class IsEatByZombieEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x20")]
	private IsEatByZombieBehaviour _behaviour;

	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x28")]
	public float AnimationDuration;

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x10BE868", Offset = "0x10BE868", VA = "0x10BE868", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x10BE944", Offset = "0x10BE944", VA = "0x10BE944")]
	public IsEatByZombieEvaluator()
	{
	}
}
