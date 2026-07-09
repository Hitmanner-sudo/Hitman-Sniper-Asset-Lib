using Il2CppDummyDll;

[Token(Token = "0x200011A")]
public class ZombieMassConfusionBehaviour : AIBehaviour
{
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x0")]
	public static bool MASS_CONFUSION_ACTIVE;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x1")]
	public static bool MASS_CONFUSION_ACTIVE_FOR_SPECIALS;

	[Token(Token = "0x1700014D")]
	public new ZombieMassConfusionEvaluator Evaluator
	{
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x883D5C", Offset = "0x883D5C", VA = "0x883D5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x883DD8", Offset = "0x883DD8", VA = "0x883DD8", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x883E84", Offset = "0x883E84", VA = "0x883E84")]
	public ZombieMassConfusionBehaviour()
	{
	}
}
