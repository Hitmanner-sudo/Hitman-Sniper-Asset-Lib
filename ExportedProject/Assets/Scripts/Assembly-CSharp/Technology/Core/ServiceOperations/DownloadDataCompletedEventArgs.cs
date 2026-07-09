using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF0")]
	public class DownloadDataCompletedEventArgs : EventArgs
	{
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x10")]
		public bool Cancelled;

		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x18")]
		public Exception Error;

		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0x20")]
		public byte[] Result;

		[Token(Token = "0x6005007")]
		[Address(RVA = "0xC1AF18", Offset = "0xC1AF18", VA = "0xC1AF18")]
		public DownloadDataCompletedEventArgs(byte[] result, bool cancelled, Exception error)
		{
		}
	}
}
