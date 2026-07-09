using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000038")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000039")]
		public enum Action
		{
			[Token(Token = "0x4000126")]
			Activate = 0,
			[Token(Token = "0x4000127")]
			Deactivate = 1,
			[Token(Token = "0x4000128")]
			Destroy = 2,
			[Token(Token = "0x4000129")]
			ReloadLevel = 3,
			[Token(Token = "0x400012A")]
			Call = 4
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		public class Entry
		{
			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x18C1108", Offset = "0x18C1108", VA = "0x18C1108")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003B")]
		public class Entries
		{
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x18BBE90", Offset = "0x18BBE90", VA = "0x18BBE90")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9028", Offset = "0x6F9028")]
		private sealed class _003CActivate_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000157")]
				[Address(RVA = "0x18C0E4C", Offset = "0x18C0E4C", VA = "0x18C0E4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000159")]
				[Address(RVA = "0x18C0E94", Offset = "0x18C0E94", VA = "0x18C0E94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x18BBDA8", Offset = "0x18BBDA8", VA = "0x18BBDA8")]
			[DebuggerHidden]
			public _003CActivate_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x18C0D84", Offset = "0x18C0D84", VA = "0x18C0D84", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x18C0D88", Offset = "0x18C0D88", VA = "0x18C0D88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x18C0E54", Offset = "0x18C0E54", VA = "0x18C0E54", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9038", Offset = "0x6F9038")]
		private sealed class _003CDeactivate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600015D")]
				[Address(RVA = "0x18C0F64", Offset = "0x18C0F64", VA = "0x18C0F64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600015F")]
				[Address(RVA = "0x18C0FAC", Offset = "0x18C0FAC", VA = "0x18C0FAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x18BBDD4", Offset = "0x18BBDD4", VA = "0x18BBDD4")]
			[DebuggerHidden]
			public _003CDeactivate_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x18C0E9C", Offset = "0x18C0E9C", VA = "0x18C0E9C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x18C0EA0", Offset = "0x18C0EA0", VA = "0x18C0EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x18C0F6C", Offset = "0x18C0F6C", VA = "0x18C0F6C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9048", Offset = "0x6F9048")]
		private sealed class _003CReloadLevel_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000013")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000163")]
				[Address(RVA = "0x18C10B8", Offset = "0x18C10B8", VA = "0x18C10B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000165")]
				[Address(RVA = "0x18C1100", Offset = "0x18C1100", VA = "0x18C1100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x18BBE00", Offset = "0x18BBE00", VA = "0x18BBE00")]
			[DebuggerHidden]
			public _003CReloadLevel_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x18C0FB4", Offset = "0x18C0FB4", VA = "0x18C0FB4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x18C0FB8", Offset = "0x18C0FB8", VA = "0x18C0FB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x18C10C0", Offset = "0x18C10C0", VA = "0x18C10C0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x18BBB3C", Offset = "0x18BBB3C", VA = "0x18BBB3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x18BBC64", Offset = "0x18BBC64", VA = "0x18BBC64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA160", Offset = "0x6FA160")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x18BBCD0", Offset = "0x18BBCD0", VA = "0x18BBCD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA1C0", Offset = "0x6FA1C0")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x18BBD3C", Offset = "0x18BBD3C", VA = "0x18BBD3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6FA220", Offset = "0x6FA220")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x18BBE2C", Offset = "0x18BBE2C", VA = "0x18BBE2C")]
		public TimedObjectActivator()
		{
		}
	}
}
