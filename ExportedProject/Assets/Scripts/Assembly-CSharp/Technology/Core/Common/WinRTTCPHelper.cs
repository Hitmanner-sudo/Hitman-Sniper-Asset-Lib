using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E0A")]
	public static class WinRTTCPHelper
	{
		[Token(Token = "0x400425A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SHA256 _sha256;

		[Token(Token = "0x6005643")]
		[Address(RVA = "0x87F334", Offset = "0x87F334", VA = "0x87F334")]
		public static string GetCurrentIPAddress()
		{
			return null;
		}

		[Token(Token = "0x6005644")]
		[Address(RVA = "0x87F3A8", Offset = "0x87F3A8", VA = "0x87F3A8")]
		public static string GetSha256Msg(string strMsg)
		{
			return null;
		}
	}
}
