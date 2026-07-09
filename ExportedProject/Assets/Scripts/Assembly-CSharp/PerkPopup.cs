using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006BA")]
public class PerkPopup : View
{
	[Token(Token = "0x20006BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595B08", Offset = "0x595B08")]
	private sealed class _003CHidePopup_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x20")]
		public PerkPopup _003C_003E4__this;

		[Token(Token = "0x170005B6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C44")]
			[Address(RVA = "0x8CF724", Offset = "0x8CF724", VA = "0x8CF724", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x8CF76C", Offset = "0x8CF76C", VA = "0x8CF76C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x8CF580", Offset = "0x8CF580", VA = "0x8CF580")]
		[DebuggerHidden]
		public _003CHidePopup_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x8CF5AC", Offset = "0x8CF5AC", VA = "0x8CF5AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x8CF5B0", Offset = "0x8CF5B0", VA = "0x8CF5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x8CF72C", Offset = "0x8CF72C", VA = "0x8CF72C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40025AD")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _perkItemPrefab;

	[Token(Token = "0x40025AE")]
	[FieldOffset(Offset = "0x68")]
	public float WaitDuration;

	[Token(Token = "0x40025AF")]
	[FieldOffset(Offset = "0x70")]
	public TweenPosition PopupTweener;

	[Token(Token = "0x40025B0")]
	[FieldOffset(Offset = "0x78")]
	public GameObject MessageAnchor;

	[Token(Token = "0x40025B1")]
	[FieldOffset(Offset = "0x80")]
	private PerkItemView _perkItemView;

	[Token(Token = "0x140000A2")]
	public event EventHandler UnlockAnimationCompleted
	{
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x9011F8", Offset = "0x9011F8", VA = "0x9011F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620538", Offset = "0x620538")]
		add
		{
		}
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x901298", Offset = "0x901298", VA = "0x901298")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620548", Offset = "0x620548")]
		remove
		{
		}
	}

	[Token(Token = "0x6002C3B")]
	[Address(RVA = "0x901338", Offset = "0x901338", VA = "0x901338")]
	public void ShowPopup(Perk perk)
	{
	}

	[Token(Token = "0x6002C3C")]
	[Address(RVA = "0x9016B0", Offset = "0x9016B0", VA = "0x9016B0")]
	public void OnShowPopupEnded()
	{
	}

	[Token(Token = "0x6002C3D")]
	[Address(RVA = "0x9016DC", Offset = "0x9016DC", VA = "0x9016DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620558", Offset = "0x620558")]
	public IEnumerator HidePopup()
	{
		return null;
	}

	[Token(Token = "0x6002C3E")]
	[Address(RVA = "0x901748", Offset = "0x901748", VA = "0x901748")]
	private void DestroyDelegate()
	{
	}

	[Token(Token = "0x6002C3F")]
	[Address(RVA = "0x9017CC", Offset = "0x9017CC", VA = "0x9017CC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C40")]
	[Address(RVA = "0x90194C", Offset = "0x90194C", VA = "0x90194C")]
	public PerkPopup()
	{
	}
}
