using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000031")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9018", Offset = "0x6F9018")]
		private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer _003C_003E4__this;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x28")]
			private ParticleSystem[] _003Csystems_003E5__2;

			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x30")]
			private float _003CstopTime_003E5__3;

			[Token(Token = "0x1700000D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x18C0D2C", Offset = "0x18C0D2C", VA = "0x18C0D2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x18C0D74", Offset = "0x18C0D74", VA = "0x18C0D74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x18C09C4", Offset = "0x18C09C4", VA = "0x18C09C4")]
			[DebuggerHidden]
			public _003CStart_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x18C09F0", Offset = "0x18C09F0", VA = "0x18C09F0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x18C09F4", Offset = "0x18C09F4", VA = "0x18C09F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x18C0D34", Offset = "0x18C0D34", VA = "0x18C0D34", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10F0FE0", Offset = "0x10F0FE0", VA = "0x10F0FE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA0B0", Offset = "0x6FA0B0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x10F104C", Offset = "0x10F104C", VA = "0x10F104C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10F1058", Offset = "0x10F1058", VA = "0x10F1058")]
		public ParticleSystemDestroyer()
		{
		}
	}
}
