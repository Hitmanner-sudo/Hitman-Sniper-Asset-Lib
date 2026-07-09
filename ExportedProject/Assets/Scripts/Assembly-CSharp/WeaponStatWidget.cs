using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007AC")]
public class WeaponStatWidget : UIWidgetContainer
{
	[Serializable]
	[Token(Token = "0x20007AD")]
	public struct WidgetAspectAdjustment
	{
		[Token(Token = "0x4002B2F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector2 _phoneSize;

		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Vector2 _tabletSize;

		[Token(Token = "0x1700067C")]
		public Vector2 Size
		{
			[Token(Token = "0x60032B3")]
			[Address(RVA = "0xA42D54", Offset = "0xA42D54", VA = "0xA42D54")]
			get
			{
				return default(Vector2);
			}
		}
	}

	[Token(Token = "0x20007AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5961E4", Offset = "0x5961E4")]
	private sealed class _003CAnimateTo_003Ed__22<T> : IEnumerator<object>, IEnumerator, IDisposable where T : IConvertible
	{
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x0")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x0")]
		public WeaponStatWidget _003C_003E4__this;

		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x0")]
		public GameplayConfig.MinMaxValue<T> minMax;

		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x0")]
		public T current;

		[Token(Token = "0x4002B36")]
		[FieldOffset(Offset = "0x0")]
		public T next;

		[Token(Token = "0x4002B37")]
		[FieldOffset(Offset = "0x0")]
		public T newNext;

		[Token(Token = "0x4002B38")]
		[FieldOffset(Offset = "0x0")]
		public T max;

		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x0")]
		public string fmtCurrentValue;

		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x0")]
		public string fmtUpgradeDelta;

		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x0")]
		public bool skipUpdateSecondPart;

		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator _003Ce_003E5__2;

		[Token(Token = "0x1700067D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032B7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700067E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032B9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60032B4")]
		[DebuggerHidden]
		public _003CAnimateTo_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032B5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032B6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60032B8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5961F4", Offset = "0x5961F4")]
	private sealed class _003CInternalAnimateTo_003Ed__23<T> : IEnumerator<object>, IEnumerator, IDisposable where T : IConvertible
	{
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x0")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x0")]
		public T minAll;

		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x0")]
		public T next;

		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x0")]
		public T max;

		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x0")]
		public T maxAll;

		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x0")]
		public WeaponStatWidget _003C_003E4__this;

		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x0")]
		public T current;

		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x0")]
		public bool skipUpdateSecondPart;

		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x0")]
		public T newNext;

		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x0")]
		public string fmtUpgradeDelta;

		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x0")]
		public string fmtCurrentValue;

		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x0")]
		private AnimationCurve _003Ccurve_003E5__2;

		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x0")]
		private NumberFormatInfo _003Cnf_003E5__3;

		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x0")]
		private ContinuousTimer _003Ctimer_003E5__4;

		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x0")]
		private float _003CminAllF_003E5__5;

		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x0")]
		private float _003CnextF_003E5__6;

		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x0")]
		private float _003CmaxF_003E5__7;

		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x0")]
		private float _003CmaxAllF_003E5__8;

		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x0")]
		private UIWidget[] _003CnextUpgradesWidgets_003E5__9;

		[Token(Token = "0x1700067F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032BD")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000680")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032BF")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60032BA")]
		[DebuggerHidden]
		public _003CInternalAnimateTo_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032BB")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032BC")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60032BE")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002B23")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ClampAttribute", RVA = "0x5BAB6C", Offset = "0x5BAB6C")]
	public float MinBarSize;

	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "ClampAttribute", RVA = "0x5BAB84", Offset = "0x5BAB84")]
	public float MaxBarSize;

	[Token(Token = "0x4002B25")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Name;

	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x28")]
	public MultiProgressBar Bar;

	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x30")]
	public UIAlignedList ValuesList;

	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Value;

	[Token(Token = "0x4002B29")]
	[FieldOffset(Offset = "0x40")]
	public UILabel NextUpgrade;

	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel InfinitLabel;

	[Token(Token = "0x4002B2B")]
	[FieldOffset(Offset = "0x50")]
	public bool OneLineText;

	[Token(Token = "0x4002B2C")]
	[FieldOffset(Offset = "0x58")]
	public string CombinedText;

	[Token(Token = "0x4002B2D")]
	[FieldOffset(Offset = "0x60")]
	public WidgetAspectAdjustment NameAspectAdjustment;

	[Token(Token = "0x140000AC")]
	public event EventHandler OnAnimationFinished
	{
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x98CE34", Offset = "0x98CE34", VA = "0x98CE34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622640", Offset = "0x622640")]
		add
		{
		}
		[Token(Token = "0x60032A7")]
		[Address(RVA = "0x98CED4", Offset = "0x98CED4", VA = "0x98CED4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622650", Offset = "0x622650")]
		remove
		{
		}
	}

	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x98CF74", Offset = "0x98CF74", VA = "0x98CF74")]
	protected void Start()
	{
	}

	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x98D22C", Offset = "0x98D22C", VA = "0x98D22C")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x98D3A4", Offset = "0x98D3A4", VA = "0x98D3A4")]
	public void SetInfinitValue(string localizedText, bool assembled)
	{
	}

	[Token(Token = "0x60032AB")]
	public void SetStatValues<T>(GameplayConfig.MinMaxValue<T> minMax, T current, T next, T max, string fmtCurrentValue = "{0}", string fmtUpgradeDelta = "(+{0})") where T : IConvertible
	{
	}

	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x98D170", Offset = "0x98D170", VA = "0x98D170")]
	protected void OnBackgroundSizeChanged(object sender, UIWidget.SizeChangedEventArgs args)
	{
	}

	[Token(Token = "0x60032AD")]
	private void SetBarValue<T>(float currentf, float allMinf, int currenti, float nextf, int nexti, float maxf, int maxi, bool isMaxNotZero, float allMaxf) where T : IConvertible
	{
	}

	[Token(Token = "0x60032AE")]
	protected float CalculateBarRatio<T>(float current, float max) where T : IConvertible
	{
		return default(float);
	}

	[Token(Token = "0x60032AF")]
	private void UpdateNextValue<T>(T current, T next, string fmtUpgradeDelta) where T : IConvertible
	{
	}

	[Token(Token = "0x60032B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622660", Offset = "0x622660")]
	public IEnumerator AnimateTo<T>(GameplayConfig.MinMaxValue<T> minMax, T current, T next, T newNext, T max, float time, string fmtCurrentValue = "{0}", string fmtUpgradeDelta = "{0}", bool skipUpdateSecondPart = false) where T : IConvertible
	{
		return null;
	}

	[Token(Token = "0x60032B1")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6226C0", Offset = "0x6226C0")]
	private IEnumerator InternalAnimateTo<T>(T minAll, T maxAll, T current, T next, T newNext, T max, float time, string fmtCurrentValue = "{0}", string fmtUpgradeDelta = "{0}", bool skipUpdateSecondPart = false) where T : IConvertible
	{
		return null;
	}

	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x98D5E4", Offset = "0x98D5E4", VA = "0x98D5E4")]
	public WeaponStatWidget()
	{
	}
}
