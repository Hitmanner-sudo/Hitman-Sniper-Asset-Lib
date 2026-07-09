using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076F")]
public class UIView : View
{
	[Token(Token = "0x2000770")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x596038", Offset = "0x596038")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x10")]
		public ContractData.ModeTypeEnum currentModeType;

		[Token(Token = "0x6003179")]
		[Address(RVA = "0xA3E90C", Offset = "0xA3E90C", VA = "0xA3E90C")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600317A")]
		[Address(RVA = "0xA3E914", Offset = "0xA3E914", VA = "0xA3E914")]
		internal bool _003CStart_003Eb__0(ModesModel.MainMenuPageInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000771")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x596048", Offset = "0x596048")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4002A17")]
		[FieldOffset(Offset = "0x10")]
		public UIView _003C_003E4__this;

		[Token(Token = "0x4002A18")]
		[FieldOffset(Offset = "0x18")]
		public UIViewModel.UIScreen previousView;

		[Token(Token = "0x4002A19")]
		[FieldOffset(Offset = "0x1C")]
		public UIViewModel.UIScreen view;

		[Token(Token = "0x600317B")]
		[Address(RVA = "0xA3E820", Offset = "0xA3E820", VA = "0xA3E820")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600317C")]
		[Address(RVA = "0xA3E828", Offset = "0xA3E828", VA = "0xA3E828")]
		internal ViewChangeEventArgs _003COnViewVisibilityChanged_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0x60")]
	private View _currentView;

	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0x68")]
	private View _preloadedView;

	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA7C8", Offset = "0x5BA7C8")]
	private static UIView _003CInstance_003Ek__BackingField;

	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x70")]
	private string[] _subViewsPrefabVariable;

	[Token(Token = "0x17000654")]
	public static UIView Instance
	{
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x11716E0", Offset = "0x11716E0", VA = "0x11716E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x622150", Offset = "0x622150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x117172C", Offset = "0x117172C", VA = "0x117172C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x622160", Offset = "0x622160")]
		private set
		{
		}
	}

	[Token(Token = "0x600316E")]
	[Address(RVA = "0x117177C", Offset = "0x117177C", VA = "0x117177C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600316F")]
	[Address(RVA = "0x11717D4", Offset = "0x11717D4", VA = "0x11717D4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0x1171888", Offset = "0x1171888", VA = "0x1171888", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003171")]
	[Address(RVA = "0x1171E78", Offset = "0x1171E78", VA = "0x1171E78", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0x117233C", Offset = "0x117233C", VA = "0x117233C")]
	private void OnResettingLoadingTips(UIViewModel.UIScreen newScreen)
	{
	}

	[Token(Token = "0x6003173")]
	[Address(RVA = "0x1172058", Offset = "0x1172058", VA = "0x1172058")]
	private void OnViewVisibilityChanged(UIViewModel.UIScreen view, UIViewModel.UIScreen previousView)
	{
	}

	[Token(Token = "0x6003174")]
	[Address(RVA = "0x1172698", Offset = "0x1172698", VA = "0x1172698")]
	private void InstantiateCurrentView(LazyGameObject currentViewRef)
	{
	}

	[Token(Token = "0x6003175")]
	[Address(RVA = "0x11723F0", Offset = "0x11723F0", VA = "0x11723F0")]
	private void OnPreloadedScreenChanged(UIViewModel.UIScreen enumView)
	{
	}

	[Token(Token = "0x6003176")]
	[Address(RVA = "0x11727E4", Offset = "0x11727E4", VA = "0x11727E4")]
	public static View InstantiateView(View prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6003177")]
	[Address(RVA = "0x11725B8", Offset = "0x11725B8", VA = "0x11725B8")]
	public static void DestroyView(ref View view)
	{
	}

	[Token(Token = "0x6003178")]
	[Address(RVA = "0x1172910", Offset = "0x1172910", VA = "0x1172910")]
	public UIView()
	{
	}
}
