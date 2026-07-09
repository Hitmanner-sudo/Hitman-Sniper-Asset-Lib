using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044C")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x594100", Offset = "0x594100")]
public class DropHandheldItems : FsmStateAction
{
	[Token(Token = "0x200044D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594138", Offset = "0x594138")]
	private sealed class _003CDelayDisappear_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x20")]
		public DropHandheldItems _003C_003E4__this;

		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject obj;

		[Token(Token = "0x17000423")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001A39")]
			[Address(RVA = "0x86C984", Offset = "0x86C984", VA = "0x86C984", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000424")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A3B")]
			[Address(RVA = "0x86C9CC", Offset = "0x86C9CC", VA = "0x86C9CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x86C8B4", Offset = "0x86C8B4", VA = "0x86C8B4")]
		[DebuggerHidden]
		public _003CDelayDisappear_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x86C8E0", Offset = "0x86C8E0", VA = "0x86C8E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x86C8E4", Offset = "0x86C8E4", VA = "0x86C8E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x86C98C", Offset = "0x86C98C", VA = "0x86C98C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0x50")]
	[RequiredField]
	public FsmGameObject NPCSpawner;

	[Token(Token = "0x40017CB")]
	[FieldOffset(Offset = "0x58")]
	public bool DropLeft;

	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x59")]
	public bool DropRight;

	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x5A")]
	public bool DropAndDisappear;

	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0x5C")]
	public float TimeBeforeDisappear;

	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent OnItemDropped;

	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0x68")]
	private GameTimer _timer;

	[Token(Token = "0x6001A33")]
	[Address(RVA = "0xC200EC", Offset = "0xC200EC", VA = "0xC200EC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A34")]
	[Address(RVA = "0xC20418", Offset = "0xC20418", VA = "0xC20418")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617804", Offset = "0x617804")]
	private IEnumerator DelayDisappear(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6001A35")]
	[Address(RVA = "0xC20490", Offset = "0xC20490", VA = "0xC20490")]
	public DropHandheldItems()
	{
	}
}
