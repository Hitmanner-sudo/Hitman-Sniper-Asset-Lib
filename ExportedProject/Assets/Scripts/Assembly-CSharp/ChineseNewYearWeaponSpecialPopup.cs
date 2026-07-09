using Il2CppDummyDll;

[Token(Token = "0x2000228")]
public class ChineseNewYearWeaponSpecialPopup : WeaponSpecialPopup
{
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0xB00D38", Offset = "0xB00D38", VA = "0xB00D38", Slot = "5")]
	protected override long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0xB00DB8", Offset = "0xB00DB8", VA = "0xB00DB8", Slot = "6")]
	protected override void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0xB00E3C", Offset = "0xB00E3C", VA = "0xB00E3C")]
	public ChineseNewYearWeaponSpecialPopup()
	{
	}
}
