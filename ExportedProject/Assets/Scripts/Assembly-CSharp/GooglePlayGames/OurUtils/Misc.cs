using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x20009D6")]
	public static class Misc
	{
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x9C360C", Offset = "0x9C360C", VA = "0x9C360C")]
		public static bool BuffersAreIdentical(byte[] a, byte[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x9C3690", Offset = "0x9C3690", VA = "0x9C3690")]
		public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x6003E53")]
		public static T CheckNotNull<T>(T value)
		{
			return (T)null;
		}

		[Token(Token = "0x6003E54")]
		public static T CheckNotNull<T>(T value, string paramName)
		{
			return (T)null;
		}

		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x9C37E0", Offset = "0x9C37E0", VA = "0x9C37E0")]
		public static bool IsApiException(AndroidJavaObject exception)
		{
			return default(bool);
		}
	}
}
