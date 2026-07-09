using System;
using Il2CppDummyDll;

[Token(Token = "0x2000010")]
public class TDDebugLogger
{
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x10D3804", Offset = "0x10D3804", VA = "0x10D3804")]
	public static void Log(object obj)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x10D4040", Offset = "0x10D4040", VA = "0x10D4040")]
	public static void LogWarning(object obj)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x10D3F58", Offset = "0x10D3F58", VA = "0x10D3F58")]
	public static void LogError(object obj)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x10F3E94", Offset = "0x10F3E94", VA = "0x10F3E94")]
	public static void LogException(Exception obj)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x10F3F1C", Offset = "0x10F3F1C", VA = "0x10F3F1C")]
	public TDDebugLogger()
	{
	}
}
