using System;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x200049C")]
public class DeepLinkFriendMessage
{
	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x10")]
	private readonly string _senderSid;

	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x18")]
	private readonly string _receiverSid;

	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x20")]
	private readonly InboxItem.MailboxIDType _type;

	[Token(Token = "0x40018F5")]
	[FieldOffset(Offset = "0x24")]
	private readonly int _lifetimeDays;

	[Token(Token = "0x6001C03")]
	[Address(RVA = "0xAEE1B4", Offset = "0xAEE1B4", VA = "0xAEE1B4")]
	public DeepLinkFriendMessage(string senderSid, string receiverSid, InboxItem.MailboxIDType type, int lifetimeDays)
	{
	}

	[Token(Token = "0x6001C04")]
	[Address(RVA = "0xAEE200", Offset = "0xAEE200", VA = "0xAEE200")]
	public void Send(Action<bool, IResponseContext> subscriberAction)
	{
	}
}
