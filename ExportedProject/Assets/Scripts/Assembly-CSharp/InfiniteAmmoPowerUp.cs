using Il2CppDummyDll;

[Token(Token = "0x200033F")]
public class InfiniteAmmoPowerUp : PowerUp
{
	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0xA0")]
	private bool _wasInfinitAmmo;

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0xB0DEF0", Offset = "0xB0DEF0", VA = "0xB0DEF0", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60013BC")]
	[Address(RVA = "0xB0DFFC", Offset = "0xB0DFFC", VA = "0xB0DFFC", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0xB0E11C", Offset = "0xB0E11C", VA = "0xB0E11C")]
	public InfiniteAmmoPowerUp()
	{
	}
}
