using Il2CppDummyDll;

[Token(Token = "0x2000244")]
public class GameplayConfigManager : ConfigManager<GameplayConfigManager, GameplayConfig>
{
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0xD9D5BC", Offset = "0xD9D5BC", VA = "0xD9D5BC", Slot = "16")]
	protected override GameplayConfig DoGetConfig(ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0xD9D5D4", Offset = "0xD9D5D4", VA = "0xD9D5D4")]
	public GameplayConfigManager()
	{
	}
}
