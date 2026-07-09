using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC2")]
	public abstract class SvcOpGetLeaderboard : SvcOpGet
	{
		[Token(Token = "0x2000CC3")]
		public enum LeaderBoardType
		{
			[Token(Token = "0x4003DBC")]
			NotRequired = -1,
			[Token(Token = "0x4003DBD")]
			AllTime = 1,
			[Token(Token = "0x4003DBE")]
			ThisWeek = 2,
			[Token(Token = "0x4003DBF")]
			LastWeek = 4
		}

		[Token(Token = "0x4003DB1")]
		public const string QUERYSTRING_PARAM_TYPE_KEY = "i32_type";

		[Token(Token = "0x4003DB2")]
		public const string QUERYSTRING_PARAM_LID_KEY = "s_lid";

		[Token(Token = "0x4003DB3")]
		public const string QUERYSTRING_PARAM_NOTIFYFRIENDS_KEY = "b_notifyfriends";

		[Token(Token = "0x4003DB4")]
		public const string QUERYSTRING_PARAM_SCORE_KEY = "i64_score";

		[Token(Token = "0x4003DB5")]
		public const string QUERYSTRING_PARAM_START_KEY = "i32_start";

		[Token(Token = "0x4003DB6")]
		public const string QUERYSTRING_PARAM_RANGE_KEY = "i32_range";

		[Token(Token = "0x4003DB7")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x4003DB8")]
		public const string QUERYSTRING_PARAM_POOL_KEY = "s_playerpool";

		[Token(Token = "0x4003DB9")]
		public const string QUERYSTRING_PARAM_BOUNDARIES_KEY = "scores";

		[Token(Token = "0x4003DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE184", Offset = "0x5BE184")]
		private string _003CSvcOpCmdQueryString_003Ek__BackingField;

		[Token(Token = "0x17000A6A")]
		protected sealed override string SvcOpCmdQueryString
		{
			[Token(Token = "0x6004F3D")]
			[Address(RVA = "0xD382E4", Offset = "0xD382E4", VA = "0xD382E4", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629280", Offset = "0x629280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F3E")]
			[Address(RVA = "0xD382EC", Offset = "0xD382EC", VA = "0xD382EC", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x629290", Offset = "0x629290")]
			set
			{
			}
		}

		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0xD382F4", Offset = "0xD382F4", VA = "0xD382F4")]
		protected SvcOpGetLeaderboard(bool requiresAuthentication, [Optional] Action<IResponseContext> responseFunction, bool requiresEditorToken = false)
		{
		}

		[Token(Token = "0x6004F40")]
		[Address(RVA = "0xD38380", Offset = "0xD38380", VA = "0xD38380", Slot = "11")]
		protected virtual void Get(int leaderboardid, string userid, sbyte notifyFriends, long score)
		{
		}

		[Token(Token = "0x6004F41")]
		[Address(RVA = "0xD38A18", Offset = "0xD38A18", VA = "0xD38A18", Slot = "12")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, string userId, string[] playerIdPool, int range)
		{
		}

		[Token(Token = "0x6004F42")]
		[Address(RVA = "0xD38A54", Offset = "0xD38A54", VA = "0xD38A54", Slot = "13")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, long score, int range)
		{
		}

		[Token(Token = "0x6004F43")]
		[Address(RVA = "0xD38AF0", Offset = "0xD38AF0", VA = "0xD38AF0", Slot = "14")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, string userId, int range)
		{
		}

		[Token(Token = "0x6004F44")]
		[Address(RVA = "0xD38B24", Offset = "0xD38B24", VA = "0xD38B24", Slot = "15")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, string userId, int start, int range)
		{
		}

		[Token(Token = "0x6004F45")]
		[Address(RVA = "0xD38B60", Offset = "0xD38B60", VA = "0xD38B60", Slot = "16")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, string[] playerIdPool)
		{
		}

		[Token(Token = "0x6004F46")]
		[Address(RVA = "0xD38BFC", Offset = "0xD38BFC", VA = "0xD38BFC", Slot = "17")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, string userId)
		{
		}

		[Token(Token = "0x6004F47")]
		[Address(RVA = "0xD38C34", Offset = "0xD38C34", VA = "0xD38C34", Slot = "18")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, int startPosition, int range, string[] playerIdPool)
		{
		}

		[Token(Token = "0x6004F48")]
		[Address(RVA = "0xD38CE0", Offset = "0xD38CE0", VA = "0xD38CE0", Slot = "19")]
		protected virtual void Get(LeaderBoardType type, int leaderboardId, int startPosition, int range)
		{
		}

		[Token(Token = "0x6004F49")]
		[Address(RVA = "0xD38D80", Offset = "0xD38D80", VA = "0xD38D80", Slot = "20")]
		protected virtual void Get(int leaderboardId, int[] boundaries)
		{
		}

		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0xD383C0", Offset = "0xD383C0", VA = "0xD383C0")]
		private void Get(LeaderBoardType type, int leaderboardId, int startPosition, int range, string uid, string[] playerIdPool, sbyte notifyfriends, long score, int[] boundaries)
		{
		}
	}
}
