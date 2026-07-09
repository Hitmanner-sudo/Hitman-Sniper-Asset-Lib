using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000800")]
public static class DDNAHackerPreventionHandler
{
	[Token(Token = "0x4002CC2")]
	private const string HACKER_PREVENTION_KEY = "changeHackerPreventionParams";

	[Token(Token = "0x4002CC3")]
	private const string SECONDS_THRESHOLD_KEY = "secondsThreshold";

	[Token(Token = "0x4002CC4")]
	private const string SCORE_THRESHOLD_KEY = "scoreThreshold";

	[Token(Token = "0x6003447")]
	[Address(RVA = "0xBC8178", Offset = "0xBC8178", VA = "0xBC8178")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003448")]
	[Address(RVA = "0xBCE5E0", Offset = "0xBCE5E0", VA = "0xBCE5E0")]
	private static bool Fail(string message, long transactionId)
	{
		return default(bool);
	}
}
