using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x590818", Offset = "0x590818")]
public class WFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590878", Offset = "0x590878")]
	private sealed class _003CCheckIfAlive_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		public WFX_AutoDestructShuriken _003C_003E4__this;

		[Token(Token = "0x17000010")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xA41244", Offset = "0xA41244", VA = "0xA41244", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xA4128C", Offset = "0xA4128C", VA = "0xA4128C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xA410D0", Offset = "0xA410D0", VA = "0xA410D0")]
		[DebuggerHidden]
		public _003CCheckIfAlive_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA410FC", Offset = "0xA410FC", VA = "0xA410FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA41100", Offset = "0xA41100", VA = "0xA41100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA4124C", Offset = "0xA4124C", VA = "0xA4124C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public bool OnlyDeactivate;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x97B63C", Offset = "0x97B63C", VA = "0x97B63C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x97B68C", Offset = "0x97B68C", VA = "0x97B68C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x97B6FC", Offset = "0x97B6FC", VA = "0x97B6FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611700", Offset = "0x611700")]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x97B768", Offset = "0x97B768", VA = "0x97B768")]
	public WFX_AutoDestructShuriken()
	{
	}
}
