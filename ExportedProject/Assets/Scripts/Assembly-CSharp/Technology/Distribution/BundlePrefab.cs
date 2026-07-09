using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BD2")]
	public class BundlePrefab : Bundle
	{
		[Token(Token = "0x2000BD3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983F4", Offset = "0x5983F4")]
		private sealed class _003CLoad_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x1700097C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AFE")]
				[Address(RVA = "0x860AD4", Offset = "0x860AD4", VA = "0x860AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700097D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B00")]
				[Address(RVA = "0x860B1C", Offset = "0x860B1C", VA = "0x860B1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004AFB")]
			[Address(RVA = "0x860A8C", Offset = "0x860A8C", VA = "0x860A8C")]
			[DebuggerHidden]
			public _003CLoad_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AFC")]
			[Address(RVA = "0x860AB8", Offset = "0x860AB8", VA = "0x860AB8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AFD")]
			[Address(RVA = "0x860ABC", Offset = "0x860ABC", VA = "0x860ABC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004AFF")]
			[Address(RVA = "0x860ADC", Offset = "0x860ADC", VA = "0x860ADC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003B66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string[] _assets;

		[Token(Token = "0x1700097B")]
		public string[] Assets
		{
			[Token(Token = "0x6004AF5")]
			[Address(RVA = "0xA8970C", Offset = "0xA8970C", VA = "0xA8970C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AF6")]
			[Address(RVA = "0xA89714", Offset = "0xA89714", VA = "0xA89714")]
			set
			{
			}
		}

		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0xA8971C", Offset = "0xA8971C", VA = "0xA8971C")]
		public BundlePrefab(string name, int version, string[] assets, [Optional] Uri uri)
		{
		}

		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0xA897D0", Offset = "0xA897D0", VA = "0xA897D0", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x627F20", Offset = "0x627F20")]
		public override IEnumerator Load()
		{
			return null;
		}

		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0xA8982C", Offset = "0xA8982C", VA = "0xA8982C", Slot = "10")]
		protected override void HandleState(BundleState state)
		{
		}

		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0xA898E8", Offset = "0xA898E8", VA = "0xA898E8", Slot = "11")]
		protected override void ToJSON(JSONNode rootNode)
		{
		}
	}
}
