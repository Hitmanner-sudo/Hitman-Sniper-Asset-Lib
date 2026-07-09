using System;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Social
{
	[Token(Token = "0x2000ACD")]
	public interface ILeaderboard
	{
		[Token(Token = "0x6004373")]
		int GetNumberOfSupportedLeaderboards();

		[Token(Token = "0x6004374")]
		OnlineServiceError ReportScoreToLeaderboard(int leaderboardId, int score, bool notifiyScore = true);

		[Token(Token = "0x6004375")]
		LeaderboardRecord[] LeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords);

		[Token(Token = "0x6004376")]
		LeaderboardRecord[] LeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid);

		[Token(Token = "0x6004377")]
		LeaderboardRecord[] LeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid, long score, Type leaderboardModuleInterface);

		[Token(Token = "0x6004378")]
		LeaderboardRecord[] LeaderboardRecords(LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, long score);

		[Token(Token = "0x6004379")]
		LeaderboardRecord[] LeaderboardRecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds, Type leaderboardModuleInterface);

		[Token(Token = "0x600437A")]
		LeaderboardRecord[] LeaderboardRecordsBelowBoundaries(int leaderboardId, int[] boundaries, Type leaderboardBoundaryInterface);

		[Token(Token = "0x600437B")]
		LeaderboardRecord[] LeaderboardRecordForPlayer(LeaderBoardType type, int leaderboardId, string uid, Action<LeaderboardRecord> onComplete, Type leaderboardModuleInterface);

		[Token(Token = "0x600437C")]
		void ResetLeaderboardCache();
	}
}
