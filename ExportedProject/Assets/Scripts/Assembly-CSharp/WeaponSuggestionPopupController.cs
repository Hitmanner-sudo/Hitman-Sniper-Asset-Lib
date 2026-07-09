using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200056A")]
public class WeaponSuggestionPopupController : UIController
{
	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _playButton;

	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _cancelButton;

	[Token(Token = "0x6002234")]
	[Address(RVA = "0x98F084", Offset = "0x98F084", VA = "0x98F084", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0x98F17C", Offset = "0x98F17C", VA = "0x98F17C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0x98F274", Offset = "0x98F274", VA = "0x98F274")]
	private void OnPlayClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x98F468", Offset = "0x98F468", VA = "0x98F468")]
	private void OnCancelClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002238")]
	[Address(RVA = "0x98F600", Offset = "0x98F600", VA = "0x98F600")]
	public WeaponSuggestionPopupController()
	{
	}
}
