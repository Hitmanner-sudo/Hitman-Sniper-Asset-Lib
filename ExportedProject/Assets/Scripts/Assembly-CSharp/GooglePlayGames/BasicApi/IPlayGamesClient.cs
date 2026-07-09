using System;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009EB")]
	public interface IPlayGamesClient
	{
		[Token(Token = "0x6003EB5")]
		void Authenticate(bool silent, Action<SignInStatus> callback);

		[Token(Token = "0x6003EB6")]
		bool IsAuthenticated();

		[Token(Token = "0x6003EB7")]
		void SignOut();

		[Token(Token = "0x6003EB8")]
		string GetUserId();

		[Token(Token = "0x6003EB9")]
		void LoadFriends(Action<bool> callback);

		[Token(Token = "0x6003EBA")]
		string GetUserDisplayName();

		[Token(Token = "0x6003EBB")]
		string GetIdToken();

		[Token(Token = "0x6003EBC")]
		string GetServerAuthCode();

		[Token(Token = "0x6003EBD")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		[Token(Token = "0x6003EBE")]
		string GetUserEmail();

		[Token(Token = "0x6003EBF")]
		string GetUserImageUrl();

		[Token(Token = "0x6003EC0")]
		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

		[Token(Token = "0x6003EC1")]
		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

		[Token(Token = "0x6003EC2")]
		void LoadAchievements(Action<Achievement[]> callback);

		[Token(Token = "0x6003EC3")]
		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6003EC4")]
		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6003EC5")]
		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6003EC6")]
		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

		[Token(Token = "0x6003EC7")]
		void ShowAchievementsUI(Action<UIStatus> callback);

		[Token(Token = "0x6003EC8")]
		void AskForLoadFriendsResolution(Action<UIStatus> callback);

		[Token(Token = "0x6003EC9")]
		LoadFriendsStatus GetLastLoadFriendsStatus();

		[Token(Token = "0x6003ECA")]
		void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);

		[Token(Token = "0x6003ECB")]
		void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);

		[Token(Token = "0x6003ECC")]
		void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);

		[Token(Token = "0x6003ECD")]
		void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);

		[Token(Token = "0x6003ECE")]
		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

		[Token(Token = "0x6003ECF")]
		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x6003ED0")]
		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

		[Token(Token = "0x6003ED1")]
		int LeaderboardMaxResults();

		[Token(Token = "0x6003ED2")]
		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6003ED3")]
		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

		[Token(Token = "0x6003ED4")]
		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);

		[Token(Token = "0x6003ED5")]
		bool HasPermissions(string[] scopes);

		[Token(Token = "0x6003ED6")]
		ISavedGameClient GetSavedGameClient();

		[Token(Token = "0x6003ED7")]
		IEventsClient GetEventsClient();

		[Token(Token = "0x6003ED8")]
		IVideoClient GetVideoClient();

		[Token(Token = "0x6003ED9")]
		IUserProfile[] GetFriends();

		[Token(Token = "0x6003EDA")]
		void SetGravityForPopups(Gravity gravity);
	}
}
