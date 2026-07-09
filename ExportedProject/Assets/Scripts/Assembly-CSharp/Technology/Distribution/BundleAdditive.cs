using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BCE")]
	public class BundleAdditive : Bundle
	{
		[Token(Token = "0x2000BCF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983D4", Offset = "0x5983D4")]
		private sealed class _003CLoad_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BundleAdditive _003C_003E4__this;

			[Token(Token = "0x17000977")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AE8")]
				[Address(RVA = "0x8609A4", Offset = "0x8609A4", VA = "0x8609A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000978")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AEA")]
				[Address(RVA = "0x8609EC", Offset = "0x8609EC", VA = "0x8609EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004AE5")]
			[Address(RVA = "0x860884", Offset = "0x860884", VA = "0x860884")]
			[DebuggerHidden]
			public _003CLoad_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AE6")]
			[Address(RVA = "0x8608B0", Offset = "0x8608B0", VA = "0x8608B0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AE7")]
			[Address(RVA = "0x8608B4", Offset = "0x8608B4", VA = "0x8608B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004AE9")]
			[Address(RVA = "0x8609AC", Offset = "0x8609AC", VA = "0x8609AC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0xA89088", Offset = "0xA89088", VA = "0xA89088")]
		public BundleAdditive(string name, string group, bool loadImmediately, uint loadorder, [Optional] Uri uri, int version = -1)
		{
		}

		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0xA890B4", Offset = "0xA890B4", VA = "0xA890B4", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627DC0", Offset = "0x627DC0")]
		public override IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0xA89120", Offset = "0xA89120", VA = "0xA89120", Slot = "10")]
		protected override void HandleState(BundleState state)
		{
		}

		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0xA89124", Offset = "0xA89124", VA = "0xA89124", Slot = "11")]
		protected override void ToJSON(JSONNode rootNode)
		{
		}
	}
}
