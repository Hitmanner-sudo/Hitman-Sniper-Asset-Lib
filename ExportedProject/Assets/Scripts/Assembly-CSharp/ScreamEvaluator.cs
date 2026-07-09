using Il2CppDummyDll;
using Technology;

[Token(Token = "0x2000110")]
public class ScreamEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x20")]
	public float ScreamCooldown;

	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x24")]
	public float IgniteDistance;

	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x28")]
	public Faction[] FactionsToIgnite;

	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x30")]
	public DamageOverTime DamageOverTime;

	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x38")]
	public SoundContainer ScreamSFX;

	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x40")]
	private ScreamBehaviour _behaviour;

	[Token(Token = "0x4000605")]
	private const string START_TIME = "StartTime";

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xB66588", Offset = "0xB66588", VA = "0xB66588", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xB66840", Offset = "0xB66840", VA = "0xB66840")]
	private bool CanIgnite(Memory memory, Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xB666F8", Offset = "0xB666F8", VA = "0xB666F8")]
	private void IgniteMyself(EvaluationComponent evaluator)
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xB66A0C", Offset = "0xB66A0C", VA = "0xB66A0C")]
	public ScreamEvaluator()
	{
	}
}
