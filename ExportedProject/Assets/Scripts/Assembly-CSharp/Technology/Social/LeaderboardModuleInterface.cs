using System;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Social
{
	[Token(Token = "0x2000AD3")]
	public abstract class LeaderboardModuleInterface : NetworkModule
	{
		[Token(Token = "0x4003752")]
		[FieldOffset(Offset = "0x0")]
		public static readonly long SCORE_NOT_DEFINED;

		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x8")]
		public static LeaderboardConfiguration Settings;

		[Token(Token = "0x6004395")]
		public abstract int NumberOfSupportedLeaderboards();

		[Token(Token = "0x6004396")]
		public abstract OnlineServiceError ReportScore(int leaderboardId, long score, bool notifyFriends);

		[Token(Token = "0x6004397")]
		public abstract LeaderboardRecord[] Records(LeaderBoardType type, int leaderboardId, bool social, int maxRecords, string userId, long score);

		[Token(Token = "0x6004398")]
		public abstract LeaderboardRecord[] RecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds);

		[Token(Token = "0x6004399")]
		public abstract LeaderboardRecord[] RecordsBelowBoundaries(int leaderboardId, int[] boundaries);

		[Token(Token = "0x600439A")]
		public abstract LeaderboardRecord[] RecordForPlayer(LeaderBoardType type, int leaderboardId, string uid, Action<LeaderboardRecord> onComplete);

		[Token(Token = "0x600439B")]
		[Address(RVA = "0x9A2C34", Offset = "0x9A2C34", VA = "0x9A2C34")]
		internal static LeaderboardModuleInterface InvokeInstance(LeaderBoard type)
		{
			return null;
		}

		[Token(Token = "0x600439C")]
		[Address(RVA = "0x9A2F38", Offset = "0x9A2F38", VA = "0x9A2F38")]
		protected LeaderboardModuleInterface()
		{
		}
	}
}
