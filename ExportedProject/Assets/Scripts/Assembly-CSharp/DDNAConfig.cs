using Il2CppDummyDll;

[Token(Token = "0x20001E3")]
public class DDNAConfig : BaseConfig<DDNAConfig>
{
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x30")]
	public string COLLECT_URL;

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x38")]
	public string ENGAGE_URL;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x40")]
	public string LIVE_ENVIRONMENT_KEY;

	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x48")]
	public string DEV_ENVIRONMENT_KEY;

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0xBC36B8", Offset = "0xBC36B8", VA = "0xBC36B8")]
	public DDNAConfig()
	{
	}
}
