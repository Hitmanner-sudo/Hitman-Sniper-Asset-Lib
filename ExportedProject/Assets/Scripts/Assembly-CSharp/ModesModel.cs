using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005DD")]
public class ModesModel : DataModel
{
	[Serializable]
	[Token(Token = "0x20005DE")]
	public class MainMenuPageInfo
	{
		[Token(Token = "0x4001FDE")]
		[FieldOffset(Offset = "0x10")]
		public LazyMainMenuPageView ViewPrefab;

		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x18")]
		public ContractData.ModeTypeEnum GoToMode;

		[Token(Token = "0x4001FE0")]
		[FieldOffset(Offset = "0x20")]
		public string OnGrayedOutClickTooltipMessage;

		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x28")]
		public string NameLocalizationKey;

		[Token(Token = "0x4001FE2")]
		[FieldOffset(Offset = "0x30")]
		public int ShowOnLevel;

		[Token(Token = "0x4001FE3")]
		[FieldOffset(Offset = "0x34")]
		public bool ShowInNavigationBar;

		[Token(Token = "0x4001FE4")]
		[FieldOffset(Offset = "0x38")]
		public ContractData.ModeTypeEnum[] VisibleInModeType;

		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x40")]
		public bool IsDefaultPageForMode;

		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x41")]
		public bool ActivateOnCreate;

		[NonSerialized]
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x44")]
		public MenuPages PageID;

		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x8C8EE0", Offset = "0x8C8EE0", VA = "0x8C8EE0")]
		public MainMenuPageInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005DF")]
	public class ModeNavBarInfo
	{
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x10")]
		public ColorModel.ColorModelEnum NavBarButtonSelectedColor;

		[Token(Token = "0x4001FE9")]
		[FieldOffset(Offset = "0x14")]
		public ColorModel.ColorModelEnum NavBarButtonNotSelectedColor;

		[Token(Token = "0x4001FEA")]
		[FieldOffset(Offset = "0x18")]
		public ColorModel.ColorModelEnum NavBarButtonLabelSelectedColor;

		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x1C")]
		public ColorModel.ColorModelEnum NavBarButtonLabelNotSelectedColor;

		[Token(Token = "0x4001FEC")]
		[FieldOffset(Offset = "0x20")]
		public ColorModel.ColorModelEnum NavBarButtonNumberSelectedColor;

		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x24")]
		public ColorModel.ColorModelEnum NavBarButtonNumberNotSelectedColor;

		[Token(Token = "0x4001FEE")]
		[FieldOffset(Offset = "0x28")]
		public ColorModel.ColorModelEnum NavBarButtonNumberBackgroundSelectedColor;

		[Token(Token = "0x4001FEF")]
		[FieldOffset(Offset = "0x2C")]
		public ColorModel.ColorModelEnum NavBarButtonNumberBackgroundNotSelectedColor;

		[Token(Token = "0x4001FF0")]
		[FieldOffset(Offset = "0x30")]
		public ColorModel.ColorModelEnum TopNavBarColor;

		[Token(Token = "0x4001FF1")]
		[FieldOffset(Offset = "0x34")]
		public Wallet.Currency TopNavBarDisplayCurrency;

		[Token(Token = "0x4001FF2")]
		[FieldOffset(Offset = "0x38")]
		public ColorModel.ColorModelEnum TopNavBarDisplayCurrencyColor;

		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x3C")]
		public int TopNavBarDisplayCurrencyOffset;

		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x40")]
		public Wallet.Currency TopNavBarDisplayToken;

		[Token(Token = "0x4001FF5")]
		[FieldOffset(Offset = "0x44")]
		public ColorModel.ColorModelEnum TopNavBarDisplayTokenColor;

		[Token(Token = "0x4001FF6")]
		[FieldOffset(Offset = "0x48")]
		public bool DisplayRankInfo;

		[Token(Token = "0x4001FF7")]
		[FieldOffset(Offset = "0x49")]
		public bool DisplayCurrencyInfo;

		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x4A")]
		public bool DisplayTokenInfo;

		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x8C8EF8", Offset = "0x8C8EF8", VA = "0x8C8EF8")]
		public ModeNavBarInfo()
		{
		}
	}

	[Token(Token = "0x20005E0")]
	public enum MenuPages
	{
		[Token(Token = "0x4001FFA")]
		Contract = 0,
		[Token(Token = "0x4001FFB")]
		Amoury = 1,
		[Token(Token = "0x4001FFC")]
		Targets = 2,
		[Token(Token = "0x4001FFD")]
		Perks = 3,
		[Token(Token = "0x4001FFE")]
		Challenge = 4,
		[Token(Token = "0x4001FFF")]
		NONE = -1
	}

	[Serializable]
	[Token(Token = "0x20005E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59546C", Offset = "0x59546C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002000")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002001")]
		[FieldOffset(Offset = "0x8")]
		public static GetVariableDelegate<bool> _003C_003E9__31_7;

		[Token(Token = "0x4002002")]
		[FieldOffset(Offset = "0x10")]
		public static SetVariableDelegate<bool> _003C_003E9__31_8;

		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x8C8E08", Offset = "0x8C8E08", VA = "0x8C8E08")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x8C8E10", Offset = "0x8C8E10", VA = "0x8C8E10")]
		internal bool _003CBindAllVariables_003Eb__31_7()
		{
			return default(bool);
		}

		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x8C8E74", Offset = "0x8C8E74", VA = "0x8C8E74")]
		internal void _003CBindAllVariables_003Eb__31_8(bool b)
		{
		}
	}

	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CURRENT_PAGE;

	[Token(Token = "0x4001FC3")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string PREVIOUS_PAGE;

	[Token(Token = "0x4001FC4")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string RECREATE_SUBPAGES;

	[Token(Token = "0x4001FC5")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string PAGES;

	[Token(Token = "0x4001FC6")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string NAV_BAR_INFO;

	[Token(Token = "0x4001FC7")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SHOW_NAV_BARS;

	[Token(Token = "0x4001FC8")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string SHOW_SPLASH_SCREEN;

	[Token(Token = "0x4001FC9")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string LOCK_MENU;

	[Token(Token = "0x4001FCA")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string LOCK_MENU_FOR_CHILD;

	[Token(Token = "0x4001FCB")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string DISPLAY_RANK_INFO;

	[Token(Token = "0x4001FCC")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string DISPLAY_CURRENCIES_INFO;

	[Token(Token = "0x4001FCD")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string OPTIONS_POPUP;

	[Token(Token = "0x4001FCE")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string IN_TARGETS_TUTORIAL;

	[Token(Token = "0x4001FCF")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string HELPSHIFT_NOTIFICATION_COUNT;

	[Token(Token = "0x4001FD0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<MainMenuPageInfo> _pages;

	[Token(Token = "0x4001FD1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<ModeNavBarInfo> _navBarsInfo;

	[Token(Token = "0x4001FD2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private MenuOptionsView _menuOptionsPrefab;

	[NonSerialized]
	[Token(Token = "0x4001FD3")]
	[FieldOffset(Offset = "0x60")]
	private MenuPages _currentPage;

	[NonSerialized]
	[Token(Token = "0x4001FD4")]
	[FieldOffset(Offset = "0x64")]
	private MenuPages _previousPage;

	[NonSerialized]
	[Token(Token = "0x4001FD5")]
	[FieldOffset(Offset = "0x68")]
	private bool _recreateSubPages;

	[NonSerialized]
	[Token(Token = "0x4001FD6")]
	[FieldOffset(Offset = "0x69")]
	private bool _showNavBars;

	[Token(Token = "0x4001FD7")]
	[FieldOffset(Offset = "0x70")]
	private static bool _showSplashScreen;

	[NonSerialized]
	[Token(Token = "0x4001FD8")]
	[FieldOffset(Offset = "0x6A")]
	private bool _lockMenu;

	[NonSerialized]
	[Token(Token = "0x4001FD9")]
	[FieldOffset(Offset = "0x6B")]
	private bool _lockMenuForChild;

	[NonSerialized]
	[Token(Token = "0x4001FDA")]
	[FieldOffset(Offset = "0x6C")]
	private bool _displayRankInfo;

	[NonSerialized]
	[Token(Token = "0x4001FDB")]
	[FieldOffset(Offset = "0x6D")]
	private bool _displayCurrenciesInfo;

	[NonSerialized]
	[Token(Token = "0x4001FDC")]
	[FieldOffset(Offset = "0x6E")]
	private bool _inTargetsTutorial;

	[NonSerialized]
	[Token(Token = "0x4001FDD")]
	[FieldOffset(Offset = "0x70")]
	private int _helpshiftNotificationCount;

	[Token(Token = "0x60025BD")]
	[Address(RVA = "0xA2B238", Offset = "0xA2B238", VA = "0xA2B238", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60025BE")]
	[Address(RVA = "0xA2BB4C", Offset = "0xA2BB4C", VA = "0xA2BB4C")]
	private ModeNavBarInfo GetCurrentModeNavBarInfo()
	{
		return null;
	}

	[Token(Token = "0x60025BF")]
	[Address(RVA = "0xA2BC60", Offset = "0xA2BC60", VA = "0xA2BC60")]
	private void SetCurrentPage(MenuPages page)
	{
	}

	[Token(Token = "0x60025C0")]
	[Address(RVA = "0xA2BC6C", Offset = "0xA2BC6C", VA = "0xA2BC6C")]
	public ModesModel()
	{
	}

	[Token(Token = "0x60025C2")]
	[Address(RVA = "0xA2C020", Offset = "0xA2C020", VA = "0xA2C020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C0D0", Offset = "0x61C0D0")]
	private object _003CBindAllVariables_003Eb__31_0()
	{
		return null;
	}

	[Token(Token = "0x60025C3")]
	[Address(RVA = "0xA2C028", Offset = "0xA2C028", VA = "0xA2C028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C0E0", Offset = "0x61C0E0")]
	private object _003CBindAllVariables_003Eb__31_1()
	{
		return null;
	}

	[Token(Token = "0x60025C4")]
	[Address(RVA = "0xA2C088", Offset = "0xA2C088", VA = "0xA2C088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C0F0", Offset = "0x61C0F0")]
	private void _003CBindAllVariables_003Eb__31_2(object i)
	{
	}

	[Token(Token = "0x60025C5")]
	[Address(RVA = "0xA2C110", Offset = "0xA2C110", VA = "0xA2C110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C100", Offset = "0x61C100")]
	private bool _003CBindAllVariables_003Eb__31_3()
	{
		return default(bool);
	}

	[Token(Token = "0x60025C6")]
	[Address(RVA = "0xA2C118", Offset = "0xA2C118", VA = "0xA2C118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C110", Offset = "0x61C110")]
	private void _003CBindAllVariables_003Eb__31_4(bool b)
	{
	}

	[Token(Token = "0x60025C7")]
	[Address(RVA = "0xA2C124", Offset = "0xA2C124", VA = "0xA2C124")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C120", Offset = "0x61C120")]
	private bool _003CBindAllVariables_003Eb__31_5()
	{
		return default(bool);
	}

	[Token(Token = "0x60025C8")]
	[Address(RVA = "0xA2C12C", Offset = "0xA2C12C", VA = "0xA2C12C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C130", Offset = "0x61C130")]
	private void _003CBindAllVariables_003Eb__31_6(bool b)
	{
	}

	[Token(Token = "0x60025C9")]
	[Address(RVA = "0xA2C138", Offset = "0xA2C138", VA = "0xA2C138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C140", Offset = "0x61C140")]
	private bool _003CBindAllVariables_003Eb__31_9()
	{
		return default(bool);
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0xA2C140", Offset = "0xA2C140", VA = "0xA2C140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C150", Offset = "0x61C150")]
	private void _003CBindAllVariables_003Eb__31_10(bool b)
	{
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0xA2C14C", Offset = "0xA2C14C", VA = "0xA2C14C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C160", Offset = "0x61C160")]
	private bool _003CBindAllVariables_003Eb__31_11()
	{
		return default(bool);
	}

	[Token(Token = "0x60025CC")]
	[Address(RVA = "0xA2C154", Offset = "0xA2C154", VA = "0xA2C154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C170", Offset = "0x61C170")]
	private void _003CBindAllVariables_003Eb__31_12(bool b)
	{
	}

	[Token(Token = "0x60025CD")]
	[Address(RVA = "0xA2C160", Offset = "0xA2C160", VA = "0xA2C160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C180", Offset = "0x61C180")]
	private bool _003CBindAllVariables_003Eb__31_13()
	{
		return default(bool);
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0xA2C168", Offset = "0xA2C168", VA = "0xA2C168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C190", Offset = "0x61C190")]
	private void _003CBindAllVariables_003Eb__31_14(bool b)
	{
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0xA2C174", Offset = "0xA2C174", VA = "0xA2C174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1A0", Offset = "0x61C1A0")]
	private bool _003CBindAllVariables_003Eb__31_15()
	{
		return default(bool);
	}

	[Token(Token = "0x60025D0")]
	[Address(RVA = "0xA2C17C", Offset = "0xA2C17C", VA = "0xA2C17C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1B0", Offset = "0x61C1B0")]
	private void _003CBindAllVariables_003Eb__31_16(bool b)
	{
	}

	[Token(Token = "0x60025D1")]
	[Address(RVA = "0xA2C188", Offset = "0xA2C188", VA = "0xA2C188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1C0", Offset = "0x61C1C0")]
	private object _003CBindAllVariables_003Eb__31_17()
	{
		return null;
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0xA2C1E8", Offset = "0xA2C1E8", VA = "0xA2C1E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1D0", Offset = "0x61C1D0")]
	private object _003CBindAllVariables_003Eb__31_18()
	{
		return null;
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0xA2C1F0", Offset = "0xA2C1F0", VA = "0xA2C1F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1E0", Offset = "0x61C1E0")]
	private bool _003CBindAllVariables_003Eb__31_19()
	{
		return default(bool);
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0xA2C1F8", Offset = "0xA2C1F8", VA = "0xA2C1F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C1F0", Offset = "0x61C1F0")]
	private void _003CBindAllVariables_003Eb__31_20(bool b)
	{
	}

	[Token(Token = "0x60025D5")]
	[Address(RVA = "0xA2C204", Offset = "0xA2C204", VA = "0xA2C204")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C200", Offset = "0x61C200")]
	private int _003CBindAllVariables_003Eb__31_21()
	{
		return default(int);
	}

	[Token(Token = "0x60025D6")]
	[Address(RVA = "0xA2C20C", Offset = "0xA2C20C", VA = "0xA2C20C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C210", Offset = "0x61C210")]
	private void _003CBindAllVariables_003Eb__31_22(int i)
	{
	}
}
