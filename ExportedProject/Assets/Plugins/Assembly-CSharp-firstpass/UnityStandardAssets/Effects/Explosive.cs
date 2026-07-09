using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x200004A")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F90D8", Offset = "0x6F90D8")]
		private sealed class _003COnCollisionEnter_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000179")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x20")]
			public Explosive _003C_003E4__this;

			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600019E")]
				[Address(RVA = "0x18C0138", Offset = "0x18C0138", VA = "0x18C0138", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60001A0")]
				[Address(RVA = "0x18C0180", Offset = "0x18C0180", VA = "0x18C0180", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x18BFE74", Offset = "0x18BFE74", VA = "0x18BFE74")]
			[DebuggerHidden]
			public _003COnCollisionEnter_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x18BFEA0", Offset = "0x18BFEA0", VA = "0x18BFEA0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x18BFEA4", Offset = "0x18BFEA4", VA = "0x18BFEA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x18C0140", Offset = "0x18C0140", VA = "0x18C0140", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x10E8390", Offset = "0x10E8390", VA = "0x10E8390")]
		private void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x10E83E4", Offset = "0x10E83E4", VA = "0x10E83E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA550", Offset = "0x6FA550")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x10E845C", Offset = "0x10E845C", VA = "0x10E845C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x10E8464", Offset = "0x10E8464", VA = "0x10E8464")]
		public Explosive()
		{
		}
	}
}
