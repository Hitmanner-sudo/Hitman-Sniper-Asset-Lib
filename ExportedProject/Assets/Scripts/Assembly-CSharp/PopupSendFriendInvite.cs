using System;
using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Social;

[Token(Token = "0x200073B")]
public class PopupSendFriendInvite : PopupOverlayView
{
	[Token(Token = "0x200073C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F08", Offset = "0x595F08")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x10")]
		public PopupSendFriendInvite _003C_003E4__this;

		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardRecord record;

		[Token(Token = "0x6003057")]
		[Address(RVA = "0x8AF638", Offset = "0x8AF638", VA = "0x8AF638")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6003058")]
		[Address(RVA = "0x8AF640", Offset = "0x8AF640", VA = "0x8AF640")]
		internal void _003CAskUserRecord_003Eb__0(object s, SharedProfile.SharedProfileEvent e)
		{
		}
	}

	[Token(Token = "0x40028F5")]
	[FieldOffset(Offset = "0x100")]
	public UILabel Subject;

	[Token(Token = "0x40028F6")]
	[FieldOffset(Offset = "0x108")]
	public UITexture AvatarTexture;

	[Token(Token = "0x40028F7")]
	[FieldOffset(Offset = "0x110")]
	public UISprite NoAvatarSprite;

	[Token(Token = "0x40028F8")]
	[FieldOffset(Offset = "0x118")]
	public UILabel PlayerNameLabel;

	[Token(Token = "0x40028F9")]
	[FieldOffset(Offset = "0x120")]
	public UILabel PlayerSIDLabel;

	[Token(Token = "0x40028FA")]
	[FieldOffset(Offset = "0x128")]
	public BlinkButtonHandler DeclineButton;

	[Token(Token = "0x40028FB")]
	[FieldOffset(Offset = "0x130")]
	private LeaderboardRecord _targetRecord;

	[Token(Token = "0x40028FC")]
	[FieldOffset(Offset = "0x138")]
	private LeaderboardRecord _userRecord;

	[Token(Token = "0x40028FD")]
	[FieldOffset(Offset = "0x140")]
	private bool _avatarTextureRefreshed;

	[Token(Token = "0x40028FE")]
	[FieldOffset(Offset = "0x148")]
	private SniperLeaderboardRecordBuilder _builder;

	[Token(Token = "0x40028FF")]
	[FieldOffset(Offset = "0x150")]
	private Action _sendCallback;

	[Token(Token = "0x4002900")]
	[FieldOffset(Offset = "0x158")]
	private Action _acceptCallback;

	[Token(Token = "0x4002901")]
	[FieldOffset(Offset = "0x160")]
	private Action _declineCallback;

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x93AC00", Offset = "0x93AC00", VA = "0x93AC00", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600304B")]
	[Address(RVA = "0x938690", Offset = "0x938690", VA = "0x938690")]
	public void SetupPopupOverlay(string title, string subject, string message, string okText, LeaderboardRecord record, Action sendCallback, Action cancelCallback)
	{
	}

	[Token(Token = "0x600304C")]
	[Address(RVA = "0x938490", Offset = "0x938490", VA = "0x938490")]
	public void SetupPopupOverlay(string title, InboxItem inboxItem, string acceptText, string declineText, Action acceptCallback, Action declineCallback, Action cancelCallback)
	{
	}

	[Token(Token = "0x600304D")]
	[Address(RVA = "0x93AFE0", Offset = "0x93AFE0", VA = "0x93AFE0")]
	private void SetupButton(PopupButton button)
	{
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x93AF7C", Offset = "0x93AF7C", VA = "0x93AF7C")]
	private void SetupMessage(string sid, string from, string subject)
	{
	}

	[Token(Token = "0x600304F")]
	[Address(RVA = "0x93AD70", Offset = "0x93AD70", VA = "0x93AD70")]
	private void AskUserRecord(string sid, LeaderboardRecord record, string defaultDisplayName)
	{
	}

	[Token(Token = "0x6003050")]
	[Address(RVA = "0x93B11C", Offset = "0x93B11C", VA = "0x93B11C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6003051")]
	[Address(RVA = "0x93AEC0", Offset = "0x93AEC0", VA = "0x93AEC0")]
	private void RefreshAvatar()
	{
	}

	[Token(Token = "0x6003052")]
	[Address(RVA = "0x93B1B4", Offset = "0x93B1B4", VA = "0x93B1B4")]
	private void OnSendClicked()
	{
	}

	[Token(Token = "0x6003053")]
	[Address(RVA = "0x93B200", Offset = "0x93B200", VA = "0x93B200")]
	private void SendMessage(string subject, string body, InboxItem.MailboxIDType messageType)
	{
	}

	[Token(Token = "0x6003054")]
	[Address(RVA = "0x93B458", Offset = "0x93B458", VA = "0x93B458")]
	private void OnDeclineClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6003055")]
	[Address(RVA = "0x93B594", Offset = "0x93B594", VA = "0x93B594")]
	private void OnAcceptClicked()
	{
	}

	[Token(Token = "0x6003056")]
	[Address(RVA = "0x93B6CC", Offset = "0x93B6CC", VA = "0x93B6CC")]
	public PopupSendFriendInvite()
	{
	}
}
