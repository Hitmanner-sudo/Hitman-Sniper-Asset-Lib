using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A8C")]
	public class ObjectRegistry<T>
	{
		[Token(Token = "0x4003697")]
		[FieldOffset(Offset = "0x0")]
		public static List<T> Register;

		[Token(Token = "0x4003698")]
		[FieldOffset(Offset = "0x0")]
		private static Action<T> ListenerAdded;

		[Token(Token = "0x4003699")]
		[FieldOffset(Offset = "0x0")]
		private static Action<T> ListenerRemoved;

		[Token(Token = "0x140000B8")]
		public static event Action<T> OnListenerAdded
		{
			[Token(Token = "0x6004259")]
			add
			{
			}
			[Token(Token = "0x600425A")]
			remove
			{
			}
		}

		[Token(Token = "0x140000B9")]
		public static event Action<T> OnListenerRemoved
		{
			[Token(Token = "0x600425B")]
			add
			{
			}
			[Token(Token = "0x600425C")]
			remove
			{
			}
		}

		[Token(Token = "0x600425D")]
		public static void Add(T obj)
		{
		}

		[Token(Token = "0x600425E")]
		public static void Remove(T obj)
		{
		}

		[Token(Token = "0x600425F")]
		public ObjectRegistry()
		{
		}
	}
}
