using System;
using Il2CppDummyDll;

[Token(Token = "0x200027A")]
public class ConditionRequirement
{
	[Token(Token = "0x200027B")]
	public enum ConditionType
	{
		[Token(Token = "0x4000DC1")]
		Ignored = 0,
		[Token(Token = "0x4000DC2")]
		Required = 1,
		[Token(Token = "0x4000DC3")]
		Forbidden = 2
	}

	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x8DFB64", Offset = "0x8DFB64", VA = "0x8DFB64")]
	public static bool ValidateCondition(ConditionType requirement, bool actualValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x8DFB94", Offset = "0x8DFB94", VA = "0x8DFB94")]
	public static bool ValidateCondition(ConditionType requirement, Func<bool> checkValueIsTrue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x8DFC48", Offset = "0x8DFC48", VA = "0x8DFC48")]
	public ConditionRequirement()
	{
	}
}
