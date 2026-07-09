using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001330")]
	public class Params
	{
		[Token(Token = "0x4005C12")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> _params;

		[Token(Token = "0x6007104")]
		[Address(RVA = "0x8F478C", Offset = "0x8F478C", VA = "0x8F478C")]
		public Params()
		{
		}

		[Token(Token = "0x6007105")]
		[Address(RVA = "0x8F4804", Offset = "0x8F4804", VA = "0x8F4804")]
		public Params(Params p)
		{
		}

		[Token(Token = "0x6007106")]
		[Address(RVA = "0x8F48C8", Offset = "0x8F48C8", VA = "0x8F48C8")]
		public Params AddParam(string key, object value)
		{
			return null;
		}

		[Token(Token = "0x6007107")]
		[Address(RVA = "0x8F4B64", Offset = "0x8F4B64", VA = "0x8F4B64")]
		public object GetParam(string key)
		{
			return null;
		}

		[Token(Token = "0x6007108")]
		[Address(RVA = "0x8F4D60", Offset = "0x8F4D60", VA = "0x8F4D60")]
		public Dictionary<string, object> AsDictionary()
		{
			return null;
		}
	}
}
