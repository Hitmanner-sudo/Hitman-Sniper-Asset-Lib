using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Buffer
{
	[Token(Token = "0x2000D74")]
	public class InBuffer
	{
		[Token(Token = "0x4004062")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_Buffer;

		[Token(Token = "0x4004063")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Pos;

		[Token(Token = "0x4004064")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_Limit;

		[Token(Token = "0x4004065")]
		[FieldOffset(Offset = "0x20")]
		private uint m_BufferSize;

		[Token(Token = "0x4004066")]
		[FieldOffset(Offset = "0x28")]
		private Stream m_Stream;

		[Token(Token = "0x4004067")]
		[FieldOffset(Offset = "0x30")]
		private bool m_StreamWasExhausted;

		[Token(Token = "0x4004068")]
		[FieldOffset(Offset = "0x38")]
		private ulong m_ProcessedSize;

		[Token(Token = "0x6005332")]
		[Address(RVA = "0xA19924", Offset = "0xA19924", VA = "0xA19924")]
		public InBuffer(uint bufferSize)
		{
		}

		[Token(Token = "0x6005333")]
		[Address(RVA = "0xA19994", Offset = "0xA19994", VA = "0xA19994")]
		public void Init(Stream stream)
		{
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0xA199A8", Offset = "0xA199A8", VA = "0xA199A8")]
		public bool ReadBlock()
		{
			return default(bool);
		}

		[Token(Token = "0x6005335")]
		[Address(RVA = "0xA19A20", Offset = "0xA19A20", VA = "0xA19A20")]
		public void ReleaseStream()
		{
		}

		[Token(Token = "0x6005336")]
		[Address(RVA = "0xA19A28", Offset = "0xA19A28", VA = "0xA19A28")]
		public bool ReadByte(byte b)
		{
			return default(bool);
		}

		[Token(Token = "0x6005337")]
		[Address(RVA = "0xA19A98", Offset = "0xA19A98", VA = "0xA19A98")]
		public byte ReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6005338")]
		[Address(RVA = "0xA19B0C", Offset = "0xA19B0C", VA = "0xA19B0C")]
		public ulong GetProcessedSize()
		{
			return default(ulong);
		}
	}
}
