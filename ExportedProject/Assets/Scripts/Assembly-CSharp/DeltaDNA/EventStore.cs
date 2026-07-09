using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200130B")]
	public class EventStore : IDisposable
	{
		[Token(Token = "0x4005B42")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PF_KEY_IN_FILE;

		[Token(Token = "0x4005B43")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string PF_KEY_OUT_FILE;

		[Token(Token = "0x4005B44")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string FILE_A;

		[Token(Token = "0x4005B45")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string FILE_B;

		[Token(Token = "0x4005B46")]
		[FieldOffset(Offset = "0x20")]
		private static readonly long MAX_FILE_SIZE_BYTES;

		[Token(Token = "0x4005B47")]
		[FieldOffset(Offset = "0x10")]
		private bool _initialised;

		[Token(Token = "0x4005B48")]
		[FieldOffset(Offset = "0x11")]
		private bool _disposed;

		[Token(Token = "0x4005B49")]
		[FieldOffset(Offset = "0x18")]
		private Stream _infs;

		[Token(Token = "0x4005B4A")]
		[FieldOffset(Offset = "0x20")]
		private Stream _outfs;

		[Token(Token = "0x4005B4B")]
		[FieldOffset(Offset = "0x28")]
		private static object _lock;

		[Token(Token = "0x17000CB7")]
		public bool IsInitialised
		{
			[Token(Token = "0x6006FD4")]
			[Address(RVA = "0xE188C0", Offset = "0xE188C0", VA = "0xE188C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0xE18440", Offset = "0xE18440", VA = "0xE18440")]
		public EventStore(string dir)
		{
		}

		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0xE188C8", Offset = "0xE188C8", VA = "0xE188C8")]
		public bool Push(string obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0xE18C48", Offset = "0xE18C48", VA = "0xE18C48")]
		public bool Swap()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0xE18F78", Offset = "0xE18F78", VA = "0xE18F78")]
		public List<string> Read()
		{
			return null;
		}

		[Token(Token = "0x6006FD8")]
		[Address(RVA = "0xE195C8", Offset = "0xE195C8", VA = "0xE195C8")]
		public void ClearOut()
		{
		}

		[Token(Token = "0x6006FD9")]
		[Address(RVA = "0xE19700", Offset = "0xE19700", VA = "0xE19700")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0xE19844", Offset = "0xE19844", VA = "0xE19844")]
		public void FlushBuffers()
		{
		}

		[Token(Token = "0x6006FDB")]
		[Address(RVA = "0xE19994", Offset = "0xE19994", VA = "0xE19994", Slot = "1")]
		~EventStore()
		{
		}

		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0xE19A08", Offset = "0xE19A08", VA = "0xE19A08", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006FDD")]
		[Address(RVA = "0xE19A80", Offset = "0xE19A80", VA = "0xE19A80", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0xE18548", Offset = "0xE18548", VA = "0xE18548")]
		private bool InitialiseFileStreams(string dir)
		{
			return default(bool);
		}

		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0xE18A74", Offset = "0xE18A74", VA = "0xE18A74")]
		public static bool PushEvent(string obj, Stream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0xE19258", Offset = "0xE19258", VA = "0xE19258")]
		public static void ReadEvents(Stream stream, IList<string> events)
		{
		}

		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0xE18ED4", Offset = "0xE18ED4", VA = "0xE18ED4")]
		public static void SwapStreams(ref Stream sin, ref Stream sout)
		{
		}

		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0xE1955C", Offset = "0xE1955C", VA = "0xE1955C")]
		public static void ClearStream(Stream stream)
		{
		}
	}
}
