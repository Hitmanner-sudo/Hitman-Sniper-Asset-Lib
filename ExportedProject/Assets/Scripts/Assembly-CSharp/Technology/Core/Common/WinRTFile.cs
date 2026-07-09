using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E04")]
	public static class WinRTFile
	{
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x87E820", Offset = "0x87E820", VA = "0x87E820")]
		public static void Save(string path, string message, bool append)
		{
		}

		[Token(Token = "0x600561F")]
		[Address(RVA = "0x87EA88", Offset = "0x87EA88", VA = "0x87EA88")]
		public static string Load(string path)
		{
			return null;
		}

		[Token(Token = "0x6005620")]
		[Address(RVA = "0x87EB34", Offset = "0x87EB34", VA = "0x87EB34")]
		public static string[] ReadAllLines(string path)
		{
			return null;
		}

		[Token(Token = "0x6005621")]
		[Address(RVA = "0x87E924", Offset = "0x87E924", VA = "0x87E924")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6005622")]
		[Address(RVA = "0x87EC00", Offset = "0x87EC00", VA = "0x87EC00")]
		public static void AppendAllLines(string path, IEnumerable<string> contents)
		{
		}

		[Token(Token = "0x6005623")]
		[Address(RVA = "0x87E9F4", Offset = "0x87E9F4", VA = "0x87E9F4")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x6005624")]
		[Address(RVA = "0x87EF8C", Offset = "0x87EF8C", VA = "0x87EF8C")]
		public static bool Create(string path, bool replace = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6005625")]
		[Address(RVA = "0x87F014", Offset = "0x87F014", VA = "0x87F014")]
		public static void Move(string oldPath, string newPath)
		{
		}

		[Token(Token = "0x6005626")]
		[Address(RVA = "0x87EB2C", Offset = "0x87EB2C", VA = "0x87EB2C")]
		public static bool Exists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6005627")]
		[Address(RVA = "0x87F01C", Offset = "0x87F01C", VA = "0x87F01C")]
		public static void Delete(string path)
		{
		}

		[Token(Token = "0x6005628")]
		[Address(RVA = "0x87F058", Offset = "0x87F058", VA = "0x87F058")]
		public static string GetFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6005629")]
		[Address(RVA = "0x87F0BC", Offset = "0x87F0BC", VA = "0x87F0BC")]
		public static void RemoveReadOnly(string path)
		{
		}
	}
}
