using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009F1")]
	public class PlayerStats
	{
		[Token(Token = "0x40034A6")]
		[FieldOffset(Offset = "0x0")]
		private static float UNSET_VALUE;

		[Token(Token = "0x40034A7")]
		[FieldOffset(Offset = "0x10")]
		private bool mValid;

		[Token(Token = "0x40034A8")]
		[FieldOffset(Offset = "0x14")]
		private int mNumberOfPurchases;

		[Token(Token = "0x40034A9")]
		[FieldOffset(Offset = "0x18")]
		private float mAvgSessionLength;

		[Token(Token = "0x40034AA")]
		[FieldOffset(Offset = "0x1C")]
		private int mDaysSinceLastPlayed;

		[Token(Token = "0x40034AB")]
		[FieldOffset(Offset = "0x20")]
		private int mNumberOfSessions;

		[Token(Token = "0x40034AC")]
		[FieldOffset(Offset = "0x24")]
		private float mSessPercentile;

		[Token(Token = "0x40034AD")]
		[FieldOffset(Offset = "0x28")]
		private float mSpendPercentile;

		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x2C")]
		private float mSpendProbability;

		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x30")]
		private float mChurnProbability;

		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x34")]
		private float mHighSpenderProbability;

		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x38")]
		private float mTotalSpendNext28Days;

		[Token(Token = "0x170007D1")]
		public bool Valid
		{
			[Token(Token = "0x6003F12")]
			[Address(RVA = "0xABA2A8", Offset = "0xABA2A8", VA = "0xABA2A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007D2")]
		public int NumberOfPurchases
		{
			[Token(Token = "0x6003F13")]
			[Address(RVA = "0xABA2B0", Offset = "0xABA2B0", VA = "0xABA2B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007D3")]
		public float AvgSessionLength
		{
			[Token(Token = "0x6003F14")]
			[Address(RVA = "0xABA2B8", Offset = "0xABA2B8", VA = "0xABA2B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007D4")]
		public int DaysSinceLastPlayed
		{
			[Token(Token = "0x6003F15")]
			[Address(RVA = "0xABA2C0", Offset = "0xABA2C0", VA = "0xABA2C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007D5")]
		public int NumberOfSessions
		{
			[Token(Token = "0x6003F16")]
			[Address(RVA = "0xABA2C8", Offset = "0xABA2C8", VA = "0xABA2C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170007D6")]
		public float SessPercentile
		{
			[Token(Token = "0x6003F17")]
			[Address(RVA = "0xABA2D0", Offset = "0xABA2D0", VA = "0xABA2D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007D7")]
		public float SpendPercentile
		{
			[Token(Token = "0x6003F18")]
			[Address(RVA = "0xABA2D8", Offset = "0xABA2D8", VA = "0xABA2D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007D8")]
		public float SpendProbability
		{
			[Token(Token = "0x6003F19")]
			[Address(RVA = "0xABA2E0", Offset = "0xABA2E0", VA = "0xABA2E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007D9")]
		public float ChurnProbability
		{
			[Token(Token = "0x6003F1A")]
			[Address(RVA = "0xABA2E8", Offset = "0xABA2E8", VA = "0xABA2E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007DA")]
		public float HighSpenderProbability
		{
			[Token(Token = "0x6003F1B")]
			[Address(RVA = "0xABA2F0", Offset = "0xABA2F0", VA = "0xABA2F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007DB")]
		public float TotalSpendNext28Days
		{
			[Token(Token = "0x6003F1C")]
			[Address(RVA = "0xABA2F8", Offset = "0xABA2F8", VA = "0xABA2F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6003F10")]
		[Address(RVA = "0xABA1EC", Offset = "0xABA1EC", VA = "0xABA1EC")]
		public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
		{
		}

		[Token(Token = "0x6003F11")]
		[Address(RVA = "0xABA280", Offset = "0xABA280", VA = "0xABA280")]
		public PlayerStats()
		{
		}

		[Token(Token = "0x6003F1D")]
		[Address(RVA = "0xABA300", Offset = "0xABA300", VA = "0xABA300")]
		public bool HasNumberOfPurchases()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0xABA390", Offset = "0xABA390", VA = "0xABA390")]
		public bool HasAvgSessionLength()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0xABA40C", Offset = "0xABA40C", VA = "0xABA40C")]
		public bool HasDaysSinceLastPlayed()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F20")]
		[Address(RVA = "0xABA49C", Offset = "0xABA49C", VA = "0xABA49C")]
		public bool HasNumberOfSessions()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F21")]
		[Address(RVA = "0xABA52C", Offset = "0xABA52C", VA = "0xABA52C")]
		public bool HasSessPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F22")]
		[Address(RVA = "0xABA5A8", Offset = "0xABA5A8", VA = "0xABA5A8")]
		public bool HasSpendPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F23")]
		[Address(RVA = "0xABA624", Offset = "0xABA624", VA = "0xABA624")]
		public bool HasChurnProbability()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F24")]
		[Address(RVA = "0xABA6A0", Offset = "0xABA6A0", VA = "0xABA6A0")]
		public bool HasHighSpenderProbability()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F25")]
		[Address(RVA = "0xABA71C", Offset = "0xABA71C", VA = "0xABA71C")]
		public bool HasTotalSpendNext28Days()
		{
			return default(bool);
		}
	}
}
