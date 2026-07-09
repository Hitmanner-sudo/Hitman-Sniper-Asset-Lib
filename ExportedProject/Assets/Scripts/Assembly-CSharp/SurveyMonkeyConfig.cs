using Il2CppDummyDll;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x2000841")]
[Attribute(Name = "ResourcePathAttribute", RVA = "0x5967A0", Offset = "0x5967A0")]
public class SurveyMonkeyConfig : ScriptableSingleton<SurveyMonkeyConfig>
{
	[Token(Token = "0x4002EBA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LazyPopupSurveyComplete _surveyCompletePopup;

	[Token(Token = "0x170006DB")]
	public PopupSurveyComplete SurveyCompletePopup
	{
		[Token(Token = "0x60035F6")]
		[Address(RVA = "0xD2FD78", Offset = "0xD2FD78", VA = "0xD2FD78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0xD2FF0C", Offset = "0xD2FF0C", VA = "0xD2FF0C")]
	public SurveyMonkeyConfig()
	{
	}
}
