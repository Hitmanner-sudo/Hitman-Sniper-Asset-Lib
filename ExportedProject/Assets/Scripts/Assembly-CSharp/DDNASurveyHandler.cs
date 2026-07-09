using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000806")]
public static class DDNASurveyHandler
{
	[Token(Token = "0x2000807")]
	private class SurveyCompleteHandler
	{
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x10")]
		private SurveyPayload _data;

		[Token(Token = "0x6003457")]
		[Address(RVA = "0x869078", Offset = "0x869078", VA = "0x869078")]
		public SurveyCompleteHandler(SurveyPayload data)
		{
		}

		[Token(Token = "0x6003458")]
		[Address(RVA = "0x8690B0", Offset = "0x8690B0", VA = "0x8690B0")]
		public void OnSurveyComplete(SurveyMonkey.Response response)
		{
		}

		[Token(Token = "0x6003459")]
		[Address(RVA = "0x869564", Offset = "0x869564", VA = "0x869564")]
		private void ShowPopup()
		{
		}
	}

	[Token(Token = "0x2000808")]
	private struct SurveyPayload
	{
		[Token(Token = "0x4002CCC")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BB1FC", Offset = "0x5BB1FC")]
		private string _surveyId;

		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BB234", Offset = "0x5BB234")]
		private string _currency;

		[Token(Token = "0x4002CCE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BB26C", Offset = "0x5BB26C")]
		private int _amount;

		[Token(Token = "0x170006B3")]
		public string SurveyId
		{
			[Token(Token = "0x600345A")]
			[Address(RVA = "0x869674", Offset = "0x869674", VA = "0x869674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B4")]
		public Wallet.CurrencyAmount Reward
		{
			[Token(Token = "0x600345B")]
			[Address(RVA = "0x86940C", Offset = "0x86940C", VA = "0x86940C")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x4002CC9")]
	private const string SHOW_SURVEY_KEY = "showSurvey";

	[Token(Token = "0x4002CCA")]
	private const string UID_KEY = "uid";

	[Token(Token = "0x6003455")]
	[Address(RVA = "0xBCBB9C", Offset = "0xBCBB9C", VA = "0xBCBB9C")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId, bool fromUserInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x6003456")]
	[Address(RVA = "0xBD580C", Offset = "0xBD580C", VA = "0xBD580C")]
	private static void Fail(string message, long transactionId)
	{
	}
}
