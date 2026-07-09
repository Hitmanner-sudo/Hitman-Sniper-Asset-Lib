using System;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A76")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x597A98", Offset = "0x597A98")]
	public class GameUpdateOrderAttribute : Attribute
	{
		[Token(Token = "0x400366F")]
		[FieldOffset(Offset = "0x10")]
		public GameScheduler.ExecutionOrder Order;

		[Token(Token = "0x6004201")]
		[Address(RVA = "0xD9C990", Offset = "0xD9C990", VA = "0xD9C990")]
		public GameUpdateOrderAttribute(GameScheduler.ExecutionOrder order)
		{
		}
	}
}
