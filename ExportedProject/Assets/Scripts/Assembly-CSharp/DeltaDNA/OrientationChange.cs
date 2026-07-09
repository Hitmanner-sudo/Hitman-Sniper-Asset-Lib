using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x200131A")]
	public class OrientationChange : MonoBehaviour
	{
		[Token(Token = "0x200131B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE89C", Offset = "0x5AE89C")]
		private sealed class _003CCheckForChange_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B8E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B8F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B90")]
			[FieldOffset(Offset = "0x20")]
			public OrientationChange _003C_003E4__this;

			[Token(Token = "0x17000CC5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007030")]
				[Address(RVA = "0x8CEBD8", Offset = "0x8CEBD8", VA = "0x8CEBD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CC6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007032")]
				[Address(RVA = "0x8CEC20", Offset = "0x8CEC20", VA = "0x8CEC20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600702D")]
			[Address(RVA = "0x8CEA28", Offset = "0x8CEA28", VA = "0x8CEA28")]
			[DebuggerHidden]
			public _003CCheckForChange_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600702E")]
			[Address(RVA = "0x8CEA54", Offset = "0x8CEA54", VA = "0x8CEA54", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600702F")]
			[Address(RVA = "0x8CEA58", Offset = "0x8CEA58", VA = "0x8CEA58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007031")]
			[Address(RVA = "0x8CEBE0", Offset = "0x8CEBE0", VA = "0x8CEBE0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005B8B")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 resolution;

		[Token(Token = "0x4005B8C")]
		[FieldOffset(Offset = "0x28")]
		private DeviceOrientation orientation;

		[Token(Token = "0x4005B8D")]
		[FieldOffset(Offset = "0x2C")]
		private bool running;

		[Token(Token = "0x1400019C")]
		private event Action onChange
		{
			[Token(Token = "0x6007026")]
			[Address(RVA = "0x9FE9E8", Offset = "0x9FE9E8", VA = "0x9FE9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CFC0", Offset = "0x62CFC0")]
			add
			{
			}
			[Token(Token = "0x6007027")]
			[Address(RVA = "0x9FEA88", Offset = "0x9FEA88", VA = "0x9FEA88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62CFD0", Offset = "0x62CFD0")]
			remove
			{
			}
		}

		[Token(Token = "0x6007028")]
		[Address(RVA = "0x9FEB28", Offset = "0x9FEB28", VA = "0x9FEB28")]
		private OrientationChange()
		{
		}

		[Token(Token = "0x6007029")]
		[Address(RVA = "0x9FEB38", Offset = "0x9FEB38", VA = "0x9FEB38")]
		public void Init(Action onChange)
		{
		}

		[Token(Token = "0x600702A")]
		[Address(RVA = "0x9FEB40", Offset = "0x9FEB40", VA = "0x9FEB40")]
		private void Start()
		{
		}

		[Token(Token = "0x600702B")]
		[Address(RVA = "0x9FEB6C", Offset = "0x9FEB6C", VA = "0x9FEB6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CFE0", Offset = "0x62CFE0")]
		private IEnumerator CheckForChange()
		{
			return null;
		}

		[Token(Token = "0x600702C")]
		[Address(RVA = "0x9FEBD8", Offset = "0x9FEBD8", VA = "0x9FEBD8")]
		private void OnDestroy()
		{
		}
	}
}
