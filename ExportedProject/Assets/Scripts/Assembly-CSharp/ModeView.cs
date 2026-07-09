using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000717")]
public class ModeView : View
{
	[Token(Token = "0x2000718")]
	public class MenuNavBarData
	{
		[Token(Token = "0x400284E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainMenuPageView MenuView;

		[Token(Token = "0x400284F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NavigationBarItem NavBar;

		[Token(Token = "0x4002850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModesModel.MainMenuPageInfo PageInfo;

		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x8C8BA4", Offset = "0x8C8BA4", VA = "0x8C8BA4")]
		public MenuNavBarData(MainMenuPageView view, NavigationBarItem item, ModesModel.MainMenuPageInfo pageInfo)
		{
		}
	}

	[Token(Token = "0x2000719")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E38", Offset = "0x595E38")]
	private sealed class _003C_003Ec__DisplayClass94_0
	{
		[Token(Token = "0x4002851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContractData.ModeTypeEnum currentModeType;

		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x8C8928", Offset = "0x8C8928", VA = "0x8C8928")]
		public _003C_003Ec__DisplayClass94_0()
		{
		}

		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x8C8930", Offset = "0x8C8930", VA = "0x8C8930")]
		internal bool _003CGetModeDefaultPage_003Eb__0(ModesModel.MainMenuPageInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200071A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E48", Offset = "0x595E48")]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		[Token(Token = "0x4002852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModeView _003C_003E4__this;

		[Token(Token = "0x4002853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ContractData.ModeTypeEnum currentModeType;

		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x8C8964", Offset = "0x8C8964", VA = "0x8C8964")]
		public _003C_003Ec__DisplayClass98_0()
		{
		}

		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x8C896C", Offset = "0x8C896C", VA = "0x8C896C")]
		internal bool _003CResizeNavBar_003Eb__0(MenuNavBarData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200071B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E58", Offset = "0x595E58")]
	private sealed class _003C_003Ec__DisplayClass107_0
	{
		[Token(Token = "0x4002854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModesModel.MenuPages page;

		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x8C867C", Offset = "0x8C867C", VA = "0x8C867C")]
		public _003C_003Ec__DisplayClass107_0()
		{
		}

		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x8C8684", Offset = "0x8C8684", VA = "0x8C8684")]
		internal bool _003CFindPage_003Eb__0(MenuNavBarData p)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200071C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E68", Offset = "0x595E68")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RogueData, int> _003C_003E9__109_0;

		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x8C865C", Offset = "0x8C865C", VA = "0x8C865C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x8C8664", Offset = "0x8C8664", VA = "0x8C8664")]
		internal int _003CSetupNextRogue_003Eb__109_0(RogueData r)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200071D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E78", Offset = "0x595E78")]
	private sealed class _003C_003Ec__DisplayClass115_0
	{
		[Token(Token = "0x4002857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainMenuPageView view;

		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x8C872C", Offset = "0x8C872C", VA = "0x8C872C")]
		public _003C_003Ec__DisplayClass115_0()
		{
		}

		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x8C8734", Offset = "0x8C8734", VA = "0x8C8734")]
		internal bool _003CGetPageIndex_003Eb__0(MenuNavBarData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200071E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E88", Offset = "0x595E88")]
	private sealed class _003C_003Ec__DisplayClass120_0
	{
		[Token(Token = "0x4002858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModesModel.MenuPages newPage;

		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x8C87C8", Offset = "0x8C87C8", VA = "0x8C87C8")]
		public _003C_003Ec__DisplayClass120_0()
		{
		}

		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x8C87D0", Offset = "0x8C87D0", VA = "0x8C87D0")]
		internal bool _003CFadeToPage_003Eb__0(MenuNavBarData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200071F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E98", Offset = "0x595E98")]
	private sealed class _003C_003Ec__DisplayClass121_0
	{
		[Token(Token = "0x4002859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModesModel.MenuPages page;

		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x8C8878", Offset = "0x8C8878", VA = "0x8C8878")]
		public _003C_003Ec__DisplayClass121_0()
		{
		}

		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x8C8880", Offset = "0x8C8880", VA = "0x8C8880")]
		internal bool _003COnFadingOutDonePageCentered_003Eb__0(MenuNavBarData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000720")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595EA8", Offset = "0x595EA8")]
	private sealed class _003CDelayHideTooltip_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400285A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400285B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400285C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModeView _003C_003E4__this;

		[Token(Token = "0x400285D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float displayTime;

		[Token(Token = "0x400285E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PointyTooltip tooltip;

		[Token(Token = "0x17000621")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F94")]
			[Address(RVA = "0x8C8B54", Offset = "0x8C8B54", VA = "0x8C8B54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000622")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0x8C8B9C", Offset = "0x8C8B9C", VA = "0x8C8B9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x8C8A1C", Offset = "0x8C8A1C", VA = "0x8C8A1C")]
		[DebuggerHidden]
		public _003CDelayHideTooltip_003Ed__152(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x8C8A48", Offset = "0x8C8A48", VA = "0x8C8A48", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x8C8A4C", Offset = "0x8C8A4C", VA = "0x8C8A4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x8C8B5C", Offset = "0x8C8B5C", VA = "0x8C8B5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400280D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject StorePagesGrid;

	[Token(Token = "0x400280E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public NavigationBarItem NavBarItemPrefab;

	[Token(Token = "0x400280F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UIGrid NavBarGrid;

	[Token(Token = "0x4002810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public UISprite TopBar;

	[Token(Token = "0x4002811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UISprite BottomBar;

	[Token(Token = "0x4002812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UIAlignedList InfoBar;

	[Token(Token = "0x4002813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public UILabel GoldValue;

	[Token(Token = "0x4002814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public UILabel GoldIcon;

	[Token(Token = "0x4002815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject GoldInfo;

	[Token(Token = "0x4002816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject GoldSaleNotification;

	[Token(Token = "0x4002817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public UILabel TokenValue;

	[Token(Token = "0x4002818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UILabel TokenIcon;

	[Token(Token = "0x4002819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject TokensInfo;

	[Token(Token = "0x400281A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject TokensSaleNotification;

	[Token(Token = "0x400281B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject RankInfo;

	[Token(Token = "0x400281C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public UILabel RankName;

	[Token(Token = "0x400281D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public UISprite RankBarItemPrefab;

	[Token(Token = "0x400281E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform RankBarHolder;

	[Token(Token = "0x400281F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public UILabel LevelText;

	[Token(Token = "0x4002820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float NavBarSlideDuration;

	[Token(Token = "0x4002821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public UISprite MenuFadeOverlay;

	[Token(Token = "0x4002822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public UISprite FadeOverlay;

	[Token(Token = "0x4002823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Camera Camera3D;

	[Token(Token = "0x4002824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Camera BackgroundCamera3D;

	[Token(Token = "0x4002825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public UIAlignedList TopNavBarRightUIAlignedList;

	[Token(Token = "0x4002826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public UIAlignedList TopNavBarLeftUIAlignedList;

	[Token(Token = "0x4002827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject StarterPackGO;

	[Token(Token = "0x4002828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public BlinkButtonHandler AddGoldButton;

	[Token(Token = "0x4002829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public BlinkButtonHandler AddTokensButton;

	[Token(Token = "0x400282A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public UISprite AddGoldButtonBackground;

	[Token(Token = "0x400282B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public UISprite AddTokensButtonBackground;

	[Token(Token = "0x400282C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public UISprite AddGoldButtonIcon;

	[Token(Token = "0x400282D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public UISprite AddTokensButtonIcon;

	[Token(Token = "0x400282E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public TweenColor AddGoldTweenColor;

	[Token(Token = "0x400282F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public TweenColor AddTokensTweenColor;

	[Token(Token = "0x4002830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public PointyTooltip AddGoldPointyTooltip;

	[Token(Token = "0x4002831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public PointyTooltip AddTokensPointyTooltip;

	[Token(Token = "0x4002832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public OfferDescription StarterPackOfferDescription;

	[Token(Token = "0x4002833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public DimmedBackgroundView DimmedBackgroundPrefab;

	[Token(Token = "0x4002834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public DimmedBackgroundView TransparentBackgroundPrefab;

	[Token(Token = "0x4002835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public bool ArmorySaleNotification;

	[Token(Token = "0x4002836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public int MaxCurrencyLabelWidth;

	[NonSerialized]
	[Token(Token = "0x4002837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public DimmedBackgroundView CurrentDimmedBackground;

	[Token(Token = "0x4002838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private GameObject _helpshiftNotificationCountObject;

	[Token(Token = "0x4002839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<UISprite> _rankBars;

	[Token(Token = "0x400283A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool _created;

	[Token(Token = "0x400283B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
	private bool _fadingInMenu;

	[Token(Token = "0x400283C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
	private bool _fadingOutMenu;

	[Token(Token = "0x400283D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Action _fadeInMenuAction;

	[Token(Token = "0x400283E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool _fadingIn;

	[Token(Token = "0x400283F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
	private bool _fadingOut;

	[Token(Token = "0x4002840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
	private bool _shouldCheckCurrencyLabelsWidth;

	[Token(Token = "0x4002841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Action _fadeInAction;

	[Token(Token = "0x4002842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ModesModel.MenuPages _firstMenuPage;

	[Token(Token = "0x4002843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private bool _firstUpdateDone;

	[Token(Token = "0x4002844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Wallet.Currency _currencyToDisplay;

	[Token(Token = "0x4002845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	private Wallet.Currency _tokenToDisplay;

	[Token(Token = "0x4002846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private Coroutine _hideTooltipCoroutine;

	[Token(Token = "0x4002847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private GameTimer _timer;

	[Token(Token = "0x4002848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private EventHandler<ButtonHandler.ButtonHandlerEventArgs> _onDismiss;

	[Token(Token = "0x4002849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9DAC", Offset = "0x5B9DAC")]
	private static ModeView _003CInstance_003Ek__BackingField;

	[Token(Token = "0x400284A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9DBC", Offset = "0x5B9DBC")]
	private List<MenuNavBarData> _003CAllPages_003Ek__BackingField;

	[Token(Token = "0x1700061B")]
	private bool IsGoldOnSale
	{
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0xA22F3C", Offset = "0xA22F3C", VA = "0xA22F3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0xA22FAC", Offset = "0xA22FAC", VA = "0xA22FAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700061C")]
	private bool IsTokensOnSale
	{
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0xA2302C", Offset = "0xA2302C", VA = "0xA2302C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0xA2309C", Offset = "0xA2309C", VA = "0xA2309C")]
		set
		{
		}
	}

	[Token(Token = "0x1700061D")]
	private bool IsNewGoldSaleOn
	{
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0xA2311C", Offset = "0xA2311C", VA = "0xA2311C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0xA2318C", Offset = "0xA2318C", VA = "0xA2318C")]
		set
		{
		}
	}

	[Token(Token = "0x1700061E")]
	private bool IsNewTokenSaleOn
	{
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0xA2320C", Offset = "0xA2320C", VA = "0xA2320C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0xA2327C", Offset = "0xA2327C", VA = "0xA2327C")]
		set
		{
		}
	}

	[Token(Token = "0x1700061F")]
	public static ModeView Instance
	{
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0xA232FC", Offset = "0xA232FC", VA = "0xA232FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216A0", Offset = "0x6216A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0xA23348", Offset = "0xA23348", VA = "0xA23348")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216B0", Offset = "0x6216B0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000620")]
	public List<MenuNavBarData> AllPages
	{
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0xA23398", Offset = "0xA23398", VA = "0xA23398")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216C0", Offset = "0x6216C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0xA233A0", Offset = "0xA233A0", VA = "0xA233A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216D0", Offset = "0x6216D0")]
		private set
		{
		}
	}

	[Token(Token = "0x140000A4")]
	public event EventHandler<EventArgs> OnFadingInDone
	{
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0xA1F798", Offset = "0xA1F798", VA = "0xA1F798")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216E0", Offset = "0x6216E0")]
		add
		{
		}
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0xA203B0", Offset = "0xA203B0", VA = "0xA203B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6216F0", Offset = "0x6216F0")]
		remove
		{
		}
	}

	[Token(Token = "0x140000A5")]
	public event EventHandler<EventArgs> OnFadingOutDone
	{
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0xA1F83C", Offset = "0xA1F83C", VA = "0xA1F83C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621700", Offset = "0x621700")]
		add
		{
		}
		[Token(Token = "0x6002F37")]
		[Address(RVA = "0xA20454", Offset = "0xA20454", VA = "0xA20454")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621710", Offset = "0x621710")]
		remove
		{
		}
	}

	[Token(Token = "0x140000A6")]
	public event EventHandler ShowNavBarsChanged
	{
		[Token(Token = "0x6002F38")]
		[Address(RVA = "0xA233A8", Offset = "0xA233A8", VA = "0xA233A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621720", Offset = "0x621720")]
		add
		{
		}
		[Token(Token = "0x6002F39")]
		[Address(RVA = "0xA2344C", Offset = "0xA2344C", VA = "0xA2344C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621730", Offset = "0x621730")]
		remove
		{
		}
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0xA234F0", Offset = "0xA234F0", VA = "0xA234F0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0xA23988", Offset = "0xA23988", VA = "0xA23988", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0xA23B48", Offset = "0xA23B48", VA = "0xA23B48", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0xA25888", Offset = "0xA25888", VA = "0xA25888")]
	private void OnChangeMissionCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0xA24EAC", Offset = "0xA24EAC", VA = "0xA24EAC")]
	private void CreateSubPages()
	{
	}

	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0xA2588C", Offset = "0xA2588C", VA = "0xA2588C")]
	public ModesModel.MenuPages GetModeDefaultPage(ContractData.ModeTypeEnum currentModeType)
	{
		return default(ModesModel.MenuPages);
	}

	[Token(Token = "0x6002F40")]
	[Address(RVA = "0xA267D0", Offset = "0xA267D0", VA = "0xA267D0")]
	private bool ShouldBeClickable(MenuNavBarData menuNavBarData)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F41")]
	[Address(RVA = "0xA26930", Offset = "0xA26930", VA = "0xA26930")]
	private bool ShouldBeActive(MenuNavBarData menuNavBarData, ContractData.ModeTypeEnum currentModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0xA2699C", Offset = "0xA2699C", VA = "0xA2699C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0xA26CE0", Offset = "0xA26CE0", VA = "0xA26CE0")]
	private void ResizeNavBar(ContractData.ModeTypeEnum currentModeType)
	{
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0xA270CC", Offset = "0xA270CC", VA = "0xA270CC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0xA27664", Offset = "0xA27664", VA = "0xA27664")]
	public void ForceRefreshMenuPages()
	{
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0xA25F0C", Offset = "0xA25F0C", VA = "0xA25F0C")]
	private void RefreshMenuPages(ContractData.ModeTypeEnum currentModeType)
	{
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0xA2797C", Offset = "0xA2797C", VA = "0xA2797C")]
	public void RecreatePage(ModesModel.MenuPages pageID)
	{
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0xA259D8", Offset = "0xA259D8", VA = "0xA259D8")]
	private MainMenuPageView CreatePage(ModesModel.MainMenuPageInfo mainMenuPageInfo, ModesModel.MenuPages pageID)
	{
		return null;
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0xA25CC4", Offset = "0xA25CC4", VA = "0xA25CC4")]
	private NavigationBarItem CreateNavBarItem(string localizedName, ModesModel.MenuPages pageID, ContractData.ModeTypeEnum goToMode, string onGrayedOutClickTooltipMessage)
	{
		return null;
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0xA2775C", Offset = "0xA2775C", VA = "0xA2775C")]
	private void UpdateNavBarItemColor(NavigationBarItem navigationBarItem)
	{
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0xA26478", Offset = "0xA26478", VA = "0xA26478")]
	private void UpdateTopNavBar()
	{
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0xA27ADC", Offset = "0xA27ADC", VA = "0xA27ADC")]
	public MenuNavBarData FindPage(ModesModel.MenuPages page)
	{
		return null;
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0xA27600", Offset = "0xA27600", VA = "0xA27600")]
	private void OnMissionChanged()
	{
	}

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0xA243FC", Offset = "0xA243FC", VA = "0xA243FC")]
	public void SetupNextRogue()
	{
	}

	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0xA242C4", Offset = "0xA242C4", VA = "0xA242C4")]
	public void UpdateCurrentRankUI()
	{
	}

	[Token(Token = "0x6002F50")]
	[Address(RVA = "0xA27BCC", Offset = "0xA27BCC", VA = "0xA27BCC")]
	public static void SetRankText(RankData[] ranks, int rank, int level, int numStars, UILabel rankName, List<UISprite> rankBars, Transform rankBarHolder, UISprite rankBarItemPrefab, UIAlignedList infoBarList)
	{
	}

	[Token(Token = "0x6002F51")]
	[Address(RVA = "0xA28154", Offset = "0xA28154", VA = "0xA28154", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002F52")]
	[Address(RVA = "0xA2855C", Offset = "0xA2855C", VA = "0xA2855C")]
	private void OnInfoBarUpdated(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002F53")]
	[Address(RVA = "0xA28440", Offset = "0xA28440", VA = "0xA28440")]
	private void OnFirstUpdate()
	{
	}

	[Token(Token = "0x6002F54")]
	[Address(RVA = "0xA286B4", Offset = "0xA286B4", VA = "0xA286B4")]
	public int GetPageIndex(MainMenuPageView view)
	{
		return default(int);
	}

	[Token(Token = "0x6002F55")]
	[Address(RVA = "0xA24230", Offset = "0xA24230", VA = "0xA24230")]
	private void OnIGCValueChanged(bool skipCurrencyTween = false)
	{
	}

	[Token(Token = "0x6002F56")]
	[Address(RVA = "0xA287A4", Offset = "0xA287A4", VA = "0xA287A4")]
	private void UpdateFieldValue(Wallet.Currency currencyToDisplay, UILabel currencyValue, bool updateImmediately = false)
	{
	}

	[Token(Token = "0x6002F57")]
	[Address(RVA = "0xA285A0", Offset = "0xA285A0", VA = "0xA285A0")]
	private void CheckCurrencyLabelWidth(UILabel currencyValueLabel)
	{
	}

	[Token(Token = "0x6002F58")]
	[Address(RVA = "0xA274AC", Offset = "0xA274AC", VA = "0xA274AC")]
	private void OnCurrentPageChanged()
	{
	}

	[Token(Token = "0x6002F59")]
	[Address(RVA = "0xA26064", Offset = "0xA26064", VA = "0xA26064")]
	public void FadeToPage(ModesModel.MenuPages newPage)
	{
	}

	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0xA28918", Offset = "0xA28918", VA = "0xA28918")]
	private void OnFadingOutDonePageCentered(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0xA28BB0", Offset = "0xA28BB0", VA = "0xA28BB0")]
	public void CenterOnFirstMenuPage()
	{
	}

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0xA28C54", Offset = "0xA28C54", VA = "0xA28C54")]
	public void StartMenuFade(Action fadeDoneMenuAction, bool fadeUp)
	{
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0xA28CB8", Offset = "0xA28CB8", VA = "0xA28CB8")]
	private void ShowFirstPage()
	{
	}

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0xA28F3C", Offset = "0xA28F3C", VA = "0xA28F3C")]
	public void SetNavBarNewFeedback(ModesModel.MenuPages pageID, bool show, int numberToShow = 0, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0xA290E8", Offset = "0xA290E8", VA = "0xA290E8")]
	public void SetNavBarSalesNotification(bool show)
	{
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0xA2927C", Offset = "0xA2927C", VA = "0xA2927C")]
	private int GetArmoryUnlockLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0xA29340", Offset = "0xA29340", VA = "0xA29340")]
	private bool IsArmoryUnlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0xA293DC", Offset = "0xA293DC", VA = "0xA293DC")]
	private bool IsInDeathValley()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0xA29470", Offset = "0xA29470", VA = "0xA29470")]
	private bool ShouldAddCurrenciesBeEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0xA2563C", Offset = "0xA2563C", VA = "0xA2563C")]
	private void UpdateAddCurrenciesEnabled()
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0xA2861C", Offset = "0xA2861C", VA = "0xA2861C")]
	private void UpdateAddCurrenciesColliders()
	{
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0xA29494", Offset = "0xA29494", VA = "0xA29494")]
	private void ResetCurrenciesSalesSeen()
	{
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0xA294D0", Offset = "0xA294D0", VA = "0xA294D0")]
	private void SetGoldSaleNotification(bool show)
	{
	}

	[Token(Token = "0x6002F68")]
	[Address(RVA = "0xA29574", Offset = "0xA29574", VA = "0xA29574")]
	private void SetTokensSaleNotification(bool show)
	{
	}

	[Token(Token = "0x6002F69")]
	[Address(RVA = "0xA27614", Offset = "0xA27614", VA = "0xA27614")]
	private void UpdateGoldSaleNotification()
	{
	}

	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0xA2763C", Offset = "0xA2763C", VA = "0xA2763C")]
	private void UpdateTokensSaleNotification()
	{
	}

	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0xA29618", Offset = "0xA29618", VA = "0xA29618")]
	private void UpdateCurrencySaleState(Wallet.Currency currencyType, out bool isOnSale, out bool isNewSaleOn)
	{
	}

	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0xA29898", Offset = "0xA29898", VA = "0xA29898")]
	private void UpdateCurrenciesSaleState()
	{
	}

	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0xA24280", Offset = "0xA24280", VA = "0xA24280")]
	private void RefreshCurrencySalesView()
	{
	}

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0xA29970", Offset = "0xA29970", VA = "0xA29970")]
	private void OnOfferRefreshSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0xA28B1C", Offset = "0xA28B1C", VA = "0xA28B1C")]
	private void OnPageCentered(MainMenuPageView view)
	{
	}

	[Token(Token = "0x6002F70")]
	[Address(RVA = "0xA24974", Offset = "0xA24974", VA = "0xA24974")]
	private void OnShowNavBarsChanged(bool show)
	{
	}

	[Token(Token = "0x6002F71")]
	[Address(RVA = "0xA24A34", Offset = "0xA24A34", VA = "0xA24A34")]
	private void OnDisplayRankInfoChanged(bool display)
	{
	}

	[Token(Token = "0x6002F72")]
	[Address(RVA = "0xA24B58", Offset = "0xA24B58", VA = "0xA24B58")]
	private void OnDisplayCurrenciesInfoChanged(bool display)
	{
	}

	[Token(Token = "0x6002F73")]
	[Address(RVA = "0xA29974", Offset = "0xA29974", VA = "0xA29974")]
	private void OnLocalizeDone(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6002F74")]
	[Address(RVA = "0xA299A4", Offset = "0xA299A4", VA = "0xA299A4")]
	private void OnInventoryChanged(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6002F75")]
	[Address(RVA = "0xA22AC0", Offset = "0xA22AC0", VA = "0xA22AC0")]
	public void CheckForStarterPack()
	{
	}

	[Token(Token = "0x6002F76")]
	[Address(RVA = "0xA299AC", Offset = "0xA299AC", VA = "0xA299AC")]
	private void BlinkAddCurrencyButton(TweenColor addCurrencyTweenColor, PointyTooltip addCurrencyPointyTooltip)
	{
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0xA21CF4", Offset = "0xA21CF4", VA = "0xA21CF4")]
	public void BlinkAddGoldButton()
	{
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0xA21D00", Offset = "0xA21D00", VA = "0xA21D00")]
	public void BlinkAddTokensButton()
	{
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0xA29C1C", Offset = "0xA29C1C", VA = "0xA29C1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621740", Offset = "0x621740")]
	private IEnumerator DelayHideTooltip(PointyTooltip tooltip, float displayTime)
	{
		return null;
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0xA29CA8", Offset = "0xA29CA8", VA = "0xA29CA8")]
	public void DimBGToHighlightButton(GameObject highlightedGameObject, ButtonHandler highlightedButton, [Optional][DefaultParameterValue(0f)] float mountDelay, [Optional] Action onMountCallback, [Optional][DefaultParameterValue(false)] bool transparentBG, [Optional][DefaultParameterValue(false)] bool canClickOnBackground, [Optional] EventHandler<ButtonHandler.ButtonHandlerEventArgs> onDismiss, bool closeDimBackgroundOnButtonClicked = true)
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0xA29F1C", Offset = "0xA29F1C", VA = "0xA29F1C")]
	public void ShowDimmedBackground(bool transparentBG = false)
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0xA2A010", Offset = "0xA2A010", VA = "0xA2A010")]
	public void ClearDimmedBackground([Optional] object sender, [Optional] ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0xA25864", Offset = "0xA25864", VA = "0xA25864")]
	private void UpdateHelpshiftNotificationCount(int count)
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0xA2A27C", Offset = "0xA2A27C", VA = "0xA2A27C")]
	public ModeView()
	{
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0xA2A330", Offset = "0xA2A330", VA = "0xA2A330")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6217A0", Offset = "0x6217A0")]
	private void _003CAwake_003Eb__90_0()
	{
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0xA2A350", Offset = "0xA2A350", VA = "0xA2A350")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6217B0", Offset = "0x6217B0")]
	private void _003CAwake_003Eb__90_1()
	{
	}
}
