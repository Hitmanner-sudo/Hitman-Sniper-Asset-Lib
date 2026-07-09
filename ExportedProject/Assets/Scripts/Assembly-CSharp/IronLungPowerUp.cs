using Il2CppDummyDll;

[Token(Token = "0x2000342")]
public class IronLungPowerUp : PowerUp
{
	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5B4430", Offset = "0x5B4430")]
	public float SlowMotionRatio;

	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0xA4")]
	private float _increasedAmount;

	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x10BE1DC", Offset = "0x10BE1DC", VA = "0x10BE1DC", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x10BE254", Offset = "0x10BE254", VA = "0x10BE254", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x10BE2A0", Offset = "0x10BE2A0", VA = "0x10BE2A0")]
	public IronLungPowerUp()
	{
	}
}
