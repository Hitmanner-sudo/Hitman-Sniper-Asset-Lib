using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D5C")]
	internal class Encoder
	{
		[Token(Token = "0x4003F95")]
		public const uint kTopValue = 16777216u;

		[Token(Token = "0x4003F96")]
		[FieldOffset(Offset = "0x10")]
		private Stream Stream;

		[Token(Token = "0x4003F97")]
		[FieldOffset(Offset = "0x18")]
		public ulong Low;

		[Token(Token = "0x4003F98")]
		[FieldOffset(Offset = "0x20")]
		public uint Range;

		[Token(Token = "0x4003F99")]
		[FieldOffset(Offset = "0x24")]
		private uint _cacheSize;

		[Token(Token = "0x4003F9A")]
		[FieldOffset(Offset = "0x28")]
		private byte _cache;

		[Token(Token = "0x4003F9B")]
		[FieldOffset(Offset = "0x30")]
		private long StartPosition;

		[Token(Token = "0x6005282")]
		[Address(RVA = "0xE12AE4", Offset = "0xE12AE4", VA = "0xE12AE4")]
		public void SetStream(Stream stream)
		{
		}

		[Token(Token = "0x6005283")]
		[Address(RVA = "0xE123EC", Offset = "0xE123EC", VA = "0xE123EC")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x6005284")]
		[Address(RVA = "0xE0E67C", Offset = "0xE0E67C", VA = "0xE0E67C")]
		public void Init()
		{
		}

		[Token(Token = "0x6005285")]
		[Address(RVA = "0xE1144C", Offset = "0xE1144C", VA = "0xE1144C")]
		public void FlushData()
		{
		}

		[Token(Token = "0x6005286")]
		[Address(RVA = "0xE1147C", Offset = "0xE1147C", VA = "0xE1147C")]
		public void FlushStream()
		{
		}

		[Token(Token = "0x6005287")]
		[Address(RVA = "0xE12B8C", Offset = "0xE12B8C", VA = "0xE12B8C")]
		public void CloseStream()
		{
		}

		[Token(Token = "0x6005288")]
		[Address(RVA = "0xE12B98", Offset = "0xE12B98", VA = "0xE12B98")]
		public void Encode(uint start, uint size, uint total)
		{
		}

		[Token(Token = "0x6005289")]
		[Address(RVA = "0xE12AEC", Offset = "0xE12AEC", VA = "0xE12AEC")]
		public void ShiftLow()
		{
		}

		[Token(Token = "0x600528A")]
		[Address(RVA = "0xE112A0", Offset = "0xE112A0", VA = "0xE112A0")]
		public void EncodeDirectBits(uint v, int numTotalBits)
		{
		}

		[Token(Token = "0x600528B")]
		[Address(RVA = "0xE12BF8", Offset = "0xE12BF8", VA = "0xE12BF8")]
		public void EncodeBit(uint size0, int numTotalBits, uint symbol)
		{
		}

		[Token(Token = "0x600528C")]
		[Address(RVA = "0xE1236C", Offset = "0xE1236C", VA = "0xE1236C")]
		public long GetProcessedSizeAdd()
		{
			return default(long);
		}

		[Token(Token = "0x600528D")]
		[Address(RVA = "0xE0E440", Offset = "0xE0E440", VA = "0xE0E440")]
		public Encoder()
		{
		}
	}
}
