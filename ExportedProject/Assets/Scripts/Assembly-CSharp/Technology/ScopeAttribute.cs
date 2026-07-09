using System;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A79")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x597AC0", Offset = "0x597AC0")]
	public class ScopeAttribute : Attribute
	{
		[Token(Token = "0x2000A7A")]
		public enum ScopeEnum
		{
			[Token(Token = "0x400367B")]
			SCENE = 0,
			[Token(Token = "0x400367C")]
			GAME = 1
		}

		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x10")]
		public ScopeEnum Scope;

		[Token(Token = "0x6004215")]
		[Address(RVA = "0xBB2E70", Offset = "0xBB2E70", VA = "0xBB2E70")]
		public ScopeAttribute()
		{
		}
	}
}
