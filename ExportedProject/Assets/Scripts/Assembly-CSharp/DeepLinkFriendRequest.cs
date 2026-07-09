using Il2CppDummyDll;

[Token(Token = "0x20004A0")]
public class DeepLinkFriendRequest : DeepLinkFriendOperation
{
	[Token(Token = "0x1700045F")]
	protected override string LogName
	{
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0xC11F40", Offset = "0xC11F40", VA = "0xC11F40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000460")]
	protected override InboxItem.MailboxIDType MailType
	{
		[Token(Token = "0x6001C25")]
		[Address(RVA = "0xC11F84", Offset = "0xC11F84", VA = "0xC11F84", Slot = "4")]
		get
		{
			return default(InboxItem.MailboxIDType);
		}
	}

	[Token(Token = "0x17000461")]
	protected override int MessageLifetimeDays
	{
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0xC11F8C", Offset = "0xC11F8C", VA = "0xC11F8C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000462")]
	protected override PopupFriendManagement.Info PopupInfo
	{
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0xC11F94", Offset = "0xC11F94", VA = "0xC11F94", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C28")]
	[Address(RVA = "0xC11FE8", Offset = "0xC11FE8", VA = "0xC11FE8")]
	public DeepLinkFriendRequest(string receiverSid)
	{
	}

	[Token(Token = "0x6001C29")]
	[Address(RVA = "0xC12014", Offset = "0xC12014", VA = "0xC12014", Slot = "7")]
	protected override void OnOperationComplete(OperationResult result)
	{
	}

	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0xC120D0", Offset = "0xC120D0", VA = "0xC120D0")]
	private void OnSuccess()
	{
	}

	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0xC12150", Offset = "0xC12150", VA = "0xC12150")]
	private void ShowProfileFetchFailPopup()
	{
	}

	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0xC121B8", Offset = "0xC121B8", VA = "0xC121B8")]
	private void ShowMailSendFailPopup()
	{
	}
}
