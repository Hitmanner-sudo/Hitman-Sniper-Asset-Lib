using Il2CppDummyDll;

[Token(Token = "0x200010F")]
public class ScreamBehaviour : AIBehaviour
{
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x38")]
	public Record Victim;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x0")]
	public static string IS_IGNITE;

	[Token(Token = "0x17000148")]
	public new ScreamEvaluator Evaluator
	{
		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB66218", Offset = "0xB66218", VA = "0xB66218")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xB66294", Offset = "0xB66294", VA = "0xB66294", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xB662C0", Offset = "0xB662C0", VA = "0xB662C0", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xB66310", Offset = "0xB66310", VA = "0xB66310")]
	private void Ignite()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xB6651C", Offset = "0xB6651C", VA = "0xB6651C")]
	public ScreamBehaviour()
	{
	}
}
