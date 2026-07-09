using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012E0")]
	internal class GraphRequest : MenuBase
	{
		[Token(Token = "0x20012E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE6B4", Offset = "0x5AE6B4")]
		private sealed class _003CTakeScreenshot_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005A7E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005A7F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005A80")]
			[FieldOffset(Offset = "0x20")]
			public GraphRequest _003C_003E4__this;

			[Token(Token = "0x17000C64")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006E39")]
				[Address(RVA = "0x877944", Offset = "0x877944", VA = "0x877944", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C65")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6006E3B")]
				[Address(RVA = "0x87798C", Offset = "0x87798C", VA = "0x87798C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006E36")]
			[Address(RVA = "0x877664", Offset = "0x877664", VA = "0x877664")]
			[DebuggerHidden]
			public _003CTakeScreenshot_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006E37")]
			[Address(RVA = "0x877690", Offset = "0x877690", VA = "0x877690", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006E38")]
			[Address(RVA = "0x877694", Offset = "0x877694", VA = "0x877694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6006E3A")]
			[Address(RVA = "0x87794C", Offset = "0x87794C", VA = "0x87794C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005A7C")]
		[FieldOffset(Offset = "0x60")]
		private string apiQuery;

		[Token(Token = "0x4005A7D")]
		[FieldOffset(Offset = "0x68")]
		private Texture2D profilePic;

		[Token(Token = "0x6006E32")]
		[Address(RVA = "0xC89818", Offset = "0xC89818", VA = "0xC89818", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x6006E33")]
		[Address(RVA = "0xC89CF4", Offset = "0xC89CF4", VA = "0xC89CF4")]
		private void ProfilePhotoCallback(IGraphResult result)
		{
		}

		[Token(Token = "0x6006E34")]
		[Address(RVA = "0xC89C88", Offset = "0xC89C88", VA = "0xC89C88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62C350", Offset = "0x62C350")]
		private IEnumerator TakeScreenshot()
		{
			return null;
		}

		[Token(Token = "0x6006E35")]
		[Address(RVA = "0xC89EE4", Offset = "0xC89EE4", VA = "0xC89EE4")]
		public GraphRequest()
		{
		}
	}
}
