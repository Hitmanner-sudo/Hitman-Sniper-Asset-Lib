using System;
using Il2CppDummyDll;

[Token(Token = "0x200090C")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x596E94", Offset = "0x596E94")]
public class DeprecatedAttribute : Attribute
{
	[Token(Token = "0x40031AC")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBAF4", Offset = "0x5BBAF4")]
	private string _003CMigrate_003Ek__BackingField;

	[Token(Token = "0x1700074B")]
	public string Migrate
	{
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0xC126D8", Offset = "0xC126D8", VA = "0xC126D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247E0", Offset = "0x6247E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0xC126E0", Offset = "0xC126E0", VA = "0xC126E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6247F0", Offset = "0x6247F0")]
		private set
		{
		}
	}

	[Token(Token = "0x60039E3")]
	[Address(RVA = "0xC126E8", Offset = "0xC126E8", VA = "0xC126E8")]
	public DeprecatedAttribute(string callback)
	{
	}
}
