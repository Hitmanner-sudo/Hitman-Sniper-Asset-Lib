using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000014")]
public class CustomLocalization
{
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x10")]
	public string Language;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x18")]
	public string Title;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x20")]
	public string Body;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x28")]
	public string Ok;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x10DF824", Offset = "0x10DF824", VA = "0x10DF824")]
	public CustomLocalization()
	{
	}
}
