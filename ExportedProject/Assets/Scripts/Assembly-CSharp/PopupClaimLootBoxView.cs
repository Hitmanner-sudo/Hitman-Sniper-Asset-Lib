using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200069A")]
public class PopupClaimLootBoxView : PopupOverlayViewBase
{
	[Serializable]
	[Token(Token = "0x200069B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5959F8", Offset = "0x5959F8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40024EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40024F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LootBoxDroppedItemView, LootBoxDroppedItemView, int> _003C_003E9__29_0;

		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x8AC980", Offset = "0x8AC980", VA = "0x8AC980")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x8AC988", Offset = "0x8AC988", VA = "0x8AC988")]
		internal int _003COnLootBoxChanged_003Eb__29_0(LootBoxDroppedItemView a, LootBoxDroppedItemView b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200069C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A08", Offset = "0x595A08")]
	private sealed class _003CPopupIntroWait_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x1700059B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B5A")]
			[Address(RVA = "0x8AE4F4", Offset = "0x8AE4F4", VA = "0x8AE4F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B5C")]
			[Address(RVA = "0x8AE53C", Offset = "0x8AE53C", VA = "0x8AE53C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x8AE2A4", Offset = "0x8AE2A4", VA = "0x8AE2A4")]
		[DebuggerHidden]
		public _003CPopupIntroWait_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B58")]
		[Address(RVA = "0x8AE2D0", Offset = "0x8AE2D0", VA = "0x8AE2D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x8AE2D4", Offset = "0x8AE2D4", VA = "0x8AE2D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x8AE4FC", Offset = "0x8AE4FC", VA = "0x8AE4FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200069D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A18", Offset = "0x595A18")]
	private sealed class _003CPopupIntroCancelled_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x1700059D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B60")]
			[Address(RVA = "0x8AE254", Offset = "0x8AE254", VA = "0x8AE254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700059E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B62")]
			[Address(RVA = "0x8AE29C", Offset = "0x8AE29C", VA = "0x8AE29C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x8AE0FC", Offset = "0x8AE0FC", VA = "0x8AE0FC")]
		[DebuggerHidden]
		public _003CPopupIntroCancelled_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x8AE128", Offset = "0x8AE128", VA = "0x8AE128", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x8AE12C", Offset = "0x8AE12C", VA = "0x8AE12C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x8AE25C", Offset = "0x8AE25C", VA = "0x8AE25C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200069E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A28", Offset = "0x595A28")]
	private sealed class _003CPopupOpening_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x1700059F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B66")]
			[Address(RVA = "0x8AE6F0", Offset = "0x8AE6F0", VA = "0x8AE6F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B68")]
			[Address(RVA = "0x8AE738", Offset = "0x8AE738", VA = "0x8AE738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x8AE544", Offset = "0x8AE544", VA = "0x8AE544")]
		[DebuggerHidden]
		public _003CPopupOpening_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x8AE570", Offset = "0x8AE570", VA = "0x8AE570", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x8AE574", Offset = "0x8AE574", VA = "0x8AE574", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x8AE6F8", Offset = "0x8AE6F8", VA = "0x8AE6F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200069F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A38", Offset = "0x595A38")]
	private sealed class _003CFadeToBlack_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x40024FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40024FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool toBlack;

		[Token(Token = "0x40024FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TweenAlpha _003Calpha_003E5__2;

		[Token(Token = "0x170005A1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B6C")]
			[Address(RVA = "0x8ADA48", Offset = "0x8ADA48", VA = "0x8ADA48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B6E")]
			[Address(RVA = "0x8ADA90", Offset = "0x8ADA90", VA = "0x8ADA90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x8AD898", Offset = "0x8AD898", VA = "0x8AD898")]
		[DebuggerHidden]
		public _003CFadeToBlack_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x8AD8C4", Offset = "0x8AD8C4", VA = "0x8AD8C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x8AD8C8", Offset = "0x8AD8C8", VA = "0x8AD8C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x8ADA50", Offset = "0x8ADA50", VA = "0x8ADA50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A48", Offset = "0x595A48")]
	private sealed class _003CBoxOpening_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x170005A3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B72")]
			[Address(RVA = "0x8ACB8C", Offset = "0x8ACB8C", VA = "0x8ACB8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B74")]
			[Address(RVA = "0x8ACBD4", Offset = "0x8ACBD4", VA = "0x8ACBD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x8AC9C8", Offset = "0x8AC9C8", VA = "0x8AC9C8")]
		[DebuggerHidden]
		public _003CBoxOpening_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x8AC9F4", Offset = "0x8AC9F4", VA = "0x8AC9F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x8AC9F8", Offset = "0x8AC9F8", VA = "0x8AC9F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x8ACB94", Offset = "0x8ACB94", VA = "0x8ACB94", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A58", Offset = "0x595A58")]
	private sealed class _003CDoBoxOpeningAnimation_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x170005A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B78")]
			[Address(RVA = "0x8ACEA8", Offset = "0x8ACEA8", VA = "0x8ACEA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B7A")]
			[Address(RVA = "0x8ACEF0", Offset = "0x8ACEF0", VA = "0x8ACEF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x8ACD84", Offset = "0x8ACD84", VA = "0x8ACD84")]
		[DebuggerHidden]
		public _003CDoBoxOpeningAnimation_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x8ACDB0", Offset = "0x8ACDB0", VA = "0x8ACDB0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x8ACDB4", Offset = "0x8ACDB4", VA = "0x8ACDB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x8ACEB0", Offset = "0x8ACEB0", VA = "0x8ACEB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A68", Offset = "0x595A68")]
	private sealed class _003CCheckInput_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x170005A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B7E")]
			[Address(RVA = "0x8ACD34", Offset = "0x8ACD34", VA = "0x8ACD34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B80")]
			[Address(RVA = "0x8ACD7C", Offset = "0x8ACD7C", VA = "0x8ACD7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x8ACBDC", Offset = "0x8ACBDC", VA = "0x8ACBDC")]
		[DebuggerHidden]
		public _003CCheckInput_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x8ACC08", Offset = "0x8ACC08", VA = "0x8ACC08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x8ACC0C", Offset = "0x8ACC0C", VA = "0x8ACC0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x8ACD3C", Offset = "0x8ACD3C", VA = "0x8ACD3C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A78", Offset = "0x595A78")]
	private sealed class _003CItemAppearing_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400250A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400250B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x170005A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B84")]
			[Address(RVA = "0x8ADD14", Offset = "0x8ADD14", VA = "0x8ADD14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x8ADD5C", Offset = "0x8ADD5C", VA = "0x8ADD5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x8ADA98", Offset = "0x8ADA98", VA = "0x8ADA98")]
		[DebuggerHidden]
		public _003CItemAppearing_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x8ADAC4", Offset = "0x8ADAC4", VA = "0x8ADAC4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x8ADAC8", Offset = "0x8ADAC8", VA = "0x8ADAC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x8ADD1C", Offset = "0x8ADD1C", VA = "0x8ADD1C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A88", Offset = "0x595A88")]
	private sealed class _003CDoItemsDroppedAppearing_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400250C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400250D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400250E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x400250F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4002510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x170005AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B8A")]
			[Address(RVA = "0x8AD68C", Offset = "0x8AD68C", VA = "0x8AD68C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B8C")]
			[Address(RVA = "0x8AD6D4", Offset = "0x8AD6D4", VA = "0x8AD6D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x8AD440", Offset = "0x8AD440", VA = "0x8AD440")]
		[DebuggerHidden]
		public _003CDoItemsDroppedAppearing_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x8AD46C", Offset = "0x8AD46C", VA = "0x8AD46C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x8AD470", Offset = "0x8AD470", VA = "0x8AD470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x8AD694", Offset = "0x8AD694", VA = "0x8AD694", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595A98", Offset = "0x595A98")]
	private sealed class _003CDoCollectButtonAppearingAnimation_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x4002514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIPanel _003Cpanel_003E5__2;

		[Token(Token = "0x4002515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TweenAlpha _003Calpha_003E5__3;

		[Token(Token = "0x170005AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B90")]
			[Address(RVA = "0x8AD134", Offset = "0x8AD134", VA = "0x8AD134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B92")]
			[Address(RVA = "0x8AD17C", Offset = "0x8AD17C", VA = "0x8AD17C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x8ACEF8", Offset = "0x8ACEF8", VA = "0x8ACEF8")]
		[DebuggerHidden]
		public _003CDoCollectButtonAppearingAnimation_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x8ACF24", Offset = "0x8ACF24", VA = "0x8ACF24", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x8ACF28", Offset = "0x8ACF28", VA = "0x8ACF28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x8AD13C", Offset = "0x8AD13C", VA = "0x8AD13C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AA8", Offset = "0x595AA8")]
	private sealed class _003CPopupClosing_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x170005AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B96")]
			[Address(RVA = "0x8AE0AC", Offset = "0x8AE0AC", VA = "0x8AE0AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0x8AE0F4", Offset = "0x8AE0F4", VA = "0x8AE0F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x8ADD64", Offset = "0x8ADD64", VA = "0x8ADD64")]
		[DebuggerHidden]
		public _003CPopupClosing_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x8ADD90", Offset = "0x8ADD90", VA = "0x8ADD90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x8ADD94", Offset = "0x8ADD94", VA = "0x8ADD94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x8AE0B4", Offset = "0x8AE0B4", VA = "0x8AE0B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AB8", Offset = "0x595AB8")]
	private sealed class _003CDoItemsCollection_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400251A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400251B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x400251C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Coroutine> _003Ccoroutines_003E5__2;

		[Token(Token = "0x400251D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400251E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _003Ccount_003E5__4;

		[Token(Token = "0x170005B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B9C")]
			[Address(RVA = "0x8AD3F0", Offset = "0x8AD3F0", VA = "0x8AD3F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B9E")]
			[Address(RVA = "0x8AD438", Offset = "0x8AD438", VA = "0x8AD438", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x8AD184", Offset = "0x8AD184", VA = "0x8AD184")]
		[DebuggerHidden]
		public _003CDoItemsCollection_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x8AD1B0", Offset = "0x8AD1B0", VA = "0x8AD1B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x8AD1B4", Offset = "0x8AD1B4", VA = "0x8AD1B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x8AD3F8", Offset = "0x8AD3F8", VA = "0x8AD3F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595AC8", Offset = "0x595AC8")]
	private sealed class _003CFadeOutPopup_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400251F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView _003C_003E4__this;

		[Token(Token = "0x4002522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TweenAlpha _003Calpha_003E5__2;

		[Token(Token = "0x170005B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x8AD848", Offset = "0x8AD848", VA = "0x8AD848", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x8AD890", Offset = "0x8AD890", VA = "0x8AD890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x8AD6DC", Offset = "0x8AD6DC", VA = "0x8AD6DC")]
		[DebuggerHidden]
		public _003CFadeOutPopup_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x8AD708", Offset = "0x8AD708", VA = "0x8AD708", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x8AD70C", Offset = "0x8AD70C", VA = "0x8AD70C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x8AD850", Offset = "0x8AD850", VA = "0x8AD850", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40024DF")]
	private const string COMPLETED = "Completed";

	[Token(Token = "0x40024E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int START_TRIGGER;

	[Token(Token = "0x40024E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int SKIP_TRIGGER;

	[Token(Token = "0x40024E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UIPanel _container;

	[Token(Token = "0x40024E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private BlinkButtonHandler _collectButton;

	[Token(Token = "0x40024E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject _itemGrids;

	[Token(Token = "0x40024E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UISprite _fadeOverlay;

	[Token(Token = "0x40024E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Camera _camera;

	[Token(Token = "0x40024E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly Dictionary<int, Transform[]> _anchors;

	[Token(Token = "0x40024E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector3 _lootBoxVisualPosition;

	[Token(Token = "0x40024E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject _lootBoxVisualInstance;

	[Token(Token = "0x40024EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Animator _lootBoxVisualAnimator;

	[Token(Token = "0x40024EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool _boxAnimationCompleted;

	[Token(Token = "0x40024EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly List<LootBoxDroppedItemView> _itemViews;

	[Token(Token = "0x40024ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Coroutine _inputCheckCoroutine;

	[Token(Token = "0x40024EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Coroutine _popupStateCoroutine;

	[Token(Token = "0x17000599")]
	private PopupClaimLootBoxModel.AnimConfig Config
	{
		[Token(Token = "0x6002B37")]
		[Address(RVA = "0x92E5E4", Offset = "0x92E5E4", VA = "0x92E5E4")]
		get
		{
			return default(PopupClaimLootBoxModel.AnimConfig);
		}
	}

	[Token(Token = "0x1700059A")]
	private float AnimationSpeedFactor
	{
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x92E6A0", Offset = "0x92E6A0", VA = "0x92E6A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x92E724", Offset = "0x92E724", VA = "0x92E724")]
	public static PopupClaimLootBoxView Create(PopupClaimLootBoxView prefab, LootBox lootBox, [Optional] Action onClaimed, [Optional] Vector3 lootBoxVisualPosition)
	{
		return null;
	}

	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x92E8FC", Offset = "0x92E8FC", VA = "0x92E8FC")]
	public void Show(bool paused = false)
	{
	}

	[Token(Token = "0x6002B3B")]
	[Address(RVA = "0x92EC84", Offset = "0x92EC84", VA = "0x92EC84")]
	public void Play()
	{
	}

	[Token(Token = "0x6002B3C")]
	[Address(RVA = "0x92ECF8", Offset = "0x92ECF8", VA = "0x92ECF8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002B3D")]
	[Address(RVA = "0x92EF18", Offset = "0x92EF18", VA = "0x92EF18", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x92F83C", Offset = "0x92F83C", VA = "0x92F83C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002B3F")]
	[Address(RVA = "0x92F73C", Offset = "0x92F73C", VA = "0x92F73C")]
	private void SetupAnchorsAndStreches()
	{
	}

	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x92FA4C", Offset = "0x92FA4C", VA = "0x92FA4C", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x92F68C", Offset = "0x92F68C", VA = "0x92F68C")]
	private void OnStateChanged(PopupClaimLootBoxModel.State state)
	{
	}

	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x92EFF4", Offset = "0x92EFF4", VA = "0x92EFF4")]
	private void OnLootBoxChanged(LootBox lootBox)
	{
	}

	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x92F864", Offset = "0x92F864", VA = "0x92F864")]
	private void Clear()
	{
	}

	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x92FE98", Offset = "0x92FE98", VA = "0x92FE98")]
	private void OnBoxAnimationCompleted(GameObject sender, AnimationEvent e)
	{
	}

	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x92FC10", Offset = "0x92FC10", VA = "0x92FC10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EBA8", Offset = "0x61EBA8")]
	private IEnumerator PopupIntroWait()
	{
		return null;
	}

	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x92FC7C", Offset = "0x92FC7C", VA = "0x92FC7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EC08", Offset = "0x61EC08")]
	private IEnumerator PopupIntroCancelled()
	{
		return null;
	}

	[Token(Token = "0x6002B47")]
	[Address(RVA = "0x92FCE8", Offset = "0x92FCE8", VA = "0x92FCE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EC68", Offset = "0x61EC68")]
	private IEnumerator PopupOpening()
	{
		return null;
	}

	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x92FF14", Offset = "0x92FF14", VA = "0x92FF14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ECC8", Offset = "0x61ECC8")]
	private IEnumerator FadeToBlack(bool toBlack, float duration)
	{
		return null;
	}

	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x92FD54", Offset = "0x92FD54", VA = "0x92FD54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ED28", Offset = "0x61ED28")]
	private IEnumerator BoxOpening()
	{
		return null;
	}

	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x92FFA4", Offset = "0x92FFA4", VA = "0x92FFA4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ED88", Offset = "0x61ED88")]
	private IEnumerator DoBoxOpeningAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002B4B")]
	[Address(RVA = "0x930010", Offset = "0x930010", VA = "0x930010")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EDE8", Offset = "0x61EDE8")]
	private IEnumerator CheckInput()
	{
		return null;
	}

	[Token(Token = "0x6002B4C")]
	[Address(RVA = "0x92FDC0", Offset = "0x92FDC0", VA = "0x92FDC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EE48", Offset = "0x61EE48")]
	private IEnumerator ItemAppearing()
	{
		return null;
	}

	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x93007C", Offset = "0x93007C", VA = "0x93007C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EEA8", Offset = "0x61EEA8")]
	private IEnumerator DoItemsDroppedAppearing()
	{
		return null;
	}

	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x9300E8", Offset = "0x9300E8", VA = "0x9300E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EF08", Offset = "0x61EF08")]
	private IEnumerator DoCollectButtonAppearingAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002B4F")]
	[Address(RVA = "0x92FE2C", Offset = "0x92FE2C", VA = "0x92FE2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EF68", Offset = "0x61EF68")]
	private IEnumerator PopupClosing()
	{
		return null;
	}

	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x930154", Offset = "0x930154", VA = "0x930154")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61EFC8", Offset = "0x61EFC8")]
	private IEnumerator DoItemsCollection()
	{
		return null;
	}

	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x9301C0", Offset = "0x9301C0", VA = "0x9301C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620028", Offset = "0x620028")]
	private IEnumerator FadeOutPopup()
	{
		return null;
	}

	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x93022C", Offset = "0x93022C", VA = "0x93022C")]
	public PopupClaimLootBoxView()
	{
	}
}
