using Il2CppDummyDll;

[Token(Token = "0x2000332")]
public class DecoyBulletPowerUp : SpawnOnImpactPowerUp
{
	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0xB8")]
	private bool _spawnBulletHoles;

	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0xB9")]
	private bool _emitRicochetMementos;

	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0xBA")]
	private bool _emitFlybyMemento;

	[Token(Token = "0x600136F")]
	[Address(RVA = "0xAEC3F8", Offset = "0xAEC3F8", VA = "0xAEC3F8", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0xAEC468", Offset = "0xAEC468", VA = "0xAEC468", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0xAEC4CC", Offset = "0xAEC4CC", VA = "0xAEC4CC")]
	public DecoyBulletPowerUp()
	{
	}
}
