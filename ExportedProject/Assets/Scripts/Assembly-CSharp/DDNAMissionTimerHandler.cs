using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x200080D")]
public static class DDNAMissionTimerHandler
{
	[Token(Token = "0x4002CD5")]
	private const string CHANGE_MISSION_TIMER_KEY = "changeMissionTimer";

	[Token(Token = "0x4002CD6")]
	private const string SECONDS_KEY = "seconds";

	[Token(Token = "0x4002CD7")]
	private const string MISSIONS_KEY = "missions";

	[Token(Token = "0x4002CD8")]
	private const string SHOULD_OVERRIDE_KEY = "shouldOverride";

	[Token(Token = "0x4002CD9")]
	private const string CONTRACT_INDEX_KEY = "contractIndex";

	[Token(Token = "0x6003468")]
	[Address(RVA = "0xBC7DE0", Offset = "0xBC7DE0", VA = "0xBC7DE0")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003469")]
	[Address(RVA = "0xBD44A0", Offset = "0xBD44A0", VA = "0xBD44A0")]
	private static bool TryGetMissions(JSONNode json, out IntRangeCollection missions)
	{
		return default(bool);
	}

	[Token(Token = "0x600346A")]
	[Address(RVA = "0xBD43D0", Offset = "0xBD43D0", VA = "0xBD43D0")]
	private static void Fail(string message, long transactionId)
	{
	}
}
