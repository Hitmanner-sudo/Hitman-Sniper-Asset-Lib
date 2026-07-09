using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BD6")]
	public class BundleJSON : Bundle
	{
		[Token(Token = "0x2000BD7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598414", Offset = "0x598414")]
		private sealed class _003CLoad_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B6D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B6E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000981")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B15")]
				[Address(RVA = "0x860A3C", Offset = "0x860A3C", VA = "0x860A3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000982")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B17")]
				[Address(RVA = "0x860A84", Offset = "0x860A84", VA = "0x860A84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004B12")]
			[Address(RVA = "0x8609F4", Offset = "0x8609F4", VA = "0x8609F4")]
			[DebuggerHidden]
			public _003CLoad_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B13")]
			[Address(RVA = "0x860A20", Offset = "0x860A20", VA = "0x860A20", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B14")]
			[Address(RVA = "0x860A24", Offset = "0x860A24", VA = "0x860A24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004B16")]
			[Address(RVA = "0x860A44", Offset = "0x860A44", VA = "0x860A44", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003B6C")]
		[FieldOffset(Offset = "0x0")]
		public static int Timestamp;

		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0xA891B8", Offset = "0xA891B8", VA = "0xA891B8")]
		public BundleJSON(string name, Uri uri)
		{
		}

		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0xA8929C", Offset = "0xA8929C", VA = "0xA8929C", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x628080", Offset = "0x628080")]
		public override IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0xA892F8", Offset = "0xA892F8", VA = "0xA892F8", Slot = "10")]
		protected override void HandleState(BundleState state)
		{
		}

		[Token(Token = "0x6004B10")]
		[Address(RVA = "0xA892FC", Offset = "0xA892FC", VA = "0xA892FC", Slot = "11")]
		protected override void ToJSON(JSONNode rootNode)
		{
		}
	}
}
