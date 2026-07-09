using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000563")]
public class UILayoutMapping
{
	[Token(Token = "0x2000564")]
	public enum MappingType
	{
		[Token(Token = "0x4001C86")]
		ChangeParent = 0,
		[Token(Token = "0x4001C87")]
		Enable = 1,
		[Token(Token = "0x4001C88")]
		Disable = 2
	}

	[Token(Token = "0x4001C81")]
	[FieldOffset(Offset = "0x10")]
	public string ElementName;

	[Token(Token = "0x4001C82")]
	[FieldOffset(Offset = "0x18")]
	public MappingType MappingFunction;

	[Token(Token = "0x4001C83")]
	[FieldOffset(Offset = "0x20")]
	public string ParentElementName;

	[Token(Token = "0x4001C84")]
	[FieldOffset(Offset = "0x28")]
	public bool FlipXCollider;

	[Token(Token = "0x6002216")]
	[Address(RVA = "0x1423AE0", Offset = "0x1423AE0", VA = "0x1423AE0")]
	public UILayoutMapping()
	{
	}
}
