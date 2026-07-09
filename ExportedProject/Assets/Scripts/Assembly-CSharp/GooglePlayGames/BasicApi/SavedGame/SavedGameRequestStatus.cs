using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20009FD")]
	public enum SavedGameRequestStatus
	{
		[Token(Token = "0x40034E0")]
		Success = 1,
		[Token(Token = "0x40034E1")]
		TimeoutError = -1,
		[Token(Token = "0x40034E2")]
		InternalError = -2,
		[Token(Token = "0x40034E3")]
		AuthenticationError = -3,
		[Token(Token = "0x40034E4")]
		BadInputError = -4
	}
}
