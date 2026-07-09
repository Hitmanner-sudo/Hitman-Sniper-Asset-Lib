using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20009FC")]
	public enum ConflictResolutionStrategy
	{
		[Token(Token = "0x40034D9")]
		UseLongestPlaytime = 0,
		[Token(Token = "0x40034DA")]
		UseOriginal = 1,
		[Token(Token = "0x40034DB")]
		UseUnmerged = 2,
		[Token(Token = "0x40034DC")]
		UseManual = 3,
		[Token(Token = "0x40034DD")]
		UseLastKnownGood = 4,
		[Token(Token = "0x40034DE")]
		UseMostRecentlySaved = 5
	}
}
