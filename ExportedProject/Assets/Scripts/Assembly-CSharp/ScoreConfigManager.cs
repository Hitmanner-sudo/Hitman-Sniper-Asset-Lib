using Il2CppDummyDll;

[Token(Token = "0x2000628")]
public class ScoreConfigManager : ConfigManager<ScoreConfigManager, ScoreConfig>
{
	[Token(Token = "0x60027F3")]
	[Address(RVA = "0xBB7080", Offset = "0xBB7080", VA = "0xBB7080", Slot = "16")]
	protected override ScoreConfig DoGetConfig(ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x60027F4")]
	[Address(RVA = "0xBB7098", Offset = "0xBB7098", VA = "0xBB7098")]
	public ScoreConfigManager()
	{
	}
}
