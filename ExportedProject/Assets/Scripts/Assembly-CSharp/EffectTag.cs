using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200004F")]
public class EffectTag
{
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x10")]
	public string Sequence;

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel.Effect EffectStyle;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 EffectDistance;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xE0C2C0", Offset = "0xE0C2C0", VA = "0xE0C2C0")]
	public EffectTag()
	{
	}
}
