using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D61")]
	internal struct BitTreeDecoder
	{
		[Token(Token = "0x4003FAD")]
		[FieldOffset(Offset = "0x0")]
		private BitDecoder[] Models;

		[Token(Token = "0x4003FAE")]
		[FieldOffset(Offset = "0x8")]
		private int NumBitLevels;

		[Token(Token = "0x60052AA")]
		[Address(RVA = "0xC66180", Offset = "0xC66180", VA = "0xC66180")]
		public BitTreeDecoder(int numBitLevels)
		{
		}

		[Token(Token = "0x60052AB")]
		[Address(RVA = "0xC661E8", Offset = "0xC661E8", VA = "0xC661E8")]
		public void Init()
		{
		}

		[Token(Token = "0x60052AC")]
		[Address(RVA = "0xC66258", Offset = "0xC66258", VA = "0xC66258")]
		public uint Decode(Decoder rangeDecoder)
		{
			return default(uint);
		}

		[Token(Token = "0x60052AD")]
		[Address(RVA = "0xC662F8", Offset = "0xC662F8", VA = "0xC662F8")]
		public uint ReverseDecode(Decoder rangeDecoder)
		{
			return default(uint);
		}

		[Token(Token = "0x60052AE")]
		[Address(RVA = "0xC6639C", Offset = "0xC6639C", VA = "0xC6639C")]
		public static uint ReverseDecode(BitDecoder[] Models, uint startIndex, Decoder rangeDecoder, int NumBitLevels)
		{
			return default(uint);
		}
	}
}
