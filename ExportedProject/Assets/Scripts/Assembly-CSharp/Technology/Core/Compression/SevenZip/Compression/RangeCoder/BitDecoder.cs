using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D5F")]
	internal struct BitDecoder
	{
		[Token(Token = "0x4003FA7")]
		public const int kNumBitModelTotalBits = 11;

		[Token(Token = "0x4003FA8")]
		public const uint kBitModelTotal = 2048u;

		[Token(Token = "0x4003FA9")]
		private const int kNumMoveBits = 5;

		[Token(Token = "0x4003FAA")]
		[FieldOffset(Offset = "0x0")]
		private uint Prob;

		[Token(Token = "0x600529F")]
		[Address(RVA = "0xC65CB4", Offset = "0xC65CB4", VA = "0xC65CB4")]
		public void UpdateModel(int numMoveBits, uint symbol)
		{
		}

		[Token(Token = "0x60052A0")]
		[Address(RVA = "0xC65CE0", Offset = "0xC65CE0", VA = "0xC65CE0")]
		public void Init()
		{
		}

		[Token(Token = "0x60052A1")]
		[Address(RVA = "0xC65CEC", Offset = "0xC65CEC", VA = "0xC65CEC")]
		public uint Decode(Decoder rangeDecoder)
		{
			return default(uint);
		}
	}
}
