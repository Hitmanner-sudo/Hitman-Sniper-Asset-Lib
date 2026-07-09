using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B48")]
	public struct LanguageSettings
	{
		[Token(Token = "0x4003983")]
		[FieldOffset(Offset = "0x0")]
		public LanguageCode Code;

		[Token(Token = "0x4003984")]
		[FieldOffset(Offset = "0x8")]
		public string FullName;

		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x10")]
		public string LocaId;

		[Token(Token = "0x6004776")]
		[Address(RVA = "0x996AE0", Offset = "0x996AE0", VA = "0x996AE0")]
		public LanguageSettings(LanguageCode code, string fullName, string locaId)
		{
		}
	}
}
