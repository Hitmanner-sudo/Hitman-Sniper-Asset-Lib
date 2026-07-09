using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000804")]
public class DDNALootBoxUpdateHandler
{
	[Token(Token = "0x4002CC7")]
	private const string LOOTBOX_UPDATE_PARAM_KEY = "changeLootbox";

	[Token(Token = "0x6003450")]
	[Address(RVA = "0xBC9130", Offset = "0xBC9130", VA = "0xBC9130")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003451")]
	[Address(RVA = "0xBD3698", Offset = "0xBD3698", VA = "0xBD3698")]
	private static bool Fail(string message, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003452")]
	[Address(RVA = "0xBD3770", Offset = "0xBD3770", VA = "0xBD3770")]
	public DDNALootBoxUpdateHandler()
	{
	}
}
