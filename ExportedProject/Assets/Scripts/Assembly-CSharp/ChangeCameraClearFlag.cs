using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000A")]
public class ChangeCameraClearFlag : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x590808", Offset = "0x590808")]
	private sealed class _003CChangeFlag_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		public ChangeCameraClearFlag _003C_003E4__this;

		[Token(Token = "0x1700000D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x8617F4", Offset = "0x8617F4", VA = "0x8617F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x86183C", Offset = "0x86183C", VA = "0x86183C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x861710", Offset = "0x861710", VA = "0x861710")]
		[DebuggerHidden]
		public _003CChangeFlag_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x86173C", Offset = "0x86173C", VA = "0x86173C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x861740", Offset = "0x861740", VA = "0x861740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x8617FC", Offset = "0x8617FC", VA = "0x8617FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public Camera AttachedCamera;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public CameraClearFlags NewClearFlags;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xAF8C34", Offset = "0xAF8C34", VA = "0xAF8C34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xAF8C60", Offset = "0xAF8C60", VA = "0xAF8C60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611650", Offset = "0x611650")]
	protected IEnumerator ChangeFlag()
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xAF8CCC", Offset = "0xAF8CCC", VA = "0xAF8CCC")]
	public void DoChangeFlag()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xAF8CF0", Offset = "0xAF8CF0", VA = "0xAF8CF0")]
	public ChangeCameraClearFlag()
	{
	}
}
