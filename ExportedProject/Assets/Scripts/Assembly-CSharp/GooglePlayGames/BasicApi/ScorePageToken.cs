using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009F3")]
	public class ScorePageToken
	{
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x18")]
		private object mInternalObject;

		[Token(Token = "0x40034B7")]
		[FieldOffset(Offset = "0x20")]
		private LeaderboardCollection mCollection;

		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x24")]
		private LeaderboardTimeSpan mTimespan;

		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x28")]
		private ScorePageDirection mDirection;

		[Token(Token = "0x170007DC")]
		public LeaderboardCollection Collection
		{
			[Token(Token = "0x6003F28")]
			[Address(RVA = "0xB5E5C8", Offset = "0xB5E5C8", VA = "0xB5E5C8")]
			get
			{
				return default(LeaderboardCollection);
			}
		}

		[Token(Token = "0x170007DD")]
		public LeaderboardTimeSpan TimeSpan
		{
			[Token(Token = "0x6003F29")]
			[Address(RVA = "0xB5E5D0", Offset = "0xB5E5D0", VA = "0xB5E5D0")]
			get
			{
				return default(LeaderboardTimeSpan);
			}
		}

		[Token(Token = "0x170007DE")]
		public ScorePageDirection Direction
		{
			[Token(Token = "0x6003F2A")]
			[Address(RVA = "0xB5E5D8", Offset = "0xB5E5D8", VA = "0xB5E5D8")]
			get
			{
				return default(ScorePageDirection);
			}
		}

		[Token(Token = "0x170007DF")]
		public string LeaderboardId
		{
			[Token(Token = "0x6003F2B")]
			[Address(RVA = "0xB5E5E0", Offset = "0xB5E5E0", VA = "0xB5E5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E0")]
		internal object InternalObject
		{
			[Token(Token = "0x6003F2C")]
			[Address(RVA = "0xB5E5E8", Offset = "0xB5E5E8", VA = "0xB5E5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F27")]
		[Address(RVA = "0xB5E574", Offset = "0xB5E574", VA = "0xB5E574")]
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction)
		{
		}
	}
}
