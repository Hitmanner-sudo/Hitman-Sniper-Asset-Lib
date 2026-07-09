using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20001E1")]
public class RestrictedPowerUp
{
	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x10")]
	public LazyPowerUp PowerUp;

	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x18")]
	public LazyWeaponUnlockable WeaponRequired;

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x9677A0", Offset = "0x9677A0", VA = "0x9677A0")]
	public RestrictedPowerUp()
	{
	}
}
