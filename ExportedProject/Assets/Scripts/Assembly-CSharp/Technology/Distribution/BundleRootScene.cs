using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BD0")]
	public class BundleRootScene : Bundle
	{
		[Token(Token = "0x2000BD1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983E4", Offset = "0x5983E4")]
		private sealed class _003CLoad_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BundleRootScene _003C_003E4__this;

			[Token(Token = "0x17000979")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AF2")]
				[Address(RVA = "0x860C44", Offset = "0x860C44", VA = "0x860C44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700097A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AF4")]
				[Address(RVA = "0x860C8C", Offset = "0x860C8C", VA = "0x860C8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x860B24", Offset = "0x860B24", VA = "0x860B24")]
			[DebuggerHidden]
			public _003CLoad_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AF0")]
			[Address(RVA = "0x860B50", Offset = "0x860B50", VA = "0x860B50", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AF1")]
			[Address(RVA = "0x860B54", Offset = "0x860B54", VA = "0x860B54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004AF3")]
			[Address(RVA = "0x860C4C", Offset = "0x860C4C", VA = "0x860C4C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0xA89A70", Offset = "0xA89A70", VA = "0xA89A70")]
		public BundleRootScene(string name, string group, [Optional] Uri uri, int version = -1)
		{
		}

		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0xA89AA0", Offset = "0xA89AA0", VA = "0xA89AA0", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627E70", Offset = "0x627E70")]
		public override IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6004AED")]
		[Address(RVA = "0xA89B0C", Offset = "0xA89B0C", VA = "0xA89B0C", Slot = "10")]
		protected override void HandleState(BundleState state)
		{
		}

		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0xA89B10", Offset = "0xA89B10", VA = "0xA89B10", Slot = "11")]
		protected override void ToJSON(JSONNode rootNode)
		{
		}
	}
}
