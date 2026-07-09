using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F5")]
public class ExplodeOnDetonate : MonoBehaviour
{
	[Token(Token = "0x20002F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5932D4", Offset = "0x5932D4")]
	private sealed class _003CExplodeDelay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x20")]
		public ExplodeOnDetonate _003C_003E4__this;

		[Token(Token = "0x170002A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600122C")]
			[Address(RVA = "0x86FC20", Offset = "0x86FC20", VA = "0x86FC20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x86FC68", Offset = "0x86FC68", VA = "0x86FC68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001229")]
		[Address(RVA = "0x86FA0C", Offset = "0x86FA0C", VA = "0x86FA0C")]
		[DebuggerHidden]
		public _003CExplodeDelay_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600122A")]
		[Address(RVA = "0x86FA38", Offset = "0x86FA38", VA = "0x86FA38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600122B")]
		[Address(RVA = "0x86FA3C", Offset = "0x86FA3C", VA = "0x86FA3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600122D")]
		[Address(RVA = "0x86FC28", Offset = "0x86FC28", VA = "0x86FC28", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x18")]
	public float DelayBeforeExplode;

	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Health _health;

	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x28")]
	private float _explodeAtGameTimeStamp;

	[Token(Token = "0x6001225")]
	[Address(RVA = "0xE1EA98", Offset = "0xE1EA98", VA = "0xE1EA98")]
	public void Explode(float delayBeforeExplode)
	{
	}

	[Token(Token = "0x6001226")]
	[Address(RVA = "0xE1EB74", Offset = "0xE1EB74", VA = "0xE1EB74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6160D4", Offset = "0x6160D4")]
	private IEnumerator ExplodeDelay()
	{
		return null;
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0xE1EBE0", Offset = "0xE1EBE0", VA = "0xE1EBE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0xE1ECA0", Offset = "0xE1ECA0", VA = "0xE1ECA0")]
	public ExplodeOnDetonate()
	{
	}
}
