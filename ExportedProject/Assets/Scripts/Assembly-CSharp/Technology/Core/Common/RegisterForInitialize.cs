using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DE2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x598A48", Offset = "0x598A48")]
	public class RegisterForInitialize : Attribute
	{
		[Token(Token = "0x40041FE")]
		[FieldOffset(Offset = "0x10")]
		public int Priority;

		[Token(Token = "0x600554B")]
		[Address(RVA = "0x9630F4", Offset = "0x9630F4", VA = "0x9630F4")]
		public RegisterForInitialize()
		{
		}
	}
}
