using Il2CppDummyDll;
using UnityEngine;

namespace Helpshift
{
	[Token(Token = "0x20012CE")]
	public class HelpshiftInternalLogger
	{
		[Token(Token = "0x4005A20")]
		[FieldOffset(Offset = "0x0")]
		private static string TAG;

		[Token(Token = "0x4005A21")]
		[FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass hsInternalLogger;

		[Token(Token = "0x6006DA6")]
		[Address(RVA = "0xA0C908", Offset = "0xA0C908", VA = "0xA0C908")]
		public static void d(string message)
		{
		}

		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0xA117C8", Offset = "0xA117C8", VA = "0xA117C8")]
		public static void e(string message)
		{
		}

		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0xA118FC", Offset = "0xA118FC", VA = "0xA118FC")]
		public static void w(string message)
		{
		}

		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0xA11A30", Offset = "0xA11A30", VA = "0xA11A30")]
		public static void f(string message)
		{
		}

		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0xA11B64", Offset = "0xA11B64", VA = "0xA11B64")]
		public HelpshiftInternalLogger()
		{
		}
	}
}
