using System.IO;
using Il2CppDummyDll;
using Technology.Core.Compression.SevenZip.Compression.LZ;
using Technology.Core.Compression.SevenZip.Compression.RangeCoder;

namespace Technology.Core.Compression.SevenZip.Compression.LZMA
{
	[Token(Token = "0x2000D68")]
	public class Encoder : ICoder, ISetCoderProperties, IWriteCoderProperties
	{
		[Token(Token = "0x2000D69")]
		private enum EMatchFinderType
		{
			[Token(Token = "0x4004023")]
			BT2 = 0,
			[Token(Token = "0x4004024")]
			BT4 = 1
		}

		[Token(Token = "0x2000D6A")]
		private class LiteralEncoder
		{
			[Token(Token = "0x2000D6B")]
			public struct Encoder2
			{
				[Token(Token = "0x4004029")]
				[FieldOffset(Offset = "0x0")]
				private BitEncoder[] m_Encoders;

				[Token(Token = "0x60052F1")]
				[Address(RVA = "0xA45834", Offset = "0xA45834", VA = "0xA45834")]
				public void Create()
				{
				}

				[Token(Token = "0x60052F2")]
				[Address(RVA = "0xA45888", Offset = "0xA45888", VA = "0xA45888")]
				public void Init()
				{
				}

				[Token(Token = "0x60052F3")]
				[Address(RVA = "0xA458F8", Offset = "0xA458F8", VA = "0xA458F8")]
				public void Encode(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Encoder rangeEncoder, byte symbol)
				{
				}

				[Token(Token = "0x60052F4")]
				[Address(RVA = "0xA4598C", Offset = "0xA4598C", VA = "0xA4598C")]
				public void EncodeMatched(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Encoder rangeEncoder, byte matchByte, byte symbol)
				{
				}

				[Token(Token = "0x60052F5")]
				[Address(RVA = "0xA45A58", Offset = "0xA45A58", VA = "0xA45A58")]
				public uint GetPrice(bool matchMode, byte matchByte, byte symbol)
				{
					return default(uint);
				}
			}

			[Token(Token = "0x4004025")]
			[FieldOffset(Offset = "0x10")]
			private Encoder2[] m_Coders;

			[Token(Token = "0x4004026")]
			[FieldOffset(Offset = "0x18")]
			private int m_NumPrevBits;

			[Token(Token = "0x4004027")]
			[FieldOffset(Offset = "0x1C")]
			private int m_NumPosBits;

			[Token(Token = "0x4004028")]
			[FieldOffset(Offset = "0x20")]
			private uint m_PosMask;

			[Token(Token = "0x60052ED")]
			[Address(RVA = "0x86DDAC", Offset = "0x86DDAC", VA = "0x86DDAC")]
			public void Create(int numPosBits, int numPrevBits)
			{
			}

			[Token(Token = "0x60052EE")]
			[Address(RVA = "0x86DE9C", Offset = "0x86DE9C", VA = "0x86DE9C")]
			public void Init()
			{
			}

			[Token(Token = "0x60052EF")]
			[Address(RVA = "0x86DF18", Offset = "0x86DF18", VA = "0x86DF18")]
			public Encoder2 GetSubCoder(uint pos, byte prevByte)
			{
				return default(Encoder2);
			}

			[Token(Token = "0x60052F0")]
			[Address(RVA = "0x86DF78", Offset = "0x86DF78", VA = "0x86DF78")]
			public LiteralEncoder()
			{
			}
		}

		[Token(Token = "0x2000D6C")]
		private class LenEncoder
		{
			[Token(Token = "0x400402A")]
			[FieldOffset(Offset = "0x10")]
			private BitEncoder _choice;

			[Token(Token = "0x400402B")]
			[FieldOffset(Offset = "0x14")]
			private BitEncoder _choice2;

			[Token(Token = "0x400402C")]
			[FieldOffset(Offset = "0x18")]
			private BitTreeEncoder[] _lowCoder;

			[Token(Token = "0x400402D")]
			[FieldOffset(Offset = "0x20")]
			private BitTreeEncoder[] _midCoder;

			[Token(Token = "0x400402E")]
			[FieldOffset(Offset = "0x28")]
			private BitTreeEncoder _highCoder;

			[Token(Token = "0x60052F6")]
			[Address(RVA = "0x86D720", Offset = "0x86D720", VA = "0x86D720")]
			public LenEncoder()
			{
			}

			[Token(Token = "0x60052F7")]
			[Address(RVA = "0x86D840", Offset = "0x86D840", VA = "0x86D840")]
			public void Init(uint numPosStates)
			{
			}

			[Token(Token = "0x60052F8")]
			[Address(RVA = "0x86D8F8", Offset = "0x86D8F8", VA = "0x86D8F8")]
			public void Encode(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol, uint posState)
			{
			}

			[Token(Token = "0x60052F9")]
			[Address(RVA = "0x86DA00", Offset = "0x86DA00", VA = "0x86DA00")]
			public void SetPrices(uint posState, uint numSymbols, uint[] prices, uint st)
			{
			}
		}

		[Token(Token = "0x2000D6D")]
		private class LenPriceTableEncoder : LenEncoder
		{
			[Token(Token = "0x400402F")]
			[FieldOffset(Offset = "0x38")]
			private uint[] _prices;

			[Token(Token = "0x4004030")]
			[FieldOffset(Offset = "0x40")]
			private uint _tableSize;

			[Token(Token = "0x4004031")]
			[FieldOffset(Offset = "0x48")]
			private uint[] _counters;

			[Token(Token = "0x60052FA")]
			[Address(RVA = "0x86DBDC", Offset = "0x86DBDC", VA = "0x86DBDC")]
			public void SetTableSize(uint tableSize)
			{
			}

			[Token(Token = "0x60052FB")]
			[Address(RVA = "0x86DBE4", Offset = "0x86DBE4", VA = "0x86DBE4")]
			public uint GetPrice(uint symbol, uint posState)
			{
				return default(uint);
			}

			[Token(Token = "0x60052FC")]
			[Address(RVA = "0x86DC28", Offset = "0x86DC28", VA = "0x86DC28")]
			private void UpdateTable(uint posState)
			{
			}

			[Token(Token = "0x60052FD")]
			[Address(RVA = "0x86DC8C", Offset = "0x86DC8C", VA = "0x86DC8C")]
			public void UpdateTables(uint numPosStates)
			{
			}

			[Token(Token = "0x60052FE")]
			[Address(RVA = "0x86DCD4", Offset = "0x86DCD4", VA = "0x86DCD4")]
			public new void Encode(Technology.Core.Compression.SevenZip.Compression.RangeCoder.Encoder rangeEncoder, uint symbol, uint posState)
			{
			}

			[Token(Token = "0x60052FF")]
			[Address(RVA = "0x86DD44", Offset = "0x86DD44", VA = "0x86DD44")]
			public LenPriceTableEncoder()
			{
			}
		}

		[Token(Token = "0x2000D6E")]
		private class Optimal
		{
			[Token(Token = "0x4004032")]
			[FieldOffset(Offset = "0x10")]
			public Base.State State;

			[Token(Token = "0x4004033")]
			[FieldOffset(Offset = "0x14")]
			public bool Prev1IsChar;

			[Token(Token = "0x4004034")]
			[FieldOffset(Offset = "0x15")]
			public bool Prev2;

			[Token(Token = "0x4004035")]
			[FieldOffset(Offset = "0x18")]
			public uint PosPrev2;

			[Token(Token = "0x4004036")]
			[FieldOffset(Offset = "0x1C")]
			public uint BackPrev2;

			[Token(Token = "0x4004037")]
			[FieldOffset(Offset = "0x20")]
			public uint Price;

			[Token(Token = "0x4004038")]
			[FieldOffset(Offset = "0x24")]
			public uint PosPrev;

			[Token(Token = "0x4004039")]
			[FieldOffset(Offset = "0x28")]
			public uint BackPrev;

			[Token(Token = "0x400403A")]
			[FieldOffset(Offset = "0x2C")]
			public uint Backs0;

			[Token(Token = "0x400403B")]
			[FieldOffset(Offset = "0x30")]
			public uint Backs1;

			[Token(Token = "0x400403C")]
			[FieldOffset(Offset = "0x34")]
			public uint Backs2;

			[Token(Token = "0x400403D")]
			[FieldOffset(Offset = "0x38")]
			public uint Backs3;

			[Token(Token = "0x6005300")]
			[Address(RVA = "0x86DF80", Offset = "0x86DF80", VA = "0x86DF80")]
			public void MakeAsChar()
			{
			}

			[Token(Token = "0x6005301")]
			[Address(RVA = "0x86DF90", Offset = "0x86DF90", VA = "0x86DF90")]
			public void MakeAsShortRep()
			{
			}

			[Token(Token = "0x6005302")]
			[Address(RVA = "0x86DF9C", Offset = "0x86DF9C", VA = "0x86DF9C")]
			public bool IsShortRep()
			{
				return default(bool);
			}

			[Token(Token = "0x6005303")]
			[Address(RVA = "0x86DFAC", Offset = "0x86DFAC", VA = "0x86DFAC")]
			public Optimal()
			{
			}
		}

		[Token(Token = "0x4003FE8")]
		private const uint kIfinityPrice = 268435455u;

		[Token(Token = "0x4003FE9")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] g_FastPos;

		[Token(Token = "0x4003FEA")]
		[FieldOffset(Offset = "0x10")]
		private Base.State _state;

		[Token(Token = "0x4003FEB")]
		[FieldOffset(Offset = "0x14")]
		private byte _previousByte;

		[Token(Token = "0x4003FEC")]
		[FieldOffset(Offset = "0x18")]
		private uint[] _repDistances;

		[Token(Token = "0x4003FED")]
		private const int kDefaultDictionaryLogSize = 4;

		[Token(Token = "0x4003FEE")]
		private const uint kNumFastBytesDefault = 32u;

		[Token(Token = "0x4003FEF")]
		private const uint kNumLenSpecSymbols = 16u;

		[Token(Token = "0x4003FF0")]
		private const uint kNumOpts = 4096u;

		[Token(Token = "0x4003FF1")]
		[FieldOffset(Offset = "0x20")]
		private Optimal[] _optimum;

		[Token(Token = "0x4003FF2")]
		[FieldOffset(Offset = "0x28")]
		private IMatchFinder _matchFinder;

		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x30")]
		private Technology.Core.Compression.SevenZip.Compression.RangeCoder.Encoder _rangeEncoder;

		[Token(Token = "0x4003FF4")]
		[FieldOffset(Offset = "0x38")]
		private BitEncoder[] _isMatch;

		[Token(Token = "0x4003FF5")]
		[FieldOffset(Offset = "0x40")]
		private BitEncoder[] _isRep;

		[Token(Token = "0x4003FF6")]
		[FieldOffset(Offset = "0x48")]
		private BitEncoder[] _isRepG0;

		[Token(Token = "0x4003FF7")]
		[FieldOffset(Offset = "0x50")]
		private BitEncoder[] _isRepG1;

		[Token(Token = "0x4003FF8")]
		[FieldOffset(Offset = "0x58")]
		private BitEncoder[] _isRepG2;

		[Token(Token = "0x4003FF9")]
		[FieldOffset(Offset = "0x60")]
		private BitEncoder[] _isRep0Long;

		[Token(Token = "0x4003FFA")]
		[FieldOffset(Offset = "0x68")]
		private BitTreeEncoder[] _posSlotEncoder;

		[Token(Token = "0x4003FFB")]
		[FieldOffset(Offset = "0x70")]
		private BitEncoder[] _posEncoders;

		[Token(Token = "0x4003FFC")]
		[FieldOffset(Offset = "0x78")]
		private BitTreeEncoder _posAlignEncoder;

		[Token(Token = "0x4003FFD")]
		[FieldOffset(Offset = "0x88")]
		private LenPriceTableEncoder _lenEncoder;

		[Token(Token = "0x4003FFE")]
		[FieldOffset(Offset = "0x90")]
		private LenPriceTableEncoder _repMatchLenEncoder;

		[Token(Token = "0x4003FFF")]
		[FieldOffset(Offset = "0x98")]
		private LiteralEncoder _literalEncoder;

		[Token(Token = "0x4004000")]
		[FieldOffset(Offset = "0xA0")]
		private uint[] _matchDistances;

		[Token(Token = "0x4004001")]
		[FieldOffset(Offset = "0xA8")]
		private uint _numFastBytes;

		[Token(Token = "0x4004002")]
		[FieldOffset(Offset = "0xAC")]
		private uint _longestMatchLength;

		[Token(Token = "0x4004003")]
		[FieldOffset(Offset = "0xB0")]
		private uint _numDistancePairs;

		[Token(Token = "0x4004004")]
		[FieldOffset(Offset = "0xB4")]
		private uint _additionalOffset;

		[Token(Token = "0x4004005")]
		[FieldOffset(Offset = "0xB8")]
		private uint _optimumEndIndex;

		[Token(Token = "0x4004006")]
		[FieldOffset(Offset = "0xBC")]
		private uint _optimumCurrentIndex;

		[Token(Token = "0x4004007")]
		[FieldOffset(Offset = "0xC0")]
		private bool _longestMatchWasFound;

		[Token(Token = "0x4004008")]
		[FieldOffset(Offset = "0xC8")]
		private uint[] _posSlotPrices;

		[Token(Token = "0x4004009")]
		[FieldOffset(Offset = "0xD0")]
		private uint[] _distancesPrices;

		[Token(Token = "0x400400A")]
		[FieldOffset(Offset = "0xD8")]
		private uint[] _alignPrices;

		[Token(Token = "0x400400B")]
		[FieldOffset(Offset = "0xE0")]
		private uint _alignPriceCount;

		[Token(Token = "0x400400C")]
		[FieldOffset(Offset = "0xE4")]
		private uint _distTableSize;

		[Token(Token = "0x400400D")]
		[FieldOffset(Offset = "0xE8")]
		private int _posStateBits;

		[Token(Token = "0x400400E")]
		[FieldOffset(Offset = "0xEC")]
		private uint _posStateMask;

		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0xF0")]
		private int _numLiteralPosStateBits;

		[Token(Token = "0x4004010")]
		[FieldOffset(Offset = "0xF4")]
		private int _numLiteralContextBits;

		[Token(Token = "0x4004011")]
		[FieldOffset(Offset = "0xF8")]
		private uint _dictionarySize;

		[Token(Token = "0x4004012")]
		[FieldOffset(Offset = "0xFC")]
		private uint _dictionarySizePrev;

		[Token(Token = "0x4004013")]
		[FieldOffset(Offset = "0x100")]
		private uint _numFastBytesPrev;

		[Token(Token = "0x4004014")]
		[FieldOffset(Offset = "0x108")]
		private long nowPos64;

		[Token(Token = "0x4004015")]
		[FieldOffset(Offset = "0x110")]
		private bool _finished;

		[Token(Token = "0x4004016")]
		[FieldOffset(Offset = "0x118")]
		private Stream _inStream;

		[Token(Token = "0x4004017")]
		[FieldOffset(Offset = "0x120")]
		private EMatchFinderType _matchFinderType;

		[Token(Token = "0x4004018")]
		[FieldOffset(Offset = "0x124")]
		private bool _writeEndMark;

		[Token(Token = "0x4004019")]
		[FieldOffset(Offset = "0x125")]
		private bool _needReleaseMFStream;

		[Token(Token = "0x400401A")]
		[FieldOffset(Offset = "0x128")]
		private uint[] reps;

		[Token(Token = "0x400401B")]
		[FieldOffset(Offset = "0x130")]
		private uint[] repLens;

		[Token(Token = "0x400401C")]
		private const int kPropSize = 5;

		[Token(Token = "0x400401D")]
		[FieldOffset(Offset = "0x138")]
		private byte[] properties;

		[Token(Token = "0x400401E")]
		[FieldOffset(Offset = "0x140")]
		private uint[] tempPrices;

		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x148")]
		private uint _matchPriceCount;

		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x8")]
		private static string[] kMatchFinderIDs;

		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x14C")]
		private uint _trainSize;

		[Token(Token = "0x60052CD")]
		[Address(RVA = "0xE0DAC0", Offset = "0xE0DAC0", VA = "0xE0DAC0")]
		static Encoder()
		{
		}

		[Token(Token = "0x60052CE")]
		[Address(RVA = "0xE0DC9C", Offset = "0xE0DC9C", VA = "0xE0DC9C")]
		private static uint GetPosSlot(uint pos)
		{
			return default(uint);
		}

		[Token(Token = "0x60052CF")]
		[Address(RVA = "0xE0DDC4", Offset = "0xE0DDC4", VA = "0xE0DDC4")]
		private static uint GetPosSlot2(uint pos)
		{
			return default(uint);
		}

		[Token(Token = "0x60052D0")]
		[Address(RVA = "0xE0DEE8", Offset = "0xE0DEE8", VA = "0xE0DEE8")]
		private void BaseInit()
		{
		}

		[Token(Token = "0x60052D1")]
		[Address(RVA = "0xE0DF50", Offset = "0xE0DF50", VA = "0xE0DF50")]
		private void Create()
		{
		}

		[Token(Token = "0x60052D2")]
		[Address(RVA = "0xE0E0B4", Offset = "0xE0E0B4", VA = "0xE0E0B4")]
		public Encoder()
		{
		}

		[Token(Token = "0x60052D3")]
		[Address(RVA = "0xE0E448", Offset = "0xE0E448", VA = "0xE0E448")]
		private void SetWriteEndMarkerMode(bool writeEndMarker)
		{
		}

		[Token(Token = "0x60052D4")]
		[Address(RVA = "0xE0E454", Offset = "0xE0E454", VA = "0xE0E454")]
		private void Init()
		{
		}

		[Token(Token = "0x60052D5")]
		[Address(RVA = "0xE0E6C8", Offset = "0xE0E6C8", VA = "0xE0E6C8")]
		private void ReadMatchDistances(out uint lenRes, out uint numDistancePairs)
		{
		}

		[Token(Token = "0x60052D6")]
		[Address(RVA = "0xE0E8BC", Offset = "0xE0E8BC", VA = "0xE0E8BC")]
		private void MovePos(uint num)
		{
		}

		[Token(Token = "0x60052D7")]
		[Address(RVA = "0xE0E990", Offset = "0xE0E990", VA = "0xE0E990")]
		private uint GetRepLen1Price(Base.State state, uint posState)
		{
			return default(uint);
		}

		[Token(Token = "0x60052D8")]
		[Address(RVA = "0xE0EA20", Offset = "0xE0EA20", VA = "0xE0EA20")]
		private uint GetPureRepPrice(uint repIndex, Base.State state, uint posState)
		{
			return default(uint);
		}

		[Token(Token = "0x60052D9")]
		[Address(RVA = "0xE0EB70", Offset = "0xE0EB70", VA = "0xE0EB70")]
		private uint GetRepPrice(uint repIndex, uint len, Base.State state, uint posState)
		{
			return default(uint);
		}

		[Token(Token = "0x60052DA")]
		[Address(RVA = "0xE0EBE0", Offset = "0xE0EBE0", VA = "0xE0EBE0")]
		private uint GetPosLenPrice(uint pos, uint len, uint posState)
		{
			return default(uint);
		}

		[Token(Token = "0x60052DB")]
		[Address(RVA = "0xE0ED0C", Offset = "0xE0ED0C", VA = "0xE0ED0C")]
		private uint Backward(out uint backRes, uint cur)
		{
			return default(uint);
		}

		[Token(Token = "0x60052DC")]
		[Address(RVA = "0xE0EF50", Offset = "0xE0EF50", VA = "0xE0EF50")]
		private uint GetOptimum(uint position, out uint backRes)
		{
			return default(uint);
		}

		[Token(Token = "0x60052DD")]
		[Address(RVA = "0xE11144", Offset = "0xE11144", VA = "0xE11144")]
		private bool ChangePair(uint smallDist, uint bigDist)
		{
			return default(bool);
		}

		[Token(Token = "0x60052DE")]
		[Address(RVA = "0xE11164", Offset = "0xE11164", VA = "0xE11164")]
		private void WriteEndMarker(uint posState)
		{
		}

		[Token(Token = "0x60052DF")]
		[Address(RVA = "0xE11318", Offset = "0xE11318", VA = "0xE11318")]
		private void Flush(uint nowPos)
		{
		}

		[Token(Token = "0x60052E0")]
		[Address(RVA = "0xE114A0", Offset = "0xE114A0", VA = "0xE114A0")]
		public void CodeOneBlock(out long inSize, out long outSize, out bool finished)
		{
		}

		[Token(Token = "0x60052E1")]
		[Address(RVA = "0xE11390", Offset = "0xE11390", VA = "0xE11390")]
		private void ReleaseMFStream()
		{
		}

		[Token(Token = "0x60052E2")]
		[Address(RVA = "0xE123B4", Offset = "0xE123B4", VA = "0xE123B4")]
		private void SetOutStream(Stream outStream)
		{
		}

		[Token(Token = "0x60052E3")]
		[Address(RVA = "0xE123D0", Offset = "0xE123D0", VA = "0xE123D0")]
		private void ReleaseOutStream()
		{
		}

		[Token(Token = "0x60052E4")]
		[Address(RVA = "0xE123F4", Offset = "0xE123F4", VA = "0xE123F4")]
		private void ReleaseStreams()
		{
		}

		[Token(Token = "0x60052E5")]
		[Address(RVA = "0xE12424", Offset = "0xE12424", VA = "0xE12424")]
		private void SetStreams(Stream inStream, Stream outStream, long inSize, long outSize)
		{
		}

		[Token(Token = "0x60052E6")]
		[Address(RVA = "0xE124DC", Offset = "0xE124DC", VA = "0xE124DC", Slot = "4")]
		public void Code(Stream inStream, Stream outStream, long inSize, long outSize, ICodeProgress progress)
		{
		}

		[Token(Token = "0x60052E7")]
		[Address(RVA = "0xE12638", Offset = "0xE12638", VA = "0xE12638", Slot = "6")]
		public void WriteCoderProperties(Stream outStream)
		{
		}

		[Token(Token = "0x60052E8")]
		[Address(RVA = "0xE12008", Offset = "0xE12008", VA = "0xE12008")]
		private void FillDistancesPrices()
		{
		}

		[Token(Token = "0x60052E9")]
		[Address(RVA = "0xE122F4", Offset = "0xE122F4", VA = "0xE122F4")]
		private void FillAlignPrices()
		{
		}

		[Token(Token = "0x60052EA")]
		[Address(RVA = "0xE126E8", Offset = "0xE126E8", VA = "0xE126E8")]
		private static int FindMatchFinder(string s)
		{
			return default(int);
		}

		[Token(Token = "0x60052EB")]
		[Address(RVA = "0xE127D4", Offset = "0xE127D4", VA = "0xE127D4", Slot = "5")]
		public void SetCoderProperties(CoderPropID[] propIDs, object[] properties)
		{
		}

		[Token(Token = "0x60052EC")]
		[Address(RVA = "0xE12ADC", Offset = "0xE12ADC", VA = "0xE12ADC")]
		public void SetTrainSize(uint trainSize)
		{
		}
	}
}
