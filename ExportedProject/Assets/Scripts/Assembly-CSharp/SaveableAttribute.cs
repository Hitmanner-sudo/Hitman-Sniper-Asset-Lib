using System;
using Il2CppDummyDll;

[Token(Token = "0x200090B")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x596E80", Offset = "0x596E80")]
public class SaveableAttribute : Attribute
{
	[Token(Token = "0x40031AB")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBAE4", Offset = "0x5BBAE4")]
	private RestoreType _003CType_003Ek__BackingField;

	[Token(Token = "0x1700074A")]
	public RestoreType Type
	{
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0xBAFEFC", Offset = "0xBAFEFC", VA = "0xBAFEFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247C0", Offset = "0x6247C0")]
		get
		{
			return default(RestoreType);
		}
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0xBAFF04", Offset = "0xBAFF04", VA = "0xBAFF04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247D0", Offset = "0x6247D0")]
		private set
		{
		}
	}

	[Token(Token = "0x60039DD")]
	[Address(RVA = "0xBAFEA8", Offset = "0xBAFEA8", VA = "0xBAFEA8")]
	public SaveableAttribute()
	{
	}

	[Token(Token = "0x60039DE")]
	[Address(RVA = "0xBAFED0", Offset = "0xBAFED0", VA = "0xBAFED0")]
	public SaveableAttribute(RestoreType type)
	{
	}
}
