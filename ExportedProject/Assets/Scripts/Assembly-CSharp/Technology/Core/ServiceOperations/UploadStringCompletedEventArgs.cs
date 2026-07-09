using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CEF")]
	public class UploadStringCompletedEventArgs : EventArgs
	{
		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x10")]
		public bool Cancelled;

		[Token(Token = "0x4003E0C")]
		[FieldOffset(Offset = "0x18")]
		public Exception Error;

		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x20")]
		public string Result;

		[Token(Token = "0x6005006")]
		[Address(RVA = "0xBA190C", Offset = "0xBA190C", VA = "0xBA190C")]
		public UploadStringCompletedEventArgs(string result, bool cancelled, Exception error)
		{
		}
	}
}
