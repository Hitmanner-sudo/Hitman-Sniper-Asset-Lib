using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012D9")]
	internal class LogView : ConsoleBase
	{
		[Token(Token = "0x4005A64")]
		[FieldOffset(Offset = "0x0")]
		private static string datePatt;

		[Token(Token = "0x4005A65")]
		[FieldOffset(Offset = "0x8")]
		private static IList<string> events;

		[Token(Token = "0x6006E16")]
		[Address(RVA = "0x9D9ABC", Offset = "0x9D9ABC", VA = "0x9D9ABC")]
		public static void AddLog(string log)
		{
		}

		[Token(Token = "0x6006E17")]
		[Address(RVA = "0x9D9C3C", Offset = "0x9D9C3C", VA = "0x9D9C3C")]
		protected void OnGUI()
		{
		}

		[Token(Token = "0x6006E18")]
		[Address(RVA = "0x9D9FF8", Offset = "0x9D9FF8", VA = "0x9D9FF8")]
		public LogView()
		{
		}
	}
}
