using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200052B")]
public class PauseMenuController : UIController
{
	[Token(Token = "0x200052C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595030", Offset = "0x595030")]
	private sealed class _003CWaitForInputToHideInfo_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B77")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B78")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B79")]
		[FieldOffset(Offset = "0x20")]
		public PauseMenuController _003C_003E4__this;

		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170004D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002047")]
			[Address(RVA = "0x8CF0E8", Offset = "0x8CF0E8", VA = "0x8CF0E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x8CF130", Offset = "0x8CF130", VA = "0x8CF130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002044")]
		[Address(RVA = "0x8CEDB0", Offset = "0x8CEDB0", VA = "0x8CEDB0")]
		[DebuggerHidden]
		public _003CWaitForInputToHideInfo_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002045")]
		[Address(RVA = "0x8CEDDC", Offset = "0x8CEDDC", VA = "0x8CEDDC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002046")]
		[Address(RVA = "0x8CEDE0", Offset = "0x8CEDE0", VA = "0x8CEDE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002048")]
		[Address(RVA = "0x8CF0F0", Offset = "0x8CF0F0", VA = "0x8CF0F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001B64")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected Collider OverlayCollider;

	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _restartButton;

	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BlinkButtonHandler _quitButton;

	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private BlinkButtonHandler _resumeButton;

	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private BlinkButtonHandler _tapToContinueButton;

	[Token(Token = "0x4001B69")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private OptionsItemView _musicVolumeOption;

	[Token(Token = "0x4001B6A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private OptionsItemView _sfxVolumeOption;

	[Token(Token = "0x4001B6B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private OptionsItemView _leftHandedOption;

	[Token(Token = "0x4001B6C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private OptionsItemView _shootButtonOption;

	[Token(Token = "0x4001B6D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private OptionsItemView _goreOption;

	[Token(Token = "0x4001B6E")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private OptionsItemView _invertAxisOption;

	[Token(Token = "0x4001B6F")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private OptionsItemView _feedbackButton;

	[Token(Token = "0x4001B70")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private QuitPromptOverlayController _quitPrompt;

	[Token(Token = "0x4001B71")]
	[FieldOffset(Offset = "0xB8")]
	protected Coroutine CurrentInfoWait;

	[Token(Token = "0x4001B72")]
	[FieldOffset(Offset = "0xC0")]
	protected UIForwardEvents EventForwarder;

	[Token(Token = "0x4001B73")]
	[FieldOffset(Offset = "0xC8")]
	protected float StartPauseTime;

	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0xCC")]
	private bool _skipInfo;

	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0xD0")]
	private string _menu;

	[Token(Token = "0x4001B76")]
	[FieldOffset(Offset = "0xD8")]
	private Transform _options;

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x8F7854", Offset = "0x8F7854", VA = "0x8F7854", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0x8F79C4", Offset = "0x8F79C4", VA = "0x8F79C4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002023")]
	[Address(RVA = "0x8F7F90", Offset = "0x8F7F90", VA = "0x8F7F90", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x8F8500", Offset = "0x8F8500", VA = "0x8F8500", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002025")]
	[Address(RVA = "0x8F8614", Offset = "0x8F8614", VA = "0x8F8614", Slot = "14")]
	protected virtual void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6002026")]
	[Address(RVA = "0x8F8864", Offset = "0x8F8864", VA = "0x8F8864")]
	protected void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6002027")]
	[Address(RVA = "0x8F887C", Offset = "0x8F887C", VA = "0x8F887C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6002028")]
	[Address(RVA = "0x8F8D48", Offset = "0x8F8D48", VA = "0x8F8D48", Slot = "15")]
	protected virtual void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002029")]
	[Address(RVA = "0x8F89D4", Offset = "0x8F89D4", VA = "0x8F89D4")]
	private void HandleAndroidHardwareButton()
	{
	}

	[Token(Token = "0x600202A")]
	[Address(RVA = "0x8F9080", Offset = "0x8F9080", VA = "0x8F9080", Slot = "16")]
	protected virtual void OnPauseMenuStateChanged(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
	}

	[Token(Token = "0x600202B")]
	[Address(RVA = "0x8F9584", Offset = "0x8F9584", VA = "0x8F9584", Slot = "17")]
	protected virtual void ShowOverlayCollider(HUDModel.PauseMenuState newState, bool paused)
	{
	}

	[Token(Token = "0x600202C")]
	[Address(RVA = "0x8F95B0", Offset = "0x8F95B0", VA = "0x8F95B0", Slot = "18")]
	protected virtual bool StartGameResume(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
		return default(bool);
	}

	[Token(Token = "0x600202D")]
	[Address(RVA = "0x8F95C8", Offset = "0x8F95C8", VA = "0x8F95C8", Slot = "19")]
	protected virtual bool StartGamePause(HUDModel.PauseMenuState newState, HUDModel.PauseMenuState oldState)
	{
		return default(bool);
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0x8F95E0", Offset = "0x8F95E0", VA = "0x8F95E0", Slot = "20")]
	public virtual void OnResumeClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x8F96A4", Offset = "0x8F96A4", VA = "0x8F96A4")]
	private void OnRestartClickFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002030")]
	[Address(RVA = "0x8F983C", Offset = "0x8F983C", VA = "0x8F983C", Slot = "21")]
	protected virtual void RestartLevel()
	{
	}

	[Token(Token = "0x6002031")]
	[Address(RVA = "0x8F8E98", Offset = "0x8F8E98", VA = "0x8F8E98")]
	private void OnQuitClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002032")]
	[Address(RVA = "0x8F9B6C", Offset = "0x8F9B6C", VA = "0x8F9B6C")]
	private void OnLeftHandedChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6002033")]
	[Address(RVA = "0x8F9D2C", Offset = "0x8F9D2C", VA = "0x8F9D2C")]
	private void OnShootButtonChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6002034")]
	[Address(RVA = "0x8F9EE8", Offset = "0x8F9EE8", VA = "0x8F9EE8")]
	private static void OnInvertAxisButtonChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x8FA01C", Offset = "0x8FA01C", VA = "0x8FA01C")]
	private static void OnGoreButtonChanged(int itemIndex, string itemName)
	{
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x8FA1E8", Offset = "0x8FA1E8", VA = "0x8FA1E8")]
	private static void OnFeedbackClicked()
	{
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x8FA268", Offset = "0x8FA268", VA = "0x8FA268")]
	private void CancelQuit()
	{
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x8FA3D0", Offset = "0x8FA3D0", VA = "0x8FA3D0")]
	private void ConfirmQuit()
	{
	}

	[Token(Token = "0x6002039")]
	[Address(RVA = "0x8F935C", Offset = "0x8F935C", VA = "0x8F935C")]
	protected void Pause()
	{
	}

	[Token(Token = "0x600203A")]
	[Address(RVA = "0x8FA5E8", Offset = "0x8FA5E8", VA = "0x8FA5E8", Slot = "22")]
	protected virtual void Resume()
	{
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x8F99BC", Offset = "0x8F99BC", VA = "0x8F99BC")]
	private void ResumeDontStopPauseMusic()
	{
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x8FA794", Offset = "0x8FA794", VA = "0x8FA794")]
	protected void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x8FA7A0", Offset = "0x8FA7A0", VA = "0x8FA7A0")]
	private void OnTapToContinueClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600203E")]
	[Address(RVA = "0x8F9518", Offset = "0x8F9518", VA = "0x8F9518")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619278", Offset = "0x619278")]
	protected IEnumerator WaitForInputToHideInfo()
	{
		return null;
	}

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x8FA7AC", Offset = "0x8FA7AC", VA = "0x8FA7AC", Slot = "23")]
	protected virtual bool ShouldPause(HUDModel.PauseMenuState oldState, HUDModel.PauseMenuState newState)
	{
		return default(bool);
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x8FA7C4", Offset = "0x8FA7C4", VA = "0x8FA7C4", Slot = "24")]
	protected virtual bool ShouldResume(HUDModel.PauseMenuState oldState, HUDModel.PauseMenuState newState)
	{
		return default(bool);
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x8F9074", Offset = "0x8F9074", VA = "0x8F9074")]
	public void ForceResumeFromStartGameInfo()
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x8FA7DC", Offset = "0x8FA7DC", VA = "0x8FA7DC")]
	public PauseMenuController()
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x8FA7E4", Offset = "0x8FA7E4", VA = "0x8FA7E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6192D8", Offset = "0x6192D8")]
	private void _003CConfirmQuit_003Eb__42_0()
	{
	}
}
