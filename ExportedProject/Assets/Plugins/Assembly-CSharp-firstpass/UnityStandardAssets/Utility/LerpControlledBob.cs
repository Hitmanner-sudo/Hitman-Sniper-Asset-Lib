using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8FF8", Offset = "0x6F8FF8")]
		private sealed class _003CDoBobCycle_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000F7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000F8")]
			[FieldOffset(Offset = "0x20")]
			public LerpControlledBob _003C_003E4__this;

			[Token(Token = "0x40000F9")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000009")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600012A")]
				[Address(RVA = "0x18C06B8", Offset = "0x18C06B8", VA = "0x18C06B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x18C0700", Offset = "0x18C0700", VA = "0x18C0700", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x18C04FC", Offset = "0x18C04FC", VA = "0x18C04FC")]
			[DebuggerHidden]
			public _003CDoBobCycle_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x18C0528", Offset = "0x18C0528", VA = "0x18C0528", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x18C052C", Offset = "0x18C052C", VA = "0x18C052C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x18C06C0", Offset = "0x18C06C0", VA = "0x18C06C0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10EFE1C", Offset = "0x10EFE1C", VA = "0x10EFE1C")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10EFE24", Offset = "0x10EFE24", VA = "0x10EFE24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F9F50", Offset = "0x6F9F50")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10EFE90", Offset = "0x10EFE90", VA = "0x10EFE90")]
		public LerpControlledBob()
		{
		}
	}
}
