using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace DeltaDNA.Consent
{
	[Token(Token = "0x200134A")]
	internal class ConsentTracker
	{
		[Token(Token = "0x200134B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AE92C", Offset = "0x5AE92C")]
		private sealed class _003CIsPiplConsentFlowRequired_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C5A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C5B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C5C")]
			[FieldOffset(Offset = "0x20")]
			public ConsentTracker _003C_003E4__this;

			[Token(Token = "0x4005C5D")]
			[FieldOffset(Offset = "0x28")]
			public Action<bool> callback;

			[Token(Token = "0x17000CF5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007192")]
				[Address(RVA = "0x862CA0", Offset = "0x862CA0", VA = "0x862CA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007194")]
				[Address(RVA = "0x862CE8", Offset = "0x862CE8", VA = "0x862CE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600718F")]
			[Address(RVA = "0x862B10", Offset = "0x862B10", VA = "0x862B10")]
			[DebuggerHidden]
			public _003CIsPiplConsentFlowRequired_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007190")]
			[Address(RVA = "0x862B3C", Offset = "0x862B3C", VA = "0x862B3C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007191")]
			[Address(RVA = "0x862B40", Offset = "0x862B40", VA = "0x862B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007193")]
			[Address(RVA = "0x862CA8", Offset = "0x862CA8", VA = "0x862CA8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4005C55")]
		[FieldOffset(Offset = "0x10")]
		private ConsentStatus m_PiplUseStatus;

		[Token(Token = "0x4005C56")]
		[FieldOffset(Offset = "0x14")]
		private ConsentStatus m_PiplExportStatus;

		[Token(Token = "0x4005C57")]
		[FieldOffset(Offset = "0x0")]
		private static string s_PiplUseSavedStatusKey;

		[Token(Token = "0x4005C58")]
		[FieldOffset(Offset = "0x8")]
		private static string s_PiplExportSavedStatusKey;

		[Token(Token = "0x4005C59")]
		[FieldOffset(Offset = "0x18")]
		private Action<bool> m_CurrentConsentCheckCallback;

		[Token(Token = "0x17000CF3")]
		public bool PiplUseConsentGiven
		{
			[Token(Token = "0x6007183")]
			[Address(RVA = "0x8E17A8", Offset = "0x8E17A8", VA = "0x8E17A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000CF4")]
		public bool PiplExportConsentGiven
		{
			[Token(Token = "0x6007184")]
			[Address(RVA = "0x8E17B8", Offset = "0x8E17B8", VA = "0x8E17B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6007185")]
		[Address(RVA = "0x8E17C8", Offset = "0x8E17C8", VA = "0x8E17C8")]
		internal ConsentTracker()
		{
		}

		[Token(Token = "0x6007186")]
		[Address(RVA = "0x8E18FC", Offset = "0x8E18FC", VA = "0x8E18FC")]
		public bool HasCheckedForConsent()
		{
			return default(bool);
		}

		[Token(Token = "0x6007187")]
		[Address(RVA = "0x8E19D4", Offset = "0x8E19D4", VA = "0x8E19D4")]
		public bool IsConsentDenied()
		{
			return default(bool);
		}

		[Token(Token = "0x6007188")]
		[Address(RVA = "0x8E19BC", Offset = "0x8E19BC", VA = "0x8E19BC")]
		private static bool IsStatusInACheckedState(ConsentStatus status)
		{
			return default(bool);
		}

		[Token(Token = "0x6007189")]
		[Address(RVA = "0x8E19F8", Offset = "0x8E19F8", VA = "0x8E19F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x62D6C0", Offset = "0x62D6C0")]
		public IEnumerator IsPiplConsentFlowRequired(Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x600718A")]
		[Address(RVA = "0x8E1A70", Offset = "0x8E1A70", VA = "0x8E1A70")]
		public void SetUserPiplUseConsent(bool consentGiven)
		{
		}

		[Token(Token = "0x600718B")]
		[Address(RVA = "0x8E1B0C", Offset = "0x8E1B0C", VA = "0x8E1B0C")]
		public void SetUserPiplExportConsent(bool consentGiven)
		{
		}

		[Token(Token = "0x600718C")]
		[Address(RVA = "0x8E1BA8", Offset = "0x8E1BA8", VA = "0x8E1BA8")]
		public bool AllConsentsAreMet()
		{
			return default(bool);
		}

		[Token(Token = "0x600718E")]
		[Address(RVA = "0x8E1C5C", Offset = "0x8E1C5C", VA = "0x8E1C5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D720", Offset = "0x62D720")]
		private void _003CIsPiplConsentFlowRequired_003Eb__13_0(GeoIpResponse response, string error)
		{
		}
	}
}
