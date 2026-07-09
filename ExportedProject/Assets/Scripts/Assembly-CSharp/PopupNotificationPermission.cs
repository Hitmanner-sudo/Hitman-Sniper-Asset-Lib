using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000735")]
public class PopupNotificationPermission : PopupOverlayViewBase
{
	[Token(Token = "0x2000736")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595EF8", Offset = "0x595EF8")]
	private sealed class _003CWaitForFocusTimeout_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40028DE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x20")]
		public PopupNotificationPermission _003C_003E4__this;

		[Token(Token = "0x1700062E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003023")]
			[Address(RVA = "0x8AF5E8", Offset = "0x8AF5E8", VA = "0x8AF5E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003025")]
			[Address(RVA = "0x8AF630", Offset = "0x8AF630", VA = "0x8AF630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003020")]
		[Address(RVA = "0x8AF510", Offset = "0x8AF510", VA = "0x8AF510")]
		[DebuggerHidden]
		public _003CWaitForFocusTimeout_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003021")]
		[Address(RVA = "0x8AF53C", Offset = "0x8AF53C", VA = "0x8AF53C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003022")]
		[Address(RVA = "0x8AF540", Offset = "0x8AF540", VA = "0x8AF540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003024")]
		[Address(RVA = "0x8AF5F0", Offset = "0x8AF5F0", VA = "0x8AF5F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40028D5")]
	private const float WAIT_FOR_FOCUS_TIMEOUT_SECONDS = 3f;

	[Token(Token = "0x40028D6")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject _visual;

	[Token(Token = "0x40028D7")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private string _acceptLocKey;

	[Token(Token = "0x40028D8")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string _cancelLocKey;

	[Token(Token = "0x40028D9")]
	[FieldOffset(Offset = "0xD8")]
	private Action _onAccept;

	[Token(Token = "0x40028DA")]
	[FieldOffset(Offset = "0xE0")]
	private Action _onCancel;

	[Token(Token = "0x40028DB")]
	[FieldOffset(Offset = "0xE8")]
	private bool _waitingForFocus;

	[Token(Token = "0x40028DC")]
	[FieldOffset(Offset = "0xF0")]
	private Coroutine _timeoutCoroutine;

	[Token(Token = "0x6003019")]
	[Address(RVA = "0x938AA4", Offset = "0x938AA4", VA = "0x938AA4")]
	public void SetupPopupOverlay(Action onAccept, Action onCancel)
	{
	}

	[Token(Token = "0x600301A")]
	[Address(RVA = "0x938C3C", Offset = "0x938C3C", VA = "0x938C3C")]
	protected void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600301B")]
	[Address(RVA = "0x938C50", Offset = "0x938C50", VA = "0x938C50")]
	private void ClearSelf()
	{
	}

	[Token(Token = "0x600301C")]
	[Address(RVA = "0x938CE4", Offset = "0x938CE4", VA = "0x938CE4")]
	private void UserAccept()
	{
	}

	[Token(Token = "0x600301D")]
	[Address(RVA = "0x938DB4", Offset = "0x938DB4", VA = "0x938DB4")]
	private void UserCancel()
	{
	}

	[Token(Token = "0x600301E")]
	[Address(RVA = "0x938D48", Offset = "0x938D48", VA = "0x938D48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6219C0", Offset = "0x6219C0")]
	private IEnumerator WaitForFocusTimeout()
	{
		return null;
	}

	[Token(Token = "0x600301F")]
	[Address(RVA = "0x938DE0", Offset = "0x938DE0", VA = "0x938DE0")]
	public PopupNotificationPermission()
	{
	}
}
