using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5908F8", Offset = "0x5908F8")]
public class WFX_LightFlicker : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590958", Offset = "0x590958")]
	private sealed class _003CFlicker_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		public WFX_LightFlicker _003C_003E4__this;

		[Token(Token = "0x17000014")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA4153C", Offset = "0xA4153C", VA = "0xA4153C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xA41584", Offset = "0xA41584", VA = "0xA41584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA41418", Offset = "0xA41418", VA = "0xA41418")]
		[DebuggerHidden]
		public _003CFlicker_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA41444", Offset = "0xA41444", VA = "0xA41444", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA41448", Offset = "0xA41448", VA = "0xA41448", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA41544", Offset = "0xA41544", VA = "0xA41544", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x97BCB4", Offset = "0x97BCB4", VA = "0x97BCB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x97BD24", Offset = "0x97BD24", VA = "0x97BD24")]
	private void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x97BD7C", Offset = "0x97BD7C", VA = "0x97BD7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611860", Offset = "0x611860")]
	private IEnumerator Flicker()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x97BDE8", Offset = "0x97BDE8", VA = "0x97BDE8")]
	public WFX_LightFlicker()
	{
	}
}
