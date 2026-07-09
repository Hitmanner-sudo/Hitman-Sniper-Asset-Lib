using System;
using Il2CppDummyDll;

[Token(Token = "0x20005FF")]
public class UIViewModel : DataModel
{
	[Token(Token = "0x2000600")]
	public enum UIScreen
	{
		[Token(Token = "0x40020C5")]
		None = 0,
		[Token(Token = "0x40020C6")]
		SplashScreenNew = 1,
		[Token(Token = "0x40020C7")]
		FirstLoadingScreen = 2,
		[Token(Token = "0x40020C8")]
		LoadingScreen = 3,
		[Token(Token = "0x40020C9")]
		HUD = 4,
		[Token(Token = "0x40020CA")]
		TallyScreen = 5,
		[Token(Token = "0x40020CB")]
		ModeScreen = 6,
		[Token(Token = "0x40020CC")]
		UnitySplashScreen = 7
	}

	[Serializable]
	[Token(Token = "0x2000601")]
	public class LoadingBackgroundDetail
	{
		[Token(Token = "0x40020CD")]
		[FieldOffset(Offset = "0x10")]
		public string Title;

		[Token(Token = "0x40020CE")]
		[FieldOffset(Offset = "0x18")]
		public string Action1;

		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x20")]
		public string Action1Detail;

		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x28")]
		public LazyTexture2D Action1Texture;

		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x30")]
		public bool ArrowFrom1To2Active;

		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x38")]
		public string Action2;

		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x40")]
		public string Action2Detail;

		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x48")]
		public LazyTexture2D Action2Texture;

		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x50")]
		public bool ArrowFrom2To3Active;

		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x58")]
		public string Action3;

		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x60")]
		public string Action3Detail;

		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0x68")]
		public LazyTexture2D Action3Texture;

		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0x70")]
		public DisplayValidation[] DisplayValidations;

		[Token(Token = "0x60026B0")]
		[Address(RVA = "0xA3EA18", Offset = "0xA3EA18", VA = "0xA3EA18")]
		public LoadingBackgroundDetail()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000602")]
	public class DisplayValidation
	{
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0x10")]
		public ContractData.ModeTypeEnum ValidMode;

		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x18")]
		public int[] SpecificMissionIDs;

		[Token(Token = "0x60026B1")]
		[Address(RVA = "0xA3EA08", Offset = "0xA3EA08", VA = "0xA3EA08")]
		public DisplayValidation()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000603")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59557C", Offset = "0x59557C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, bool> _003C_003E9__39_0;

		[Token(Token = "0x60026B3")]
		[Address(RVA = "0xA3E9A8", Offset = "0xA3E9A8", VA = "0xA3E9A8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60026B4")]
		[Address(RVA = "0xA3E9B0", Offset = "0xA3E9B0", VA = "0xA3E9B0")]
		internal bool _003CGetLoadingScreenHintKeys_003Eb__39_0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40020A1")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CURRENT_SCREEN;

	[Token(Token = "0x40020A2")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PRELOADED_SCREEN;

	[Token(Token = "0x40020A3")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SPLASH_SCREEN_NEW_VIEW_PREFAB;

	[Token(Token = "0x40020A4")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string FIRST_LOADING_VIEW_PREFAB;

	[Token(Token = "0x40020A5")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string LOADING_VIEW_PREFAB;

	[Token(Token = "0x40020A6")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string HUD_VIEW_PREFAB;

	[Token(Token = "0x40020A7")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string TALLY_VIEW_PREFAB;

	[Token(Token = "0x40020A8")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string MODE_VIEW_PREFAB;

	[Token(Token = "0x40020A9")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string UNITY_SPLASH_SCREEN_VIEW_PREFAB;

	[Token(Token = "0x40020AA")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string MENU_SCENE;

	[Token(Token = "0x40020AB")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string LOADING_COMPLETED;

	[Token(Token = "0x40020AC")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string LOADING_SCREEN_TAPPED;

	[Token(Token = "0x40020AD")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string FIRST_LOADING_SCREEN_SHOWN;

	[Token(Token = "0x40020AE")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string LOADING_SCREEN_CURRENT_HINT;

	[Token(Token = "0x40020AF")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string LOADING_SCREEN_HINT_KEYS;

	[Token(Token = "0x40020B0")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string LOADING_SCREEN_CURRENT_BACKGROUND;

	[Token(Token = "0x40020B1")]
	[FieldOffset(Offset = "0x80")]
	public static readonly string LOADING_SCREEN_BACKGROUND_DETAILS;

	[Token(Token = "0x40020B2")]
	[FieldOffset(Offset = "0x48")]
	public UIScreen StartingScreen;

	[Token(Token = "0x40020B3")]
	[FieldOffset(Offset = "0x50")]
	public string MenuScene;

	[Token(Token = "0x40020B4")]
	[FieldOffset(Offset = "0x58")]
	public LazyGameObject SplashScreenViewNewPrefab;

	[Token(Token = "0x40020B5")]
	[FieldOffset(Offset = "0x60")]
	public LazyGameObject FirstLoadingViewPrefab;

	[Token(Token = "0x40020B6")]
	[FieldOffset(Offset = "0x68")]
	public LazyGameObject LoadingViewPrefab;

	[Token(Token = "0x40020B7")]
	[FieldOffset(Offset = "0x70")]
	public LazyGameObject HUDViewPrefab;

	[Token(Token = "0x40020B8")]
	[FieldOffset(Offset = "0x78")]
	public LazyGameObject TallyViewPrefab;

	[Token(Token = "0x40020B9")]
	[FieldOffset(Offset = "0x80")]
	public LazyGameObject ModeViewPrefab;

	[Token(Token = "0x40020BA")]
	[FieldOffset(Offset = "0x88")]
	public LazyGameObject UnitySplashScreenViewPrefab;

	[Token(Token = "0x40020BB")]
	[FieldOffset(Offset = "0x90")]
	public LoadingBackgroundDetail[] LoadingBackgroundDetailList;

	[NonSerialized]
	[Token(Token = "0x40020BC")]
	[FieldOffset(Offset = "0x98")]
	private UIScreen _currentScreen;

	[NonSerialized]
	[Token(Token = "0x40020BD")]
	[FieldOffset(Offset = "0x9C")]
	private UIScreen _preloadedScreen;

	[NonSerialized]
	[Token(Token = "0x40020BE")]
	[FieldOffset(Offset = "0xA0")]
	private bool _loadingCompleted;

	[NonSerialized]
	[Token(Token = "0x40020BF")]
	[FieldOffset(Offset = "0xA1")]
	private bool _loadingScreenTapped;

	[NonSerialized]
	[Token(Token = "0x40020C0")]
	[FieldOffset(Offset = "0xA2")]
	private bool _firstLoadingScreenShown;

	[NonSerialized]
	[Token(Token = "0x40020C1")]
	[FieldOffset(Offset = "0xA8")]
	private string _loadingScreenCurrentHint;

	[NonSerialized]
	[Token(Token = "0x40020C2")]
	[FieldOffset(Offset = "0xB0")]
	private string[] _loadingScreenHintKeys;

	[NonSerialized]
	[Token(Token = "0x40020C3")]
	[FieldOffset(Offset = "0xB8")]
	private LoadingBackgroundDetail _loadingScreenCurrentBackground;

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x1172B74", Offset = "0x1172B74", VA = "0x1172B74", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002695")]
	[Address(RVA = "0x11733A8", Offset = "0x11733A8", VA = "0x11733A8")]
	private object GetLoadingScreenHintKeys()
	{
		return null;
	}

	[Token(Token = "0x6002696")]
	[Address(RVA = "0x1173594", Offset = "0x1173594", VA = "0x1173594")]
	public UIViewModel()
	{
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0x1173864", Offset = "0x1173864", VA = "0x1173864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7C0", Offset = "0x61C7C0")]
	private object _003CBindAllVariables_003Eb__38_0()
	{
		return null;
	}

	[Token(Token = "0x6002699")]
	[Address(RVA = "0x11738C4", Offset = "0x11738C4", VA = "0x11738C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7D0", Offset = "0x61C7D0")]
	private void _003CBindAllVariables_003Eb__38_1(object a)
	{
	}

	[Token(Token = "0x600269A")]
	[Address(RVA = "0x1173948", Offset = "0x1173948", VA = "0x1173948")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7E0", Offset = "0x61C7E0")]
	private object _003CBindAllVariables_003Eb__38_2()
	{
		return null;
	}

	[Token(Token = "0x600269B")]
	[Address(RVA = "0x11739A8", Offset = "0x11739A8", VA = "0x11739A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C7F0", Offset = "0x61C7F0")]
	private void _003CBindAllVariables_003Eb__38_3(object a)
	{
	}

	[Token(Token = "0x600269C")]
	[Address(RVA = "0x1173A2C", Offset = "0x1173A2C", VA = "0x1173A2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C800", Offset = "0x61C800")]
	private object _003CBindAllVariables_003Eb__38_4()
	{
		return null;
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0x1173A34", Offset = "0x1173A34", VA = "0x1173A34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C810", Offset = "0x61C810")]
	private object _003CBindAllVariables_003Eb__38_5()
	{
		return null;
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0x1173A3C", Offset = "0x1173A3C", VA = "0x1173A3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C820", Offset = "0x61C820")]
	private object _003CBindAllVariables_003Eb__38_6()
	{
		return null;
	}

	[Token(Token = "0x600269F")]
	[Address(RVA = "0x1173A44", Offset = "0x1173A44", VA = "0x1173A44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C830", Offset = "0x61C830")]
	private object _003CBindAllVariables_003Eb__38_7()
	{
		return null;
	}

	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x1173A4C", Offset = "0x1173A4C", VA = "0x1173A4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C840", Offset = "0x61C840")]
	private object _003CBindAllVariables_003Eb__38_8()
	{
		return null;
	}

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x1173A54", Offset = "0x1173A54", VA = "0x1173A54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C850", Offset = "0x61C850")]
	private object _003CBindAllVariables_003Eb__38_9()
	{
		return null;
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x1173A5C", Offset = "0x1173A5C", VA = "0x1173A5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C860", Offset = "0x61C860")]
	private object _003CBindAllVariables_003Eb__38_10()
	{
		return null;
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x1173A64", Offset = "0x1173A64", VA = "0x1173A64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C870", Offset = "0x61C870")]
	private object _003CBindAllVariables_003Eb__38_11()
	{
		return null;
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x1173A6C", Offset = "0x1173A6C", VA = "0x1173A6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C880", Offset = "0x61C880")]
	private void _003CBindAllVariables_003Eb__38_12(object a)
	{
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x1173ADC", Offset = "0x1173ADC", VA = "0x1173ADC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C890", Offset = "0x61C890")]
	private bool _003CBindAllVariables_003Eb__38_13()
	{
		return default(bool);
	}

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x1173AE4", Offset = "0x1173AE4", VA = "0x1173AE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8A0", Offset = "0x61C8A0")]
	private void _003CBindAllVariables_003Eb__38_14(bool a)
	{
	}

	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x1173AF0", Offset = "0x1173AF0", VA = "0x1173AF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8B0", Offset = "0x61C8B0")]
	private bool _003CBindAllVariables_003Eb__38_15()
	{
		return default(bool);
	}

	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x1173AF8", Offset = "0x1173AF8", VA = "0x1173AF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8C0", Offset = "0x61C8C0")]
	private void _003CBindAllVariables_003Eb__38_16(bool a)
	{
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x1173B04", Offset = "0x1173B04", VA = "0x1173B04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8D0", Offset = "0x61C8D0")]
	private bool _003CBindAllVariables_003Eb__38_17()
	{
		return default(bool);
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x1173B0C", Offset = "0x1173B0C", VA = "0x1173B0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8E0", Offset = "0x61C8E0")]
	private void _003CBindAllVariables_003Eb__38_18(bool a)
	{
	}

	[Token(Token = "0x60026AB")]
	[Address(RVA = "0x1173B18", Offset = "0x1173B18", VA = "0x1173B18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C8F0", Offset = "0x61C8F0")]
	private object _003CBindAllVariables_003Eb__38_19()
	{
		return null;
	}

	[Token(Token = "0x60026AC")]
	[Address(RVA = "0x1173B20", Offset = "0x1173B20", VA = "0x1173B20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C900", Offset = "0x61C900")]
	private void _003CBindAllVariables_003Eb__38_20(object a)
	{
	}

	[Token(Token = "0x60026AD")]
	[Address(RVA = "0x1173B90", Offset = "0x1173B90", VA = "0x1173B90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C910", Offset = "0x61C910")]
	private object _003CBindAllVariables_003Eb__38_21()
	{
		return null;
	}

	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x1173B98", Offset = "0x1173B98", VA = "0x1173B98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C920", Offset = "0x61C920")]
	private void _003CBindAllVariables_003Eb__38_22(object a)
	{
	}

	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x1173C24", Offset = "0x1173C24", VA = "0x1173C24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C930", Offset = "0x61C930")]
	private object _003CBindAllVariables_003Eb__38_23()
	{
		return null;
	}
}
