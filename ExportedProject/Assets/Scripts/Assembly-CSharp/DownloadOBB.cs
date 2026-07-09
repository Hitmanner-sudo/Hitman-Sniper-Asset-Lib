using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008FD")]
public class DownloadOBB
{
	[Token(Token = "0x20008FE")]
	public delegate void DownloadCompleteCallback();

	[Token(Token = "0x20008FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596DE4", Offset = "0x596DE4")]
	private sealed class _003CLoadLevel_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400318A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400318B")]
		[FieldOffset(Offset = "0x20")]
		public DownloadOBB _003C_003E4__this;

		[Token(Token = "0x17000747")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60039B5")]
			[Address(RVA = "0x86C134", Offset = "0x86C134", VA = "0x86C134", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000748")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60039B7")]
			[Address(RVA = "0x86C17C", Offset = "0x86C17C", VA = "0x86C17C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x86BCAC", Offset = "0x86BCAC", VA = "0x86BCAC")]
		[DebuggerHidden]
		public _003CLoadLevel_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x86BCD8", Offset = "0x86BCD8", VA = "0x86BCD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x86BCDC", Offset = "0x86BCDC", VA = "0x86BCDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x86C13C", Offset = "0x86C13C", VA = "0x86C13C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4003183")]
	[FieldOffset(Offset = "0x10")]
	private readonly DownloadCompleteCallback _callback;

	[Token(Token = "0x4003184")]
	[FieldOffset(Offset = "0x18")]
	private readonly MonoBehaviour _owner;

	[Token(Token = "0x4003185")]
	[FieldOffset(Offset = "0x20")]
	private string _expPath;

	[Token(Token = "0x4003186")]
	[FieldOffset(Offset = "0x28")]
	private bool _downloadStarted;

	[Token(Token = "0x4003187")]
	[FieldOffset(Offset = "0x30")]
	private readonly CustomLocalization _needPermissionLoc;

	[Token(Token = "0x4003188")]
	[FieldOffset(Offset = "0x38")]
	private readonly CustomLocalization _requestPermissionLoc;

	[Token(Token = "0x60039A6")]
	[Address(RVA = "0xC1B0B0", Offset = "0xC1B0B0", VA = "0xC1B0B0")]
	public DownloadOBB(MonoBehaviour ownerGameobject, DownloadCompleteCallback callback)
	{
	}

	[Token(Token = "0x60039A7")]
	[Address(RVA = "0xC1B170", Offset = "0xC1B170", VA = "0xC1B170")]
	public void Start()
	{
	}

	[Token(Token = "0x60039A8")]
	[Address(RVA = "0xC1B174", Offset = "0xC1B174", VA = "0xC1B174")]
	private void FetchOBB()
	{
	}

	[Token(Token = "0x60039A9")]
	[Address(RVA = "0xC1B4A0", Offset = "0xC1B4A0", VA = "0xC1B4A0")]
	private void RequestPermissionNotPermitCB()
	{
	}

	[Token(Token = "0x60039AA")]
	[Address(RVA = "0xC1B5C8", Offset = "0xC1B5C8", VA = "0xC1B5C8")]
	private void ShouldShowRequestPermissionRationaleOkClicked()
	{
	}

	[Token(Token = "0x60039AB")]
	[Address(RVA = "0xC1B6B0", Offset = "0xC1B6B0", VA = "0xC1B6B0")]
	private void RedirectToSettingsOkClicked()
	{
	}

	[Token(Token = "0x60039AC")]
	[Address(RVA = "0xC1B434", Offset = "0xC1B434", VA = "0xC1B434")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6246C0", Offset = "0x6246C0")]
	protected IEnumerator LoadLevel()
	{
		return null;
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0xC1B758", Offset = "0xC1B758", VA = "0xC1B758")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624720", Offset = "0x624720")]
	private void _003CFetchOBB_003Eb__9_0()
	{
	}
}
