using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000757")]
public class TagIndicatorView : View
{
	[Token(Token = "0x2000758")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F68", Offset = "0x595F68")]
	private sealed class _003CFadeOutAutoTag_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x20")]
		public TagIndicatorView _003C_003E4__this;

		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CendTime_003E5__3;

		[Token(Token = "0x17000641")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0xA53F78", Offset = "0xA53F78", VA = "0xA53F78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000642")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0xA53FC0", Offset = "0xA53FC0", VA = "0xA53FC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030EE")]
		[Address(RVA = "0xA53BA0", Offset = "0xA53BA0", VA = "0xA53BA0")]
		[DebuggerHidden]
		public _003CFadeOutAutoTag_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030EF")]
		[Address(RVA = "0xA53BCC", Offset = "0xA53BCC", VA = "0xA53BCC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030F0")]
		[Address(RVA = "0xA53BD0", Offset = "0xA53BD0", VA = "0xA53BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60030F2")]
		[Address(RVA = "0xA53F80", Offset = "0xA53F80", VA = "0xA53F80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400296F")]
	[FieldOffset(Offset = "0x60")]
	public UISprite FilledBackground;

	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0x68")]
	public UISprite FilledBorder;

	[Token(Token = "0x4002971")]
	[FieldOffset(Offset = "0x70")]
	public UISprite Icon;

	[Token(Token = "0x4002972")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ManualTagIcon;

	[Token(Token = "0x4002973")]
	[FieldOffset(Offset = "0x80")]
	public UISprite DiamondBG;

	[Token(Token = "0x4002974")]
	[FieldOffset(Offset = "0x88")]
	public UISprite DiamondBGOverlay;

	[Token(Token = "0x4002975")]
	[FieldOffset(Offset = "0x90")]
	public UISprite DiamondOutline;

	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TagBackgroundIcons;

	[Token(Token = "0x4002977")]
	[FieldOffset(Offset = "0xA0")]
	public Color OnScreenAlertIconColor;

	[Token(Token = "0x4002978")]
	[FieldOffset(Offset = "0xB0")]
	public float OutOfScopeAutoTagAlpha;

	[Token(Token = "0x4002979")]
	[FieldOffset(Offset = "0xB4")]
	public float OutOfScopeAutoTagHighAlertAlpha;

	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0xB8")]
	public UITweener[] ShowIconTweeners;

	[Token(Token = "0x400297B")]
	[FieldOffset(Offset = "0xC0")]
	public UITweener[] HideIconTweeners;

	[Token(Token = "0x400297C")]
	[FieldOffset(Offset = "0xC8")]
	public string InvestigateIcon;

	[Token(Token = "0x400297D")]
	[FieldOffset(Offset = "0xD0")]
	public string AlertedIcon;

	[Token(Token = "0x400297E")]
	[FieldOffset(Offset = "0xD8")]
	public float InScopeTagScale;

	[Token(Token = "0x400297F")]
	[FieldOffset(Offset = "0xDC")]
	public float OutScopeTagScale;

	[Token(Token = "0x4002980")]
	[FieldOffset(Offset = "0xE0")]
	public float OutScopePhoneTagScale;

	[Token(Token = "0x4002981")]
	[FieldOffset(Offset = "0xE4")]
	public float ManualTagNoOutlineOffset;

	[Token(Token = "0x4002982")]
	[FieldOffset(Offset = "0xE8")]
	public float ManualTagNormalOffset;

	[Token(Token = "0x4002983")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite ScaredUISprite;

	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0xF8")]
	public Color ScaredBackgroundColor;

	[NonSerialized]
	[Token(Token = "0x4002985")]
	[FieldOffset(Offset = "0x108")]
	public bool OnlyShowComunicate;

	[NonSerialized]
	[Token(Token = "0x4002986")]
	[FieldOffset(Offset = "0x109")]
	public bool HideOutline;

	[Token(Token = "0x4002987")]
	[FieldOffset(Offset = "0x10A")]
	private bool _overrideColor;

	[Token(Token = "0x4002988")]
	[FieldOffset(Offset = "0x10C")]
	private Color _colorOverride;

	[Token(Token = "0x4002989")]
	[FieldOffset(Offset = "0x120")]
	private string _iconNameOverride;

	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0x128")]
	private bool _dirty;

	[Token(Token = "0x400298B")]
	[FieldOffset(Offset = "0x129")]
	private bool _wantsIcon;

	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0x12A")]
	private bool _isFading;

	[Token(Token = "0x400298D")]
	[FieldOffset(Offset = "0x12C")]
	private float _fadeAlpha;

	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0x130")]
	private bool _hasFaded;

	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0x131")]
	private bool _isInScope;

	[Token(Token = "0x4002990")]
	[FieldOffset(Offset = "0x132")]
	private bool _isAlerted;

	[Token(Token = "0x4002991")]
	[FieldOffset(Offset = "0x133")]
	private bool _dontShowAlertIcon;

	[Token(Token = "0x4002992")]
	[FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA688", Offset = "0x5BA688")]
	private Transform _003CIconTransform_003Ek__BackingField;

	[Token(Token = "0x1700063F")]
	public bool IsInScope
	{
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0xB4C524", Offset = "0xB4C524", VA = "0xB4C524")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000640")]
	public Transform IconTransform
	{
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0xB4C52C", Offset = "0xB4C52C", VA = "0xB4C52C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621B90", Offset = "0x621B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0xB4C534", Offset = "0xB4C534", VA = "0xB4C534")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621BA0", Offset = "0x621BA0")]
		private set
		{
		}
	}

	[Token(Token = "0x60030E2")]
	[Address(RVA = "0xB4C53C", Offset = "0xB4C53C", VA = "0xB4C53C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60030E3")]
	[Address(RVA = "0xB4C5C0", Offset = "0xB4C5C0", VA = "0xB4C5C0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60030E4")]
	[Address(RVA = "0xB4C6B8", Offset = "0xB4C6B8", VA = "0xB4C6B8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0xB4C8CC", Offset = "0xB4C8CC", VA = "0xB4C8CC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0xB4D00C", Offset = "0xB4D00C", VA = "0xB4D00C")]
	public void SetCurrentHealthRatio(float healthRatio)
	{
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0xB4D028", Offset = "0xB4D028", VA = "0xB4D028")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621BB0", Offset = "0x621BB0")]
	private IEnumerator FadeOutAutoTag()
	{
		return null;
	}

	[Token(Token = "0x60030E8")]
	[Address(RVA = "0xB4D094", Offset = "0xB4D094", VA = "0xB4D094")]
	private void UpdateTagFadeColor(float alpha)
	{
	}

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0xB4D19C", Offset = "0xB4D19C", VA = "0xB4D19C")]
	public void UpdateIcon()
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0xB4D3B0", Offset = "0xB4D3B0", VA = "0xB4D3B0")]
	private void DisableTweener(UITweener tweener)
	{
	}

	[Token(Token = "0x60030EB")]
	[Address(RVA = "0xB4D440", Offset = "0xB4D440", VA = "0xB4D440")]
	private void EnableTweener(UITweener tweener)
	{
	}

	[Token(Token = "0x60030EC")]
	[Address(RVA = "0xB4D4D8", Offset = "0xB4D4D8", VA = "0xB4D4D8")]
	private void ResolveIconProperties(AlertLevel alertLevel, bool isScared)
	{
	}

	[Token(Token = "0x60030ED")]
	[Address(RVA = "0xB4DD5C", Offset = "0xB4DD5C", VA = "0xB4DD5C")]
	public TagIndicatorView()
	{
	}
}
