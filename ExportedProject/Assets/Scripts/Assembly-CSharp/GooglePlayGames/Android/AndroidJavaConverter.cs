using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x200099F")]
	internal class AndroidJavaConverter
	{
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0xD698B8", Offset = "0xD698B8", VA = "0xD698B8")]
		internal static DateTime ToDateTime(long milliseconds)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0xD67EF4", Offset = "0xD67EF4", VA = "0xD67EF4")]
		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span)
		{
			return default(int);
		}

		[Token(Token = "0x6003D70")]
		[Address(RVA = "0xD67F08", Offset = "0xD67F08", VA = "0xD67F08")]
		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection)
		{
			return default(int);
		}

		[Token(Token = "0x6003D71")]
		[Address(RVA = "0xD683E0", Offset = "0xD683E0", VA = "0xD683E0")]
		internal static int ToPageDirection(ScorePageDirection direction)
		{
			return default(int);
		}

		[Token(Token = "0x6003D72")]
		[Address(RVA = "0xD6EACC", Offset = "0xD6EACC", VA = "0xD6EACC")]
		internal static Player ToPlayer(AndroidJavaObject player)
		{
			return null;
		}

		[Token(Token = "0x6003D73")]
		[Address(RVA = "0xD6ED78", Offset = "0xD6ED78", VA = "0xD6ED78")]
		internal static GooglePlayGames.BasicApi.PlayerProfile ToPlayerProfile(AndroidJavaObject player)
		{
			return null;
		}

		[Token(Token = "0x6003D74")]
		[Address(RVA = "0xD6F1BC", Offset = "0xD6F1BC", VA = "0xD6F1BC")]
		internal static List<string> ToStringList(AndroidJavaObject stringList)
		{
			return null;
		}

		[Token(Token = "0x6003D75")]
		[Address(RVA = "0xD6F478", Offset = "0xD6F478", VA = "0xD6F478")]
		internal static AndroidJavaObject ToJavaStringList(List<string> list)
		{
			return null;
		}

		[Token(Token = "0x6003D76")]
		[Address(RVA = "0xD6F6A4", Offset = "0xD6F6A4", VA = "0xD6F6A4")]
		internal static FriendsListVisibilityStatus ToFriendsListVisibilityStatus(int playerListVisibility)
		{
			return default(FriendsListVisibilityStatus);
		}

		[Token(Token = "0x6003D77")]
		[Address(RVA = "0xD6F6B4", Offset = "0xD6F6B4", VA = "0xD6F6B4")]
		internal static IUserProfile[] playersBufferToArray(AndroidJavaObject playersBuffer)
		{
			return null;
		}

		[Token(Token = "0x6003D78")]
		[Address(RVA = "0xD6FAF8", Offset = "0xD6FAF8", VA = "0xD6FAF8")]
		public AndroidJavaConverter()
		{
		}
	}
}
