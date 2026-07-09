using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZ
{
	[Token(Token = "0x2000D71")]
	public class BinTree : InWindow, IMatchFinder, IInWindowStream
	{
		[Token(Token = "0x400403E")]
		[FieldOffset(Offset = "0x44")]
		private uint _cyclicBufferPos;

		[Token(Token = "0x400403F")]
		[FieldOffset(Offset = "0x48")]
		private uint _cyclicBufferSize;

		[Token(Token = "0x4004040")]
		[FieldOffset(Offset = "0x4C")]
		private uint _matchMaxLen;

		[Token(Token = "0x4004041")]
		[FieldOffset(Offset = "0x50")]
		private uint[] _son;

		[Token(Token = "0x4004042")]
		[FieldOffset(Offset = "0x58")]
		private uint[] _hash;

		[Token(Token = "0x4004043")]
		[FieldOffset(Offset = "0x60")]
		private uint _cutValue;

		[Token(Token = "0x4004044")]
		[FieldOffset(Offset = "0x64")]
		private uint _hashMask;

		[Token(Token = "0x4004045")]
		[FieldOffset(Offset = "0x68")]
		private uint _hashSizeSum;

		[Token(Token = "0x4004046")]
		[FieldOffset(Offset = "0x6C")]
		private bool HASH_ARRAY;

		[Token(Token = "0x4004047")]
		private const uint kHash2Size = 1024u;

		[Token(Token = "0x4004048")]
		private const uint kHash3Size = 65536u;

		[Token(Token = "0x4004049")]
		private const uint kBT2HashSize = 65536u;

		[Token(Token = "0x400404A")]
		private const uint kStartMaxLen = 1u;

		[Token(Token = "0x400404B")]
		private const uint kHash3Offset = 1024u;

		[Token(Token = "0x400404C")]
		private const uint kEmptyHashValue = 0u;

		[Token(Token = "0x400404D")]
		private const uint kMaxValForNormalize = 2147483647u;

		[Token(Token = "0x400404E")]
		[FieldOffset(Offset = "0x70")]
		private uint kNumHashDirectBytes;

		[Token(Token = "0x400404F")]
		[FieldOffset(Offset = "0x74")]
		private uint kMinMatchCheck;

		[Token(Token = "0x4004050")]
		[FieldOffset(Offset = "0x78")]
		private uint kFixHashSize;

		[Token(Token = "0x600530D")]
		[Address(RVA = "0xC645C8", Offset = "0xC645C8", VA = "0xC645C8")]
		public void SetType(int numHashBytes)
		{
		}

		[Token(Token = "0x600530E")]
		[Address(RVA = "0xC645FC", Offset = "0xC645FC", VA = "0xC645FC", Slot = "8")]
		public new void SetStream(Stream stream)
		{
		}

		[Token(Token = "0x600530F")]
		[Address(RVA = "0xC64604", Offset = "0xC64604", VA = "0xC64604", Slot = "10")]
		public new void ReleaseStream()
		{
		}

		[Token(Token = "0x6005310")]
		[Address(RVA = "0xC6460C", Offset = "0xC6460C", VA = "0xC6460C", Slot = "9")]
		public new void Init()
		{
		}

		[Token(Token = "0x6005311")]
		[Address(RVA = "0xC64688", Offset = "0xC64688", VA = "0xC64688")]
		public new void MovePos()
		{
		}

		[Token(Token = "0x6005312")]
		[Address(RVA = "0xC64734", Offset = "0xC64734", VA = "0xC64734", Slot = "11")]
		public new byte GetIndexByte(int index)
		{
			return default(byte);
		}

		[Token(Token = "0x6005313")]
		[Address(RVA = "0xC6473C", Offset = "0xC6473C", VA = "0xC6473C", Slot = "12")]
		public new uint GetMatchLen(int index, uint distance, uint limit)
		{
			return default(uint);
		}

		[Token(Token = "0x6005314")]
		[Address(RVA = "0xC64744", Offset = "0xC64744", VA = "0xC64744", Slot = "13")]
		public new uint GetNumAvailableBytes()
		{
			return default(uint);
		}

		[Token(Token = "0x6005315")]
		[Address(RVA = "0xC6474C", Offset = "0xC6474C", VA = "0xC6474C", Slot = "5")]
		public void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter)
		{
		}

		[Token(Token = "0x6005316")]
		[Address(RVA = "0xC648B4", Offset = "0xC648B4", VA = "0xC648B4", Slot = "6")]
		public uint GetMatches(uint[] distances)
		{
			return default(uint);
		}

		[Token(Token = "0x6005317")]
		[Address(RVA = "0xC6508C", Offset = "0xC6508C", VA = "0xC6508C", Slot = "7")]
		public void Skip(uint num)
		{
		}

		[Token(Token = "0x6005318")]
		[Address(RVA = "0xC65590", Offset = "0xC65590", VA = "0xC65590")]
		private void NormalizeLinks(uint[] items, uint numItems, uint subValue)
		{
		}

		[Token(Token = "0x6005319")]
		[Address(RVA = "0xC646E0", Offset = "0xC646E0", VA = "0xC646E0")]
		private void Normalize()
		{
		}

		[Token(Token = "0x600531A")]
		[Address(RVA = "0xC655F0", Offset = "0xC655F0", VA = "0xC655F0")]
		public void SetCutValue(uint cutValue)
		{
		}

		[Token(Token = "0x600531B")]
		[Address(RVA = "0xC655F8", Offset = "0xC655F8", VA = "0xC655F8")]
		public BinTree()
		{
		}
	}
}
