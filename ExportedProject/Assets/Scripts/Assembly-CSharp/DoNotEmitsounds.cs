using System;
using Il2CppDummyDll;

[Token(Token = "0x2000398")]
public class DoNotEmitsounds : WeaponMod
{
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0xC18740", Offset = "0xC18740", VA = "0xC18740", Slot = "9")]
	public override void UnEquip()
	{
	}

	[Token(Token = "0x60015F8")]
	[Address(RVA = "0xC18810", Offset = "0xC18810", VA = "0xC18810", Slot = "10")]
	protected override void OnWeaponAttached(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60015F9")]
	[Address(RVA = "0xC1886C", Offset = "0xC1886C", VA = "0xC1886C")]
	public DoNotEmitsounds()
	{
	}
}
