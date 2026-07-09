using Il2CppDummyDll;

[Token(Token = "0x20001E0")]
public class CustomizableWeaponConfig : BaseConfig<CustomizableWeaponConfig>
{
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x30")]
	public LazyPowerUp[] AvailablePowerUps;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x38")]
	public LazyWeaponMod[] AvailableMods;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x40")]
	public RestrictedPowerUp[] RestrictedPowerUps;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x48")]
	public RestrictedMod[] RestrictedMods;

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0xBBB538", Offset = "0xBBB538", VA = "0xBBB538")]
	public CustomizableWeaponConfig()
	{
	}
}
