using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C75")]
	public class TriggerEvent
	{
		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDB94", Offset = "0x5BDB94")]
		private bool _003CTriggered_003Ek__BackingField;

		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x20")]
		private object _sender;

		[Token(Token = "0x170009E3")]
		public bool Triggered
		{
			[Token(Token = "0x6004DA8")]
			[Address(RVA = "0xC9E960", Offset = "0xC9E960", VA = "0xC9E960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628890", Offset = "0x628890")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004DA9")]
			[Address(RVA = "0xC9E968", Offset = "0xC9E968", VA = "0xC9E968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288A0", Offset = "0x6288A0")]
			private set
			{
			}
		}

		[Token(Token = "0x14000140")]
		private event EventHandler _event
		{
			[Token(Token = "0x6004DA6")]
			[Address(RVA = "0xC9E820", Offset = "0xC9E820", VA = "0xC9E820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628870", Offset = "0x628870")]
			add
			{
			}
			[Token(Token = "0x6004DA7")]
			[Address(RVA = "0xC9E8C0", Offset = "0xC9E8C0", VA = "0xC9E8C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628880", Offset = "0x628880")]
			remove
			{
			}
		}

		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0xC9E974", Offset = "0xC9E974", VA = "0xC9E974")]
		public void Add(EventHandler c2)
		{
		}

		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0xC9EA20", Offset = "0xC9EA20", VA = "0xC9EA20")]
		public void Remove(EventHandler c2)
		{
		}

		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0xC9EA24", Offset = "0xC9EA24", VA = "0xC9EA24")]
		public static TriggerEvent operator +(TriggerEvent c1, EventHandler c2)
		{
			return null;
		}

		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0xC9EB04", Offset = "0xC9EB04", VA = "0xC9EB04")]
		public static TriggerEvent operator -(TriggerEvent c1, EventHandler c2)
		{
			return null;
		}

		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0xC9EB34", Offset = "0xC9EB34", VA = "0xC9EB34")]
		public void Trigger(object sender)
		{
		}

		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0xC9EBC4", Offset = "0xC9EBC4", VA = "0xC9EBC4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0xC9EAFC", Offset = "0xC9EAFC", VA = "0xC9EAFC")]
		public TriggerEvent()
		{
		}
	}
	[Token(Token = "0x2000C76")]
	public class TriggerEvent<T> where T : EventArgs
	{
		[Token(Token = "0x4003CE7")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDBB4", Offset = "0x5BDBB4")]
		private bool _003CTriggered_003Ek__BackingField;

		[Token(Token = "0x4003CE8")]
		[FieldOffset(Offset = "0x0")]
		private object _sender;

		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x0")]
		private T _args;

		[Token(Token = "0x170009E4")]
		public bool Triggered
		{
			[Token(Token = "0x6004DB3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288D0", Offset = "0x6288D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288E0", Offset = "0x6288E0")]
			private set
			{
			}
		}

		[Token(Token = "0x14000141")]
		private event EventHandler<T> _event
		{
			[Token(Token = "0x6004DB1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288B0", Offset = "0x6288B0")]
			add
			{
			}
			[Token(Token = "0x6004DB2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288C0", Offset = "0x6288C0")]
			remove
			{
			}
		}

		[Token(Token = "0x6004DB5")]
		public void Add(EventHandler<T> c2)
		{
		}

		[Token(Token = "0x6004DB6")]
		public void Remove(EventHandler<T> c2)
		{
		}

		[Token(Token = "0x6004DB7")]
		public static TriggerEvent<T> operator +(TriggerEvent<T> c1, EventHandler<T> c2)
		{
			return null;
		}

		[Token(Token = "0x6004DB8")]
		public static TriggerEvent<T> operator -(TriggerEvent<T> c1, EventHandler<T> c2)
		{
			return null;
		}

		[Token(Token = "0x6004DB9")]
		public void Trigger(object sender, T args)
		{
		}

		[Token(Token = "0x6004DBA")]
		public void Reset()
		{
		}

		[Token(Token = "0x6004DBB")]
		public TriggerEvent()
		{
		}
	}
}
