using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000559")]
public class SplashScreenNewController : UIController
{
	[Token(Token = "0x200055A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595274", Offset = "0x595274")]
	private sealed class _003CWaitBeforeFadeToMenu_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x20")]
		public SplashScreenNewController _003C_003E4__this;

		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170004E8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021DE")]
			[Address(RVA = "0xA524E4", Offset = "0xA524E4", VA = "0xA524E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0xA5252C", Offset = "0xA5252C", VA = "0xA5252C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021DB")]
		[Address(RVA = "0xA52388", Offset = "0xA52388", VA = "0xA52388")]
		[DebuggerHidden]
		public _003CWaitBeforeFadeToMenu_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021DC")]
		[Address(RVA = "0xA523B4", Offset = "0xA523B4", VA = "0xA523B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021DD")]
		[Address(RVA = "0xA523B8", Offset = "0xA523B8", VA = "0xA523B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021DF")]
		[Address(RVA = "0xA524EC", Offset = "0xA524EC", VA = "0xA524EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C67")]
	private const float SPLASH_SCREEN_VISIBLE_DELAY = 1f;

	[Token(Token = "0x4001C68")]
	[FieldOffset(Offset = "0x50")]
	public UISprite FadeOverlayUISprite;

	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x58")]
	public TweenColor FadeOverlayTweenColor;

	[Token(Token = "0x4001C6A")]
	[FieldOffset(Offset = "0x60")]
	public TweenScale LogoTweenScale;

	[Token(Token = "0x4001C6B")]
	[FieldOffset(Offset = "0x68")]
	private EventDelegate _onFadeInDoneDelegate;

	[Token(Token = "0x60021D3")]
	[Address(RVA = "0xA748A0", Offset = "0xA748A0", VA = "0xA748A0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60021D4")]
	[Address(RVA = "0xA74A50", Offset = "0xA74A50", VA = "0xA74A50", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60021D5")]
	[Address(RVA = "0xA74B04", Offset = "0xA74B04", VA = "0xA74B04")]
	private void OnFadeInDone()
	{
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0xA74B7C", Offset = "0xA74B7C", VA = "0xA74B7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619A58", Offset = "0x619A58")]
	private IEnumerator WaitBeforeFadeToMenu()
	{
		return null;
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0xA74BE8", Offset = "0xA74BE8", VA = "0xA74BE8")]
	private void FadeToMenu()
	{
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0xA74D98", Offset = "0xA74D98", VA = "0xA74D98")]
	private void StartMenu()
	{
	}

	[Token(Token = "0x60021D9")]
	[Address(RVA = "0xA74F78", Offset = "0xA74F78", VA = "0xA74F78")]
	public SplashScreenNewController()
	{
	}

	[Token(Token = "0x60021DA")]
	[Address(RVA = "0xA74F80", Offset = "0xA74F80", VA = "0xA74F80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619AB8", Offset = "0x619AB8")]
	private void _003CFadeToMenu_003Eb__9_0()
	{
	}
}
