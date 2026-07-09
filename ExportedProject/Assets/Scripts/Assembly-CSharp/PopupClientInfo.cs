using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000724")]
public class PopupClientInfo : PopupOverlayViewBase
{
	[Token(Token = "0x4002869")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UILabel _infoBox;

	[Token(Token = "0x400286A")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private ColorModel.ColorModelEnum _textColor;

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x930388", Offset = "0x930388", VA = "0x930388")]
	public void SetupPopupOverlay()
	{
	}

	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x9308E8", Offset = "0x9308E8", VA = "0x9308E8")]
	private void OnSharePressed()
	{
	}

	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x93057C", Offset = "0x93057C", VA = "0x93057C")]
	private string GetClientInfoText(bool addColor)
	{
		return null;
	}

	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x930914", Offset = "0x930914", VA = "0x930914")]
	public PopupClientInfo()
	{
	}
}
