using Il2CppDummyDll;
using Technology.Social;

[Token(Token = "0x200049D")]
public class DeepLinkFriendDelete : DeepLinkFriendOperation
{
	[Token(Token = "0x17000454")]
	protected override string LogName
	{
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0xAECD20", Offset = "0xAECD20", VA = "0xAECD20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000455")]
	protected override InboxItem.MailboxIDType MailType
	{
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0xAECD64", Offset = "0xAECD64", VA = "0xAECD64", Slot = "4")]
		get
		{
			return default(InboxItem.MailboxIDType);
		}
	}

	[Token(Token = "0x17000456")]
	protected override int MessageLifetimeDays
	{
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0xAECD6C", Offset = "0xAECD6C", VA = "0xAECD6C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000457")]
	protected override PopupFriendManagement.Info PopupInfo
	{
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0xAECD74", Offset = "0xAECD74", VA = "0xAECD74", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C09")]
	[Address(RVA = "0xAECDC8", Offset = "0xAECDC8", VA = "0xAECDC8")]
	public DeepLinkFriendDelete(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0xAECDD0", Offset = "0xAECDD0", VA = "0xAECDD0", Slot = "7")]
	protected override void OnOperationComplete(OperationResult result)
	{
	}

	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0xAECE28", Offset = "0xAECE28", VA = "0xAECE28")]
	private void ShowSuccessPopup()
	{
	}

	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0xAECE8C", Offset = "0xAECE8C", VA = "0xAECE8C")]
	private void ShowProfileFailPopup()
	{
	}
}
