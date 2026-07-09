using Il2CppDummyDll;

[Token(Token = "0x20000FB")]
public class HealEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x20")]
	private HealBehaviour _behaviour;

	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B0654", Offset = "0x5B0654")]
	public bool HealAllAllies;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B068C", Offset = "0x5B068C")]
	public Faction[] FactionsToHeal;

	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x38")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x6000716")]
	[Address(RVA = "0xA0A1A4", Offset = "0xA0A1A4", VA = "0xA0A1A4", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0xA0A31C", Offset = "0xA0A31C", VA = "0xA0A31C")]
	private bool CanHeal(Memory memory, Record record)
	{
		return default(bool);
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0xA0A520", Offset = "0xA0A520", VA = "0xA0A520", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0xA0A540", Offset = "0xA0A540", VA = "0xA0A540")]
	public HealEvaluator()
	{
	}
}
