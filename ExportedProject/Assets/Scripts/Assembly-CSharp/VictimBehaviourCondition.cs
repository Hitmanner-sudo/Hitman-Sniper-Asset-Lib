using Il2CppDummyDll;

[Token(Token = "0x2000280")]
public class VictimBehaviourCondition
{
	[Token(Token = "0x2000281")]
	public enum VictimBehaviourType
	{
		[Token(Token = "0x4000DE0")]
		Ignored = 0,
		[Token(Token = "0x4000DE1")]
		InvestigateOrFirework = 1,
		[Token(Token = "0x4000DE2")]
		Communicate = 2,
		[Token(Token = "0x4000DE3")]
		Scared = 3
	}

	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x13C943C", Offset = "0x13C943C", VA = "0x13C943C")]
	public static bool ValidateCondition(VictimBehaviourType type, Target target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x13C97F4", Offset = "0x13C97F4", VA = "0x13C97F4")]
	public VictimBehaviourCondition()
	{
	}
}
