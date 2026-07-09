using Il2CppDummyDll;

[Token(Token = "0x200011B")]
public class ZombieMassConfusionEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x20")]
	private ZombieMassConfusionBehaviour _behaviour;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x28")]
	public bool IsSpecialZombie;

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x883E90", Offset = "0x883E90", VA = "0x883E90", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x883F30", Offset = "0x883F30", VA = "0x883F30")]
	public ZombieMassConfusionEvaluator()
	{
	}
}
