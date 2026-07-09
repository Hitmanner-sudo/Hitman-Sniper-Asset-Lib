using System;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000AAD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x597C20", Offset = "0x597C20")]
	public class DisplayNameAttribute : Attribute
	{
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x60042F6")]
		[Address(RVA = "0xC16DF0", Offset = "0xC16DF0", VA = "0xC16DF0")]
		public DisplayNameAttribute(string name)
		{
		}
	}
}
