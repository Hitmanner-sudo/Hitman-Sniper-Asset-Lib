using Il2CppDummyDll;
using Technology;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x20007B5")]
public static class LeaderboardUtility
{
	[Token(Token = "0x20007B6")]
	public struct TierInfo
	{
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x0")]
		public LeaderboardConfiguration.Tier Tier;

		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x8")]
		public string DivisionKey;

		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x10")]
		public string SubDivision;

		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D Texture;
	}

	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x9A7108", Offset = "0x9A7108", VA = "0x9A7108")]
	public static int GetTierIndex(LeaderboardRecord record, int leaderboardId, LeaderboardConfiguration config)
	{
		return default(int);
	}

	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x9A71DC", Offset = "0x9A71DC", VA = "0x9A71DC")]
	public static bool IsInLastTier(LeaderboardRecord record, int leaderboardId, LeaderboardConfiguration config)
	{
		return default(bool);
	}

	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x9A712C", Offset = "0x9A712C", VA = "0x9A712C")]
	public static int GetTierIndex(LeaderboardRecord record, int leaderboardId, LeaderboardConfiguration config, out int lastTierIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x9A720C", Offset = "0x9A720C", VA = "0x9A720C")]
	public static TierInfo GetTierInfo(int tierIndex, int leaderboardId, LeaderboardConfiguration config)
	{
		return default(TierInfo);
	}
}
