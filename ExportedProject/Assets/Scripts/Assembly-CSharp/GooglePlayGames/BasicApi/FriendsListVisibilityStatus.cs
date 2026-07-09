using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009E3")]
	public enum FriendsListVisibilityStatus
	{
		[Token(Token = "0x4003469")]
		Unknown = 0,
		[Token(Token = "0x400346A")]
		Visible = 1,
		[Token(Token = "0x400346B")]
		ResolutionRequired = 2,
		[Token(Token = "0x400346C")]
		Unavailable = 3,
		[Token(Token = "0x400346D")]
		NetworkError = -4,
		[Token(Token = "0x400346E")]
		NotAuthorized = -5
	}
}
