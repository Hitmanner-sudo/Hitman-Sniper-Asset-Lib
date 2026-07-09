using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20000B3")]
[Scope]
public class MusicManager : GameSingleton<MusicManager>
{
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59223C", Offset = "0x59223C")]
	private sealed class _003CPlayMenuMusicDelayCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x20")]
		public MusicManager _003C_003E4__this;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x28")]
		public SoundContainer soundContainer;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x30")]
		public bool stopPreviousImmediate;

		[Token(Token = "0x17000113")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x8C93E0", Offset = "0x8C93E0", VA = "0x8C93E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x8C9428", Offset = "0x8C9428", VA = "0x8C9428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8C9350", Offset = "0x8C9350", VA = "0x8C9350")]
		[DebuggerHidden]
		public _003CPlayMenuMusicDelayCoroutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x8C937C", Offset = "0x8C937C", VA = "0x8C937C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8C9380", Offset = "0x8C9380", VA = "0x8C9380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8C93E8", Offset = "0x8C93E8", VA = "0x8C93E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x47")]
	private bool _isPlayingAlerted;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x48")]
	private SoundContainer _gameContainer;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x50")]
	private SoundContainer _menuContainer;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x58")]
	private PlayingSoundContainer _currentGamePlayingContainer;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x60")]
	private PlayingSoundContainer _currentMenuPlayingContainer;

	[Token(Token = "0x6000576")]
	[Address(RVA = "0xA31348", Offset = "0xA31348", VA = "0xA31348", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0xA31498", Offset = "0xA31498", VA = "0xA31498", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0xA31644", Offset = "0xA31644", VA = "0xA31644")]
	public void PlayGameMusic(SoundContainer soundContainer, bool stopPreviousImmediate = false)
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0xA24D58", Offset = "0xA24D58", VA = "0xA24D58")]
	public void PlayMenuMusic(SoundContainer soundContainer, bool stopPreviousImmediate = false)
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0xA317F8", Offset = "0xA317F8", VA = "0xA317F8")]
	public void PlayMenuMusicDelay(SoundContainer soundContainer, bool stopPreviousImmediate = false)
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0xA31828", Offset = "0xA31828", VA = "0xA31828")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611CB0", Offset = "0x611CB0")]
	private IEnumerator PlayMenuMusicDelayCoroutine(SoundContainer soundContainer, bool stopPreviousImmediate = false)
	{
		return null;
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0xA24CF8", Offset = "0xA24CF8", VA = "0xA24CF8")]
	public void StopGameMusic(bool immediate = false)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0xA31798", Offset = "0xA31798", VA = "0xA31798")]
	public void StopMenuMusic(bool immediate = false)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0xA318AC", Offset = "0xA318AC", VA = "0xA318AC")]
	private void OnLoadingViewDisabled(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0xA31A10", Offset = "0xA31A10", VA = "0xA31A10")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0xA31C04", Offset = "0xA31C04", VA = "0xA31C04")]
	private void OnGlobalAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs e)
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0xA31D9C", Offset = "0xA31D9C", VA = "0xA31D9C")]
	public MusicManager()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0xA31E14", Offset = "0xA31E14", VA = "0xA31E14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x611D10", Offset = "0x611D10")]
	private void _003COnContractEnded_003Eb__14_0()
	{
	}
}
