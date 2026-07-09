using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x2000028")]
	public class FOVKick
	{
		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F78", Offset = "0x6F8F78")]
		private sealed class _003CFOVKickUp_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick _003C_003E4__this;

			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000005")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x18C04AC", Offset = "0x18C04AC", VA = "0x18C04AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x18C04F4", Offset = "0x18C04F4", VA = "0x18C04F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x18C034C", Offset = "0x18C034C", VA = "0x18C034C")]
			[DebuggerHidden]
			public _003CFOVKickUp_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x18C0378", Offset = "0x18C0378", VA = "0x18C0378", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x18C037C", Offset = "0x18C037C", VA = "0x18C037C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x18C04B4", Offset = "0x18C04B4", VA = "0x18C04B4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8F88", Offset = "0x6F8F88")]
		private sealed class _003CFOVKickDown_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x20")]
			public FOVKick _003C_003E4__this;

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000007")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x18C02FC", Offset = "0x18C02FC", VA = "0x18C02FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x18C0344", Offset = "0x18C0344", VA = "0x18C0344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x18C0188", Offset = "0x18C0188", VA = "0x18C0188")]
			[DebuggerHidden]
			public _003CFOVKickDown_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x18C01B4", Offset = "0x18C01B4", VA = "0x18C01B4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x18C01B8", Offset = "0x18C01B8", VA = "0x18C01B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x18C0304", Offset = "0x18C0304", VA = "0x18C0304", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10E8578", Offset = "0x10E8578", VA = "0x10E8578")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10E85B8", Offset = "0x10E85B8", VA = "0x10E85B8")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10E86A4", Offset = "0x10E86A4", VA = "0x10E86A4")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10E86AC", Offset = "0x10E86AC", VA = "0x10E86AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F9DF0", Offset = "0x6F9DF0")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10E8718", Offset = "0x10E8718", VA = "0x10E8718")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6F9E50", Offset = "0x6F9E50")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x10E8784", Offset = "0x10E8784", VA = "0x10E8784")]
		public FOVKick()
		{
		}
	}
}
