using Il2CppDummyDll;

namespace DeltaDNA.Consent
{
	[Token(Token = "0x2001348")]
	internal enum ConsentStatus
	{
		[Token(Token = "0x4005C50")]
		Unknown = 0,
		[Token(Token = "0x4005C51")]
		NotRequired = 1,
		[Token(Token = "0x4005C52")]
		RequiredButUnchecked = 2,
		[Token(Token = "0x4005C53")]
		ConsentGiven = 3,
		[Token(Token = "0x4005C54")]
		ConsentDenied = 4
	}
}
