using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001320")]
	public static class Utils
	{
		[Token(Token = "0x600707E")]
		public static Dictionary<K, V> HashtableToDictionary<K, V>(Hashtable table)
		{
			return null;
		}

		[Token(Token = "0x600707F")]
		public static Dictionary<K, V> HashtableToDictionary<K, V>(Dictionary<K, V> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6007080")]
		[Address(RVA = "0xBA2A10", Offset = "0xBA2A10", VA = "0xBA2A10")]
		public static byte[] ComputeMD5Hash(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6007081")]
		[Address(RVA = "0xBA2A7C", Offset = "0xBA2A7C", VA = "0xBA2A7C")]
		public static bool IsDirectoryWritable(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6007082")]
		[Address(RVA = "0xBA2D7C", Offset = "0xBA2D7C", VA = "0xBA2D7C")]
		public static bool FileExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6007083")]
		[Address(RVA = "0xBA2C30", Offset = "0xBA2C30", VA = "0xBA2C30")]
		public static bool DirectoryExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6007084")]
		[Address(RVA = "0xBA2CD8", Offset = "0xBA2CD8", VA = "0xBA2CD8")]
		public static void CreateDirectory(string path)
		{
		}

		[Token(Token = "0x6007085")]
		[Address(RVA = "0xBA2E24", Offset = "0xBA2E24", VA = "0xBA2E24")]
		public static Stream CreateStream(string path)
		{
			return null;
		}

		[Token(Token = "0x6007086")]
		[Address(RVA = "0xBA2F94", Offset = "0xBA2F94", VA = "0xBA2F94")]
		public static Stream OpenStream(string path)
		{
			return null;
		}

		[Token(Token = "0x6007087")]
		[Address(RVA = "0xBA3104", Offset = "0xBA3104", VA = "0xBA3104")]
		public static string FixURL(string url)
		{
			return null;
		}

		[Token(Token = "0x6007088")]
		public static T GetOrDefault<T, K>(this IDictionary<K, object> dict, K key, T def)
		{
			return (T)null;
		}
	}
}
