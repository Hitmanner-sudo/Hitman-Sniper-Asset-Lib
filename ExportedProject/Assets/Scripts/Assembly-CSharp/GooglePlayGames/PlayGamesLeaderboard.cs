using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200095A")]
	public class PlayGamesLeaderboard : ILeaderboard
	{
		[Token(Token = "0x40032EE")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x40032EF")]
		[FieldOffset(Offset = "0x18")]
		private UserScope mUserScope;

		[Token(Token = "0x40032F0")]
		[FieldOffset(Offset = "0x1C")]
		private Range mRange;

		[Token(Token = "0x40032F1")]
		[FieldOffset(Offset = "0x24")]
		private TimeScope mTimeScope;

		[Token(Token = "0x40032F2")]
		[FieldOffset(Offset = "0x28")]
		private string[] mFilteredUserIds;

		[Token(Token = "0x40032F3")]
		[FieldOffset(Offset = "0x30")]
		private bool mLoading;

		[Token(Token = "0x40032F4")]
		[FieldOffset(Offset = "0x38")]
		private IScore mLocalUserScore;

		[Token(Token = "0x40032F5")]
		[FieldOffset(Offset = "0x40")]
		private uint mMaxRange;

		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScoreList;

		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x50")]
		private string mTitle;

		[Token(Token = "0x1700077E")]
		public bool loading
		{
			[Token(Token = "0x6003BF8")]
			[Address(RVA = "0xB7775C", Offset = "0xB7775C", VA = "0xB7775C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BF9")]
			[Address(RVA = "0xB77764", Offset = "0xB77764", VA = "0xB77764")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700077F")]
		public string id
		{
			[Token(Token = "0x6003BFA")]
			[Address(RVA = "0xB77770", Offset = "0xB77770", VA = "0xB77770", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BFB")]
			[Address(RVA = "0xB77778", Offset = "0xB77778", VA = "0xB77778", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000780")]
		public UserScope userScope
		{
			[Token(Token = "0x6003BFC")]
			[Address(RVA = "0xB77780", Offset = "0xB77780", VA = "0xB77780", Slot = "6")]
			get
			{
				return default(UserScope);
			}
			[Token(Token = "0x6003BFD")]
			[Address(RVA = "0xB77788", Offset = "0xB77788", VA = "0xB77788", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000781")]
		public Range range
		{
			[Token(Token = "0x6003BFE")]
			[Address(RVA = "0xB77790", Offset = "0xB77790", VA = "0xB77790", Slot = "7")]
			get
			{
				return default(Range);
			}
			[Token(Token = "0x6003BFF")]
			[Address(RVA = "0xB77798", Offset = "0xB77798", VA = "0xB77798", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000782")]
		public TimeScope timeScope
		{
			[Token(Token = "0x6003C00")]
			[Address(RVA = "0xB777A0", Offset = "0xB777A0", VA = "0xB777A0", Slot = "8")]
			get
			{
				return default(TimeScope);
			}
			[Token(Token = "0x6003C01")]
			[Address(RVA = "0xB777A8", Offset = "0xB777A8", VA = "0xB777A8", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000783")]
		public IScore localUserScore
		{
			[Token(Token = "0x6003C02")]
			[Address(RVA = "0xB777B0", Offset = "0xB777B0", VA = "0xB777B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000784")]
		public uint maxRange
		{
			[Token(Token = "0x6003C03")]
			[Address(RVA = "0xB777B8", Offset = "0xB777B8", VA = "0xB777B8", Slot = "16")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000785")]
		public IScore[] scores
		{
			[Token(Token = "0x6003C04")]
			[Address(RVA = "0xB777C0", Offset = "0xB777C0", VA = "0xB777C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000786")]
		public string title
		{
			[Token(Token = "0x6003C05")]
			[Address(RVA = "0xB7785C", Offset = "0xB7785C", VA = "0xB7785C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000787")]
		public int ScoreCount
		{
			[Token(Token = "0x6003C0B")]
			[Address(RVA = "0xB77BDC", Offset = "0xB77BDC", VA = "0xB77BDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0xB7700C", Offset = "0xB7700C", VA = "0xB7700C")]
		public PlayGamesLeaderboard(string id)
		{
		}

		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0xB77098", Offset = "0xB77098", VA = "0xB77098", Slot = "9")]
		public void SetUserFilter(string[] userIDs)
		{
		}

		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0xB770A0", Offset = "0xB770A0", VA = "0xB770A0", Slot = "10")]
		public void LoadScores(Action<bool> callback)
		{
		}

		[Token(Token = "0x6003C06")]
		[Address(RVA = "0xB77864", Offset = "0xB77864", VA = "0xB77864")]
		internal bool SetFromData(LeaderboardScoreData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6003C07")]
		[Address(RVA = "0xB77A6C", Offset = "0xB77A6C", VA = "0xB77A6C")]
		internal void SetMaxRange(ulong val)
		{
		}

		[Token(Token = "0x6003C08")]
		[Address(RVA = "0xB77BCC", Offset = "0xB77BCC", VA = "0xB77BCC")]
		internal void SetTitle(string value)
		{
		}

		[Token(Token = "0x6003C09")]
		[Address(RVA = "0xB77BD4", Offset = "0xB77BD4", VA = "0xB77BD4")]
		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0xB77A74", Offset = "0xB77A74", VA = "0xB77A74")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0xB77B60", Offset = "0xB77B60", VA = "0xB77B60")]
		internal bool HasAllScores()
		{
			return default(bool);
		}
	}
}
