using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C86")]
	public abstract class ComponentController<T> where T : IArmoryComponent
	{
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x0")]
		private T _active;

		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x0")]
		protected readonly Dictionary<Type, T> _components;

		[Token(Token = "0x170009F0")]
		public T Active
		{
			[Token(Token = "0x6004E00")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170009F1")]
		public Dictionary<Type, T> Components
		{
			[Token(Token = "0x6004E01")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000142")]
		public event EventHandler OnComponentChange
		{
			[Token(Token = "0x6004DFE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A10", Offset = "0x628A10")]
			add
			{
			}
			[Token(Token = "0x6004DFF")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628A20", Offset = "0x628A20")]
			remove
			{
			}
		}

		[Token(Token = "0x6004E02")]
		public void Register(T component)
		{
		}

		[Token(Token = "0x6004E03")]
		public bool Unregister<T2>() where T2 : T
		{
			return default(bool);
		}

		[Token(Token = "0x6004E04")]
		public bool Unregister(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E05")]
		public bool Contains<T2>() where T2 : T
		{
			return default(bool);
		}

		[Token(Token = "0x6004E06")]
		public bool Contains(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E07")]
		public bool Contains(T component)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E08")]
		public void SetActive<T2>() where T2 : T
		{
		}

		[Token(Token = "0x6004E09")]
		public void SetActive(Type type)
		{
		}

		[Token(Token = "0x6004E0A")]
		public void SetActive(T component)
		{
		}

		[Token(Token = "0x6004E0B")]
		protected ComponentController()
		{
		}
	}
}
