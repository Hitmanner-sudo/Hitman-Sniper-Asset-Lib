using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074D")]
public class PopupWeaponMasterySingleRifleFullyMastered : PopupWeaponMastery
{
	[Token(Token = "0x4002954")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private UILabel _innerTextLabel;

	[Token(Token = "0x4002955")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private string _innerTextLocKey;

	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x93E008", Offset = "0x93E008", VA = "0x93E008", Slot = "22")]
	protected override void OnSetupPopup()
	{
	}

	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x93E10C", Offset = "0x93E10C", VA = "0x93E10C")]
	public PopupWeaponMasterySingleRifleFullyMastered()
	{
	}
}
