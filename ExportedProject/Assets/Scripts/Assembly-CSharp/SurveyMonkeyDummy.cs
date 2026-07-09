using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000842")]
public class SurveyMonkeyDummy : AbstractSurveyMonkey
{
	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly SurveyMonkey.Response DEFAULT_REPONSE;

	[Token(Token = "0x60035F8")]
	[Address(RVA = "0xD2FF58", Offset = "0xD2FF58", VA = "0xD2FF58", Slot = "4")]
	public override void PresentSurvey(string collectorId, Dictionary<string, string> variables, Action<SurveyMonkey.Response> onSurveyComplete)
	{
	}

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0xD30040", Offset = "0xD30040", VA = "0xD30040", Slot = "5")]
	protected override string StringifyVariables(Dictionary<string, string> variables)
	{
		return null;
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0xD301D8", Offset = "0xD301D8", VA = "0xD301D8")]
	public SurveyMonkeyDummy()
	{
	}
}
