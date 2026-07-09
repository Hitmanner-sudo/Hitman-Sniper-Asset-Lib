using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

namespace Sniper.Gameplay
{
	[Token(Token = "0x2000E79")]
	public class AnimatorController : GameMonoBehaviour
	{
		[Token(Token = "0x2000E7A")]
		protected delegate void SetBoolDelegate(bool value);

		[Token(Token = "0x2000E7B")]
		protected delegate bool GetBoolDelegate();

		[Token(Token = "0x2000E7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598E74", Offset = "0x598E74")]
		private sealed class _003CResetTrigger_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4004409")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400440A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400440B")]
			[FieldOffset(Offset = "0x20")]
			public SetBoolDelegate SetBool;

			[Token(Token = "0x17000BFB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005960")]
				[Address(RVA = "0x921994", Offset = "0x921994", VA = "0x921994", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000BFC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005962")]
				[Address(RVA = "0x9219DC", Offset = "0x9219DC", VA = "0x9219DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600595D")]
			[Address(RVA = "0x921698", Offset = "0x921698", VA = "0x921698")]
			[DebuggerHidden]
			public _003CResetTrigger_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600595E")]
			[Address(RVA = "0x9216C4", Offset = "0x9216C4", VA = "0x9216C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600595F")]
			[Address(RVA = "0x9216C8", Offset = "0x9216C8", VA = "0x9216C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6005961")]
			[Address(RVA = "0x92199C", Offset = "0x92199C", VA = "0x92199C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4004408")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDE4", Offset = "0x5BFDE4")]
		private Animator _003CAnimator_003Ek__BackingField;

		[Token(Token = "0x17000BFA")]
		public Animator Animator
		{
			[Token(Token = "0x600594E")]
			[Address(RVA = "0xD45FBC", Offset = "0xD45FBC", VA = "0xD45FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BDA8", Offset = "0x62BDA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600594F")]
			[Address(RVA = "0xD45FC4", Offset = "0xD45FC4", VA = "0xD45FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BDB8", Offset = "0x62BDB8")]
			private set
			{
			}
		}

		[Token(Token = "0x6005950")]
		[Address(RVA = "0xD45FCC", Offset = "0xD45FCC", VA = "0xD45FCC", Slot = "9")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6005951")]
		[Address(RVA = "0xD4602C", Offset = "0xD4602C", VA = "0xD4602C", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6005952")]
		[Address(RVA = "0xD460BC", Offset = "0xD460BC", VA = "0xD460BC")]
		protected bool SetTrigger(GetBoolDelegate GetBool, SetBoolDelegate SetBool)
		{
			return default(bool);
		}

		[Token(Token = "0x6005953")]
		[Address(RVA = "0xD46160", Offset = "0xD46160", VA = "0xD46160")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62BDC8", Offset = "0x62BDC8")]
		private IEnumerator ResetTrigger(SetBoolDelegate SetBool)
		{
			return null;
		}

		[Token(Token = "0x6005954")]
		[Address(RVA = "0xD461CC", Offset = "0xD461CC", VA = "0xD461CC")]
		public AnimatorController()
		{
		}
	}
}
