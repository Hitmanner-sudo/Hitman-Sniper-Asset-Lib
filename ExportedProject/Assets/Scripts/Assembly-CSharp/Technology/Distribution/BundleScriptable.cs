using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BD4")]
	public class BundleScriptable : Bundle
	{
		[Token(Token = "0x2000BD5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598404", Offset = "0x598404")]
		private sealed class _003CLoad_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x1700097F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B0A")]
				[Address(RVA = "0x860CDC", Offset = "0x860CDC", VA = "0x860CDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000980")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B0C")]
				[Address(RVA = "0x860D24", Offset = "0x860D24", VA = "0x860D24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004B07")]
			[Address(RVA = "0x860C94", Offset = "0x860C94", VA = "0x860C94")]
			[DebuggerHidden]
			public _003CLoad_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B08")]
			[Address(RVA = "0x860CC0", Offset = "0x860CC0", VA = "0x860CC0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B09")]
			[Address(RVA = "0x860CC4", Offset = "0x860CC4", VA = "0x860CC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0x860CE4", Offset = "0x860CE4", VA = "0x860CE4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003B69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string[] _assets;

		[Token(Token = "0x1700097E")]
		public string[] Assets
		{
			[Token(Token = "0x6004B01")]
			[Address(RVA = "0xA89B14", Offset = "0xA89B14", VA = "0xA89B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B02")]
			[Address(RVA = "0xA89B1C", Offset = "0xA89B1C", VA = "0xA89B1C")]
			set
			{
			}
		}

		[Token(Token = "0x6004B03")]
		[Address(RVA = "0xA89B24", Offset = "0xA89B24", VA = "0xA89B24")]
		public BundleScriptable(string name, int version, string[] assets, [Optional] Uri uri)
		{
		}

		[Token(Token = "0x6004B04")]
		[Address(RVA = "0xA89BD8", Offset = "0xA89BD8", VA = "0xA89BD8", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627FD0", Offset = "0x627FD0")]
		public override IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6004B05")]
		[Address(RVA = "0xA89C34", Offset = "0xA89C34", VA = "0xA89C34", Slot = "10")]
		protected override void HandleState(BundleState state)
		{
		}

		[Token(Token = "0x6004B06")]
		[Address(RVA = "0xA89CF0", Offset = "0xA89CF0", VA = "0xA89CF0", Slot = "11")]
		protected override void ToJSON(JSONNode rootNode)
		{
		}
	}
}
