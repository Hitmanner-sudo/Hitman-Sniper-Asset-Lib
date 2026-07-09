using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000803")]
public static class DDNAJustCausePopupAdConfigHandler
{
	[Token(Token = "0x4002CC6")]
	private const string JUST_CAUSE_POPUP_AD_CONFIG_KEY = "justCausePopupAdConfig";

	[Token(Token = "0x600344E")]
	[Address(RVA = "0xBC96E0", Offset = "0xBC96E0", VA = "0xBC96E0")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x600344F")]
	[Address(RVA = "0xBD35C0", Offset = "0xBD35C0", VA = "0xBD35C0")]
	private static bool Fail(string message, long transactionId)
	{
		return default(bool);
	}
}
