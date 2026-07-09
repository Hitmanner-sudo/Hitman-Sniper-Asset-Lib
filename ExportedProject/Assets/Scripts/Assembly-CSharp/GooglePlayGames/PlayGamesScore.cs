using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200096E")]
	public class PlayGamesScore : IScore
	{
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x10")]
		private string mLbId;

		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x18")]
		private long mValue;

		[Token(Token = "0x4003325")]
		[FieldOffset(Offset = "0x20")]
		private ulong mRank;

		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x28")]
		private string mPlayerId;

		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x30")]
		private string mMetadata;

		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x38")]
		private DateTime mDate;

		[Token(Token = "0x17000798")]
		public string leaderboardID
		{
			[Token(Token = "0x6003C92")]
			[Address(RVA = "0xB7D8FC", Offset = "0xB7D8FC", VA = "0xB7D8FC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C93")]
			[Address(RVA = "0xB7D904", Offset = "0xB7D904", VA = "0xB7D904", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000799")]
		public long value
		{
			[Token(Token = "0x6003C94")]
			[Address(RVA = "0xB7D90C", Offset = "0xB7D90C", VA = "0xB7D90C", Slot = "7")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6003C95")]
			[Address(RVA = "0xB7D914", Offset = "0xB7D914", VA = "0xB7D914", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700079A")]
		public DateTime date
		{
			[Token(Token = "0x6003C96")]
			[Address(RVA = "0xB7D91C", Offset = "0xB7D91C", VA = "0xB7D91C", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x1700079B")]
		public string formattedValue
		{
			[Token(Token = "0x6003C97")]
			[Address(RVA = "0xB7D924", Offset = "0xB7D924", VA = "0xB7D924", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079C")]
		public string userID
		{
			[Token(Token = "0x6003C98")]
			[Address(RVA = "0xB7D930", Offset = "0xB7D930", VA = "0xB7D930", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079D")]
		public int rank
		{
			[Token(Token = "0x6003C99")]
			[Address(RVA = "0xB7D938", Offset = "0xB7D938", VA = "0xB7D938", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700079E")]
		public string metaData
		{
			[Token(Token = "0x6003C9A")]
			[Address(RVA = "0xB7D940", Offset = "0xB7D940", VA = "0xB7D940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C90")]
		[Address(RVA = "0xB7D7A8", Offset = "0xB7D7A8", VA = "0xB7D7A8")]
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		[Token(Token = "0x6003C91")]
		[Address(RVA = "0xB7D87C", Offset = "0xB7D87C", VA = "0xB7D87C", Slot = "4")]
		public void ReportScore(Action<bool> callback)
		{
		}
	}
}
