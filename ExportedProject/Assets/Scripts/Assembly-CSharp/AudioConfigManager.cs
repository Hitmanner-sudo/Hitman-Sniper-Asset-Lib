using Il2CppDummyDll;

[Token(Token = "0x2000217")]
public class AudioConfigManager : ConfigManager<AudioConfigManager, AudioConfig>
{
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0xC08B64", Offset = "0xC08B64", VA = "0xC08B64", Slot = "16")]
	protected override AudioConfig DoGetConfig(ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0xC08B7C", Offset = "0xC08B7C", VA = "0xC08B7C")]
	public AudioConfigManager()
	{
	}
}
