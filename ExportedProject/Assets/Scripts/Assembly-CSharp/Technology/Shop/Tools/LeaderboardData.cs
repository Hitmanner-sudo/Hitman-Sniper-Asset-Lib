using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B58")]
	public class LeaderboardData : BaseShopData
	{
		[Token(Token = "0x2000B59")]
		public delegate void LeaderboardResetHandler();

		[Token(Token = "0x2000B5A")]
		public delegate void LeaderboardDataHandler(LeaderboardData data);

		[Token(Token = "0x2000B5B")]
		public delegate void LeaderboardListHandler(List<LeaderboardData> list);

		[Token(Token = "0x2000B5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598130", Offset = "0x598130")]
		private sealed class _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x40039CE")]
			[FieldOffset(Offset = "0x10")]
			public List<LeaderboardData> entryList;

			[Token(Token = "0x60047FE")]
			[Address(RVA = "0xB2F874", Offset = "0xB2F874", VA = "0xB2F874")]
			public _003C_003Ec__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60047FF")]
			[Address(RVA = "0xB2F87C", Offset = "0xB2F87C", VA = "0xB2F87C")]
			internal void _003CGetLeaderboardEntries_003Eb__0(IResponseContext response)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000B5D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598140", Offset = "0x598140")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40039CF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40039D0")]
			[FieldOffset(Offset = "0x8")]
			public static Action<IResponseContext> _003C_003E9__30_0;

			[Token(Token = "0x6004801")]
			[Address(RVA = "0xB2F4D4", Offset = "0xB2F4D4", VA = "0xB2F4D4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004802")]
			[Address(RVA = "0xB2F4DC", Offset = "0xB2F4DC", VA = "0xB2F4DC")]
			internal void _003CResetThisWeekLeaderboard_003Eb__30_0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x40039C3")]
		private const int INVALID_VALUE = -1;

		[Token(Token = "0x40039C4")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD0CC", Offset = "0x5BD0CC")]
		public string UserId;

		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD104", Offset = "0x5BD104")]
		public string LeaderboardId;

		[Token(Token = "0x40039C6")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD13C", Offset = "0x5BD13C")]
		public string FacebookId;

		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD174", Offset = "0x5BD174")]
		public string Ranking;

		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD1AC", Offset = "0x5BD1AC")]
		public int OldRank;

		[Token(Token = "0x40039C9")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BD1E4", Offset = "0x5BD1E4")]
		public int Score;

		[Token(Token = "0x40039CA")]
		[FieldOffset(Offset = "0x68")]
		public bool Selected;

		[Token(Token = "0x17000921")]
		public override string ObjectName
		{
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x99EA14", Offset = "0x99EA14", VA = "0x99EA14", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000EC")]
		public event LeaderboardDataHandler OnResetScore
		{
			[Token(Token = "0x60047E0")]
			[Address(RVA = "0x99E480", Offset = "0x99E480", VA = "0x99E480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FC8", Offset = "0x626FC8")]
			add
			{
			}
			[Token(Token = "0x60047E1")]
			[Address(RVA = "0x99E520", Offset = "0x99E520", VA = "0x99E520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FD8", Offset = "0x626FD8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000ED")]
		public static event LeaderboardResetHandler OnResetThisWeekLeaderboard
		{
			[Token(Token = "0x60047E2")]
			[Address(RVA = "0x99E5C0", Offset = "0x99E5C0", VA = "0x99E5C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FE8", Offset = "0x626FE8")]
			add
			{
			}
			[Token(Token = "0x60047E3")]
			[Address(RVA = "0x99E67C", Offset = "0x99E67C", VA = "0x99E67C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626FF8", Offset = "0x626FF8")]
			remove
			{
			}
		}

		[Token(Token = "0x140000EE")]
		public static event LeaderboardListHandler OnGetEntryList
		{
			[Token(Token = "0x60047E4")]
			[Address(RVA = "0x99E738", Offset = "0x99E738", VA = "0x99E738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627008", Offset = "0x627008")]
			add
			{
			}
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x99E7F8", Offset = "0x99E7F8", VA = "0x99E7F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627018", Offset = "0x627018")]
			remove
			{
			}
		}

		[Token(Token = "0x60047E6")]
		[Address(RVA = "0x99E8B8", Offset = "0x99E8B8", VA = "0x99E8B8")]
		public LeaderboardData()
		{
		}

		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x99E944", Offset = "0x99E944", VA = "0x99E944")]
		public LeaderboardData(LeaderboardData obj)
		{
		}

		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x99EA58", Offset = "0x99EA58", VA = "0x99EA58", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x99EA5C", Offset = "0x99EA5C", VA = "0x99EA5C", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x60047EB")]
		[Address(RVA = "0x99EAA8", Offset = "0x99EAA8", VA = "0x99EAA8", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x60047EC")]
		[Address(RVA = "0x99EAB0", Offset = "0x99EAB0", VA = "0x99EAB0", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x60047ED")]
		[Address(RVA = "0x99EAB8", Offset = "0x99EAB8", VA = "0x99EAB8", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x60047EE")]
		[Address(RVA = "0x99EAC0", Offset = "0x99EAC0", VA = "0x99EAC0")]
		public static void GetLeaderboardEntries(SvcOpGetLeaderboard.LeaderBoardType type, int id, int start, int range)
		{
		}

		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x99EC1C", Offset = "0x99EC1C", VA = "0x99EC1C")]
		public static void ResetThisWeekLeaderboard(int leaderboardId)
		{
		}

		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x99ED54", Offset = "0x99ED54", VA = "0x99ED54")]
		public void ResetScore(SvcOpGetLeaderboard.LeaderBoardType type, int leaderboardId)
		{
		}

		[Token(Token = "0x60047F1")]
		[Address(RVA = "0x99EE3C", Offset = "0x99EE3C", VA = "0x99EE3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627028", Offset = "0x627028")]
		private void _003CResetScore_003Eb__31_0(IResponseContext response)
		{
		}
	}
}
