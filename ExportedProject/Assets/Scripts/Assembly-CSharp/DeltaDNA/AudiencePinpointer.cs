using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x20012E5")]
	public static class AudiencePinpointer
	{
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0xC07B80", Offset = "0xC07B80", VA = "0xC07B80")]
		public static void RecordSessionEvent()
		{
		}

		[Token(Token = "0x6006E48")]
		[Address(RVA = "0xC07B84", Offset = "0xC07B84", VA = "0xC07B84")]
		public static void RecordInstallEvent()
		{
		}

		[Token(Token = "0x6006E49")]
		[Address(RVA = "0xC07B88", Offset = "0xC07B88", VA = "0xC07B88")]
		public static void RecordPurchaseEvent(int realCurrencyAmount, string realCurrencyType, string transactionID, string transactionReceipt)
		{
		}

		[Token(Token = "0x6006E4A")]
		[Address(RVA = "0xC07B8C", Offset = "0xC07B8C", VA = "0xC07B8C")]
		private static bool CheckForRequiredFields()
		{
			return default(bool);
		}
	}
}
