using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009E4")]
	public enum LoadFriendsStatus
	{
		[Token(Token = "0x4003470")]
		Unknown = 0,
		[Token(Token = "0x4003471")]
		Completed = 1,
		[Token(Token = "0x4003472")]
		LoadMore = 2,
		[Token(Token = "0x4003473")]
		ResolutionRequired = -3,
		[Token(Token = "0x4003474")]
		InternalError = -4,
		[Token(Token = "0x4003475")]
		NotAuthorized = -5,
		[Token(Token = "0x4003476")]
		NetworkError = -6
	}
}
