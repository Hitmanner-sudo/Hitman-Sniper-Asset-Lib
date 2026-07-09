using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class AndroidRateMe
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass ioPixelRateMeClass;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10D7CE0", Offset = "0x10D7CE0", VA = "0x10D7CE0")]
	static AndroidRateMe()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10D7DA4", Offset = "0x10D7DA4", VA = "0x10D7DA4")]
	public static void askToRate(string appID, string title, string message, string rateButton, string remindMeButton, string cancelButton)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10D7FB8", Offset = "0x10D7FB8", VA = "0x10D7FB8")]
	public AndroidRateMe()
	{
	}
}
