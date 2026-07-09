using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D60")]
	internal struct BitTreeEncoder
	{
		[Token(Token = "0x4003FAB")]
		[FieldOffset(Offset = "0x0")]
		private BitEncoder[] Models;

		[Token(Token = "0x4003FAC")]
		[FieldOffset(Offset = "0x8")]
		private int NumBitLevels;

		[Token(Token = "0x60052A2")]
		[Address(RVA = "0xC66448", Offset = "0xC66448", VA = "0xC66448")]
		public BitTreeEncoder(int numBitLevels)
		{
		}

		[Token(Token = "0x60052A3")]
		[Address(RVA = "0xC664B0", Offset = "0xC664B0", VA = "0xC664B0")]
		public void Init()
		{
		}

		[Token(Token = "0x60052A4")]
		[Address(RVA = "0xC66520", Offset = "0xC66520", VA = "0xC66520")]
		public void Encode(Encoder rangeEncoder, uint symbol)
		{
		}

		[Token(Token = "0x60052A5")]
		[Address(RVA = "0xC665C0", Offset = "0xC665C0", VA = "0xC665C0")]
		public void ReverseEncode(Encoder rangeEncoder, uint symbol)
		{
		}

		[Token(Token = "0x60052A6")]
		[Address(RVA = "0xC66664", Offset = "0xC66664", VA = "0xC66664")]
		public uint GetPrice(uint symbol)
		{
			return default(uint);
		}

		[Token(Token = "0x60052A7")]
		[Address(RVA = "0xC66710", Offset = "0xC66710", VA = "0xC66710")]
		public uint ReverseGetPrice(uint symbol)
		{
			return default(uint);
		}

		[Token(Token = "0x60052A8")]
		[Address(RVA = "0xC667B8", Offset = "0xC667B8", VA = "0xC667B8")]
		public static uint ReverseGetPrice(BitEncoder[] Models, uint startIndex, int NumBitLevels, uint symbol)
		{
			return default(uint);
		}

		[Token(Token = "0x60052A9")]
		[Address(RVA = "0xC66868", Offset = "0xC66868", VA = "0xC66868")]
		public static void ReverseEncode(BitEncoder[] Models, uint startIndex, Encoder rangeEncoder, int NumBitLevels, uint symbol)
		{
		}
	}
}
