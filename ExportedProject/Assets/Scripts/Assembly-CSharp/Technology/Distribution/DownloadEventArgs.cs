using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BF5")]
	public class DownloadEventArgs : EventArgs
	{
		[Token(Token = "0x4003BD5")]
		[FieldOffset(Offset = "0x10")]
		public Bundle Bundle;

		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0xC1AFA8", Offset = "0xC1AFA8", VA = "0xC1AFA8")]
		public DownloadEventArgs(Bundle bundle)
		{
		}
	}
}
