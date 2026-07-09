using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C65")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x598664", Offset = "0x598664")]
	public class ResourcePathAttribute : Attribute
	{
		[Token(Token = "0x4003CC0")]
		[FieldOffset(Offset = "0x10")]
		public string Path;

		[Token(Token = "0x6004D81")]
		[Address(RVA = "0x96682C", Offset = "0x96682C", VA = "0x96682C")]
		public ResourcePathAttribute()
		{
		}

		[Token(Token = "0x6004D82")]
		[Address(RVA = "0x966834", Offset = "0x966834", VA = "0x966834")]
		public ResourcePathAttribute(string path)
		{
		}
	}
}
