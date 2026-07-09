using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20008CD")]
public class LocalizationSettings : ScriptableObject
{
	[Token(Token = "0x40030CA")]
	[FieldOffset(Offset = "0x18")]
	public string[] sheetTitles;

	[Token(Token = "0x40030CB")]
	[FieldOffset(Offset = "0x20")]
	public bool useSystemLanguagePerDefault;

	[Token(Token = "0x40030CC")]
	[FieldOffset(Offset = "0x28")]
	public string defaultLangCode;

	[Token(Token = "0x60038A0")]
	[Address(RVA = "0x9D8D18", Offset = "0x9D8D18", VA = "0x9D8D18")]
	public static LanguageCode GetLanguageEnum(string langCode)
	{
		return default(LanguageCode);
	}

	[Token(Token = "0x60038A1")]
	[Address(RVA = "0x9D90F8", Offset = "0x9D90F8", VA = "0x9D90F8")]
	public LocalizationSettings()
	{
	}
}
