using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BF1")]
	public static class DLCValidator
	{
		[Token(Token = "0x4003BC8")]
		public const string ERROR_STRING = "ERROR";

		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0xADB408", Offset = "0xADB408", VA = "0xADB408")]
		public static bool IsValid(int value, Type l_enumType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0xADB4B0", Offset = "0xADB4B0", VA = "0xADB4B0")]
		public static bool IsValid(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0xADBE98", Offset = "0xADBE98", VA = "0xADBE98")]
		public static bool IsValid(uint value)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0xADBEA0", Offset = "0xADBEA0", VA = "0xADBEA0")]
		public static ValidatorState IsValid(DLCConfiguration l_dlcconfig)
		{
			return null;
		}
	}
}
