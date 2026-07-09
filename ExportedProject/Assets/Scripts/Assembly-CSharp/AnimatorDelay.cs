using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200088F")]
public class AnimatorDelay : MonoBehaviour
{
	[Token(Token = "0x2000890")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596A6C", Offset = "0x596A6C")]
	private sealed class _003CStartCo_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x20")]
		public AnimatorDelay _003C_003E4__this;

		[Token(Token = "0x17000716")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x921F0C", Offset = "0x921F0C", VA = "0x921F0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000717")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037D2")]
			[Address(RVA = "0x921F54", Offset = "0x921F54", VA = "0x921F54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x921DAC", Offset = "0x921DAC", VA = "0x921DAC")]
		[DebuggerHidden]
		public _003CStartCo_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x921DD8", Offset = "0x921DD8", VA = "0x921DD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x921DDC", Offset = "0x921DDC", VA = "0x921DDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x921F14", Offset = "0x921F14", VA = "0x921F14", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000891")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596A7C", Offset = "0x596A7C")]
	private sealed class _003CTriggersCo_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x20")]
		public AnimatorDelay _003C_003E4__this;

		[Token(Token = "0x17000718")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037D6")]
			[Address(RVA = "0x9220D4", Offset = "0x9220D4", VA = "0x9220D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000719")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037D8")]
			[Address(RVA = "0x92211C", Offset = "0x92211C", VA = "0x92211C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x921F5C", Offset = "0x921F5C", VA = "0x921F5C")]
		[DebuggerHidden]
		public _003CTriggersCo_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x921F88", Offset = "0x921F88", VA = "0x921F88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x921F8C", Offset = "0x921F8C", VA = "0x921F8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x9220DC", Offset = "0x9220DC", VA = "0x9220DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4003000")]
	[FieldOffset(Offset = "0x18")]
	public bool Active;

	[Token(Token = "0x4003001")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 Delay;

	[Token(Token = "0x4003002")]
	[FieldOffset(Offset = "0x24")]
	public bool ActivateAnimator;

	[Token(Token = "0x4003003")]
	[FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5BB740", Offset = "0x5BB740")]
	public bool SendTriggers;

	[Token(Token = "0x4003004")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 TriggerDelay;

	[Token(Token = "0x4003005")]
	[FieldOffset(Offset = "0x30")]
	public bool Loop;

	[Token(Token = "0x4003006")]
	[FieldOffset(Offset = "0x38")]
	public string Trigger;

	[Token(Token = "0x60037C9")]
	[Address(RVA = "0xD46704", Offset = "0xD46704", VA = "0xD46704")]
	private void Start()
	{
	}

	[Token(Token = "0x60037CA")]
	[Address(RVA = "0xD46784", Offset = "0xD46784", VA = "0xD46784")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623760", Offset = "0x623760")]
	private IEnumerator StartCo()
	{
		return null;
	}

	[Token(Token = "0x60037CB")]
	[Address(RVA = "0xD467F0", Offset = "0xD467F0", VA = "0xD467F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6237C0", Offset = "0x6237C0")]
	private IEnumerator TriggersCo()
	{
		return null;
	}

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0xD4685C", Offset = "0xD4685C", VA = "0xD4685C")]
	public AnimatorDelay()
	{
	}
}
