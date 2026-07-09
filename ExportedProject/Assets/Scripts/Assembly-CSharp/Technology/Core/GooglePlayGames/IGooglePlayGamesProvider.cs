using Il2CppDummyDll;

namespace Technology.Core.GooglePlayGames
{
	[Token(Token = "0x2000CA0")]
	internal interface IGooglePlayGamesProvider : IArmoryProvider
	{
		[Token(Token = "0x170009F6")]
		bool IsLoggedIn
		{
			[Token(Token = "0x6004E4B")]
			get;
		}
	}
}
