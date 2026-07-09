using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000D")]
public class GoogleCloudMessaging
{
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _plugin;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x10E8D38", Offset = "0x10E8D38", VA = "0x10E8D38")]
	static GoogleCloudMessaging()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x10E8F94", Offset = "0x10E8F94", VA = "0x10E8F94")]
	public static void checkForNotifications()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x10E90E0", Offset = "0x10E90E0", VA = "0x10E90E0")]
	public static void register(string gcmSenderId)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x10E9200", Offset = "0x10E9200", VA = "0x10E9200")]
	public static void unRegister()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x10E934C", Offset = "0x10E934C", VA = "0x10E934C")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x10E9498", Offset = "0x10E9498", VA = "0x10E9498")]
	public GoogleCloudMessaging()
	{
	}
}
