using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core;

[Token(Token = "0x20002E5")]
public class InboxItem
{
	[Token(Token = "0x20002E6")]
	public enum MailboxIDType
	{
		[Token(Token = "0x4001002")]
		NONE = 0,
		[Token(Token = "0x4001003")]
		Reward = 1,
		[Token(Token = "0x4001004")]
		DEPRECATED_SaveGame = 2,
		[Token(Token = "0x4001005")]
		FriendInvite = 3,
		[Token(Token = "0x4001006")]
		ConfirmFriendInvite = 4,
		[Token(Token = "0x4001007")]
		FriendReferral = 5,
		[Token(Token = "0x4001008")]
		DeepLinkFriendRequest = 6,
		[Token(Token = "0x4001009")]
		DeepLinkFriendDelete = 7,
		[Token(Token = "0x400100A")]
		COUNT = 8
	}

	[Token(Token = "0x4000FFA")]
	public const string JSON_CONTENT_TYPE = "application/json";

	[Token(Token = "0x4000FFB")]
	private const string JSON_BODY_KEY = "Body";

	[Token(Token = "0x4000FFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int Width;

	[Token(Token = "0x4000FFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3CB4", Offset = "0x5B3CB4")]
	private string _003CBody_003Ek__BackingField;

	[Token(Token = "0x4000FFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3CC4", Offset = "0x5B3CC4")]
	private MailboxIDType _003CMailboxID_003Ek__BackingField;

	[Token(Token = "0x4000FFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3CD4", Offset = "0x5B3CD4")]
	private BaseInboxItemJSONData _003CJSONData_003Ek__BackingField;

	[Token(Token = "0x4001000")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Message Message;

	[Token(Token = "0x1700029A")]
	public string Body
	{
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0xB0A7C0", Offset = "0xB0A7C0", VA = "0xB0A7C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F64", Offset = "0x615F64")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0xB0A7C8", Offset = "0xB0A7C8", VA = "0xB0A7C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F74", Offset = "0x615F74")]
		private set
		{
		}
	}

	[Token(Token = "0x1700029B")]
	public MailboxIDType MailboxID
	{
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0xB0A7D0", Offset = "0xB0A7D0", VA = "0xB0A7D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F84", Offset = "0x615F84")]
		get
		{
			return default(MailboxIDType);
		}
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0xB0A7D8", Offset = "0xB0A7D8", VA = "0xB0A7D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615F94", Offset = "0x615F94")]
		private set
		{
		}
	}

	[Token(Token = "0x1700029C")]
	public BaseInboxItemJSONData JSONData
	{
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0xB0A7E0", Offset = "0xB0A7E0", VA = "0xB0A7E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FA4", Offset = "0x615FA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0xB0A7E8", Offset = "0xB0A7E8", VA = "0xB0A7E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615FB4", Offset = "0x615FB4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700029D")]
	public List<Message.Attachment> Attachments
	{
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0xB0A7F0", Offset = "0xB0A7F0", VA = "0xB0A7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029E")]
	public bool HasAttachments
	{
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0xB0A80C", Offset = "0xB0A80C", VA = "0xB0A80C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700029F")]
	public string Subject
	{
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0xB0A870", Offset = "0xB0A870", VA = "0xB0A870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A0")]
	public string From
	{
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0xB0A898", Offset = "0xB0A898", VA = "0xB0A898")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A1")]
	public string FromID
	{
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0xB0A8C0", Offset = "0xB0A8C0", VA = "0xB0A8C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A2")]
	public DateTime Date
	{
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0xB0A8E8", Offset = "0xB0A8E8", VA = "0xB0A8E8")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x170002A3")]
	public bool IsRead
	{
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0xB0A910", Offset = "0xB0A910", VA = "0xB0A910")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0xB0A92C", Offset = "0xB0A92C", VA = "0xB0A92C")]
	public InboxItem(Message message)
	{
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0xB0A9F4", Offset = "0xB0A9F4", VA = "0xB0A9F4")]
	private void ReadJSONContent()
	{
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0xB0ABA4", Offset = "0xB0ABA4", VA = "0xB0ABA4")]
	private void ReadDefaultContent()
	{
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0xB0ACA0", Offset = "0xB0ACA0", VA = "0xB0ACA0")]
	private void SetMailboxID()
	{
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0xB0ACD8", Offset = "0xB0ACD8", VA = "0xB0ACD8")]
	private void SetJSONData(BaseInboxItemJSONData baseInboxItemJSONData)
	{
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0xB0ACEC", Offset = "0xB0ACEC", VA = "0xB0ACEC")]
	public void Delete([Optional] Action action)
	{
	}
}
