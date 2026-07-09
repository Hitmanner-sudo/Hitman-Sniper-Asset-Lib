using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008A1")]
public class LazyWeaponMod : TLazyScriptableObject<WeaponMod>
{
	[Token(Token = "0x6003810")]
	[Address(RVA = "0x997EBC", Offset = "0x997EBC", VA = "0x997EBC", Slot = "9")]
	protected override WeaponMod LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003811")]
	[Address(RVA = "0x997F4C", Offset = "0x997F4C", VA = "0x997F4C", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003812")]
	[Address(RVA = "0x99808C", Offset = "0x99808C", VA = "0x99808C")]
	public LazyWeaponMod()
	{
	}
}
