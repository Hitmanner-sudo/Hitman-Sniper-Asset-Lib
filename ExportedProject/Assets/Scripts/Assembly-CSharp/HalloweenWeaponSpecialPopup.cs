using Il2CppDummyDll;

[Token(Token = "0x2000249")]
public class HalloweenWeaponSpecialPopup : WeaponSpecialPopup
{
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0xA08D80", Offset = "0xA08D80", VA = "0xA08D80", Slot = "5")]
	protected override long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0xA08E00", Offset = "0xA08E00", VA = "0xA08E00", Slot = "6")]
	protected override void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0xA08E84", Offset = "0xA08E84", VA = "0xA08E84")]
	public HalloweenWeaponSpecialPopup()
	{
	}
}
