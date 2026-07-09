using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000741")]
public class PopupSurveyComplete : PopupOverlayView
{
	[Token(Token = "0x4002916")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private string _descriptionLocKey;

	[Token(Token = "0x4002917")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ColorModel.ColorModelEnum _textHighlightColor;

	[Token(Token = "0x6003063")]
	[Address(RVA = "0x93D088", Offset = "0x93D088", VA = "0x93D088")]
	public void SetupPopupOverlay(int amount)
	{
	}

	[Token(Token = "0x6003064")]
	[Address(RVA = "0x93D2D8", Offset = "0x93D2D8", VA = "0x93D2D8")]
	public PopupSurveyComplete()
	{
	}
}
