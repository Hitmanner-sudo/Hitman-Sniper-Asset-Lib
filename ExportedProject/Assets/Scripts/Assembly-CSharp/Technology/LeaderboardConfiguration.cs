using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AB9")]
	public class LeaderboardConfiguration : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000ABA")]
		public class SubDivision
		{
			[Token(Token = "0x4003710")]
			[FieldOffset(Offset = "0x10")]
			public LazyTexture2D TierIcon;

			[Token(Token = "0x4003711")]
			[FieldOffset(Offset = "0x18")]
			public int MaximumScore;

			[Token(Token = "0x4003712")]
			[FieldOffset(Offset = "0x20")]
			[LootBoxReference]
			public LootBox LootBox;

			[Token(Token = "0x600431F")]
			[Address(RVA = "0xB2EBAC", Offset = "0xB2EBAC", VA = "0xB2EBAC")]
			public SubDivision()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000ABB")]
		public class Tier
		{
			[Token(Token = "0x4003713")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4003714")]
			[FieldOffset(Offset = "0x18")]
			public string Localization;

			[Token(Token = "0x4003715")]
			[FieldOffset(Offset = "0x20")]
			public Color BgColor;

			[Token(Token = "0x4003716")]
			[FieldOffset(Offset = "0x30")]
			public SubDivision[] SubDivision;

			[Token(Token = "0x6004320")]
			[Address(RVA = "0xB2EBB4", Offset = "0xB2EBB4", VA = "0xB2EBB4")]
			public Tier()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000ABC")]
		public class LeaderBoardTier
		{
			[Token(Token = "0x4003717")]
			[FieldOffset(Offset = "0x10")]
			public int LeaderboardID;

			[Token(Token = "0x4003718")]
			[FieldOffset(Offset = "0x18")]
			public List<Tier> TierList;

			[Token(Token = "0x4003719")]
			[FieldOffset(Offset = "0x20")]
			public Color DefaultColor;

			[Token(Token = "0x400371A")]
			[FieldOffset(Offset = "0x30")]
			public int[] ScoreBoundaryPercentages;

			[Token(Token = "0x6004321")]
			[Address(RVA = "0xB2EB24", Offset = "0xB2EB24", VA = "0xB2EB24")]
			public LeaderBoardTier()
			{
			}
		}

		[Token(Token = "0x2000ABD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C64", Offset = "0x597C64")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x400371B")]
			[FieldOffset(Offset = "0x10")]
			public int leaderboardID;

			[Token(Token = "0x6004322")]
			[Address(RVA = "0xB2E954", Offset = "0xB2E954", VA = "0xB2E954")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6004323")]
			[Address(RVA = "0xB2E95C", Offset = "0xB2E95C", VA = "0xB2E95C")]
			internal bool _003CGetLeaderBoardTier_003Eb__0(LeaderBoardTier x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000ABE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C74", Offset = "0x597C74")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x400371C")]
			[FieldOffset(Offset = "0x10")]
			public Unlockable unlockable;

			[Token(Token = "0x6004324")]
			[Address(RVA = "0xB2E980", Offset = "0xB2E980", VA = "0xB2E980")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6004325")]
			[Address(RVA = "0xB2E988", Offset = "0xB2E988", VA = "0xB2E988")]
			internal bool _003CGetTierUnlockIndex_003Eb__0(LazyUnlockable r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000ABF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C84", Offset = "0x597C84")]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			[Token(Token = "0x400371D")]
			[FieldOffset(Offset = "0x10")]
			public LootBox lootBox;

			[Token(Token = "0x6004326")]
			[Address(RVA = "0xB2EA4C", Offset = "0xB2EA4C", VA = "0xB2EA4C")]
			public _003C_003Ec__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6004327")]
			[Address(RVA = "0xB2EA54", Offset = "0xB2EA54", VA = "0xB2EA54")]
			internal bool _003CIsLeaderboardLootbox_003Eb__2(SubDivision sub)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000AC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C94", Offset = "0x597C94")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400371E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400371F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<LeaderBoardTier, IEnumerable<Tier>> _003C_003E9__32_0;

			[Token(Token = "0x4003720")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Tier, IEnumerable<SubDivision>> _003C_003E9__32_1;

			[Token(Token = "0x6004329")]
			[Address(RVA = "0xB2E91C", Offset = "0xB2E91C", VA = "0xB2E91C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600432A")]
			[Address(RVA = "0xB2E924", Offset = "0xB2E924", VA = "0xB2E924")]
			internal IEnumerable<Tier> _003CIsLeaderboardLootbox_003Eb__32_0(LeaderBoardTier leaderboard)
			{
				return null;
			}

			[Token(Token = "0x600432B")]
			[Address(RVA = "0xB2E93C", Offset = "0xB2E93C", VA = "0xB2E93C")]
			internal IEnumerable<SubDivision> _003CIsLeaderboardLootbox_003Eb__32_1(Tier tier)
			{
				return null;
			}
		}

		[Token(Token = "0x4003702")]
		public const int INVALID_TIER_INDEX = -1;

		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x18")]
		public int[] OnlineSuiteLeaderboards;

		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x20")]
		public string[] GoogleLeaderboards;

		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x28")]
		public int LeaderboardAvatarWidth;

		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x2C")]
		public int LeaderboardAvatarHeight;

		[Token(Token = "0x4003707")]
		[FieldOffset(Offset = "0x30")]
		public int LeaderboardFreshnessTimeout;

		[Token(Token = "0x4003708")]
		[FieldOffset(Offset = "0x34")]
		public int DefaultTimeoutForRequests;

		[Token(Token = "0x4003709")]
		[FieldOffset(Offset = "0x38")]
		public string FacebookProfileURLFormat;

		[Token(Token = "0x400370A")]
		[FieldOffset(Offset = "0x40")]
		public string FacebookProfileImageURLFormat;

		[Token(Token = "0x400370B")]
		[FieldOffset(Offset = "0x48")]
		public string DefaultPlayerDisplayName;

		[Token(Token = "0x400370C")]
		[FieldOffset(Offset = "0x50")]
		public List<LeaderBoardTier> LeaderBoardTierList;

		[Token(Token = "0x400370D")]
		[FieldOffset(Offset = "0x58")]
		public int LastTierMaxPlayerCount;

		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PopupLeaderboardTierLootBox _rankUpPopupPrefab;

		[Token(Token = "0x400370F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _inactivityPeriodHours;

		[Token(Token = "0x17000889")]
		public PopupLeaderboardTierLootBox RankUpPopupPrefab
		{
			[Token(Token = "0x600430D")]
			[Address(RVA = "0x9985F4", Offset = "0x9985F4", VA = "0x9985F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088A")]
		public TimeSpan ScoreInactivityPeriod
		{
			[Token(Token = "0x600430E")]
			[Address(RVA = "0x9985FC", Offset = "0x9985FC", VA = "0x9985FC")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x600430F")]
		[Address(RVA = "0x998664", Offset = "0x998664", VA = "0x998664")]
		public List<Tier> GetTierList(int leaderboardID)
		{
			return null;
		}

		[Token(Token = "0x6004310")]
		[Address(RVA = "0x998690", Offset = "0x998690", VA = "0x998690")]
		public LeaderBoardTier GetLeaderBoardTier(int leaderboardID)
		{
			return null;
		}

		[Token(Token = "0x6004311")]
		[Address(RVA = "0x99877C", Offset = "0x99877C", VA = "0x99877C")]
		public int GetTierIndex(int score, int leaderboardID)
		{
			return default(int);
		}

		[Token(Token = "0x6004312")]
		[Address(RVA = "0x9989A0", Offset = "0x9989A0", VA = "0x9989A0")]
		public int GetLastIndex(int leaderboardID)
		{
			return default(int);
		}

		[Token(Token = "0x6004313")]
		[Address(RVA = "0x998AF4", Offset = "0x998AF4", VA = "0x998AF4")]
		public string GetTierNameByIndex(int index, int leaderboardId)
		{
			return null;
		}

		[Token(Token = "0x6004314")]
		[Address(RVA = "0x998ED4", Offset = "0x998ED4", VA = "0x998ED4")]
		public string GetTierLocalizationKey(int index, int leaderboardId)
		{
			return null;
		}

		[Token(Token = "0x6004315")]
		[Address(RVA = "0x998F78", Offset = "0x998F78", VA = "0x998F78")]
		public string GetTierUnlocalizedNameByIndex(int index, int leaderboardID)
		{
			return null;
		}

		[Token(Token = "0x6004316")]
		[Address(RVA = "0x998EAC", Offset = "0x998EAC", VA = "0x998EAC")]
		private bool IsInvalidTier(int subDivisionID, Tier tier, SubDivision subDivision)
		{
			return default(bool);
		}

		[Token(Token = "0x6004317")]
		[Address(RVA = "0x999070", Offset = "0x999070", VA = "0x999070")]
		public bool IsUnlockableLocked(Unlockable unlockable, out int leaderboardID, out int tierUnlockIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6004318")]
		[Address(RVA = "0x99922C", Offset = "0x99922C", VA = "0x99922C")]
		public int GetTierUnlockIndex(Unlockable unlockable, int leaderboardID)
		{
			return default(int);
		}

		[Token(Token = "0x6004319")]
		[Address(RVA = "0x998C0C", Offset = "0x998C0C", VA = "0x998C0C")]
		public int GetTierDetailByIndex(int index, int leaderboardID, out Tier tierOUT, out SubDivision subDivisionOUT)
		{
			return default(int);
		}

		[Token(Token = "0x600431A")]
		[Address(RVA = "0x99960C", Offset = "0x99960C", VA = "0x99960C")]
		public bool IsLeaderboardLootbox(LootBox lootBox)
		{
			return default(bool);
		}

		[Token(Token = "0x600431B")]
		[Address(RVA = "0x9998C8", Offset = "0x9998C8", VA = "0x9998C8")]
		public bool IsLeaderboardUnlockable(Unlockable unlockable)
		{
			return default(bool);
		}

		[Token(Token = "0x600431C")]
		[Address(RVA = "0x999980", Offset = "0x999980", VA = "0x999980")]
		public int[] GetScoreBoundaries(int leaderboardId, int score)
		{
			return null;
		}

		[Token(Token = "0x600431D")]
		[Address(RVA = "0x999B08", Offset = "0x999B08", VA = "0x999B08")]
		public bool CanUseScoreBoundaries(int leaderboardId)
		{
			return default(bool);
		}

		[Token(Token = "0x600431E")]
		[Address(RVA = "0x999B40", Offset = "0x999B40", VA = "0x999B40")]
		public LeaderboardConfiguration()
		{
		}
	}
}
