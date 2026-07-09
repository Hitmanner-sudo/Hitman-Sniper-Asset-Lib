using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009EA")]
	public class DummyClient : IPlayGamesClient
	{
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0xC206EC", Offset = "0xC206EC", VA = "0xC206EC", Slot = "4")]
		public void Authenticate(bool silent, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0xC207C4", Offset = "0xC207C4", VA = "0xC207C4", Slot = "5")]
		public bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0xC207DC", Offset = "0xC207DC", VA = "0xC207DC", Slot = "6")]
		public void SignOut()
		{
		}

		[Token(Token = "0x6003E90")]
		[Address(RVA = "0xC207E0", Offset = "0xC207E0", VA = "0xC207E0", Slot = "10")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x6003E91")]
		[Address(RVA = "0xC207F8", Offset = "0xC207F8", VA = "0xC207F8", Slot = "7")]
		public string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6003E92")]
		[Address(RVA = "0xC20840", Offset = "0xC20840", VA = "0xC20840", Slot = "11")]
		public string GetServerAuthCode()
		{
			return null;
		}

		[Token(Token = "0x6003E93")]
		[Address(RVA = "0xC20858", Offset = "0xC20858", VA = "0xC20858", Slot = "12")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x6003E94")]
		[Address(RVA = "0xC208B4", Offset = "0xC208B4", VA = "0xC208B4", Slot = "13")]
		public string GetUserEmail()
		{
			return null;
		}

		[Token(Token = "0x6003E95")]
		[Address(RVA = "0xC20900", Offset = "0xC20900", VA = "0xC20900", Slot = "15")]
		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		[Token(Token = "0x6003E96")]
		[Address(RVA = "0xC20988", Offset = "0xC20988", VA = "0xC20988", Slot = "9")]
		public string GetUserDisplayName()
		{
			return null;
		}

		[Token(Token = "0x6003E97")]
		[Address(RVA = "0xC209D0", Offset = "0xC209D0", VA = "0xC209D0", Slot = "14")]
		public string GetUserImageUrl()
		{
			return null;
		}

		[Token(Token = "0x6003E98")]
		[Address(RVA = "0xC209E8", Offset = "0xC209E8", VA = "0xC209E8", Slot = "16")]
		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		[Token(Token = "0x6003E99")]
		[Address(RVA = "0xC20A4C", Offset = "0xC20A4C", VA = "0xC20A4C", Slot = "17")]
		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0xC20AB0", Offset = "0xC20AB0", VA = "0xC20AB0", Slot = "18")]
		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0xC20B14", Offset = "0xC20B14", VA = "0xC20B14", Slot = "19")]
		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E9C")]
		[Address(RVA = "0xC20B78", Offset = "0xC20B78", VA = "0xC20B78", Slot = "20")]
		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E9D")]
		[Address(RVA = "0xC20BDC", Offset = "0xC20BDC", VA = "0xC20BDC", Slot = "21")]
		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003E9E")]
		[Address(RVA = "0xC20C40", Offset = "0xC20C40", VA = "0xC20C40", Slot = "22")]
		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0xC20CA4", Offset = "0xC20CA4", VA = "0xC20CA4", Slot = "23")]
		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0xC20D08", Offset = "0xC20D08", VA = "0xC20D08", Slot = "24")]
		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0xC20D20", Offset = "0xC20D20", VA = "0xC20D20", Slot = "27")]
		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0xC20D84", Offset = "0xC20D84", VA = "0xC20D84", Slot = "28")]
		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0xC20DE8", Offset = "0xC20DE8", VA = "0xC20DE8", Slot = "25")]
		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0xC20E4C", Offset = "0xC20E4C", VA = "0xC20E4C", Slot = "26")]
		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0xC20EB0", Offset = "0xC20EB0", VA = "0xC20EB0", Slot = "29")]
		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0xC20F14", Offset = "0xC20F14", VA = "0xC20F14", Slot = "32")]
		public int LeaderboardMaxResults()
		{
			return default(int);
		}

		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0xC20F1C", Offset = "0xC20F1C", VA = "0xC20F1C", Slot = "30")]
		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0xC20FC0", Offset = "0xC20FC0", VA = "0xC20FC0", Slot = "31")]
		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0xC21070", Offset = "0xC21070", VA = "0xC21070", Slot = "33")]
		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0xC210D4", Offset = "0xC210D4", VA = "0xC210D4", Slot = "34")]
		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0xC21138", Offset = "0xC21138", VA = "0xC21138", Slot = "35")]
		public void RequestPermissions(string[] scopes, Action<SignInStatus> callback)
		{
		}

		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0xC2119C", Offset = "0xC2119C", VA = "0xC2119C", Slot = "36")]
		public bool HasPermissions(string[] scopes)
		{
			return default(bool);
		}

		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0xC211B4", Offset = "0xC211B4", VA = "0xC211B4", Slot = "37")]
		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0xC211CC", Offset = "0xC211CC", VA = "0xC211CC", Slot = "38")]
		public IEventsClient GetEventsClient()
		{
			return null;
		}

		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0xC211E4", Offset = "0xC211E4", VA = "0xC211E4", Slot = "39")]
		public IVideoClient GetVideoClient()
		{
			return null;
		}

		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0xC211FC", Offset = "0xC211FC", VA = "0xC211FC", Slot = "8")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0xC21258", Offset = "0xC21258", VA = "0xC21258", Slot = "40")]
		public IUserProfile[] GetFriends()
		{
			return null;
		}

		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0xC212A4", Offset = "0xC212A4", VA = "0xC212A4", Slot = "41")]
		public void SetGravityForPopups(Gravity gravity)
		{
		}

		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0xC20750", Offset = "0xC20750", VA = "0xC20750")]
		private static void LogUsage()
		{
		}

		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0xC212A8", Offset = "0xC212A8", VA = "0xC212A8")]
		public DummyClient()
		{
		}
	}
}
