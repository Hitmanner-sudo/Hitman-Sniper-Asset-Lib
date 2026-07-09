using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E06")]
	public static class WinRTDirectory
	{
		[Token(Token = "0x600562A")]
		[Address(RVA = "0x87E648", Offset = "0x87E648", VA = "0x87E648")]
		public static void CreateDirectory(string path)
		{
		}

		[Token(Token = "0x600562B")]
		[Address(RVA = "0x87E650", Offset = "0x87E650", VA = "0x87E650")]
		public static string[] GetFiles(string path)
		{
			return null;
		}

		[Token(Token = "0x600562C")]
		[Address(RVA = "0x87E6A4", Offset = "0x87E6A4", VA = "0x87E6A4")]
		public static string[] GetFiles(string path, string search)
		{
			return null;
		}

		[Token(Token = "0x600562D")]
		[Address(RVA = "0x87E6B0", Offset = "0x87E6B0", VA = "0x87E6B0")]
		public static string[] GetFiles(string path, string search, WinRTSearchOption options)
		{
			return null;
		}

		[Token(Token = "0x600562E")]
		[Address(RVA = "0x87E6C0", Offset = "0x87E6C0", VA = "0x87E6C0")]
		internal static string WildcardToRegex(string pattern)
		{
			return null;
		}

		[Token(Token = "0x600562F")]
		[Address(RVA = "0x87E7E0", Offset = "0x87E7E0", VA = "0x87E7E0")]
		public static bool Exists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6005630")]
		[Address(RVA = "0x87E7E8", Offset = "0x87E7E8", VA = "0x87E7E8")]
		public static string GetParent(string path)
		{
			return null;
		}

		[Token(Token = "0x6005631")]
		[Address(RVA = "0x87E810", Offset = "0x87E810", VA = "0x87E810")]
		public static void Delete(string path)
		{
		}
	}
}
