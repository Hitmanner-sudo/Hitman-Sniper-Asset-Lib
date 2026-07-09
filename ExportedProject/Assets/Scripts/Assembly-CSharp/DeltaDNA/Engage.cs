using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x2001306")]
	internal class Engage
	{
		[Token(Token = "0x2001307")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE7FC", Offset = "0x5AE7FC")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4005B2C")]
			[FieldOffset(Offset = "0x10")]
			public EngageCache cache;

			[Token(Token = "0x4005B2D")]
			[FieldOffset(Offset = "0x18")]
			public EngageRequest request;

			[Token(Token = "0x4005B2E")]
			[FieldOffset(Offset = "0x20")]
			public EngageResponse response;

			[Token(Token = "0x6006FBC")]
			[Address(RVA = "0x86DFB4", Offset = "0x86DFB4", VA = "0x86DFB4")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6006FBD")]
			[Address(RVA = "0x86DFBC", Offset = "0x86DFBC", VA = "0x86DFBC")]
			internal void _003CRequest_003Eb__0(int statusCode, string data, string error)
			{
			}
		}

		[Token(Token = "0x2001308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE80C", Offset = "0x5AE80C")]
		private sealed class _003CRequest_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B2F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B30")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B31")]
			[FieldOffset(Offset = "0x20")]
			public EngageCache cache;

			[Token(Token = "0x4005B32")]
			[FieldOffset(Offset = "0x28")]
			public EngageRequest request;

			[Token(Token = "0x4005B33")]
			[FieldOffset(Offset = "0x30")]
			public EngageResponse response;

			[Token(Token = "0x4005B34")]
			[FieldOffset(Offset = "0x38")]
			public bool useConfigurationTimeout;

			[Token(Token = "0x4005B35")]
			[FieldOffset(Offset = "0x40")]
			public MonoBehaviour caller;

			[Token(Token = "0x17000CB5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006FC1")]
				[Address(RVA = "0x86E480", Offset = "0x86E480", VA = "0x86E480", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006FC3")]
				[Address(RVA = "0x86E4C8", Offset = "0x86E4C8", VA = "0x86E4C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006FBE")]
			[Address(RVA = "0x86E1B4", Offset = "0x86E1B4", VA = "0x86E1B4")]
			[DebuggerHidden]
			public _003CRequest_003Ed__0(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006FBF")]
			[Address(RVA = "0x86E1E0", Offset = "0x86E1E0", VA = "0x86E1E0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006FC0")]
			[Address(RVA = "0x86E1E4", Offset = "0x86E1E4", VA = "0x86E1E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006FC2")]
			[Address(RVA = "0x86E488", Offset = "0x86E488", VA = "0x86E488", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0xE12E3C", Offset = "0xE12E3C", VA = "0xE12E3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CBD0", Offset = "0x62CBD0")]
		internal static IEnumerator Request(MonoBehaviour caller, EngageCache cache, EngageRequest request, EngageResponse response, bool useConfigurationTimeout = false)
		{
			return null;
		}

		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0xE12ED8", Offset = "0xE12ED8", VA = "0xE12ED8")]
		public Engage()
		{
		}
	}
}
