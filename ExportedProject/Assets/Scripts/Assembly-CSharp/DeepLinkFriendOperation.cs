using Il2CppDummyDll;
using Technology.Core.Common;
using Technology.Core.ServiceOperations;
using Technology.Social;

[Token(Token = "0x200049E")]
public abstract class DeepLinkFriendOperation
{
	[Token(Token = "0x200049F")]
	protected enum OperationResult
	{
		[Token(Token = "0x40018F9")]
		Success = 0,
		[Token(Token = "0x40018FA")]
		FailureProfileFetch = 1,
		[Token(Token = "0x40018FB")]
		FailureMailSend = 2,
		[Token(Token = "0x40018FC")]
		FailureCancel = 3
	}

	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x10")]
	private readonly string _receiverSid;

	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0x18")]
	private LeaderboardRecord _record;

	[Token(Token = "0x17000458")]
	public string ReceiverSid
	{
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0xC11698", Offset = "0xC11698", VA = "0xC11698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000459")]
	protected LeaderboardRecord Record
	{
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0xC116A0", Offset = "0xC116A0", VA = "0xC116A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045A")]
	protected static DeepLinkFriendData FriendData
	{
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0xC116A8", Offset = "0xC116A8", VA = "0xC116A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045B")]
	protected abstract InboxItem.MailboxIDType MailType
	{
		[Token(Token = "0x6001C10")]
		get;
	}

	[Token(Token = "0x1700045C")]
	protected abstract int MessageLifetimeDays
	{
		[Token(Token = "0x6001C11")]
		get;
	}

	[Token(Token = "0x1700045D")]
	protected abstract PopupFriendManagement.Info PopupInfo
	{
		[Token(Token = "0x6001C12")]
		get;
	}

	[Token(Token = "0x1700045E")]
	protected abstract string LogName
	{
		[Token(Token = "0x6001C21")]
		get;
	}

	[Token(Token = "0x6001C13")]
	[Address(RVA = "0xC11730", Offset = "0xC11730", VA = "0xC11730")]
	protected DeepLinkFriendOperation(string receiverSid)
	{
	}

	[Token(Token = "0x6001C14")]
	[Address(RVA = "0xC1175C", Offset = "0xC1175C", VA = "0xC1175C")]
	protected DeepLinkFriendOperation(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6001C15")]
	[Address(RVA = "0xC11794", Offset = "0xC11794", VA = "0xC11794")]
	public void Start()
	{
	}

	[Token(Token = "0x6001C16")]
	[Address(RVA = "0xC11994", Offset = "0xC11994", VA = "0xC11994")]
	public void Send()
	{
	}

	[Token(Token = "0x6001C17")]
	protected abstract void OnOperationComplete(OperationResult result);

	[Token(Token = "0x6001C18")]
	[Address(RVA = "0xC11AE0", Offset = "0xC11AE0", VA = "0xC11AE0", Slot = "8")]
	protected virtual void OnBeforeSend()
	{
	}

	[Token(Token = "0x6001C19")]
	[Address(RVA = "0xC11888", Offset = "0xC11888", VA = "0xC11888")]
	private void ShowConfirmationPopup()
	{
	}

	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0xC11AE4", Offset = "0xC11AE4", VA = "0xC11AE4")]
	private void PopupConfirm()
	{
	}

	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0xC11B70", Offset = "0xC11B70", VA = "0xC11B70")]
	private void PopupCancel()
	{
	}

	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0xC11C08", Offset = "0xC11C08", VA = "0xC11C08")]
	private void OnSendComplete(bool success, IResponseContext response)
	{
	}

	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0xC117A4", Offset = "0xC117A4", VA = "0xC117A4")]
	private void GetOnlineProfile()
	{
	}

	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0xC11C20", Offset = "0xC11C20", VA = "0xC11C20")]
	private void GetSharedProfileComplete(object sender, SharedProfile.SharedProfileEvent e)
	{
	}

	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0xC11C74", Offset = "0xC11C74", VA = "0xC11C74")]
	private void GetScore()
	{
	}

	[Token(Token = "0x6001C20")]
	[Address(RVA = "0xC11E48", Offset = "0xC11E48", VA = "0xC11E48")]
	private void OnGetScoreComplete(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6001C22")]
	[Address(RVA = "0xC11F38", Offset = "0xC11F38", VA = "0xC11F38")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x618528", Offset = "0x618528")]
	protected void Log(string msg)
	{
	}

	[Token(Token = "0x6001C23")]
	[Address(RVA = "0xC11F3C", Offset = "0xC11F3C", VA = "0xC11F3C")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0x618560", Offset = "0x618560")]
	protected void Logf(string fmt, params object[] args)
	{
	}
}
