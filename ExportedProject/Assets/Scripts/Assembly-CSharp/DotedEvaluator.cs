using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000F1")]
public class DotedEvaluator : AttractorEvaluator
{
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x34")]
	public bool CanSuicide;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x38")]
	public ReactionType ReactIndex;

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x40")]
	public Bark ReactBarkMale;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x48")]
	public Bark ReactBarkFemale;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x50")]
	public AlertLevel CausingAlertLevel;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x54")]
	public float WanderRadius;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x58")]
	public float ChanceOnSuicide;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x5C")]
	public float ChanceOnWandering;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x60")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x68")]
	public List<Damage.Types> ValidDamageTypes;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x70")]
	private DotedBehaviour _dotedBehaviour;

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0xC1930C", Offset = "0xC1930C", VA = "0xC1930C", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xC194D8", Offset = "0xC194D8", VA = "0xC194D8", Slot = "6")]
	protected override List<Attractor> GetAvailableAttractors(AIController aiController)
	{
		return null;
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xC19618", Offset = "0xC19618", VA = "0xC19618", Slot = "7")]
	protected override AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xC19620", Offset = "0xC19620", VA = "0xC19620")]
	public DotedEvaluator()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0xC196EC", Offset = "0xC196EC", VA = "0xC196EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x612250", Offset = "0x612250")]
	private bool _003CEvaluate_003Eb__11_0(Damage.Types x)
	{
		return default(bool);
	}
}
