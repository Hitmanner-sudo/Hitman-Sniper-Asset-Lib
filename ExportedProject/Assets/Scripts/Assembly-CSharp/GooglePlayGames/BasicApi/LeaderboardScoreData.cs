using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009EC")]
	public class LeaderboardScoreData
	{
		[Token(Token = "0x400348D")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x400348E")]
		[FieldOffset(Offset = "0x18")]
		private ResponseStatus mStatus;

		[Token(Token = "0x400348F")]
		[FieldOffset(Offset = "0x20")]
		private ulong mApproxCount;

		[Token(Token = "0x4003490")]
		[FieldOffset(Offset = "0x28")]
		private string mTitle;

		[Token(Token = "0x4003491")]
		[FieldOffset(Offset = "0x30")]
		private IScore mPlayerScore;

		[Token(Token = "0x4003492")]
		[FieldOffset(Offset = "0x38")]
		private ScorePageToken mPrevPage;

		[Token(Token = "0x4003493")]
		[FieldOffset(Offset = "0x40")]
		private ScorePageToken mNextPage;

		[Token(Token = "0x4003494")]
		[FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScores;

		[Token(Token = "0x170007C0")]
		public bool Valid
		{
			[Token(Token = "0x6003EDD")]
			[Address(RVA = "0x9A6E04", Offset = "0x9A6E04", VA = "0x9A6E04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007C1")]
		public ResponseStatus Status
		{
			[Token(Token = "0x6003EDE")]
			[Address(RVA = "0x9A6E18", Offset = "0x9A6E18", VA = "0x9A6E18")]
			get
			{
				return default(ResponseStatus);
			}
			[Token(Token = "0x6003EDF")]
			[Address(RVA = "0x9A6E20", Offset = "0x9A6E20", VA = "0x9A6E20")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C2")]
		public ulong ApproximateCount
		{
			[Token(Token = "0x6003EE0")]
			[Address(RVA = "0x9A6E28", Offset = "0x9A6E28", VA = "0x9A6E28")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6003EE1")]
			[Address(RVA = "0x9A6E30", Offset = "0x9A6E30", VA = "0x9A6E30")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C3")]
		public string Title
		{
			[Token(Token = "0x6003EE2")]
			[Address(RVA = "0x9A6E38", Offset = "0x9A6E38", VA = "0x9A6E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EE3")]
			[Address(RVA = "0x9A6E40", Offset = "0x9A6E40", VA = "0x9A6E40")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C4")]
		public string Id
		{
			[Token(Token = "0x6003EE4")]
			[Address(RVA = "0x9A6E48", Offset = "0x9A6E48", VA = "0x9A6E48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EE5")]
			[Address(RVA = "0x9A6E50", Offset = "0x9A6E50", VA = "0x9A6E50")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C5")]
		public IScore PlayerScore
		{
			[Token(Token = "0x6003EE6")]
			[Address(RVA = "0x9A6E58", Offset = "0x9A6E58", VA = "0x9A6E58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EE7")]
			[Address(RVA = "0x9A6E60", Offset = "0x9A6E60", VA = "0x9A6E60")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C6")]
		public IScore[] Scores
		{
			[Token(Token = "0x6003EE8")]
			[Address(RVA = "0x9A6E68", Offset = "0x9A6E68", VA = "0x9A6E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C7")]
		public ScorePageToken PrevPageToken
		{
			[Token(Token = "0x6003EEA")]
			[Address(RVA = "0x9A6F3C", Offset = "0x9A6F3C", VA = "0x9A6F3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EEB")]
			[Address(RVA = "0x9A6F44", Offset = "0x9A6F44", VA = "0x9A6F44")]
			internal set
			{
			}
		}

		[Token(Token = "0x170007C8")]
		public ScorePageToken NextPageToken
		{
			[Token(Token = "0x6003EEC")]
			[Address(RVA = "0x9A6F4C", Offset = "0x9A6F4C", VA = "0x9A6F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EED")]
			[Address(RVA = "0x9A6F54", Offset = "0x9A6F54", VA = "0x9A6F54")]
			internal set
			{
			}
		}

		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x9A6CE4", Offset = "0x9A6CE4", VA = "0x9A6CE4")]
		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x9A6D70", Offset = "0x9A6D70", VA = "0x9A6D70")]
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x9A6EBC", Offset = "0x9A6EBC", VA = "0x9A6EBC")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x9A6F5C", Offset = "0x9A6F5C", VA = "0x9A6F5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
