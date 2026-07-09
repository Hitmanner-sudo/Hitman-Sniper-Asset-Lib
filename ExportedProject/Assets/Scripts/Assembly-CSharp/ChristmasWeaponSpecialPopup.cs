using Il2CppDummyDll;

[Token(Token = "0x2000229")]
public class ChristmasWeaponSpecialPopup : WeaponSpecialPopup
{
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0xB00ED0", Offset = "0xB00ED0", VA = "0xB00ED0", Slot = "5")]
	protected override long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0xB00F50", Offset = "0xB00F50", VA = "0xB00F50", Slot = "6")]
	protected override void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0xB00FD4", Offset = "0xB00FD4", VA = "0xB00FD4")]
	public ChristmasWeaponSpecialPopup()
	{
	}
}
