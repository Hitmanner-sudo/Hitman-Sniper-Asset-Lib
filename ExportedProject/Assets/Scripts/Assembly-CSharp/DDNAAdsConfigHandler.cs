using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20007F9")]
public static class DDNAAdsConfigHandler
{
	[Token(Token = "0x4002CB0")]
	private const string ADS_CONFIG_PARAM_KEY = "adsConfig";

	[Token(Token = "0x4002CB1")]
	private const string CHALLENGE_ADS_CONFIG_PARAM_KEY = "challengeAdsConfig";

	[Token(Token = "0x600342C")]
	[Address(RVA = "0xBBF390", Offset = "0xBBF390", VA = "0xBBF390")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x600342D")]
	[Address(RVA = "0xBBF4F4", Offset = "0xBBF4F4", VA = "0xBBF4F4")]
	private static bool DoDeserialize(string adsConfig, DailyRewardsData data, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x600342E")]
	[Address(RVA = "0xBBF73C", Offset = "0xBBF73C", VA = "0xBBF73C")]
	private static bool Fail(string message, long transactionId)
	{
		return default(bool);
	}
}
