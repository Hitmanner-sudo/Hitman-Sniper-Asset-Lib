using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D5E")]
	internal struct BitEncoder
	{
		[Token(Token = "0x4003FA0")]
		public const int kNumBitModelTotalBits = 11;

		[Token(Token = "0x4003FA1")]
		public const uint kBitModelTotal = 2048u;

		[Token(Token = "0x4003FA2")]
		private const int kNumMoveBits = 5;

		[Token(Token = "0x4003FA3")]
		private const int kNumMoveReducingBits = 2;

		[Token(Token = "0x4003FA4")]
		public const int kNumBitPriceShiftBits = 6;

		[Token(Token = "0x4003FA5")]
		[FieldOffset(Offset = "0x0")]
		private uint Prob;

		[Token(Token = "0x4003FA6")]
		[FieldOffset(Offset = "0x0")]
		private static uint[] ProbPrices;

		[Token(Token = "0x6005298")]
		[Address(RVA = "0xC65DD8", Offset = "0xC65DD8", VA = "0xC65DD8")]
		public void Init()
		{
		}

		[Token(Token = "0x6005299")]
		[Address(RVA = "0xC65DE4", Offset = "0xC65DE4", VA = "0xC65DE4")]
		public void UpdateModel(uint symbol)
		{
		}

		[Token(Token = "0x600529A")]
		[Address(RVA = "0xC65E08", Offset = "0xC65E08", VA = "0xC65E08")]
		public void Encode(Encoder encoder, uint symbol)
		{
		}

		[Token(Token = "0x600529B")]
		[Address(RVA = "0xC65E88", Offset = "0xC65E88", VA = "0xC65E88")]
		static BitEncoder()
		{
		}

		[Token(Token = "0x600529C")]
		[Address(RVA = "0xC65F8C", Offset = "0xC65F8C", VA = "0xC65F8C")]
		public uint GetPrice(uint symbol)
		{
			return default(uint);
		}

		[Token(Token = "0x600529D")]
		[Address(RVA = "0xC66048", Offset = "0xC66048", VA = "0xC66048")]
		public uint GetPrice0()
		{
			return default(uint);
		}

		[Token(Token = "0x600529E")]
		[Address(RVA = "0xC660E0", Offset = "0xC660E0", VA = "0xC660E0")]
		public uint GetPrice1()
		{
			return default(uint);
		}
	}
}
