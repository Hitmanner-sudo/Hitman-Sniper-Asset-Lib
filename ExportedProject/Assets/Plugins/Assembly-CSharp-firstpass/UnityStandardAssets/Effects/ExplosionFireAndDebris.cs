using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000046")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F90B8", Offset = "0x6F90B8")]
		private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400016B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400016C")]
			[FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris _003C_003E4__this;

			[Token(Token = "0x400016D")]
			[FieldOffset(Offset = "0x28")]
			private float _003Cmultiplier_003E5__2;

			[Token(Token = "0x1700001A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0x18BFA38", Offset = "0x18BFA38", VA = "0x18BFA38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x18BFA80", Offset = "0x18BFA80", VA = "0x18BFA80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x18BF4EC", Offset = "0x18BF4EC", VA = "0x18BF4EC")]
			[DebuggerHidden]
			public _003CStart_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x18BF518", Offset = "0x18BF518", VA = "0x18BF518", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x18BF51C", Offset = "0x18BF51C", VA = "0x18BF51C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x18BFA40", Offset = "0x18BFA40", VA = "0x18BFA40", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x10E817C", Offset = "0x10E817C", VA = "0x10E817C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA3F0", Offset = "0x6FA3F0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10E81E8", Offset = "0x10E81E8", VA = "0x10E81E8")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x10E830C", Offset = "0x10E830C", VA = "0x10E830C")]
		public ExplosionFireAndDebris()
		{
		}
	}
}
