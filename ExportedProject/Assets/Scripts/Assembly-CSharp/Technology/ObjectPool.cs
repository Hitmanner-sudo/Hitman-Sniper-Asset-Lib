using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A89")]
	public class ObjectPool<T> where T : class
	{
		[Token(Token = "0x2000A8A")]
		public delegate T CreateInstance();

		[Token(Token = "0x2000A8B")]
		public delegate void InstanceAction(T instance);

		[Token(Token = "0x4003692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly LinkedList<T> Active;

		[Token(Token = "0x4003693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Stack<T> _available;

		[Token(Token = "0x4003694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CreateInstance _createDelegate;

		[Token(Token = "0x4003695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly InstanceAction _returnedDelegate;

		[Token(Token = "0x4003696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly InstanceAction _destroyDelegate;

		[Token(Token = "0x600424C")]
		public ObjectPool(CreateInstance creationDelegate, [Optional] InstanceAction returnedDelegate, [Optional] InstanceAction destroyDelegate)
		{
		}

		[Token(Token = "0x600424D")]
		public void PreAllocate(int count)
		{
		}

		[Token(Token = "0x600424E")]
		public T Allocate()
		{
			return null;
		}

		[Token(Token = "0x600424F")]
		public void Return(T instance)
		{
		}

		[Token(Token = "0x6004250")]
		public void Clear()
		{
		}
	}
}
