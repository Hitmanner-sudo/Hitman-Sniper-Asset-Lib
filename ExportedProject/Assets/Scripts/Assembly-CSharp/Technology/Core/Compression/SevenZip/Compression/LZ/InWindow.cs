using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZ
{
	[Token(Token = "0x2000D72")]
	public class InWindow
	{
		[Token(Token = "0x4004051")]
		[FieldOffset(Offset = "0x10")]
		public byte[] _bufferBase;

		[Token(Token = "0x4004052")]
		[FieldOffset(Offset = "0x18")]
		private Stream _stream;

		[Token(Token = "0x4004053")]
		[FieldOffset(Offset = "0x20")]
		private uint _posLimit;

		[Token(Token = "0x4004054")]
		[FieldOffset(Offset = "0x24")]
		private bool _streamEndWasReached;

		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x28")]
		private uint _pointerToLastSafePosition;

		[Token(Token = "0x4004056")]
		[FieldOffset(Offset = "0x2C")]
		public uint _bufferOffset;

		[Token(Token = "0x4004057")]
		[FieldOffset(Offset = "0x30")]
		public uint _blockSize;

		[Token(Token = "0x4004058")]
		[FieldOffset(Offset = "0x34")]
		public uint _pos;

		[Token(Token = "0x4004059")]
		[FieldOffset(Offset = "0x38")]
		private uint _keepSizeBefore;

		[Token(Token = "0x400405A")]
		[FieldOffset(Offset = "0x3C")]
		private uint _keepSizeAfter;

		[Token(Token = "0x400405B")]
		[FieldOffset(Offset = "0x40")]
		public uint _streamPos;

		[Token(Token = "0x600531C")]
		[Address(RVA = "0xB0A2D8", Offset = "0xB0A2D8", VA = "0xB0A2D8")]
		public void MoveBlock()
		{
		}

		[Token(Token = "0x600531D")]
		[Address(RVA = "0xB0A370", Offset = "0xB0A370", VA = "0xB0A370", Slot = "4")]
		public virtual void ReadBlock()
		{
		}

		[Token(Token = "0x600531E")]
		[Address(RVA = "0xB0A428", Offset = "0xB0A428", VA = "0xB0A428")]
		private void Free()
		{
		}

		[Token(Token = "0x600531F")]
		[Address(RVA = "0xB0A430", Offset = "0xB0A430", VA = "0xB0A430")]
		public void Create(uint keepSizeBefore, uint keepSizeAfter, uint keepSizeReserv)
		{
		}

		[Token(Token = "0x6005320")]
		[Address(RVA = "0xB0A4D0", Offset = "0xB0A4D0", VA = "0xB0A4D0")]
		public void SetStream(Stream stream)
		{
		}

		[Token(Token = "0x6005321")]
		[Address(RVA = "0xB0A4D8", Offset = "0xB0A4D8", VA = "0xB0A4D8")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x6005322")]
		[Address(RVA = "0xB0A4E0", Offset = "0xB0A4E0", VA = "0xB0A4E0")]
		public void Init()
		{
		}

		[Token(Token = "0x6005323")]
		[Address(RVA = "0xB0A4FC", Offset = "0xB0A4FC", VA = "0xB0A4FC")]
		public void MovePos()
		{
		}

		[Token(Token = "0x6005324")]
		[Address(RVA = "0xB0A560", Offset = "0xB0A560", VA = "0xB0A560")]
		public byte GetIndexByte(int index)
		{
			return default(byte);
		}

		[Token(Token = "0x6005325")]
		[Address(RVA = "0xB0A5E4", Offset = "0xB0A5E4", VA = "0xB0A5E4")]
		public uint GetMatchLen(int index, uint distance, uint limit)
		{
			return default(uint);
		}

		[Token(Token = "0x6005326")]
		[Address(RVA = "0xB0A698", Offset = "0xB0A698", VA = "0xB0A698")]
		public uint GetNumAvailableBytes()
		{
			return default(uint);
		}

		[Token(Token = "0x6005327")]
		[Address(RVA = "0xB0A6A8", Offset = "0xB0A6A8", VA = "0xB0A6A8")]
		public void ReduceOffsets(int subValue)
		{
		}

		[Token(Token = "0x6005328")]
		[Address(RVA = "0xB0A6DC", Offset = "0xB0A6DC", VA = "0xB0A6DC")]
		public InWindow()
		{
		}
	}
}
