using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000025")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F68", Offset = "0x6F8F68")]
		private sealed class _003CDragObject_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x20")]
			public DragRigidbody _003C_003E4__this;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x2C")]
			private float _003ColdDrag_003E5__2;

			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x30")]
			private float _003ColdAngularDrag_003E5__3;

			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x38")]
			private Camera _003CmainCamera_003E5__4;

			[Token(Token = "0x17000003")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000107")]
				[Address(RVA = "0x18BF494", Offset = "0x18BF494", VA = "0x18BF494", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0x18BF4DC", Offset = "0x18BF4DC", VA = "0x18BF4DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x18BF224", Offset = "0x18BF224", VA = "0x18BF224")]
			[DebuggerHidden]
			public _003CDragObject_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x18BF250", Offset = "0x18BF250", VA = "0x18BF250", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x18BF254", Offset = "0x18BF254", VA = "0x18BF254", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x18BF49C", Offset = "0x18BF49C", VA = "0x18BF49C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40000C4")]
		private const float k_Spring = 50f;

		[Token(Token = "0x40000C5")]
		private const float k_Damper = 5f;

		[Token(Token = "0x40000C6")]
		private const float k_Drag = 10f;

		[Token(Token = "0x40000C7")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x40000C8")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x40000C9")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10DF82C", Offset = "0x10DF82C", VA = "0x10DF82C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10DFC6C", Offset = "0x10DFC6C", VA = "0x10DFC6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F9D40", Offset = "0x6F9D40")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10DFBB4", Offset = "0x10DFBB4", VA = "0x10DFBB4")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x10DFCE8", Offset = "0x10DFCE8", VA = "0x10DFCE8")]
		public DragRigidbody()
		{
		}
	}
}
