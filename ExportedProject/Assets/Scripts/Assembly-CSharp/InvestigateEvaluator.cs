using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20000FE")]
public class InvestigateEvaluator : BehaviourEvaluator
{
	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x20")]
	public Range InvestigationDuration;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x28")]
	public bool InvestigateFromAfar;

	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x29")]
	public bool InvestigateAnything;

	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x2A")]
	public bool InvestigateWhileAware;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x30")]
	public AnimationConfig.IdleType[] Animation;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B06C4", Offset = "0x5B06C4")]
	public ThreatLevel MinThreatLevel;

	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "DescriptionAttribute", RVA = "0x5B06FC", Offset = "0x5B06FC")]
	public ThreatLevel MaxThreatLevel;

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x40")]
	private InvestigateBehaviour _behaviour;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x48")]
	public AnimationConfig.MovementSpeed SpeedMinor;

	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationConfig.MovementSpeed SpeedWorrying;

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x50")]
	public AnimationConfig.MovementSpeed SpeedAlarming;

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x10BCA80", Offset = "0x10BCA80", VA = "0x10BCA80", Slot = "4")]
	public override AIBehaviour Evaluate(EvaluationComponent evaluator)
	{
		return null;
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x10BCBAC", Offset = "0x10BCBAC", VA = "0x10BCBAC", Slot = "5")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x10BCBCC", Offset = "0x10BCBCC", VA = "0x10BCBCC")]
	public InvestigateEvaluator()
	{
	}
}
