using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000764")]
public class TallyView : View
{
	[Token(Token = "0x2000765")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FD8", Offset = "0x595FD8")]
	private sealed class _003CHighlightWidget_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029DD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget widget;

		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x28")]
		public float waitFlashTime;

		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x2C")]
		public Color originalColor;

		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x40")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x17000648")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003134")]
			[Address(RVA = "0xA54D7C", Offset = "0xA54D7C", VA = "0xA54D7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000649")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003136")]
			[Address(RVA = "0xA54DC4", Offset = "0xA54DC4", VA = "0xA54DC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003131")]
		[Address(RVA = "0xA54C40", Offset = "0xA54C40", VA = "0xA54C40")]
		[DebuggerHidden]
		public _003CHighlightWidget_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003132")]
		[Address(RVA = "0xA54C6C", Offset = "0xA54C6C", VA = "0xA54C6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003133")]
		[Address(RVA = "0xA54C70", Offset = "0xA54C70", VA = "0xA54C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003135")]
		[Address(RVA = "0xA54D84", Offset = "0xA54D84", VA = "0xA54D84", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000766")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FE8", Offset = "0x595FE8")]
	private sealed class _003CFlashFrameBox_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x20")]
		public TallyView _003C_003E4__this;

		[Token(Token = "0x40029E5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject gameObject;

		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x30")]
		public float waitFlashTime;

		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x38")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x1700064A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600313A")]
			[Address(RVA = "0xA54BF0", Offset = "0xA54BF0", VA = "0xA54BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600313C")]
			[Address(RVA = "0xA54C38", Offset = "0xA54C38", VA = "0xA54C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003137")]
		[Address(RVA = "0xA54ABC", Offset = "0xA54ABC", VA = "0xA54ABC")]
		[DebuggerHidden]
		public _003CFlashFrameBox_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003138")]
		[Address(RVA = "0xA54AE8", Offset = "0xA54AE8", VA = "0xA54AE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003139")]
		[Address(RVA = "0xA54AEC", Offset = "0xA54AEC", VA = "0xA54AEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600313B")]
		[Address(RVA = "0xA54BF8", Offset = "0xA54BF8", VA = "0xA54BF8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x60")]
	public UILabel CurrencyValue;

	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x68")]
	public UILabel CurrencyIcon;

	[Token(Token = "0x40029C6")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TokenValue;

	[Token(Token = "0x40029C7")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TokenIcon;

	[Token(Token = "0x40029C8")]
	[FieldOffset(Offset = "0x80")]
	public UIAlignedList InfoBarList;

	[Token(Token = "0x40029C9")]
	[FieldOffset(Offset = "0x88")]
	public GameObject RankGO;

	[Token(Token = "0x40029CA")]
	[FieldOffset(Offset = "0x90")]
	public GameObject WalletGO;

	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x98")]
	public UILabel RankName;

	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite RankIcon;

	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel LevelText;

	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite RankBarItemPrefab;

	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0xB8")]
	public Transform RankBarHolder;

	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0xC0")]
	public UIAlignedList TopNavBarUIAlignedList;

	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0xC8")]
	private Wallet.Currency _currencyToDisplay;

	[Token(Token = "0x40029D2")]
	[FieldOffset(Offset = "0xCC")]
	private Wallet.Currency _tokenToDisplay;

	[Token(Token = "0x40029D3")]
	[FieldOffset(Offset = "0xD0")]
	private View _scoreTally;

	[Token(Token = "0x40029D4")]
	[FieldOffset(Offset = "0xD8")]
	private LazyGameObject _scoreTallyRef;

	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0xE0")]
	private bool _wantsScoreTally;

	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0xE1")]
	private bool _displayRankInfo;

	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0xE2")]
	private bool _displayCurrencyInfo;

	[Token(Token = "0x40029D8")]
	[FieldOffset(Offset = "0xE4")]
	private Color _rankOriginalColor;

	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0xF4")]
	private Color _currencyOriginalColor;

	[Token(Token = "0x40029DA")]
	[FieldOffset(Offset = "0x104")]
	private Color _tokenOriginalColor;

	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x118")]
	private List<UISprite> _rankBars;

	[Token(Token = "0x600311E")]
	[Address(RVA = "0xB502A4", Offset = "0xB502A4", VA = "0xB502A4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600311F")]
	[Address(RVA = "0xB50A0C", Offset = "0xB50A0C", VA = "0xB50A0C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0xB50CFC", Offset = "0xB50CFC", VA = "0xB50CFC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003121")]
	[Address(RVA = "0xB506AC", Offset = "0xB506AC", VA = "0xB506AC")]
	private void SetNavBarInfo()
	{
	}

	[Token(Token = "0x6003122")]
	[Address(RVA = "0xB50B90", Offset = "0xB50B90", VA = "0xB50B90")]
	private void SetRankText()
	{
	}

	[Token(Token = "0x6003123")]
	[Address(RVA = "0xB50E04", Offset = "0xB50E04", VA = "0xB50E04", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003124")]
	[Address(RVA = "0xB50EBC", Offset = "0xB50EBC", VA = "0xB50EBC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6003125")]
	[Address(RVA = "0xB510B0", Offset = "0xB510B0", VA = "0xB510B0")]
	private void HighlightRank()
	{
	}

	[Token(Token = "0x6003126")]
	[Address(RVA = "0xB511C0", Offset = "0xB511C0", VA = "0xB511C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003127")]
	[Address(RVA = "0xB50B20", Offset = "0xB50B20", VA = "0xB50B20")]
	private void OnCurrentTallyChanged(TallyModel.TallyScreen screen)
	{
	}

	[Token(Token = "0x6003128")]
	[Address(RVA = "0xB50B34", Offset = "0xB50B34", VA = "0xB50B34")]
	private void OnIGCValueChanged(bool updateImmediately = false)
	{
	}

	[Token(Token = "0x6003129")]
	[Address(RVA = "0xB51334", Offset = "0xB51334", VA = "0xB51334")]
	private void UpdateCurrency(Wallet.Currency currencyToDisplay, UILabel currencyValue, UILabel currencyIcon, bool updateImmediately, Color currencyOriginalColor)
	{
	}

	[Token(Token = "0x600312A")]
	[Address(RVA = "0xB5111C", Offset = "0xB5111C", VA = "0xB5111C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621DC0", Offset = "0x621DC0")]
	private IEnumerator HighlightWidget(UIWidget widget, float waitFlashTime, Color originalColor)
	{
		return null;
	}

	[Token(Token = "0x600312B")]
	[Address(RVA = "0xB515A8", Offset = "0xB515A8", VA = "0xB515A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621E20", Offset = "0x621E20")]
	private IEnumerator FlashFrameBox(GameObject gameObject, float waitFlashTime)
	{
		return null;
	}

	[Token(Token = "0x600312C")]
	[Address(RVA = "0xB51630", Offset = "0xB51630", VA = "0xB51630")]
	private void SetFrameFlash(GameObject gameObject, bool enable = false)
	{
	}

	[Token(Token = "0x600312D")]
	[Address(RVA = "0xB5171C", Offset = "0xB5171C", VA = "0xB5171C")]
	private void OnInventoryChanged(object sender, ShopEvent e)
	{
	}

	[Token(Token = "0x600312E")]
	[Address(RVA = "0xB51724", Offset = "0xB51724", VA = "0xB51724")]
	public TallyView()
	{
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0xB517AC", Offset = "0xB517AC", VA = "0xB517AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621E80", Offset = "0x621E80")]
	private void _003CAwake_003Eb__24_0()
	{
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0xB517CC", Offset = "0xB517CC", VA = "0xB517CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621E90", Offset = "0x621E90")]
	private void _003CAwake_003Eb__24_1()
	{
	}
}
