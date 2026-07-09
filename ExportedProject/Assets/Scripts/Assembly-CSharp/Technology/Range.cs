using System;
using Il2CppDummyDll;

namespace Technology
{
	[Serializable]
	[Token(Token = "0x2000A85")]
	public class Range
	{
		[Token(Token = "0x400368F")]
		[FieldOffset(Offset = "0x10")]
		public float Min;

		[Token(Token = "0x4003690")]
		[FieldOffset(Offset = "0x14")]
		public float Max;

		[Token(Token = "0x600423F")]
		[Address(RVA = "0xB3F0B8", Offset = "0xB3F0B8", VA = "0xB3F0B8")]
		public Range()
		{
		}

		[Token(Token = "0x6004240")]
		[Address(RVA = "0xB3F0E8", Offset = "0xB3F0E8", VA = "0xB3F0E8")]
		public Range(float min, float max)
		{
		}

		[Token(Token = "0x6004241")]
		[Address(RVA = "0xB3F120", Offset = "0xB3F120", VA = "0xB3F120")]
		public float GetRandom()
		{
			return default(float);
		}

		[Token(Token = "0x6004242")]
		[Address(RVA = "0xB3F12C", Offset = "0xB3F12C", VA = "0xB3F12C")]
		public bool Contains(float value)
		{
			return default(bool);
		}
	}
}
