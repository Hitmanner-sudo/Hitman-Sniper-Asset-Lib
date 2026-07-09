using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000805")]
public static class DDNANotificationPermissionHandler
{
	[Token(Token = "0x4002CC8")]
	private const string NOTIFCATION_PERMISSION_CONFIG_KEY = "notificationPermissionConfig";

	[Token(Token = "0x6003453")]
	[Address(RVA = "0xBC9430", Offset = "0xBC9430", VA = "0xBC9430")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003454")]
	[Address(RVA = "0xBD5484", Offset = "0xBD5484", VA = "0xBD5484")]
	private static bool Fail(string message, long transactionId)
	{
		return default(bool);
	}
}
