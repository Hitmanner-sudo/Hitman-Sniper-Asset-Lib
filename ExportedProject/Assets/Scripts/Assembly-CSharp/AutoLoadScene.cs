using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000892")]
public class AutoLoadScene : MonoBehaviour
{
	[Token(Token = "0x2000893")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596A8C", Offset = "0x596A8C")]
	private sealed class _003CLoadNextScene_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x20")]
		public AutoLoadScene _003C_003E4__this;

		[Token(Token = "0x1700071A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037DF")]
			[Address(RVA = "0x925E8C", Offset = "0x925E8C", VA = "0x925E8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x925ED4", Offset = "0x925ED4", VA = "0x925ED4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037DC")]
		[Address(RVA = "0x925DB8", Offset = "0x925DB8", VA = "0x925DB8")]
		[DebuggerHidden]
		public _003CLoadNextScene_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037DD")]
		[Address(RVA = "0x925DE4", Offset = "0x925DE4", VA = "0x925DE4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037DE")]
		[Address(RVA = "0x925DE8", Offset = "0x925DE8", VA = "0x925DE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60037E0")]
		[Address(RVA = "0x925E94", Offset = "0x925E94", VA = "0x925E94", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400300D")]
	[FieldOffset(Offset = "0x18")]
	public string NextScene;

	[Token(Token = "0x60037D9")]
	[Address(RVA = "0xC0BE38", Offset = "0xC0BE38", VA = "0xC0BE38")]
	private void Start()
	{
	}

	[Token(Token = "0x60037DA")]
	[Address(RVA = "0xC0BE64", Offset = "0xC0BE64", VA = "0xC0BE64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6238C0", Offset = "0x6238C0")]
	private IEnumerator LoadNextScene()
	{
		return null;
	}

	[Token(Token = "0x60037DB")]
	[Address(RVA = "0xC0BED0", Offset = "0xC0BED0", VA = "0xC0BED0")]
	public AutoLoadScene()
	{
	}
}
