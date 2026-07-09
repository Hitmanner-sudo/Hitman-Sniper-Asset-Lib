using System;
using System.IO;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000C01")]
	public sealed class MemoryStreamStringBuilder : IDisposable
	{
		[Token(Token = "0x4003BF4")]
		[FieldOffset(Offset = "0x10")]
		private MemoryStream _ms;

		[Token(Token = "0x4003BF5")]
		[FieldOffset(Offset = "0x18")]
		private StreamWriter _sw;

		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x9BA254", Offset = "0x9BA254", VA = "0x9BA254")]
		public MemoryStreamStringBuilder(int capacity)
		{
		}

		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x9BA2FC", Offset = "0x9BA2FC", VA = "0x9BA2FC")]
		public void WriteLine(string content)
		{
		}

		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x9BA320", Offset = "0x9BA320", VA = "0x9BA320")]
		public void Flush()
		{
		}

		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0x9BA340", Offset = "0x9BA340", VA = "0x9BA340")]
		public MemoryStream GetStream()
		{
			return null;
		}

		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x9BA348", Offset = "0x9BA348", VA = "0x9BA348", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
