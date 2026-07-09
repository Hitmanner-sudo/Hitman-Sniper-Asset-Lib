using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000752")]
public class WeaponSpecialPopupView : PopupOverlayView
{
	[Token(Token = "0x4002960")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private string _titleLoc;

	[Token(Token = "0x4002961")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private string _descriptionLoc;

	[Token(Token = "0x4002962")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private string _okButtonLoc;

	[Token(Token = "0x4002963")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private LazyWeaponUnlockable _lazyWeaponUnlockable;

	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private bool _showWeaponModel;

	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x98C864", Offset = "0x98C864", VA = "0x98C864")]
	public void SetupPopupOverlay()
	{
	}

	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x98CADC", Offset = "0x98CADC", VA = "0x98CADC")]
	private void OnOkClicked()
	{
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x98CDC4", Offset = "0x98CDC4", VA = "0x98CDC4")]
	private void OnCancelClicked()
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x98CC80", Offset = "0x98CC80", VA = "0x98CC80")]
	private void ClearAndSave()
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x98CE20", Offset = "0x98CE20", VA = "0x98CE20", Slot = "21")]
	protected virtual void SetSaveGameLastDateSeen(long lastDateSeen)
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x98CE24", Offset = "0x98CE24", VA = "0x98CE24")]
	public WeaponSpecialPopupView()
	{
	}
}
