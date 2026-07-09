using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000F6")]
public class FireworkAttractionEvaluator : AttractorEvaluator
{
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x34")]
	public ReactionType ReactIndex;

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x38")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x40")]
	private FireworkAttractionBehaviour _fireworkAttractionBehaviour;

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x9567A0", Offset = "0x9567A0", VA = "0x9567A0", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x956850", Offset = "0x956850", VA = "0x956850", Slot = "6")]
	protected override List<Attractor> GetAvailableAttractors(AIController aiController)
	{
		return null;
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x956958", Offset = "0x956958", VA = "0x956958", Slot = "7")]
	protected override AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x956960", Offset = "0x956960", VA = "0x956960")]
	public FireworkAttractionEvaluator()
	{
	}
}
