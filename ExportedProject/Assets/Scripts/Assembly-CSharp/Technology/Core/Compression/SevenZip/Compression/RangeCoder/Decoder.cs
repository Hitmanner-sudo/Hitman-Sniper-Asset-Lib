using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.RangeCoder
{
	[Token(Token = "0x2000D5D")]
	internal class Decoder
	{
		[Token(Token = "0x4003F9C")]
		public const uint kTopValue = 16777216u;

		[Token(Token = "0x4003F9D")]
		[FieldOffset(Offset = "0x10")]
		public uint Range;

		[Token(Token = "0x4003F9E")]
		[FieldOffset(Offset = "0x14")]
		public uint Code;

		[Token(Token = "0x4003F9F")]
		[FieldOffset(Offset = "0x18")]
		public Stream Stream;

		[Token(Token = "0x600528E")]
		[Address(RVA = "0xAEB86C", Offset = "0xAEB86C", VA = "0xAEB86C")]
		public void Init(Stream stream)
		{
		}

		[Token(Token = "0x600528F")]
		[Address(RVA = "0xAEBEC4", Offset = "0xAEBEC4", VA = "0xAEBEC4")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x6005290")]
		[Address(RVA = "0xAEC028", Offset = "0xAEC028", VA = "0xAEC028")]
		public void CloseStream()
		{
		}

		[Token(Token = "0x6005291")]
		[Address(RVA = "0xAEC034", Offset = "0xAEC034", VA = "0xAEC034")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6005292")]
		[Address(RVA = "0xAEC090", Offset = "0xAEC090", VA = "0xAEC090")]
		public void Normalize2()
		{
		}

		[Token(Token = "0x6005293")]
		[Address(RVA = "0xAEC0E4", Offset = "0xAEC0E4", VA = "0xAEC0E4")]
		public uint GetThreshold(uint total)
		{
			return default(uint);
		}

		[Token(Token = "0x6005294")]
		[Address(RVA = "0xAEC0FC", Offset = "0xAEC0FC", VA = "0xAEC0FC")]
		public void Decode(uint start, uint size, uint total)
		{
		}

		[Token(Token = "0x6005295")]
		[Address(RVA = "0xAEBE10", Offset = "0xAEBE10", VA = "0xAEBE10")]
		public uint DecodeDirectBits(int numTotalBits)
		{
			return default(uint);
		}

		[Token(Token = "0x6005296")]
		[Address(RVA = "0xAEC110", Offset = "0xAEC110", VA = "0xAEC110")]
		public uint DecodeBit(uint size0, int numTotalBits)
		{
			return default(uint);
		}

		[Token(Token = "0x6005297")]
		[Address(RVA = "0xAEB484", Offset = "0xAEB484", VA = "0xAEB484")]
		public Decoder()
		{
		}
	}
}
