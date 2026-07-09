using Il2CppDummyDll;

[Token(Token = "0x200035A")]
public class RateOfFirePowerUp : PowerUp
{
	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5B450C", Offset = "0x5B450C")]
	public float ROFRatio;

	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0xA4")]
	private float _oldROF;

	[Token(Token = "0x6001444")]
	[Address(RVA = "0xB40328", Offset = "0xB40328", VA = "0xB40328", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0xB403D0", Offset = "0xB403D0", VA = "0xB403D0", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001446")]
	[Address(RVA = "0xB40448", Offset = "0xB40448", VA = "0xB40448")]
	public RateOfFirePowerUp()
	{
	}
}
