using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001302")]
	internal class ConcurrentQueue<T>
	{
		[Token(Token = "0x4005B1A")]
		[FieldOffset(Offset = "0x0")]
		private readonly object queueLock;

		[Token(Token = "0x4005B1B")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> queue;

		[Token(Token = "0x17000CB1")]
		public int Count
		{
			[Token(Token = "0x6006FA5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6006FA6")]
		public T Peek()
		{
			return (T)null;
		}

		[Token(Token = "0x6006FA7")]
		public void Enqueue(T obj)
		{
		}

		[Token(Token = "0x6006FA8")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x6006FA9")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006FAA")]
		public ConcurrentQueue()
		{
		}
	}
}
