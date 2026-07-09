using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200083F")]
public class SurveyMonkeyAndroid : AbstractSurveyMonkey
{
	[Token(Token = "0x2000840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596790", Offset = "0x596790")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4002EB6")]
		[FieldOffset(Offset = "0x10")]
		public SurveyMonkeyAndroid _003C_003E4__this;

		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x18")]
		public string collectorId;

		[Token(Token = "0x4002EB8")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> variables;

		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x28")]
		public Action<SurveyMonkey.Response> onSurveyComplete;

		[Token(Token = "0x60035F4")]
		[Address(RVA = "0xA5375C", Offset = "0xA5375C", VA = "0xA5375C")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60035F5")]
		[Address(RVA = "0xA53764", Offset = "0xA53764", VA = "0xA53764")]
		internal void _003CPresentSurvey_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x4002EB3")]
	private const string SEM_SURVEY_MONKEY_CLASSPATH = "com.squareenixmontreal.armory.SEMSurveyMonkey";

	[Token(Token = "0x4002EB4")]
	private const string METHOD_NAME = "presentSurvey";

	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly SurveyMonkey.Response RESPONSE_NO_INTERNET;

	[Token(Token = "0x60035F0")]
	[Address(RVA = "0xD2FA58", Offset = "0xD2FA58", VA = "0xD2FA58", Slot = "4")]
	public override void PresentSurvey(string collectorId, Dictionary<string, string> variables, Action<SurveyMonkey.Response> onSurveyComplete)
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0xD2FB68", Offset = "0xD2FB68", VA = "0xD2FB68")]
	private void OnInternetReachable(string collectorId, Dictionary<string, string> variables, Action<SurveyMonkey.Response> onSurveyComplete)
	{
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0xD2F9BC", Offset = "0xD2F9BC", VA = "0xD2F9BC")]
	public SurveyMonkeyAndroid()
	{
	}
}
