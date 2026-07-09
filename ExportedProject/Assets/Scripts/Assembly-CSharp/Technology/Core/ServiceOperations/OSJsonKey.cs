using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D0B")]
	public class OSJsonKey : Attribute
	{
		[Token(Token = "0x4003E7E")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Key;

		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x9E88C4", Offset = "0x9E88C4", VA = "0x9E88C4")]
		public OSJsonKey(string key)
		{
		}
	}
}
