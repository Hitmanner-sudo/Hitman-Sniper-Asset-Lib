using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074C")]
public abstract class PopupWeaponMastery : PopupOverlayView
{
	[Token(Token = "0x400294A")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UISprite _tierIcon;

	[Token(Token = "0x400294B")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private GameObject _bigFlourish;

	[Token(Token = "0x400294C")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private GameObject _smallFlourish;

	[Token(Token = "0x400294D")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UILabel _scoreBonusLabel;

	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private float _flourishDuration;

	[Token(Token = "0x400294F")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	private float _secondFlourishDelay;

	[Token(Token = "0x4002950")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private float _timeBetweenPulses;

	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private string _titleLocKey;

	[Token(Token = "0x4002952")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private string _descLocKey;

	[NonSerialized]
	[Token(Token = "0x4002953")]
	[FieldOffset(Offset = "0x140")]
	protected WeaponUnlockable Weapon;

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x93D7BC", Offset = "0x93D7BC", VA = "0x93D7BC")]
	public void SetupPopup(PopupButton okButton, WeaponUnlockable weapon)
	{
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x93DEA4", Offset = "0x93DEA4", VA = "0x93DEA4", Slot = "21")]
	protected virtual string[] GetDescriptionFormatArguments()
	{
		return null;
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x93E000", Offset = "0x93E000", VA = "0x93E000", Slot = "22")]
	protected virtual void OnSetupPopup()
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x93D9C0", Offset = "0x93D9C0", VA = "0x93D9C0")]
	private string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x93DB78", Offset = "0x93DB78", VA = "0x93DB78")]
	private void SetupFlourish()
	{
	}

	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x93E004", Offset = "0x93E004", VA = "0x93E004")]
	protected PopupWeaponMastery()
	{
	}
}
