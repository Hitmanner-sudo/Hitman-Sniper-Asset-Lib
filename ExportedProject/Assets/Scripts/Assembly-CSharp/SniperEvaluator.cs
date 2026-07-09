using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000115")]
public class SniperEvaluator : AttractorEvaluator
{
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x38")]
	private SniperBehaviour _sniperBehaviour;

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0xA5E504", Offset = "0xA5E504", VA = "0xA5E504", Slot = "6")]
	protected override List<Attractor> GetAvailableAttractors(AIController forAI)
	{
		return null;
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0xA5E5E4", Offset = "0xA5E5E4", VA = "0xA5E5E4", Slot = "7")]
	protected override AttractorBehaviour GetAIBehaviour(Attractor attractor)
	{
		return null;
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0xA5E5EC", Offset = "0xA5E5EC", VA = "0xA5E5EC")]
	public SniperEvaluator()
	{
	}
}
