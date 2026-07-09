using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

[Token(Token = "0x200083C")]
public static class SurveyMonkey
{
	[Token(Token = "0x200083D")]
	public class Response
	{
		[Token(Token = "0x4002EA8")]
		private const string RESPONSE_STATE_KEY = "state";

		[Token(Token = "0x4002EA9")]
		private const string RESPONSE_ERROR_KEY = "error";

		[Token(Token = "0x4002EAA")]
		private const string STATE_SUCCESS = "success";

		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool Success;

		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x18")]
		public readonly Error Error;

		[Token(Token = "0x60035EE")]
		[Address(RVA = "0xA53644", Offset = "0xA53644", VA = "0xA53644")]
		public Response(JSONNode node)
		{
		}
	}

	[Token(Token = "0x200083E")]
	public class Error
	{
		[Token(Token = "0x4002EAD")]
		private const string SHOW_FEEDBACK_KEY = "showFeedback";

		[Token(Token = "0x4002EAE")]
		private const string CODE_KEY = "code";

		[Token(Token = "0x4002EAF")]
		private const string MESSAGE_KEY = "message";

		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool ShowFeedback;

		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Code;

		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Message;

		[Token(Token = "0x60035EF")]
		[Address(RVA = "0xA53530", Offset = "0xA53530", VA = "0xA53530")]
		public Error(JSONNode node)
		{
		}
	}

	[Token(Token = "0x4002EA7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly AbstractSurveyMonkey _monkey;

	[Token(Token = "0x60035EC")]
	[Address(RVA = "0xD2F948", Offset = "0xD2F948", VA = "0xD2F948")]
	static SurveyMonkey()
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0xD2F9C4", Offset = "0xD2F9C4", VA = "0xD2F9C4")]
	public static void PresentSurvey(string collectorId, Dictionary<string, string> variables, Action<Response> onSurveyComplete)
	{
	}
}
