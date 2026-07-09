using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003B7")]
public class WeaponXPUpgrade
{
	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x10")]
	public int XP;

	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x18")]
	public LazyWeaponMod[] WeaponModRefs;

	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x20")]
	public LazyPowerUp[] PowerUpRefs;

	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x28")]
	public LazyUnlockable UpgradeUnlockable;

	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5B4D40", Offset = "0x5B4D40")]
	public int ScoreMultiplierGrade;

	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x34")]
	public int FireRateGrade;

	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x38")]
	public int SwayGrade;

	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x3C")]
	public int ClipSizeGrade;

	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x40")]
	public int MaxZoomGrade;

	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0x44")]
	public int BulletSpeedGrade;

	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x48")]
	public int BulletDamageGrade;

	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x50")]
	public Wallet.CurrencyAmount Cost;

	[Token(Token = "0x600172B")]
	[Address(RVA = "0x87B4C0", Offset = "0x87B4C0", VA = "0x87B4C0")]
	public bool IsUnlockedMod(int weaponXP, int attachementIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600172C")]
	[Address(RVA = "0x87E614", Offset = "0x87E614", VA = "0x87E614")]
	public WeaponXPUpgrade()
	{
	}
}
