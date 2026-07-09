using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001E2")]
public class RestrictedMod
{
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x10")]
	public LazyWeaponMod Mod;

	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x18")]
	public LazyWeaponUnlockable WeaponRequired;

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x967798", Offset = "0x967798", VA = "0x967798")]
	public RestrictedMod()
	{
	}
}
