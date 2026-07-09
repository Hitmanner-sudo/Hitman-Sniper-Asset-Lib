using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace DeltaDNA
{
	[Token(Token = "0x2001318")]
	internal static class Network
	{
		[Token(Token = "0x2001319")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE88C", Offset = "0x5AE88C")]
		private sealed class _003CSendRequest_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B85")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005B86")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005B87")]
			[FieldOffset(Offset = "0x20")]
			public HttpRequest request;

			[Token(Token = "0x4005B88")]
			[FieldOffset(Offset = "0x28")]
			public Action<int, string, string> completionHandler;

			[Token(Token = "0x4005B89")]
			[FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000CC3")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007023")]
				[Address(RVA = "0x8C9E64", Offset = "0x8C9E64", VA = "0x8C9E64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CC4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007025")]
				[Address(RVA = "0x8C9EAC", Offset = "0x8C9EAC", VA = "0x8C9EAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007020")]
			[Address(RVA = "0x8C9978", Offset = "0x8C9978", VA = "0x8C9978")]
			[DebuggerHidden]
			public _003CSendRequest_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007021")]
			[Address(RVA = "0x8C99A4", Offset = "0x8C99A4", VA = "0x8C99A4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007022")]
			[Address(RVA = "0x8C99A8", Offset = "0x8C99A8", VA = "0x8C99A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007024")]
			[Address(RVA = "0x8C9E6C", Offset = "0x8C9E6C", VA = "0x8C9E6C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005B82")]
		private const string HeaderKey = "STATUS";

		[Token(Token = "0x4005B83")]
		private const string StatusRegex = "^.*\\s(\\d{3})\\s.*$";

		[Token(Token = "0x4005B84")]
		private const string ErrorRegex = "^(\\d{3})\\s.*$";

		[Token(Token = "0x600701F")]
		[Address(RVA = "0xC59628", Offset = "0xC59628", VA = "0xC59628")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62CF10", Offset = "0x62CF10")]
		internal static IEnumerator SendRequest(HttpRequest request, Action<int, string, string> completionHandler)
		{
			return null;
		}
	}
}
