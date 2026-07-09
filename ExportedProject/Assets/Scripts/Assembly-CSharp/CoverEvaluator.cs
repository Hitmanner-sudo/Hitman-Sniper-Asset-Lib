using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20000EE")]
public class CoverEvaluator : AttractorEvaluator
{
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x34")]
	public bool CanCallIn;

	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x35")]
	public bool FullHealthOnly;

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xD807C0", Offset = "0xD807C0", VA = "0xD807C0", Slot = "6")]
	protected override List<Attractor> GetAvailableAttractors(AIController forAI)
	{
		return null;
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xD80910", Offset = "0xD80910", VA = "0xD80910")]
	public CoverEvaluator()
	{
	}
}
