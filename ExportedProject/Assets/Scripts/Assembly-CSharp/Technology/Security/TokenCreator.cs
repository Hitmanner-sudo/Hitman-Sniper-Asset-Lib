using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C4A")]
	public static class TokenCreator
	{
		[Token(Token = "0x4003C9A")]
		private const uint _byteMask = 255u;

		[Token(Token = "0x4003C9B")]
		private const uint _shortMask = 65535u;

		[Token(Token = "0x4003C9C")]
		[FieldOffset(Offset = "0x0")]
		private static byte _sessionTokenByte;

		[Token(Token = "0x4003C9D")]
		[FieldOffset(Offset = "0x2")]
		private static ushort _sessionTokenShort;

		[Token(Token = "0x4003C9E")]
		[FieldOffset(Offset = "0x4")]
		private static bool _sessionTokenByteGenerated;

		[Token(Token = "0x4003C9F")]
		[FieldOffset(Offset = "0x5")]
		private static bool _sessionTokenShortGenerated;

		[Token(Token = "0x6004D2B")]
		[Address(RVA = "0xAD3258", Offset = "0xAD3258", VA = "0xAD3258")]
		public static byte GetSessionTokenByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0xAD3390", Offset = "0xAD3390", VA = "0xAD3390")]
		public static ushort GetSessionTokenShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0xAD331C", Offset = "0xAD331C", VA = "0xAD331C")]
		public static byte CreateTokenByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0xAD3454", Offset = "0xAD3454", VA = "0xAD3454")]
		public static ushort CreateTokenShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0xAD35C0", Offset = "0xAD35C0", VA = "0xAD35C0")]
		public static bool IsPrime(uint value)
		{
			return default(bool);
		}

		[Token(Token = "0x6004D30")]
		[Address(RVA = "0xAD368C", Offset = "0xAD368C", VA = "0xAD368C")]
		public static byte GetNextPrime(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6004D31")]
		[Address(RVA = "0xAD3558", Offset = "0xAD3558", VA = "0xAD3558")]
		public static ushort GetNextPrime(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6004D32")]
		[Address(RVA = "0xAD36F4", Offset = "0xAD36F4", VA = "0xAD36F4")]
		public static uint GetNextPrime(uint value, uint max)
		{
			return default(uint);
		}
	}
}
