using Il2CppDummyDll;

[Token(Token = "0x2000233")]
public class FourthJulyWeaponSpecialPopup : WeaponSpecialPopup
{
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x95B184", Offset = "0x95B184", VA = "0x95B184", Slot = "5")]
	protected override long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x95B204", Offset = "0x95B204", VA = "0x95B204", Slot = "6")]
	protected override void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x95B288", Offset = "0x95B288", VA = "0x95B288")]
	public FourthJulyWeaponSpecialPopup()
	{
	}
}
