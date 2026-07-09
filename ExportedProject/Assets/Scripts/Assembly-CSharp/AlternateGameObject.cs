using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001DE")]
public struct AlternateGameObject
{
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x0")]
	public LazyGameObject Original;

	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x8")]
	public LazyGameObject ReplaceBy;
}
