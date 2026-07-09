using System;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A91")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x597B0C", Offset = "0x597B0C")]
	public class TestAttribute : Attribute
	{
		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x10")]
		public TestType TestType;

		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6004277")]
		[Address(RVA = "0xAC271C", Offset = "0xAC271C", VA = "0xAC271C")]
		public TestAttribute()
		{
		}
	}
}
