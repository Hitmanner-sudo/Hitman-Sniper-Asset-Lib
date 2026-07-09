using System;
using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000729")]
public class PopupFriendInvite : PopupOverlayView
{
	[Token(Token = "0x400287A")]
	[FieldOffset(Offset = "0x100")]
	public BlinkButtonHandler LoginToFacebookButton;

	[Token(Token = "0x400287B")]
	[FieldOffset(Offset = "0x108")]
	public UILabel LoginToFacebookLabel;

	[Token(Token = "0x400287C")]
	[FieldOffset(Offset = "0x110")]
	public GameObject Foreground;

	[Token(Token = "0x400287D")]
	[FieldOffset(Offset = "0x118")]
	public UILabel ErrorMessage;

	[Token(Token = "0x400287E")]
	[FieldOffset(Offset = "0x120")]
	public UILabel SearchIDDescription;

	[Token(Token = "0x400287F")]
	[FieldOffset(Offset = "0x128")]
	public PopupSendFriendInvite PopupSendFriendInvitePrefab;

	[Token(Token = "0x4002880")]
	[FieldOffset(Offset = "0x130")]
	private LeaderboardRecord _record;

	[Token(Token = "0x4002881")]
	[FieldOffset(Offset = "0x138")]
	private bool _playerFound;

	[Token(Token = "0x4002882")]
	[FieldOffset(Offset = "0x140")]
	private Action _sendCallback;

	[Token(Token = "0x4002883")]
	[FieldOffset(Offset = "0x148")]
	private Action _facebookCallback;

	[Token(Token = "0x4002884")]
	[FieldOffset(Offset = "0x150")]
	private Action _cancelCallback;

	[Token(Token = "0x4002885")]
	[FieldOffset(Offset = "0x158")]
	private SniperLeaderboardRecordBuilder _builder;

	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x931508", Offset = "0x931508", VA = "0x931508", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x93166C", Offset = "0x93166C", VA = "0x93166C")]
	public void SetupPopupOverlay(string title, string message, string okText, Action facebookCallback, Action sendCallback, Action cancelCallback)
	{
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x9317C4", Offset = "0x9317C4", VA = "0x9317C4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x931B78", Offset = "0x931B78", VA = "0x931B78", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x931CB4", Offset = "0x931CB4", VA = "0x931CB4")]
	private void OnSearchClicked()
	{
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x931E50", Offset = "0x931E50", VA = "0x931E50")]
	private void AskUserRecord()
	{
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x931F74", Offset = "0x931F74", VA = "0x931F74")]
	private void Update()
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x932340", Offset = "0x932340", VA = "0x932340")]
	private void OnLoginToFacebookClicked(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x93235C", Offset = "0x93235C", VA = "0x93235C")]
	private void OnLinkConfirmed(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x931908", Offset = "0x931908", VA = "0x931908")]
	private void RefreshConnectionStatus()
	{
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x932380", Offset = "0x932380", VA = "0x932380")]
	public PopupFriendInvite()
	{
	}

	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x932384", Offset = "0x932384", VA = "0x932384")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621980", Offset = "0x621980")]
	private void _003CAskUserRecord_003Eb__17_0(object s, SharedProfile.SharedProfileEvent e)
	{
	}
}
