using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CEE")]
	public class DownloadStringCompletedEventArgs : EventArgs
	{
		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x10")]
		public bool Cancelled;

		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x18")]
		public Exception Error;

		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x20")]
		public string Result;

		[Token(Token = "0x6005005")]
		[Address(RVA = "0xC1C06C", Offset = "0xC1C06C", VA = "0xC1C06C")]
		public DownloadStringCompletedEventArgs(string result, bool cancelled, Exception error)
		{
		}
	}
}
