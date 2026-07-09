using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002DE")]
public class WeaponSpecialPopup : SpecialPopup
{
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LazyWeaponSpecialPopupView _lazyWeaponPopupView;

	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LazyWeaponUnlockable _lazyWeaponUnlockable;

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x98C4F0", Offset = "0x98C4F0", VA = "0x98C4F0", Slot = "4")]
	public override bool DoDisplay()
	{
		return default(bool);
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x98CAC8", Offset = "0x98CAC8", VA = "0x98CAC8", Slot = "5")]
	protected virtual long GetSaveGameLastDateSeen()
	{
		return default(long);
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x98CAD0", Offset = "0x98CAD0", VA = "0x98CAD0", Slot = "6")]
	protected virtual void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x98CAD4", Offset = "0x98CAD4", VA = "0x98CAD4")]
	public WeaponSpecialPopup()
	{
	}
}
