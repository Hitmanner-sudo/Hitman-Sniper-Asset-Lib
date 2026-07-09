using Il2CppDummyDll;

[Token(Token = "0x200091B")]
public class RateMe
{
	[Token(Token = "0x40031D0")]
	private const string SAVE_INT_NAME = "RateMePluginShowOnMissionID";

	[Token(Token = "0x40031D1")]
	[FieldOffset(Offset = "0x0")]
	public static int DefaultCompletedCountNeeded;

	[Token(Token = "0x6003A0D")]
	[Address(RVA = "0xB3F5D0", Offset = "0xB3F5D0", VA = "0xB3F5D0")]
	public static void askToRate(int nbOfMisisonsCompleted, string appID, string title, string message, string rateButton, string remindMeButton, string cancelButton)
	{
	}

	[Token(Token = "0x6003A0E")]
	[Address(RVA = "0xB3F6F4", Offset = "0xB3F6F4", VA = "0xB3F6F4")]
	public static void increaseAndSaveIntValue(int newValue)
	{
	}

	[Token(Token = "0x6003A0F")]
	[Address(RVA = "0xB3F7D8", Offset = "0xB3F7D8", VA = "0xB3F7D8")]
	public static void resetState()
	{
	}

	[Token(Token = "0x6003A10")]
	[Address(RVA = "0xB3F780", Offset = "0xB3F780", VA = "0xB3F780")]
	public static void setAndSaveIntValue(int newValue)
	{
	}

	[Token(Token = "0x6003A11")]
	[Address(RVA = "0xB3F83C", Offset = "0xB3F83C", VA = "0xB3F83C")]
	public RateMe()
	{
	}
}
