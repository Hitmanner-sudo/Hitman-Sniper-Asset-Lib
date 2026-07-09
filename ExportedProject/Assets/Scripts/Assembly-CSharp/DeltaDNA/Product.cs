using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001331")]
	public class Product<T> : Params where T : Product<T>
	{
		[Token(Token = "0x4005C13")]
		[FieldOffset(Offset = "0x0")]
		private List<Dictionary<string, object>> virtualCurrencies;

		[Token(Token = "0x4005C14")]
		[FieldOffset(Offset = "0x0")]
		private List<Dictionary<string, object>> items;

		[Token(Token = "0x4005C15")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<string, int> ISO4217;

		[Token(Token = "0x6007109")]
		public T SetRealCurrency(string type, int amount)
		{
			return null;
		}

		[Token(Token = "0x600710A")]
		public T AddVirtualCurrency(string name, string type, long amount)
		{
			return null;
		}

		[Token(Token = "0x600710B")]
		public T AddItem(string name, string type, int amount)
		{
			return null;
		}

		[Token(Token = "0x600710C")]
		public static int ConvertCurrency(string code, decimal value)
		{
			return default(int);
		}

		[Token(Token = "0x600710D")]
		static Product()
		{
		}

		[Token(Token = "0x600710E")]
		public Product()
		{
		}
	}
	[Token(Token = "0x2001332")]
	public class Product : Product<Product>
	{
		[Token(Token = "0x600710F")]
		[Address(RVA = "0xB389D8", Offset = "0xB389D8", VA = "0xB389D8")]
		public Product()
		{
		}
	}
}
