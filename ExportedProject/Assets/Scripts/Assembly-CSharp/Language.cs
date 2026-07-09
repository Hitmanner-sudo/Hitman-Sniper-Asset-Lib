using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008C9")]
public static class Language
{
	[Token(Token = "0x4003031")]
	[FieldOffset(Offset = "0x0")]
	private static readonly LocalizationSettings settings;

	[Token(Token = "0x4003032")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string resourcePath;

	[Token(Token = "0x4003033")]
	[FieldOffset(Offset = "0x10")]
	private static List<LanguageCode> availableLanguages;

	[Token(Token = "0x4003034")]
	[FieldOffset(Offset = "0x18")]
	private static LanguageCode currentLanguage;

	[Token(Token = "0x4003035")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<string, Dictionary<string, string>> currentEntrySheets;

	[Token(Token = "0x600388F")]
	[Address(RVA = "0x994ACC", Offset = "0x994ACC", VA = "0x994ACC")]
	static Language()
	{
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0x994E98", Offset = "0x994E98", VA = "0x994E98")]
	private static void LoadAvailableLanguages()
	{
	}

	[Token(Token = "0x6003891")]
	[Address(RVA = "0x995760", Offset = "0x995760", VA = "0x995760")]
	public static LanguageCode[] GetAvailableLanguages()
	{
		return null;
	}

	[Token(Token = "0x6003892")]
	[Address(RVA = "0x9953B8", Offset = "0x9953B8", VA = "0x9953B8")]
	public static bool SwitchLanguage(LanguageCode code)
	{
		return default(bool);
	}

	[Token(Token = "0x6003893")]
	[Address(RVA = "0x9957E4", Offset = "0x9957E4", VA = "0x9957E4")]
	private static void DoSwitch(LanguageCode newLang)
	{
	}

	[Token(Token = "0x6003894")]
	[Address(RVA = "0x99629C", Offset = "0x99629C", VA = "0x99629C")]
	public static Object GetAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0x995568", Offset = "0x995568", VA = "0x995568")]
	private static bool HasLanguageFile(LanguageCode lang, string sheetTitle)
	{
		return default(bool);
	}

	[Token(Token = "0x6003896")]
	[Address(RVA = "0x995EBC", Offset = "0x995EBC", VA = "0x995EBC")]
	private static string GetLanguageFileContents(string sheetTitle)
	{
		return null;
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0x996314", Offset = "0x996314", VA = "0x996314")]
	public static LanguageCode CurrentLanguage()
	{
		return default(LanguageCode);
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0x996378", Offset = "0x996378", VA = "0x996378")]
	public static string Get(string key)
	{
		return null;
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0x99640C", Offset = "0x99640C", VA = "0x99640C")]
	public static string Get(string key, string sheetTitle)
	{
		return null;
	}

	[Token(Token = "0x600389A")]
	[Address(RVA = "0x9965EC", Offset = "0x9965EC", VA = "0x9965EC")]
	public static bool Has(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600389B")]
	[Address(RVA = "0x996680", Offset = "0x996680", VA = "0x996680")]
	public static bool Has(string key, string sheetTitle)
	{
		return default(bool);
	}

	[Token(Token = "0x600389C")]
	[Address(RVA = "0x996068", Offset = "0x996068", VA = "0x996068")]
	private static void SendMonoMessage(string methodString, params object[] parameters)
	{
	}

	[Token(Token = "0x600389D")]
	[Address(RVA = "0x995398", Offset = "0x995398", VA = "0x995398")]
	public static LanguageCode LanguageNameToCode(SystemLanguage name)
	{
		return default(LanguageCode);
	}
}
