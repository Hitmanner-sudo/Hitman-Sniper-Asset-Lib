using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000E3")]
public class AttractorEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000523")]
	private const float _distanceHysteresis = 0.75f;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x20")]
	private AttractorBehaviour _behaviour;

	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x28")]
	public float MaxAttractorDistance;

	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x2C")]
	public int MinimumPriority;

	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x30")]
	public AlertLevel MinGlobalAlertLevel;

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0xC0760C", Offset = "0xC0760C", VA = "0xC0760C", Slot = "6")]
	protected virtual List<Attractor> GetAvailableAttractors(AIController forAI)
	{
		return null;
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0xC076DC", Offset = "0xC076DC", VA = "0xC076DC", Slot = "7")]
	protected virtual AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xC076E4", Offset = "0xC076E4", VA = "0xC076E4", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xC079C8", Offset = "0xC079C8", VA = "0xC079C8", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xBFFDE4", Offset = "0xBFFDE4", VA = "0xBFFDE4")]
	public AttractorEvaluator()
	{
	}
}
