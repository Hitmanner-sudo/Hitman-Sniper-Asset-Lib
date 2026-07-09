using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace DeltaDNA.Consent
{
	[Token(Token = "0x200134D")]
	internal class GeoIpApiRequest
	{
		[Token(Token = "0x200134E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE93C", Offset = "0x5AE93C")]
		private sealed class _003CMakeRequest_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C64")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C65")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C66")]
			[FieldOffset(Offset = "0x20")]
			public GeoIpApiRequest _003C_003E4__this;

			[Token(Token = "0x17000CF7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600719F")]
				[Address(RVA = "0x8742E8", Offset = "0x8742E8", VA = "0x8742E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60071A1")]
				[Address(RVA = "0x874330", Offset = "0x874330", VA = "0x874330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600719C")]
			[Address(RVA = "0x87417C", Offset = "0x87417C", VA = "0x87417C")]
			[DebuggerHidden]
			public _003CMakeRequest_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600719D")]
			[Address(RVA = "0x8741A8", Offset = "0x8741A8", VA = "0x8741A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600719E")]
			[Address(RVA = "0x8741AC", Offset = "0x8741AC", VA = "0x8741AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60071A0")]
			[Address(RVA = "0x8742F0", Offset = "0x8742F0", VA = "0x8742F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005C63")]
		[FieldOffset(Offset = "0x0")]
		private static string s_PrivacyEndpoint;

		[Token(Token = "0x140001AA")]
		public event Action<GeoIpResponse, string> OnCompleted
		{
			[Token(Token = "0x6007196")]
			[Address(RVA = "0xD9F094", Offset = "0xD9F094", VA = "0xD9F094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D780", Offset = "0x62D780")]
			add
			{
			}
			[Token(Token = "0x6007197")]
			[Address(RVA = "0xD9F134", Offset = "0xD9F134", VA = "0xD9F134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D790", Offset = "0x62D790")]
			remove
			{
			}
		}

		[Token(Token = "0x6007198")]
		[Address(RVA = "0xD9F1D4", Offset = "0xD9F1D4", VA = "0xD9F1D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62D7A0", Offset = "0x62D7A0")]
		public IEnumerator MakeRequest()
		{
			return null;
		}

		[Token(Token = "0x6007199")]
		[Address(RVA = "0xD9F240", Offset = "0xD9F240", VA = "0xD9F240")]
		private void RequestCompleted(int code, string data, string error)
		{
		}

		[Token(Token = "0x600719A")]
		[Address(RVA = "0xD9F3F4", Offset = "0xD9F3F4", VA = "0xD9F3F4")]
		public GeoIpApiRequest()
		{
		}
	}
}
