using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A9A")]
	public class Blackboard
	{
		[Token(Token = "0x40036BF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<object, object> Items;

		[Token(Token = "0x600429A")]
		[Address(RVA = "0xC66910", Offset = "0xC66910", VA = "0xC66910")]
		public void Clear()
		{
		}

		[Token(Token = "0x600429B")]
		public T Get<T>(object key) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x600429C")]
		[Address(RVA = "0xC66964", Offset = "0xC66964", VA = "0xC66964")]
		public bool Has(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x600429D")]
		public T GetOrCreate<T>(object key) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x600429E")]
		[Address(RVA = "0xC669C8", Offset = "0xC669C8", VA = "0xC669C8")]
		public void Set(object key, object value)
		{
		}

		[Token(Token = "0x600429F")]
		[Address(RVA = "0xC66A98", Offset = "0xC66A98", VA = "0xC66A98")]
		public void Increment(object key, int value)
		{
		}

		[Token(Token = "0x60042A0")]
		[Address(RVA = "0xC66B64", Offset = "0xC66B64", VA = "0xC66B64")]
		public void Increment(object key, float value)
		{
		}

		[Token(Token = "0x60042A1")]
		[Address(RVA = "0xC66C34", Offset = "0xC66C34", VA = "0xC66C34")]
		public bool Remove(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60042A2")]
		[Address(RVA = "0xC66C98", Offset = "0xC66C98", VA = "0xC66C98")]
		public void UpdateFrom(Blackboard other)
		{
		}

		[Token(Token = "0x60042A3")]
		[Address(RVA = "0xC66E08", Offset = "0xC66E08", VA = "0xC66E08")]
		public Blackboard()
		{
		}
	}
}
