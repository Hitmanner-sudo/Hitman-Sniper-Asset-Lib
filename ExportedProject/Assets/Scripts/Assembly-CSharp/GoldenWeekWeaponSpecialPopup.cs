using Il2CppDummyDll;

[Token(Token = "0x2000248")]
public class GoldenWeekWeaponSpecialPopup : WeaponSpecialPopup
{
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0xC840FC", Offset = "0xC840FC", VA = "0xC840FC", Slot = "5")]
	protected override long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0xC8417C", Offset = "0xC8417C", VA = "0xC8417C", Slot = "6")]
	protected override void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0xC84200", Offset = "0xC84200", VA = "0xC84200")]
	public GoldenWeekWeaponSpecialPopup()
	{
	}
}
