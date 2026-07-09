using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006AB")]
public class MainMenuPageView : View
{
	[NonSerialized]
	[Token(Token = "0x4002529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public UIDraggablePanel OwnerPanel;

	[NonSerialized]
	[Token(Token = "0x400252A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ModeView ParentModeView;

	[NonSerialized]
	[Token(Token = "0x400252B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ModesModel.MenuPages PageID;

	[Token(Token = "0x400252C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public DimmedBackgroundView DimmedBackgroundPrefab;

	[Token(Token = "0x400252D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public DimmedBackgroundView TransparentBackgroundPrefab;

	[Token(Token = "0x400252E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool HideNewFeedBackOnPageCentered;

	[Token(Token = "0x400252F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float _startPauseTime;

	[Token(Token = "0x1400009D")]
	public event EventHandler<EventArgs> OnMenuPageCentered
	{
		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x9AD758", Offset = "0x9AD758", VA = "0x9AD758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620498", Offset = "0x620498")]
		add
		{
		}
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x9AD7F8", Offset = "0x9AD7F8", VA = "0x9AD7F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204A8", Offset = "0x6204A8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x9AD898", Offset = "0x9AD898", VA = "0x9AD898", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002BAF")]
	[Address(RVA = "0x9AD914", Offset = "0x9AD914", VA = "0x9AD914", Slot = "15")]
	protected virtual void OnApplicationPause(bool isPaused)
	{
	}

	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x9AD9C0", Offset = "0x9AD9C0", VA = "0x9AD9C0", Slot = "16")]
	public virtual void LoadView()
	{
	}

	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x9AD9C4", Offset = "0x9AD9C4", VA = "0x9AD9C4")]
	protected void SetNewFeedback(bool visible, int numberToShow = 0, ModesModel.MenuPages specificPage = ModesModel.MenuPages.NONE, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x9ADA04", Offset = "0x9ADA04", VA = "0x9ADA04", Slot = "17")]
	public virtual void RaisePageCentered()
	{
	}

	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x9ADAB8", Offset = "0x9ADAB8", VA = "0x9ADAB8", Slot = "18")]
	public virtual void PageVisibilityChanged(bool active)
	{
	}

	[Token(Token = "0x6002BB4")]
	[Address(RVA = "0x9ADABC", Offset = "0x9ADABC", VA = "0x9ADABC")]
	public void DimBGToHighlightButton(GameObject highlightedGameObject, ButtonHandler highlightedButton, [Optional][DefaultParameterValue(0f)] float mountDelay, [Optional] Action onMountCallback, [Optional][DefaultParameterValue(false)] bool transparentBG, [Optional][DefaultParameterValue(false)] bool canClickOnBackground, [Optional] EventHandler<ButtonHandler.ButtonHandlerEventArgs> onDismiss, bool closeDimBackgroundOnButtonClicked = true)
	{
	}

	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x9ADAE8", Offset = "0x9ADAE8", VA = "0x9ADAE8")]
	public void ClearDimmedBackground([Optional] object sender, [Optional] ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002BB6")]
	[Address(RVA = "0x9ADB04", Offset = "0x9ADB04", VA = "0x9ADB04")]
	public DimmedBackgroundView GetDimmedBackground()
	{
		return null;
	}

	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x9ADB20", Offset = "0x9ADB20", VA = "0x9ADB20")]
	public MainMenuPageView()
	{
	}

	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x9ADB30", Offset = "0x9ADB30", VA = "0x9ADB30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6204B8", Offset = "0x6204B8")]
	private void _003COnApplicationPause_003Eb__11_0()
	{
	}
}
