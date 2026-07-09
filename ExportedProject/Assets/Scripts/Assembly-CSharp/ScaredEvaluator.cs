using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200010E")]
public class ScaredEvaluator : AttractorEvaluator
{
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x34")]
	public bool CanSuicide;

	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x38")]
	public ReactionType ReactIndex;

	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x40")]
	public Bark ReactBarkMale;

	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x48")]
	public Bark ReactBarkFemale;

	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x50")]
	public AlertLevel CausingAlertLevel;

	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x54")]
	public float WanderRadius;

	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x58")]
	public float ChanceOnSuicide;

	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x5C")]
	public float ChanceOnWandering;

	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x60")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x68")]
	private ScaredBehaviour _scaredBehaviour;

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xBB2734", Offset = "0xBB2734", VA = "0xBB2734", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xBB2794", Offset = "0xBB2794", VA = "0xBB2794", Slot = "6")]
	protected override List<Attractor> GetAvailableAttractors(AIController aiController)
	{
		return null;
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xBB2934", Offset = "0xBB2934", VA = "0xBB2934", Slot = "7")]
	protected override AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xBB293C", Offset = "0xBB293C", VA = "0xBB293C")]
	public ScaredEvaluator()
	{
	}
}
