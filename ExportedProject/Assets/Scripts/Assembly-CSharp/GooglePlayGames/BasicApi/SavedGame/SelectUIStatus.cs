using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20009FE")]
	public enum SelectUIStatus
	{
		[Token(Token = "0x40034E6")]
		SavedGameSelected = 1,
		[Token(Token = "0x40034E7")]
		UserClosedUI = 2,
		[Token(Token = "0x40034E8")]
		InternalError = -1,
		[Token(Token = "0x40034E9")]
		TimeoutError = -2,
		[Token(Token = "0x40034EA")]
		AuthenticationError = -3,
		[Token(Token = "0x40034EB")]
		BadInputError = -4,
		[Token(Token = "0x40034EC")]
		UiBusy = -5
	}
}
