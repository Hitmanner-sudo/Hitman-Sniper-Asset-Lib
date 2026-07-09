using Il2CppDummyDll;

[Token(Token = "0x200058E")]
public class ChallengeModel : DataModel
{
	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CONTRACT_DATA_MODEL;

	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ACTIVE_DIFFICULTY_TYPE;

	[Token(Token = "0x4001D40")]
	[FieldOffset(Offset = "0x48")]
	private ContractDataModel _contractDataModel;

	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x50")]
	private ContractDataModel.DifficultyType _activeDifficultyType;

	[Token(Token = "0x60022C1")]
	[Address(RVA = "0xAF46AC", Offset = "0xAF46AC", VA = "0xAF46AC", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60022C2")]
	[Address(RVA = "0xAF487C", Offset = "0xAF487C", VA = "0xAF487C")]
	public ChallengeModel()
	{
	}

	[Token(Token = "0x60022C4")]
	[Address(RVA = "0xAF490C", Offset = "0xAF490C", VA = "0xAF490C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A020", Offset = "0x61A020")]
	private object _003CBindAllVariables_003Eb__4_0()
	{
		return null;
	}

	[Token(Token = "0x60022C5")]
	[Address(RVA = "0xAF4914", Offset = "0xAF4914", VA = "0xAF4914")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A030", Offset = "0x61A030")]
	private void _003CBindAllVariables_003Eb__4_1(object a)
	{
	}

	[Token(Token = "0x60022C6")]
	[Address(RVA = "0xAF49A0", Offset = "0xAF49A0", VA = "0xAF49A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A040", Offset = "0x61A040")]
	private object _003CBindAllVariables_003Eb__4_2()
	{
		return null;
	}

	[Token(Token = "0x60022C7")]
	[Address(RVA = "0xAF4A00", Offset = "0xAF4A00", VA = "0xAF4A00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61A050", Offset = "0x61A050")]
	private void _003CBindAllVariables_003Eb__4_3(object a)
	{
	}
}
