using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000048")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F90C8", Offset = "0x6F90C8")]
		private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000171")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce _003C_003E4__this;

			[Token(Token = "0x1700001C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000194")]
				[Address(RVA = "0x18BFE24", Offset = "0x18BFE24", VA = "0x18BFE24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000196")]
				[Address(RVA = "0x18BFE6C", Offset = "0x18BFE6C", VA = "0x18BFE6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x18BFA88", Offset = "0x18BFA88", VA = "0x18BFA88")]
			[DebuggerHidden]
			public _003CStart_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x18BFAB4", Offset = "0x18BFAB4", VA = "0x18BFAB4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x18BFAB8", Offset = "0x18BFAB8", VA = "0x18BFAB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x18BFE2C", Offset = "0x18BFE2C", VA = "0x18BFE2C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10E8314", Offset = "0x10E8314", VA = "0x10E8314")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA4A0", Offset = "0x6FA4A0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x10E8380", Offset = "0x10E8380", VA = "0x10E8380")]
		public ExplosionPhysicsForce()
		{
		}
	}
}
