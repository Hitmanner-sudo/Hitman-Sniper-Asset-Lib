using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZMA
{
	[Token(Token = "0x2000D62")]
	internal abstract class Base
	{
		[Token(Token = "0x2000D63")]
		public struct State
		{
			[Token(Token = "0x4003FCA")]
			[FieldOffset(Offset = "0x0")]
			public uint Index;

			[Token(Token = "0x60052B1")]
			[Address(RVA = "0x925EDC", Offset = "0x925EDC", VA = "0x925EDC")]
			public void Init()
			{
			}

			[Token(Token = "0x60052B2")]
			[Address(RVA = "0x925EE4", Offset = "0x925EE4", VA = "0x925EE4")]
			public void UpdateChar()
			{
			}

			[Token(Token = "0x60052B3")]
			[Address(RVA = "0x925F14", Offset = "0x925F14", VA = "0x925F14")]
			public void UpdateMatch()
			{
			}

			[Token(Token = "0x60052B4")]
			[Address(RVA = "0x925F30", Offset = "0x925F30", VA = "0x925F30")]
			public void UpdateRep()
			{
			}

			[Token(Token = "0x60052B5")]
			[Address(RVA = "0x925F4C", Offset = "0x925F4C", VA = "0x925F4C")]
			public void UpdateShortRep()
			{
			}

			[Token(Token = "0x60052B6")]
			[Address(RVA = "0x925F68", Offset = "0x925F68", VA = "0x925F68")]
			public bool IsCharState()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003FAF")]
		public const uint kNumRepDistances = 4u;

		[Token(Token = "0x4003FB0")]
		public const uint kNumStates = 12u;

		[Token(Token = "0x4003FB1")]
		public const int kNumPosSlotBits = 6;

		[Token(Token = "0x4003FB2")]
		public const int kDicLogSizeMin = 0;

		[Token(Token = "0x4003FB3")]
		public const int kNumLenToPosStatesBits = 2;

		[Token(Token = "0x4003FB4")]
		public const uint kNumLenToPosStates = 4u;

		[Token(Token = "0x4003FB5")]
		public const uint kMatchMinLen = 2u;

		[Token(Token = "0x4003FB6")]
		public const int kNumAlignBits = 4;

		[Token(Token = "0x4003FB7")]
		public const uint kAlignTableSize = 16u;

		[Token(Token = "0x4003FB8")]
		public const uint kAlignMask = 15u;

		[Token(Token = "0x4003FB9")]
		public const uint kStartPosModelIndex = 4u;

		[Token(Token = "0x4003FBA")]
		public const uint kEndPosModelIndex = 14u;

		[Token(Token = "0x4003FBB")]
		public const uint kNumPosModels = 10u;

		[Token(Token = "0x4003FBC")]
		public const uint kNumFullDistances = 128u;

		[Token(Token = "0x4003FBD")]
		public const uint kNumLitPosStatesBitsEncodingMax = 4u;

		[Token(Token = "0x4003FBE")]
		public const uint kNumLitContextBitsMax = 8u;

		[Token(Token = "0x4003FBF")]
		public const int kNumPosStatesBitsMax = 4;

		[Token(Token = "0x4003FC0")]
		public const uint kNumPosStatesMax = 16u;

		[Token(Token = "0x4003FC1")]
		public const int kNumPosStatesBitsEncodingMax = 4;

		[Token(Token = "0x4003FC2")]
		public const uint kNumPosStatesEncodingMax = 16u;

		[Token(Token = "0x4003FC3")]
		public const int kNumLowLenBits = 3;

		[Token(Token = "0x4003FC4")]
		public const int kNumMidLenBits = 3;

		[Token(Token = "0x4003FC5")]
		public const int kNumHighLenBits = 8;

		[Token(Token = "0x4003FC6")]
		public const uint kNumLowLenSymbols = 8u;

		[Token(Token = "0x4003FC7")]
		public const uint kNumMidLenSymbols = 8u;

		[Token(Token = "0x4003FC8")]
		public const uint kNumLenSymbols = 272u;

		[Token(Token = "0x4003FC9")]
		public const uint kMatchMaxLen = 273u;

		[Token(Token = "0x60052AF")]
		[Address(RVA = "0xC0CC20", Offset = "0xC0CC20", VA = "0xC0CC20")]
		public static uint GetLenToPosState(uint len)
		{
			return default(uint);
		}

		[Token(Token = "0x60052B0")]
		[Address(RVA = "0xC0CC34", Offset = "0xC0CC34", VA = "0xC0CC34")]
		protected Base()
		{
		}
	}
}
