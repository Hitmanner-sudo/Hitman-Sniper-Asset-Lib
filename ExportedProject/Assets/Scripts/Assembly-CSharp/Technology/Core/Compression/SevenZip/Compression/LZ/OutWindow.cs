using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZ
{
	[Token(Token = "0x2000D73")]
	public class OutWindow
	{
		[Token(Token = "0x400405C")]
		[FieldOffset(Offset = "0x10")]
		private byte[] _buffer;

		[Token(Token = "0x400405D")]
		[FieldOffset(Offset = "0x18")]
		private uint _pos;

		[Token(Token = "0x400405E")]
		[FieldOffset(Offset = "0x1C")]
		private uint _windowSize;

		[Token(Token = "0x400405F")]
		[FieldOffset(Offset = "0x20")]
		private uint _streamPos;

		[Token(Token = "0x4004060")]
		[FieldOffset(Offset = "0x28")]
		private Stream _stream;

		[Token(Token = "0x4004061")]
		[FieldOffset(Offset = "0x30")]
		public uint TrainSize;

		[Token(Token = "0x6005329")]
		[Address(RVA = "0x8F3528", Offset = "0x8F3528", VA = "0x8F3528")]
		public void Create(uint windowSize)
		{
		}

		[Token(Token = "0x600532A")]
		[Address(RVA = "0x8F359C", Offset = "0x8F359C", VA = "0x8F359C")]
		public void Init(Stream stream, bool solid)
		{
		}

		[Token(Token = "0x600532B")]
		[Address(RVA = "0x8F3604", Offset = "0x8F3604", VA = "0x8F3604")]
		public bool Train(Stream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x600532C")]
		[Address(RVA = "0x8F35E0", Offset = "0x8F35E0", VA = "0x8F35E0")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x600532D")]
		[Address(RVA = "0x8F36E0", Offset = "0x8F36E0", VA = "0x8F36E0")]
		public void Flush()
		{
		}

		[Token(Token = "0x600532E")]
		[Address(RVA = "0x8F3744", Offset = "0x8F3744", VA = "0x8F3744")]
		public void CopyBlock(uint distance, uint len)
		{
		}

		[Token(Token = "0x600532F")]
		[Address(RVA = "0x8F380C", Offset = "0x8F380C", VA = "0x8F380C")]
		public void PutByte(byte b)
		{
		}

		[Token(Token = "0x6005330")]
		[Address(RVA = "0x8F3868", Offset = "0x8F3868", VA = "0x8F3868")]
		public byte GetByte(uint distance)
		{
			return default(byte);
		}

		[Token(Token = "0x6005331")]
		[Address(RVA = "0x8F38BC", Offset = "0x8F38BC", VA = "0x8F38BC")]
		public OutWindow()
		{
		}
	}
}
