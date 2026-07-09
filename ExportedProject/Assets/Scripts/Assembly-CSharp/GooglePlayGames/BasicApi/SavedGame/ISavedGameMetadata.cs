using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x2000A02")]
	public interface ISavedGameMetadata
	{
		[Token(Token = "0x170007E9")]
		bool IsOpen
		{
			[Token(Token = "0x6003F59")]
			get;
		}

		[Token(Token = "0x170007EA")]
		string Filename
		{
			[Token(Token = "0x6003F5A")]
			get;
		}

		[Token(Token = "0x170007EB")]
		string Description
		{
			[Token(Token = "0x6003F5B")]
			get;
		}

		[Token(Token = "0x170007EC")]
		string CoverImageURL
		{
			[Token(Token = "0x6003F5C")]
			get;
		}

		[Token(Token = "0x170007ED")]
		TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x6003F5D")]
			get;
		}

		[Token(Token = "0x170007EE")]
		DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x6003F5E")]
			get;
		}
	}
}
