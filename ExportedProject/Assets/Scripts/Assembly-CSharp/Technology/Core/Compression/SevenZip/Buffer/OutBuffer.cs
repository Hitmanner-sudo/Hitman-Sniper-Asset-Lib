using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Buffer
{
	[Token(Token = "0x2000D75")]
	public class OutBuffer
	{
		[Token(Token = "0x4004069")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_Buffer;

		[Token(Token = "0x400406A")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Pos;

		[Token(Token = "0x400406B")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_BufferSize;

		[Token(Token = "0x400406C")]
		[FieldOffset(Offset = "0x20")]
		private Stream m_Stream;

		[Token(Token = "0x400406D")]
		[FieldOffset(Offset = "0x28")]
		private ulong m_ProcessedSize;

		[Token(Token = "0x6005339")]
		[Address(RVA = "0x9FEEB0", Offset = "0x9FEEB0", VA = "0x9FEEB0")]
		public OutBuffer(uint bufferSize)
		{
		}

		[Token(Token = "0x600533A")]
		[Address(RVA = "0x9FEF20", Offset = "0x9FEF20", VA = "0x9FEF20")]
		public void SetStream(Stream stream)
		{
		}

		[Token(Token = "0x600533B")]
		[Address(RVA = "0x9FEF28", Offset = "0x9FEF28", VA = "0x9FEF28")]
		public void FlushStream()
		{
		}

		[Token(Token = "0x600533C")]
		[Address(RVA = "0x9FEF4C", Offset = "0x9FEF4C", VA = "0x9FEF4C")]
		public void CloseStream()
		{
		}

		[Token(Token = "0x600533D")]
		[Address(RVA = "0x9FEF58", Offset = "0x9FEF58", VA = "0x9FEF58")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x600533E")]
		[Address(RVA = "0x9FEF60", Offset = "0x9FEF60", VA = "0x9FEF60")]
		public void Init()
		{
		}

		[Token(Token = "0x600533F")]
		[Address(RVA = "0x9FEF6C", Offset = "0x9FEF6C", VA = "0x9FEF6C")]
		public void WriteByte(byte b)
		{
		}

		[Token(Token = "0x6005340")]
		[Address(RVA = "0x9FEFC8", Offset = "0x9FEFC8", VA = "0x9FEFC8")]
		public void FlushData()
		{
		}

		[Token(Token = "0x6005341")]
		[Address(RVA = "0x9FF014", Offset = "0x9FF014", VA = "0x9FF014")]
		public ulong GetProcessedSize()
		{
			return default(ulong);
		}
	}
}
