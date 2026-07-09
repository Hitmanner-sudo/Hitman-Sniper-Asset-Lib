using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200055B")]
public class TagIndicatorController : UIController
{
	[Token(Token = "0x200055C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595284", Offset = "0x595284")]
	private sealed class _003CEnableTaps_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001C74")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0x20")]
		public TagIndicatorController _003C_003E4__this;

		[Token(Token = "0x4001C77")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170004EA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0xA53B50", Offset = "0xA53B50", VA = "0xA53B50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021F2")]
			[Address(RVA = "0xA53B98", Offset = "0xA53B98", VA = "0xA53B98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021ED")]
		[Address(RVA = "0xA53A8C", Offset = "0xA53A8C", VA = "0xA53A8C")]
		[DebuggerHidden]
		public _003CEnableTaps_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60021EE")]
		[Address(RVA = "0xA53AB8", Offset = "0xA53AB8", VA = "0xA53AB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60021EF")]
		[Address(RVA = "0xA53ABC", Offset = "0xA53ABC", VA = "0xA53ABC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60021F1")]
		[Address(RVA = "0xA53B58", Offset = "0xA53B58", VA = "0xA53B58", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001C70")]
	[FieldOffset(Offset = "0x50")]
	public ButtonHandler TagIndicatorButton;

	[Token(Token = "0x4001C71")]
	[FieldOffset(Offset = "0x58")]
	public UIForwardEvents UIForwardEvents;

	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x60")]
	private Coroutine _enableTapsCoroutine;

	[Token(Token = "0x1400008B")]
	public static event EventHandler OnClickbaleTagClicked
	{
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0xB4AC44", Offset = "0xB4AC44", VA = "0xB4AC44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619B18", Offset = "0x619B18")]
		add
		{
		}
		[Token(Token = "0x60021E2")]
		[Address(RVA = "0xB4AD00", Offset = "0xB4AD00", VA = "0xB4AD00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619B28", Offset = "0x619B28")]
		remove
		{
		}
	}

	[Token(Token = "0x60021E3")]
	[Address(RVA = "0xB4ADBC", Offset = "0xB4ADBC", VA = "0xB4ADBC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60021E4")]
	[Address(RVA = "0xB4AFAC", Offset = "0xB4AFAC", VA = "0xB4AFAC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60021E5")]
	[Address(RVA = "0xB4B070", Offset = "0xB4B070", VA = "0xB4B070", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60021E6")]
	[Address(RVA = "0xB4B1E8", Offset = "0xB4B1E8", VA = "0xB4B1E8")]
	public void CenterOnTransform()
	{
	}

	[Token(Token = "0x60021E7")]
	[Address(RVA = "0xB4B2C4", Offset = "0xB4B2C4", VA = "0xB4B2C4")]
	private void OnTagPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021E8")]
	[Address(RVA = "0xB4B4D4", Offset = "0xB4B4D4", VA = "0xB4B4D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619B38", Offset = "0x619B38")]
	private IEnumerator EnableTaps()
	{
		return null;
	}

	[Token(Token = "0x60021E9")]
	[Address(RVA = "0xB4B2E8", Offset = "0xB4B2E8", VA = "0xB4B2E8")]
	private void SetCanTap(bool activate)
	{
	}

	[Token(Token = "0x60021EA")]
	[Address(RVA = "0xB4B034", Offset = "0xB4B034", VA = "0xB4B034")]
	private void ForceStopEnableTapsCoroutine()
	{
	}

	[Token(Token = "0x60021EB")]
	[Address(RVA = "0xB4B540", Offset = "0xB4B540", VA = "0xB4B540")]
	private void OnTagClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x60021EC")]
	[Address(RVA = "0xB4B59C", Offset = "0xB4B59C", VA = "0xB4B59C")]
	public TagIndicatorController()
	{
	}
}
