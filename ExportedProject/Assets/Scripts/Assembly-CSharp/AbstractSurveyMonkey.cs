using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Token(Token = "0x200083A")]
public abstract class AbstractSurveyMonkey
{
	[Token(Token = "0x200083B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596780", Offset = "0x596780")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x10")]
		public Action<SurveyMonkey.Response> onSurveyComplete;

		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x912304", Offset = "0x912304", VA = "0x912304")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x91230C", Offset = "0x91230C", VA = "0x91230C")]
		internal void _003CGetOnNativeSurveyComplete_003Eb__0(JSONNode resp)
		{
		}
	}

	[Token(Token = "0x60035E6")]
	public abstract void PresentSurvey(string collectorId, Dictionary<string, string> variables, Action<SurveyMonkey.Response> onSurveyComplete);

	[Token(Token = "0x60035E7")]
	[Address(RVA = "0xAA5A9C", Offset = "0xAA5A9C", VA = "0xAA5A9C")]
	protected static NativeResponseAction GetOnNativeSurveyComplete(Action<SurveyMonkey.Response> onSurveyComplete)
	{
		return null;
	}

	[Token(Token = "0x60035E8")]
	[Address(RVA = "0xAA5B88", Offset = "0xAA5B88", VA = "0xAA5B88", Slot = "5")]
	protected virtual string StringifyVariables(Dictionary<string, string> variables)
	{
		return null;
	}

	[Token(Token = "0x60035E9")]
	[Address(RVA = "0xAA5D80", Offset = "0xAA5D80", VA = "0xAA5D80")]
	protected AbstractSurveyMonkey()
	{
	}
}
