using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200002F")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9008", Offset = "0x6F9008")]
		private sealed class _003CResetCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x28")]
			public ObjectResetter _003C_003E4__this;

			[Token(Token = "0x1700000B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000134")]
				[Address(RVA = "0x18C0974", Offset = "0x18C0974", VA = "0x18C0974", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x18C09BC", Offset = "0x18C09BC", VA = "0x18C09BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x18C0708", Offset = "0x18C0708", VA = "0x18C0708")]
			[DebuggerHidden]
			public _003CResetCoroutine_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x18C0734", Offset = "0x18C0734", VA = "0x18C0734", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x18C0738", Offset = "0x18C0738", VA = "0x18C0738", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x18C097C", Offset = "0x18C097C", VA = "0x18C097C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10F0E24", Offset = "0x10F0E24", VA = "0x10F0E24")]
		private void Start()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10F0F30", Offset = "0x10F0F30", VA = "0x10F0F30")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10F0F5C", Offset = "0x10F0F5C", VA = "0x10F0F5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA000", Offset = "0x6FA000")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10F0FD8", Offset = "0x10F0FD8", VA = "0x10F0FD8")]
		public ObjectResetter()
		{
		}
	}
}
