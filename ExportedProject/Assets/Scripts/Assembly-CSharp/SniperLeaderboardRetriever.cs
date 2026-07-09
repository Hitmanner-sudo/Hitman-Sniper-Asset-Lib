using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using Technology.Social;

[Token(Token = "0x20005EC")]
public class SniperLeaderboardRetriever : IDisposable
{
	[Token(Token = "0x20005ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954DC", Offset = "0x5954DC")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400202E")]
		[FieldOffset(Offset = "0x10")]
		public LeaderBoardType type;

		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x14")]
		public int leaderboardId;

		[Token(Token = "0x4002030")]
		[FieldOffset(Offset = "0x18")]
		public int maxRecords;

		[Token(Token = "0x4002031")]
		[FieldOffset(Offset = "0x20")]
		public string playerid;

		[Token(Token = "0x4002032")]
		[FieldOffset(Offset = "0x28")]
		public string requestPlayerId;

		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x30")]
		public long score;

		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x38")]
		public string localPlayerId;

		[Token(Token = "0x600262B")]
		[Address(RVA = "0xA49F98", Offset = "0xA49F98", VA = "0xA49F98")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}
	}

	[Token(Token = "0x20005EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954EC", Offset = "0x5954EC")]
	private sealed class _003C_003Ec__DisplayClass11_1
	{
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetTopScores op;

		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600262C")]
		[Address(RVA = "0xA49FA0", Offset = "0xA49FA0", VA = "0xA49FA0")]
		public _003C_003Ec__DisplayClass11_1()
		{
		}

		[Token(Token = "0x600262D")]
		[Address(RVA = "0xA49FA8", Offset = "0xA49FA8", VA = "0xA49FA8")]
		internal void _003CRecords_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20005EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954FC", Offset = "0x5954FC")]
	private sealed class _003C_003Ec__DisplayClass11_2
	{
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetSurroundingScores op;

		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x600262E")]
		[Address(RVA = "0xA49FDC", Offset = "0xA49FDC", VA = "0xA49FDC")]
		public _003C_003Ec__DisplayClass11_2()
		{
		}

		[Token(Token = "0x600262F")]
		[Address(RVA = "0xA49FE4", Offset = "0xA49FE4", VA = "0xA49FE4")]
		internal void _003CRecords_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20005F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59550C", Offset = "0x59550C")]
	private sealed class _003C_003Ec__DisplayClass11_3
	{
		[Token(Token = "0x4002039")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetSurroundingScoresAmongstFriends op;

		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals3;

		[Token(Token = "0x6002630")]
		[Address(RVA = "0xA4A024", Offset = "0xA4A024", VA = "0xA4A024")]
		public _003C_003Ec__DisplayClass11_3()
		{
		}

		[Token(Token = "0x6002631")]
		[Address(RVA = "0xA4A02C", Offset = "0xA4A02C", VA = "0xA4A02C")]
		internal void _003CRecords_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20005F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59551C", Offset = "0x59551C")]
	private sealed class _003C_003Ec__DisplayClass11_4
	{
		[Token(Token = "0x400203B")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetSurroundingScoresByScore op;

		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals4;

		[Token(Token = "0x6002632")]
		[Address(RVA = "0xA4A060", Offset = "0xA4A060", VA = "0xA4A060")]
		public _003C_003Ec__DisplayClass11_4()
		{
		}

		[Token(Token = "0x6002633")]
		[Address(RVA = "0xA4A068", Offset = "0xA4A068", VA = "0xA4A068")]
		internal void _003CRecords_003Eb__3()
		{
		}
	}

	[Token(Token = "0x20005F2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59552C", Offset = "0x59552C")]
	private sealed class _003C_003Ec__DisplayClass11_5
	{
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetSurroundingScores op;

		[Token(Token = "0x400203E")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals5;

		[Token(Token = "0x6002634")]
		[Address(RVA = "0xA4A0A8", Offset = "0xA4A0A8", VA = "0xA4A0A8")]
		public _003C_003Ec__DisplayClass11_5()
		{
		}

		[Token(Token = "0x6002635")]
		[Address(RVA = "0xA4A0B0", Offset = "0xA4A0B0", VA = "0xA4A0B0")]
		internal void _003CRecords_003Eb__4()
		{
		}
	}

	[Token(Token = "0x20005F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59553C", Offset = "0x59553C")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetPlayerScores op;

		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x18")]
		public SvcOpGetLeaderboard.LeaderBoardType leaderboardType;

		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x1C")]
		public int leaderboardId;

		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x20")]
		public string[] playerPoolIds;

		[Token(Token = "0x6002636")]
		[Address(RVA = "0xA4A0F0", Offset = "0xA4A0F0", VA = "0xA4A0F0")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002637")]
		[Address(RVA = "0xA4A0F8", Offset = "0xA4A0F8", VA = "0xA4A0F8")]
		internal void _003CRecordsFromPool_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20005F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59554C", Offset = "0x59554C")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4002043")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetScoresAroundBoundaries op;

		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x18")]
		public int leaderboardId;

		[Token(Token = "0x4002045")]
		[FieldOffset(Offset = "0x20")]
		public int[] boundaries;

		[Token(Token = "0x6002638")]
		[Address(RVA = "0xA4A120", Offset = "0xA4A120", VA = "0xA4A120")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6002639")]
		[Address(RVA = "0xA4A128", Offset = "0xA4A128", VA = "0xA4A128")]
		internal void _003CRecordsBelowBoundaries_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20005F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59555C", Offset = "0x59555C")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpGetPlayerScore op;

		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x18")]
		public SvcOpGetLeaderboard.LeaderBoardType leaderboardType;

		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x1C")]
		public int leaderboardId;

		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x20")]
		public string sid;

		[Token(Token = "0x600263A")]
		[Address(RVA = "0xA4A150", Offset = "0xA4A150", VA = "0xA4A150")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600263B")]
		[Address(RVA = "0xA4A158", Offset = "0xA4A158", VA = "0xA4A158")]
		internal void _003CGetPlayerScore_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002024")]
	private const string ON_COMPLETE_KEY = "onComplete";

	[Token(Token = "0x4002025")]
	private const string RESULTS_KEY = "results";

	[Token(Token = "0x4002026")]
	private const string LEADERBOARD_ID_KEY = "leaderboardId";

	[Token(Token = "0x4002027")]
	private const string RECORDS_KEY = "records";

	[Token(Token = "0x4002028")]
	[FieldOffset(Offset = "0x10")]
	private readonly int _maxAllowedRecords;

	[Token(Token = "0x4002029")]
	[FieldOffset(Offset = "0x18")]
	private readonly long _topScore;

	[Token(Token = "0x400202A")]
	[FieldOffset(Offset = "0x20")]
	private readonly bool _autoAddLocalPlayer;

	[Token(Token = "0x400202B")]
	[FieldOffset(Offset = "0x28")]
	private readonly SniperLeaderboardRecordBuilder _builder;

	[Token(Token = "0x400202C")]
	[FieldOffset(Offset = "0x30")]
	private readonly HashSet<LeaderboardRecord[]> _recordRequests;

	[Token(Token = "0x400202D")]
	[FieldOffset(Offset = "0x38")]
	private bool _disposed;

	[Token(Token = "0x600261F")]
	[Address(RVA = "0xA608FC", Offset = "0xA608FC", VA = "0xA608FC")]
	public SniperLeaderboardRetriever(int maxAllowedRecords, long topScore, bool autoAddLocalPlayer)
	{
	}

	[Token(Token = "0x6002620")]
	[Address(RVA = "0xA60DA4", Offset = "0xA60DA4", VA = "0xA60DA4")]
	public LeaderboardRecord[] Records(LeaderBoardType type, int leaderboardId, bool social, int maxRecords, string playerid, long score)
	{
		return null;
	}

	[Token(Token = "0x6002621")]
	[Address(RVA = "0xA61428", Offset = "0xA61428", VA = "0xA61428")]
	public LeaderboardRecord[] RecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds)
	{
		return null;
	}

	[Token(Token = "0x6002622")]
	[Address(RVA = "0xA61750", Offset = "0xA61750", VA = "0xA61750")]
	public LeaderboardRecord[] RecordsBelowBoundaries(int leaderboardId, int[] boundaries)
	{
		return null;
	}

	[Token(Token = "0x6002623")]
	[Address(RVA = "0xA61A70", Offset = "0xA61A70", VA = "0xA61A70")]
	public LeaderboardRecord[] GetPlayerScore(LeaderBoardType type, int leaderboardId, string sid, Action<LeaderboardRecord> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0xA63C08", Offset = "0xA63C08", VA = "0xA63C08")]
	private void OnGetMultipleRecordsComplete(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x6002625")]
	[Address(RVA = "0xA64058", Offset = "0xA64058", VA = "0xA64058")]
	private void ProcessResult(string response, LeaderboardRecord[] records, out bool isLocalPlayerAdded)
	{
	}

	[Token(Token = "0x6002626")]
	[Address(RVA = "0xA63F4C", Offset = "0xA63F4C", VA = "0xA63F4C")]
	private void LeaderboardOnAysncError(IResponseContext response, IRequestContext request, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x6002627")]
	[Address(RVA = "0xA64248", Offset = "0xA64248", VA = "0xA64248")]
	private void OnGetSingleRecordComplete(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> meta)
	{
	}

	[Token(Token = "0x6002628")]
	[Address(RVA = "0xA6452C", Offset = "0xA6452C", VA = "0xA6452C")]
	private static int CompareScore(LeaderboardRecord x, LeaderboardRecord y)
	{
		return default(int);
	}

	[Token(Token = "0x6002629")]
	[Address(RVA = "0xA61EB8", Offset = "0xA61EB8", VA = "0xA61EB8", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600262A")]
	[Address(RVA = "0xA6455C", Offset = "0xA6455C", VA = "0xA6455C")]
	protected void Dispose(bool disposing)
	{
	}
}
