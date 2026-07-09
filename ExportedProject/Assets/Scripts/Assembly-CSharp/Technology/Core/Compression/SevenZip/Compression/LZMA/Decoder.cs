using System.IO;
using Il2CppDummyDll;
using Technology.Core.Compression.SevenZip.Compression.LZ;
using Technology.Core.Compression.SevenZip.Compression.RangeCoder;

namespace Technology.Core.Compression.SevenZip.Compression.LZMA
{
	[Token(Token = "0x2000D64")]
	public class Decoder : ICoder, ISetDecoderProperties
	{
		[Token(Token = "0x2000D65")]
		private class LenDecoder
		{
			[Token(Token = "0x4003FDD")]
			[FieldOffset(Offset = "0x10")]
			private BitDecoder m_Choice;

			[Token(Token = "0x4003FDE")]
			[FieldOffset(Offset = "0x14")]
			private BitDecoder m_Choice2;

			[Token(Token = "0x4003FDF")]
			[FieldOffset(Offset = "0x18")]
			private BitTreeDecoder[] m_LowCoder;

			[Token(Token = "0x4003FE0")]
			[FieldOffset(Offset = "0x20")]
			private BitTreeDecoder[] m_MidCoder;

			[Token(Token = "0x4003FE1")]
			[FieldOffset(Offset = "0x28")]
			private BitTreeDecoder m_HighCoder;

			[Token(Token = "0x4003FE2")]
			[FieldOffset(Offset = "0x38")]
			private uint m_NumPosStates;

			[Token(Token = "0x60052BF")]
			[Address(RVA = "0x86B170", Offset = "0x86B170", VA = "0x86B170")]
			public void Create(uint numPosStates)
			{
			}

			[Token(Token = "0x60052C0")]
			[Address(RVA = "0x86B248", Offset = "0x86B248", VA = "0x86B248")]
			public void Init()
			{
			}

			[Token(Token = "0x60052C1")]
			[Address(RVA = "0x86B300", Offset = "0x86B300", VA = "0x86B300")]
			public uint Decode(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint posState)
			{
				return default(uint);
			}

			[Token(Token = "0x60052C2")]
			[Address(RVA = "0x86B3D8", Offset = "0x86B3D8", VA = "0x86B3D8")]
			public LenDecoder()
			{
			}
		}

		[Token(Token = "0x2000D66")]
		private class LiteralDecoder
		{
			[Token(Token = "0x2000D67")]
			private struct Decoder2
			{
				[Token(Token = "0x4003FE7")]
				[FieldOffset(Offset = "0x0")]
				private BitDecoder[] m_Decoders;

				[Token(Token = "0x60052C9")]
				[Address(RVA = "0xA4562C", Offset = "0xA4562C", VA = "0xA4562C")]
				public void Create()
				{
				}

				[Token(Token = "0x60052CA")]
				[Address(RVA = "0xA45680", Offset = "0xA45680", VA = "0xA45680")]
				public void Init()
				{
				}

				[Token(Token = "0x60052CB")]
				[Address(RVA = "0xA456F0", Offset = "0xA456F0", VA = "0xA456F0")]
				public byte DecodeNormal(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder rangeDecoder)
				{
					return default(byte);
				}

				[Token(Token = "0x60052CC")]
				[Address(RVA = "0xA45764", Offset = "0xA45764", VA = "0xA45764")]
				public byte DecodeWithMatchByte(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder rangeDecoder, byte matchByte)
				{
					return default(byte);
				}
			}

			[Token(Token = "0x4003FE3")]
			[FieldOffset(Offset = "0x10")]
			private Decoder2[] m_Coders;

			[Token(Token = "0x4003FE4")]
			[FieldOffset(Offset = "0x18")]
			private int m_NumPrevBits;

			[Token(Token = "0x4003FE5")]
			[FieldOffset(Offset = "0x1C")]
			private int m_NumPosBits;

			[Token(Token = "0x4003FE6")]
			[FieldOffset(Offset = "0x20")]
			private uint m_PosMask;

			[Token(Token = "0x60052C3")]
			[Address(RVA = "0x86B46C", Offset = "0x86B46C", VA = "0x86B46C")]
			public void Create(int numPosBits, int numPrevBits)
			{
			}

			[Token(Token = "0x60052C4")]
			[Address(RVA = "0x86B55C", Offset = "0x86B55C", VA = "0x86B55C")]
			public void Init()
			{
			}

			[Token(Token = "0x60052C5")]
			[Address(RVA = "0x86B5D8", Offset = "0x86B5D8", VA = "0x86B5D8")]
			private uint GetState(uint pos, byte prevByte)
			{
				return default(uint);
			}

			[Token(Token = "0x60052C6")]
			[Address(RVA = "0x86B600", Offset = "0x86B600", VA = "0x86B600")]
			public byte DecodeNormal(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint pos, byte prevByte)
			{
				return default(byte);
			}

			[Token(Token = "0x60052C7")]
			[Address(RVA = "0x86B664", Offset = "0x86B664", VA = "0x86B664")]
			public byte DecodeWithMatchByte(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder rangeDecoder, uint pos, byte prevByte, byte matchByte)
			{
				return default(byte);
			}

			[Token(Token = "0x60052C8")]
			[Address(RVA = "0x86B6CC", Offset = "0x86B6CC", VA = "0x86B6CC")]
			public LiteralDecoder()
			{
			}
		}

		[Token(Token = "0x4003FCB")]
		[FieldOffset(Offset = "0x10")]
		private OutWindow m_OutWindow;

		[Token(Token = "0x4003FCC")]
		[FieldOffset(Offset = "0x18")]
		private Technology.Core.Compression.SevenZip.Compression.RangeCoder.Decoder m_RangeDecoder;

		[Token(Token = "0x4003FCD")]
		[FieldOffset(Offset = "0x20")]
		private BitDecoder[] m_IsMatchDecoders;

		[Token(Token = "0x4003FCE")]
		[FieldOffset(Offset = "0x28")]
		private BitDecoder[] m_IsRepDecoders;

		[Token(Token = "0x4003FCF")]
		[FieldOffset(Offset = "0x30")]
		private BitDecoder[] m_IsRepG0Decoders;

		[Token(Token = "0x4003FD0")]
		[FieldOffset(Offset = "0x38")]
		private BitDecoder[] m_IsRepG1Decoders;

		[Token(Token = "0x4003FD1")]
		[FieldOffset(Offset = "0x40")]
		private BitDecoder[] m_IsRepG2Decoders;

		[Token(Token = "0x4003FD2")]
		[FieldOffset(Offset = "0x48")]
		private BitDecoder[] m_IsRep0LongDecoders;

		[Token(Token = "0x4003FD3")]
		[FieldOffset(Offset = "0x50")]
		private BitTreeDecoder[] m_PosSlotDecoder;

		[Token(Token = "0x4003FD4")]
		[FieldOffset(Offset = "0x58")]
		private BitDecoder[] m_PosDecoders;

		[Token(Token = "0x4003FD5")]
		[FieldOffset(Offset = "0x60")]
		private BitTreeDecoder m_PosAlignDecoder;

		[Token(Token = "0x4003FD6")]
		[FieldOffset(Offset = "0x70")]
		private LenDecoder m_LenDecoder;

		[Token(Token = "0x4003FD7")]
		[FieldOffset(Offset = "0x78")]
		private LenDecoder m_RepLenDecoder;

		[Token(Token = "0x4003FD8")]
		[FieldOffset(Offset = "0x80")]
		private LiteralDecoder m_LiteralDecoder;

		[Token(Token = "0x4003FD9")]
		[FieldOffset(Offset = "0x88")]
		private uint m_DictionarySize;

		[Token(Token = "0x4003FDA")]
		[FieldOffset(Offset = "0x8C")]
		private uint m_DictionarySizeCheck;

		[Token(Token = "0x4003FDB")]
		[FieldOffset(Offset = "0x90")]
		private uint m_PosStateMask;

		[Token(Token = "0x4003FDC")]
		[FieldOffset(Offset = "0x94")]
		private bool _solid;

		[Token(Token = "0x60052B7")]
		[Address(RVA = "0xAEB250", Offset = "0xAEB250", VA = "0xAEB250")]
		public Decoder()
		{
		}

		[Token(Token = "0x60052B8")]
		[Address(RVA = "0xAEB48C", Offset = "0xAEB48C", VA = "0xAEB48C")]
		private void SetDictionarySize(uint dictionarySize)
		{
		}

		[Token(Token = "0x60052B9")]
		[Address(RVA = "0xAEB54C", Offset = "0xAEB54C", VA = "0xAEB54C")]
		private void SetLiteralProperties(int lp, int lc)
		{
		}

		[Token(Token = "0x60052BA")]
		[Address(RVA = "0xAEB5B8", Offset = "0xAEB5B8", VA = "0xAEB5B8")]
		private void SetPosBitsProperties(int pb)
		{
		}

		[Token(Token = "0x60052BB")]
		[Address(RVA = "0xAEB64C", Offset = "0xAEB64C", VA = "0xAEB64C")]
		private void Init(Stream inStream, Stream outStream)
		{
		}

		[Token(Token = "0x60052BC")]
		[Address(RVA = "0xAEB8E4", Offset = "0xAEB8E4", VA = "0xAEB8E4", Slot = "4")]
		public void Code(Stream inStream, Stream outStream, long inSize, long outSize, ICodeProgress progress)
		{
		}

		[Token(Token = "0x60052BD")]
		[Address(RVA = "0xAEBECC", Offset = "0xAEBECC", VA = "0xAEBECC", Slot = "5")]
		public void SetDecoderProperties(byte[] properties)
		{
		}

		[Token(Token = "0x60052BE")]
		[Address(RVA = "0xAEC000", Offset = "0xAEC000", VA = "0xAEC000")]
		public bool Train(Stream stream)
		{
			return default(bool);
		}
	}
}
