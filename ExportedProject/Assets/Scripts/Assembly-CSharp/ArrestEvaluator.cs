using Il2CppDummyDll;

[Token(Token = "0x20000DE")]
public class ArrestEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x20")]
	public float TimeBeforeExecution;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x28")]
	public NPCFilter Filter;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x30")]
	private ArrestBehaviour _behaviour;

	[Token(Token = "0x600068F")]
	[Address(RVA = "0xBFEF78", Offset = "0xBFEF78", VA = "0xBFEF78", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0xBFF074", Offset = "0xBFF074", VA = "0xBFF074")]
	private bool CanArrest(Memory memory, Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xBFF194", Offset = "0xBFF194", VA = "0xBFF194", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xBFF1B4", Offset = "0xBFF1B4", VA = "0xBFF1B4")]
	public ArrestEvaluator()
	{
	}
}
