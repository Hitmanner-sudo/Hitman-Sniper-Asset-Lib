using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Distribution;
using UnityEngine;

[Token(Token = "0x2000052")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x591430", Offset = "0x591430")]
public class Localization : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000053")]
	public class FontScale
	{
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x10")]
		public LazyUIFont[] UIFonts;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x8C2800", Offset = "0x8C2800", VA = "0x8C2800")]
		public FontScale()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591468", Offset = "0x591468")]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x10")]
		public string value;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x8C27E4", Offset = "0x8C27E4", VA = "0x8C27E4")]
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x8C27EC", Offset = "0x8C27EC", VA = "0x8C27EC")]
		internal bool _003CForceUpdate_003Eb__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string LANGUAGE_CODE;

	[Token(Token = "0x40001BD")]
	private const string LOCALIZATION_FILENAME = "Localization";

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x8")]
	private static Localization mInstance;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x18")]
	public UIFont[] ReferenceUIFonts;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public FontScale[] _fontByLanguague;

	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x20")]
	public static string[] knownLanguages;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x28")]
	public static bool[] isKnownLanguagesForLowEnd;

	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x30")]
	public static int languageIndex;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x38")]
	private static Dictionary<string, string> mDictionary;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x40")]
	private static string mLanguage;

	[Token(Token = "0x17000057")]
	public static Dictionary<string, string> dictionary
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9D6B30", Offset = "0x9D6B30", VA = "0x9D6B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	public static Localization instance
	{
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9D6B94", Offset = "0x9D6B94", VA = "0x9D6B94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public static string language
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9D79BC", Offset = "0x9D79BC", VA = "0x9D79BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9D7040", Offset = "0x9D7040", VA = "0x9D7040")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event EventHandler OnLocalize
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9D6750", Offset = "0x9D6750", VA = "0x9D6750")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6119E0", Offset = "0x6119E0")]
		add
		{
		}
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9D6848", Offset = "0x9D6848", VA = "0x9D6848")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6119F0", Offset = "0x6119F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event EventHandler OnLocalizeDone
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9D6940", Offset = "0x9D6940", VA = "0x9D6940")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611A00", Offset = "0x611A00")]
		add
		{
		}
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9D6A38", Offset = "0x9D6A38", VA = "0x9D6A38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611A10", Offset = "0x611A10")]
		remove
		{
		}
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x9D6E14", Offset = "0x9D6E14", VA = "0x9D6E14")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x9D70E0", Offset = "0x9D70E0", VA = "0x9D70E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x9D71B8", Offset = "0x9D71B8", VA = "0x9D71B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x9D7328", Offset = "0x9D7328", VA = "0x9D7328")]
	private void ResetReferenceFonts()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x9D732C", Offset = "0x9D732C", VA = "0x9D732C")]
	private static void OnBundleLoaded(Bundle b)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x9D73C4", Offset = "0x9D73C4", VA = "0x9D73C4")]
	private static void ForceReloadLocalization()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x9D7A20", Offset = "0x9D7A20", VA = "0x9D7A20")]
	public static bool IsKnownLanguageIndexValid(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x9D7AFC", Offset = "0x9D7AFC", VA = "0x9D7AFC")]
	public static void SetLanguageIndex(int index)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x9D7428", Offset = "0x9D7428", VA = "0x9D7428")]
	private static void ForceUpdate(string value)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x9D2AF0", Offset = "0x9D2AF0", VA = "0x9D2AF0")]
	public static string Get(string key)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x9D7BC8", Offset = "0x9D7BC8", VA = "0x9D7BC8")]
	public static void LoadCSV(TextAsset asset, ref string targetLanguage)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x9D81A8", Offset = "0x9D81A8", VA = "0x9D81A8")]
	private static void AddCSV(BetterList<string> values)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x9D835C", Offset = "0x9D835C", VA = "0x9D835C")]
	public Localization()
	{
	}
}
