using System;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using Technology.Social;

[Token(Token = "0x20005E3")]
public class SniperLeaderboardOS : LeaderboardModuleInterface, IDisposable
{
	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x0")]
	public static readonly long TOP_SCORE;

	[Token(Token = "0x400200E")]
	private const int MAX_ALLOWED_RECORDS = 100;

	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x10")]
	private readonly SniperLeaderboardReporter _reporter;

	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x18")]
	private readonly SniperLeaderboardRetriever _retriever;

	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0x20")]
	private bool _isDisposed;

	[Token(Token = "0x1400008E")]
	public static event Action<bool> OnScoreUpdated
	{
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0xA605B0", Offset = "0xA605B0", VA = "0xA605B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C2C0", Offset = "0x61C2C0")]
		add
		{
		}
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0xA606A8", Offset = "0xA606A8", VA = "0xA606A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C2D0", Offset = "0x61C2D0")]
		remove
		{
		}
	}

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0xA607A0", Offset = "0xA607A0", VA = "0xA607A0")]
	public SniperLeaderboardOS()
	{
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0xA609CC", Offset = "0xA609CC", VA = "0xA609CC", Slot = "8")]
	public override OnlineServiceError ReportScore(int leaderboardId, long score, bool notifyFriends)
	{
		return default(OnlineServiceError);
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0xA60D80", Offset = "0xA60D80", VA = "0xA60D80", Slot = "7")]
	public override int NumberOfSupportedLeaderboards()
	{
		return default(int);
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0xA60D88", Offset = "0xA60D88", VA = "0xA60D88", Slot = "9")]
	public override LeaderboardRecord[] Records(LeaderBoardType type, int leaderboardId, bool social, int maxRecords, string playerid, long score)
	{
		return null;
	}

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0xA61410", Offset = "0xA61410", VA = "0xA61410", Slot = "10")]
	public override LeaderboardRecord[] RecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds)
	{
		return null;
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0xA61738", Offset = "0xA61738", VA = "0xA61738", Slot = "11")]
	public override LeaderboardRecord[] RecordsBelowBoundaries(int leaderboardId, int[] boundaries)
	{
		return null;
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0xA61A58", Offset = "0xA61A58", VA = "0xA61A58", Slot = "12")]
	public override LeaderboardRecord[] RecordForPlayer(LeaderBoardType type, int leaderboardId, string uid, Action<LeaderboardRecord> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0xA61DA8", Offset = "0xA61DA8", VA = "0xA61DA8")]
	public static bool CanReportScore()
	{
		return default(bool);
	}

	[Token(Token = "0x60025F4")]
	[Address(RVA = "0xA60AD8", Offset = "0xA60AD8", VA = "0xA60AD8")]
	private static bool IsLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x60025F5")]
	[Address(RVA = "0xA60B44", Offset = "0xA60B44", VA = "0xA60B44")]
	private static bool IsProfileSubmitted()
	{
		return default(bool);
	}

	[Token(Token = "0x60025F6")]
	[Address(RVA = "0xA61E30", Offset = "0xA61E30", VA = "0xA61E30", Slot = "13")]
	public void Dispose()
	{
	}
}
