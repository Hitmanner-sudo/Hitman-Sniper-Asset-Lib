using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Social
{
	[Token(Token = "0x2000AD4")]
	internal class LeaderboardOS : LeaderboardModuleInterface, IDisposable
	{
		[Token(Token = "0x2000AD5")]
		internal static class PersisterKeys
		{
			[Token(Token = "0x4003759")]
			internal const string LBREQ_PREFIX_KEY = "LBOSRequest";

			[Token(Token = "0x400375A")]
			internal const string LBREQIDS_PREFIX_KEY = "LBOSRequestIds";

			[Token(Token = "0x400375B")]
			internal const char LBREQIDS_SEPARATOR_PREFIX_KEY = ',';

			[Token(Token = "0x400375C")]
			internal const string SCORE_PREFIX_KEY = "LBOSScore";

			[Token(Token = "0x400375D")]
			internal const string LBSOCIAL_PREFIX_KEY = "LBOSIsSocial";
		}

		[Token(Token = "0x2000AD6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D28", Offset = "0x597D28")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400375E")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpSetPlayerScore svcOp;

			[Token(Token = "0x400375F")]
			[FieldOffset(Offset = "0x18")]
			public int leaderboardId;

			[Token(Token = "0x4003760")]
			[FieldOffset(Offset = "0x1C")]
			public bool notifyFriends;

			[Token(Token = "0x4003761")]
			[FieldOffset(Offset = "0x20")]
			public long scorePersisted;

			[Token(Token = "0x60043AE")]
			[Address(RVA = "0xB336E4", Offset = "0xB336E4", VA = "0xB336E4")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60043AF")]
			[Address(RVA = "0xB336EC", Offset = "0xB336EC", VA = "0xB336EC")]
			internal void _003CReportScore_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000AD7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D38", Offset = "0x597D38")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4003762")]
			[FieldOffset(Offset = "0x10")]
			public LeaderBoardType type;

			[Token(Token = "0x4003763")]
			[FieldOffset(Offset = "0x14")]
			public int leaderboardId;

			[Token(Token = "0x4003764")]
			[FieldOffset(Offset = "0x18")]
			public string playerid;

			[Token(Token = "0x4003765")]
			[FieldOffset(Offset = "0x20")]
			public int maxRecords;

			[Token(Token = "0x4003766")]
			[FieldOffset(Offset = "0x28")]
			public string request_playerId;

			[Token(Token = "0x4003767")]
			[FieldOffset(Offset = "0x30")]
			public long score;

			[Token(Token = "0x4003768")]
			[FieldOffset(Offset = "0x38")]
			public string localPlayerId;

			[Token(Token = "0x60043B0")]
			[Address(RVA = "0xB32E34", Offset = "0xB32E34", VA = "0xB32E34")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}
		}

		[Token(Token = "0x2000AD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D48", Offset = "0x597D48")]
		private sealed class _003C_003Ec__DisplayClass10_1
		{
			[Token(Token = "0x4003769")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetSurroundingScores op;

			[Token(Token = "0x400376A")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60043B1")]
			[Address(RVA = "0xB32E3C", Offset = "0xB32E3C", VA = "0xB32E3C")]
			public _003C_003Ec__DisplayClass10_1()
			{
			}

			[Token(Token = "0x60043B2")]
			[Address(RVA = "0xB32E44", Offset = "0xB32E44", VA = "0xB32E44")]
			internal void _003CRecords_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000AD9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D58", Offset = "0x597D58")]
		private sealed class _003C_003Ec__DisplayClass10_2
		{
			[Token(Token = "0x400376B")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetSurroundingScoresAmongstFriends op;

			[Token(Token = "0x400376C")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x60043B3")]
			[Address(RVA = "0xB32E84", Offset = "0xB32E84", VA = "0xB32E84")]
			public _003C_003Ec__DisplayClass10_2()
			{
			}

			[Token(Token = "0x60043B4")]
			[Address(RVA = "0xB32E8C", Offset = "0xB32E8C", VA = "0xB32E8C")]
			internal void _003CRecords_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000ADA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D68", Offset = "0x597D68")]
		private sealed class _003C_003Ec__DisplayClass10_3
		{
			[Token(Token = "0x400376D")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetSurroundingScoresByScore op;

			[Token(Token = "0x400376E")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals3;

			[Token(Token = "0x60043B5")]
			[Address(RVA = "0xB32ECC", Offset = "0xB32ECC", VA = "0xB32ECC")]
			public _003C_003Ec__DisplayClass10_3()
			{
			}

			[Token(Token = "0x60043B6")]
			[Address(RVA = "0xB32ED4", Offset = "0xB32ED4", VA = "0xB32ED4")]
			internal void _003CRecords_003Eb__2()
			{
			}
		}

		[Token(Token = "0x2000ADB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D78", Offset = "0x597D78")]
		private sealed class _003C_003Ec__DisplayClass10_4
		{
			[Token(Token = "0x400376F")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetSurroundingScores op;

			[Token(Token = "0x4003770")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals4;

			[Token(Token = "0x60043B7")]
			[Address(RVA = "0xB32F14", Offset = "0xB32F14", VA = "0xB32F14")]
			public _003C_003Ec__DisplayClass10_4()
			{
			}

			[Token(Token = "0x60043B8")]
			[Address(RVA = "0xB32F1C", Offset = "0xB32F1C", VA = "0xB32F1C")]
			internal void _003CRecords_003Eb__3()
			{
			}
		}

		[Token(Token = "0x2000ADC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597D88", Offset = "0x597D88")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x4003771")]
			[FieldOffset(Offset = "0x10")]
			public LeaderboardOS _003C_003E4__this;

			[Token(Token = "0x4003772")]
			[FieldOffset(Offset = "0x18")]
			public JSONArray array;

			[Token(Token = "0x4003773")]
			[FieldOffset(Offset = "0x20")]
			public int avatarHeight;

			[Token(Token = "0x4003774")]
			[FieldOffset(Offset = "0x24")]
			public int avatarWidth;

			[Token(Token = "0x4003775")]
			[FieldOffset(Offset = "0x28")]
			public string defaultPlayerName;

			[Token(Token = "0x4003776")]
			[FieldOffset(Offset = "0x30")]
			public string localPlayerId;

			[Token(Token = "0x4003777")]
			[FieldOffset(Offset = "0x38")]
			public long localPlayerScore;

			[Token(Token = "0x4003778")]
			[FieldOffset(Offset = "0x40")]
			public bool isLocalPlayerAdded;

			[Token(Token = "0x4003779")]
			[FieldOffset(Offset = "0x44")]
			public int arrayCount;

			[Token(Token = "0x400377A")]
			[FieldOffset(Offset = "0x48")]
			public string gamerTag;

			[Token(Token = "0x400377B")]
			[FieldOffset(Offset = "0x50")]
			public string profileURLFormat;

			[Token(Token = "0x400377C")]
			[FieldOffset(Offset = "0x58")]
			public int defaultTimeout;

			[Token(Token = "0x400377D")]
			[FieldOffset(Offset = "0x60")]
			public string profileImageURLFormat;

			[Token(Token = "0x60043B9")]
			[Address(RVA = "0xB32F5C", Offset = "0xB32F5C", VA = "0xB32F5C")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60043BA")]
			[Address(RVA = "0xB32F64", Offset = "0xB32F64", VA = "0xB32F64")]
			internal void _003CLeaderboardOnAysncComplete_003Eb__0(object _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x10")]
		private bool _IsDisposed;

		[Token(Token = "0x4003755")]
		private const string META_KEY_LEADERBOARDID = "leaderboardId";

		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x18")]
		private LeaderboardRecord[] _records;

		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> _profileRequestOptions;

		[Token(Token = "0x4003758")]
		private const int MAX_ALLOWED_RECORDS = 100;

		[Token(Token = "0x600439E")]
		[Address(RVA = "0x9A2CD4", Offset = "0x9A2CD4", VA = "0x9A2CD4")]
		internal LeaderboardOS(LeaderboardConfiguration config)
		{
		}

		[Token(Token = "0x600439F")]
		[Address(RVA = "0x9A2F90", Offset = "0x9A2F90", VA = "0x9A2F90", Slot = "13")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x9A3000", Offset = "0x9A3000", VA = "0x9A3000")]
		public void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x9A3120", Offset = "0x9A3120", VA = "0x9A3120", Slot = "7")]
		public override int NumberOfSupportedLeaderboards()
		{
			return default(int);
		}

		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x9A3198", Offset = "0x9A3198", VA = "0x9A3198", Slot = "8")]
		public override OnlineServiceError ReportScore(int leaderboardId, long score, bool notifyFriends)
		{
			return default(OnlineServiceError);
		}

		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x9A32F8", Offset = "0x9A32F8", VA = "0x9A32F8", Slot = "9")]
		public override LeaderboardRecord[] Records(LeaderBoardType type, int leaderboardId, bool social, int maxRecords, string playerid, long score)
		{
			return null;
		}

		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x9A386C", Offset = "0x9A386C", VA = "0x9A386C", Slot = "10")]
		public override LeaderboardRecord[] RecordsFromPool(LeaderBoardType type, int leaderboardId, string[] playerPoolIds)
		{
			return null;
		}

		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x9A38B4", Offset = "0x9A38B4", VA = "0x9A38B4", Slot = "11")]
		public override LeaderboardRecord[] RecordsBelowBoundaries(int leaderboardId, int[] boundaries)
		{
			return null;
		}

		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x9A38FC", Offset = "0x9A38FC", VA = "0x9A38FC", Slot = "12")]
		public override LeaderboardRecord[] RecordForPlayer(LeaderBoardType type, int leaderboardId, string uid, Action<LeaderboardRecord> onComplete)
		{
			return null;
		}

		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x9A3944", Offset = "0x9A3944", VA = "0x9A3944")]
		private void LeaderboardOnAysncComplete(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> metaDictionary)
		{
		}

		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x9A23E0", Offset = "0x9A23E0", VA = "0x9A23E0")]
		public static long GetPlayerScore(string lbid)
		{
			return default(long);
		}

		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x9A3D80", Offset = "0x9A3D80", VA = "0x9A3D80")]
		private void LeaderboardOnAysncError(IResponseContext response, IRequestContext request, Dictionary<string, object> metaDictionary)
		{
		}

		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x99CF0C", Offset = "0x99CF0C", VA = "0x99CF0C")]
		public static long PersistScore(int leaderboardId, long score, bool notifyFriends, bool forceScore = false)
		{
			return default(long);
		}

		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x9A41CC", Offset = "0x9A41CC", VA = "0x9A41CC")]
		private static void Persist(string lbid, long score, bool notifyFriends)
		{
		}

		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x9A412C", Offset = "0x9A412C", VA = "0x9A412C")]
		private static string CreateKey(string prefix, string leaderboardid)
		{
			return null;
		}

		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x9A457C", Offset = "0x9A457C", VA = "0x9A457C")]
		private static int CompareScore(LeaderboardRecord x, LeaderboardRecord y)
		{
			return default(int);
		}
	}
}
