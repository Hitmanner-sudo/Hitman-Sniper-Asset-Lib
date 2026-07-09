using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Disk
{
	[Token(Token = "0x2000C9E")]
	public static class DiskUtils
	{
		[Token(Token = "0x2000C9F")]
		public enum Type : long
		{
			[Token(Token = "0x4003D58")]
			Byte = 1L,
			[Token(Token = "0x4003D59")]
			Kilobyte = 0x400L,
			[Token(Token = "0x4003D5A")]
			Megabyte = 0x100000L,
			[Token(Token = "0x4003D5B")]
			Gigabyte = 0x40000000L,
			[Token(Token = "0x4003D5C")]
			Terabyte = 0x10000000000L,
			[Token(Token = "0x4003D5D")]
			Petabyte = 0x4000000000000L,
			[Token(Token = "0x4003D5E")]
			Exabyte = 0x1000000000000000L
		}

		[Token(Token = "0x4003D55")]
		[FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x4003D56")]
		[FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass _diskUtilsClass;

		[Token(Token = "0x6004E44")]
		[Address(RVA = "0xC15EE4", Offset = "0xC15EE4", VA = "0xC15EE4")]
		public static long TotalSpace(Type type = Type.Byte)
		{
			return default(long);
		}

		[Token(Token = "0x6004E45")]
		[Address(RVA = "0xC16244", Offset = "0xC16244", VA = "0xC16244")]
		public static long UsableSpace(Type type = Type.Byte)
		{
			return default(long);
		}

		[Token(Token = "0x6004E46")]
		[Address(RVA = "0xC163C4", Offset = "0xC163C4", VA = "0xC163C4")]
		public static long FreeSpace(Type type = Type.Byte)
		{
			return default(long);
		}

		[Token(Token = "0x6004E47")]
		[Address(RVA = "0xC16544", Offset = "0xC16544", VA = "0xC16544")]
		public static long OccupiedSpace(Type type = Type.Byte)
		{
			return default(long);
		}

		[Token(Token = "0x6004E48")]
		[Address(RVA = "0xC166C4", Offset = "0xC166C4", VA = "0xC166C4")]
		public static long UnusableSpace(Type type = Type.Byte)
		{
			return default(long);
		}

		[Token(Token = "0x6004E49")]
		[Address(RVA = "0xC16064", Offset = "0xC16064", VA = "0xC16064")]
		private static void Initialize()
		{
		}
	}
}
