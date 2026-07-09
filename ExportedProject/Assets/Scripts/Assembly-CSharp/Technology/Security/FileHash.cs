using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Security
{
	[Token(Token = "0x2000C2C")]
	public static class FileHash
	{
		[Token(Token = "0x2000C2D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985E4", Offset = "0x5985E4")]
		private sealed class _003CHashFileWithWWWCoroutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003C7D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003C7E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003C7F")]
			[FieldOffset(Offset = "0x20")]
			public string filePath;

			[Token(Token = "0x4003C80")]
			[FieldOffset(Offset = "0x28")]
			public Action<string> response;

			[Token(Token = "0x4003C81")]
			[FieldOffset(Offset = "0x30")]
			private WWW _003Cwww_003E5__2;

			[Token(Token = "0x170009C3")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004CD4")]
				[Address(RVA = "0x870EFC", Offset = "0x870EFC", VA = "0x870EFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170009C4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004CD6")]
				[Address(RVA = "0x870F44", Offset = "0x870F44", VA = "0x870F44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004CD1")]
			[Address(RVA = "0x870CE0", Offset = "0x870CE0", VA = "0x870CE0")]
			[DebuggerHidden]
			public _003CHashFileWithWWWCoroutine_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004CD2")]
			[Address(RVA = "0x870D0C", Offset = "0x870D0C", VA = "0x870D0C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004CD3")]
			[Address(RVA = "0x870D10", Offset = "0x870D10", VA = "0x870D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004CD5")]
			[Address(RVA = "0x870F04", Offset = "0x870F04", VA = "0x870F04", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x2000C2E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985F4", Offset = "0x5985F4")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x4003C82")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> response;

			[Token(Token = "0x4003C83")]
			[FieldOffset(Offset = "0x18")]
			public StringBuilder builder;

			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x870BD8", Offset = "0x870BD8", VA = "0x870BD8")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x870BE0", Offset = "0x870BE0", VA = "0x870BE0")]
			internal void _003CHashFileThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000C2F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598604", Offset = "0x598604")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4003C84")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> response;

			[Token(Token = "0x4003C85")]
			[FieldOffset(Offset = "0x18")]
			public StringBuilder builder;

			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x870C5C", Offset = "0x870C5C", VA = "0x870C5C")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x870C64", Offset = "0x870C64", VA = "0x870C64")]
			internal void _003CHashFileWithWWWCoroutineThread_003Eb__0()
			{
			}
		}

		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x952828", Offset = "0x952828", VA = "0x952828")]
		public static void HashFile(string filePath, Action<string> response)
		{
		}

		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x9529C8", Offset = "0x9529C8", VA = "0x9529C8")]
		public static void HashFileWithWWW(string filePath, Action<string> response)
		{
		}

		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x952A70", Offset = "0x952A70", VA = "0x952A70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x628730", Offset = "0x628730")]
		private static IEnumerator HashFileWithWWWCoroutine(string filePath, Action<string> response)
		{
			return null;
		}

		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x952AE8", Offset = "0x952AE8", VA = "0x952AE8")]
		private static void HashFileThread(object arg)
		{
		}

		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x952E6C", Offset = "0x952E6C", VA = "0x952E6C")]
		private static void HashFileWithWWWCoroutineThread(object arg)
		{
		}
	}
}
