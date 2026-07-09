using Il2CppDummyDll;

[Token(Token = "0x200033E")]
public class IncreasedDamagePowerUp : PowerUp
{
	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5B43E8", Offset = "0x5B43E8")]
	public float ImpactForceRatio;

	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5B4404", Offset = "0x5B4404")]
	public float DamageRatio;

	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0xA8")]
	private float _impactForceDelta;

	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0xAC")]
	private float _damageDelta;

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0xB0B07C", Offset = "0xB0B07C", VA = "0xB0B07C", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013B9")]
	[Address(RVA = "0xB0B16C", Offset = "0xB0B16C", VA = "0xB0B16C", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0xB0B214", Offset = "0xB0B214", VA = "0xB0B214")]
	public IncreasedDamagePowerUp()
	{
	}
}
