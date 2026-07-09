using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200042E")]
public class SteadyHandsToggledMod : ToggledMod
{
	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x40")]
	public GameplayConfig.SwayGradeData OverrideSway;

	[Token(Token = "0x4001720")]
	[FieldOffset(Offset = "0x48")]
	private WeaponData _weaponData;

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0xD2A0AC", Offset = "0xD2A0AC", VA = "0xD2A0AC", Slot = "6")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0xD2A128", Offset = "0xD2A128", VA = "0xD2A128")]
	public SteadyHandsToggledMod()
	{
	}
}
