using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core;

[Token(Token = "0x2000785")]
public class CheckInboxItems
{
	[Token(Token = "0x2000786")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596088", Offset = "0x596088")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0x10")]
		public CheckInboxItems _003C_003E4__this;

		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x18")]
		public Mailbox mailbox;

		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x8623E0", Offset = "0x8623E0", VA = "0x8623E0")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x8623E8", Offset = "0x8623E8", VA = "0x8623E8")]
		internal void _003CUpdateInbox_003Eb__0(bool succeed)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000787")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596098", Offset = "0x596098")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<Message, InboxItem> _003C_003E9__6_1;

		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<InboxItem> _003C_003E9__6_2;

		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x8622F4", Offset = "0x8622F4", VA = "0x8622F4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x8622FC", Offset = "0x8622FC", VA = "0x8622FC")]
		internal InboxItem _003CUpdateInbox_003Eb__6_1(Message a)
		{
			return null;
		}

		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x86235C", Offset = "0x86235C", VA = "0x86235C")]
		internal int _003CUpdateInbox_003Eb__6_2(InboxItem item1, InboxItem item2)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000788")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5960A8", Offset = "0x5960A8")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x10")]
		public CheckInboxItems _003C_003E4__this;

		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x18")]
		public InboxItem inboxItem;

		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x86268C", Offset = "0x86268C", VA = "0x86268C")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x862694", Offset = "0x862694", VA = "0x862694")]
		internal void _003CDisplayInboxMessage_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000789")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5960B8", Offset = "0x5960B8")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x10")]
		public CheckInboxItems _003C_003E4__this;

		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0x18")]
		public InboxItem inboxItem;

		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x8626BC", Offset = "0x8626BC", VA = "0x8626BC")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6003200")]
		[Address(RVA = "0x8626C4", Offset = "0x8626C4", VA = "0x8626C4")]
		internal void _003CDisplayConfirmFriendInvite_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200078A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5960C8", Offset = "0x5960C8")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0x10")]
		public CheckInboxItems _003C_003E4__this;

		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x18")]
		public InboxItem inboxItem;

		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> validAttachments;

		[Token(Token = "0x6003201")]
		[Address(RVA = "0x8623B4", Offset = "0x8623B4", VA = "0x8623B4")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6003202")]
		[Address(RVA = "0x8623BC", Offset = "0x8623BC", VA = "0x8623BC")]
		internal void _003CDisplayInboxReward_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002A68")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<InboxItem> _inboxItems;

	[Token(Token = "0x4002A69")]
	[FieldOffset(Offset = "0x18")]
	private readonly Action _callbackAfterUpdateSucceded;

	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0x20")]
	private readonly Action _callbackAfterClearMessage;

	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0x28")]
	private InboxItem _currentPopupInboxItem;

	[Token(Token = "0x60031E7")]
	[Address(RVA = "0xAF7E88", Offset = "0xAF7E88", VA = "0xAF7E88")]
	public CheckInboxItems(Action callbackAfterUpdateSucceded, Action callbackAfterClearMessage)
	{
	}

	[Token(Token = "0x60031E8")]
	[Address(RVA = "0xAF822C", Offset = "0xAF822C", VA = "0xAF822C")]
	public bool DoCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60031E9")]
	[Address(RVA = "0xAF8114", Offset = "0xAF8114", VA = "0xAF8114")]
	public void UpdateInbox()
	{
	}

	[Token(Token = "0x60031EA")]
	[Address(RVA = "0xAFDE98", Offset = "0xAFDE98", VA = "0xAFDE98")]
	private void DisplayInboxMessage(InboxItem inboxItem)
	{
	}

	[Token(Token = "0x60031EB")]
	[Address(RVA = "0xAFE4C8", Offset = "0xAFE4C8", VA = "0xAFE4C8")]
	private void DisplayConfirmFriendInvite(InboxItem inboxItem)
	{
	}

	[Token(Token = "0x60031EC")]
	[Address(RVA = "0xAFEBC8", Offset = "0xAFEBC8", VA = "0xAFEBC8")]
	private void OnConfirmFriendClicked(InboxItem inboxItem)
	{
	}

	[Token(Token = "0x60031ED")]
	[Address(RVA = "0xAFEC84", Offset = "0xAFEC84", VA = "0xAFEC84")]
	private void ClearInboxMessage(InboxItem inboxItem, bool clearPopup)
	{
	}

	[Token(Token = "0x60031EE")]
	[Address(RVA = "0xAFDFA4", Offset = "0xAFDFA4", VA = "0xAFDFA4")]
	private void DisplayInboxReward(InboxItem inboxItem)
	{
	}

	[Token(Token = "0x60031EF")]
	[Address(RVA = "0xAFE7BC", Offset = "0xAFE7BC", VA = "0xAFE7BC")]
	private static void CreateMessagePopup(InboxItem inboxItem, Action onOk, string onOkText)
	{
	}

	[Token(Token = "0x60031F0")]
	[Address(RVA = "0xAFED3C", Offset = "0xAFED3C", VA = "0xAFED3C")]
	private void OnInboxRewardOkCallback(InboxItem inboxItem, Dictionary<string, int> validAttachments)
	{
	}

	[Token(Token = "0x60031F1")]
	[Address(RVA = "0xAFE344", Offset = "0xAFE344", VA = "0xAFE344")]
	private void DisplayFriendInvite(InboxItem inboxItem)
	{
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0xAFEFE0", Offset = "0xAFEFE0", VA = "0xAFEFE0")]
	private void OnAcceptOrDeclineCallback()
	{
	}

	[Token(Token = "0x60031F3")]
	[Address(RVA = "0xAFF00C", Offset = "0xAFF00C", VA = "0xAFF00C")]
	private void OnCancelCallback()
	{
	}

	[Token(Token = "0x60031F4")]
	[Address(RVA = "0xAFE5D4", Offset = "0xAFE5D4", VA = "0xAFE5D4")]
	private void ProcessFriendReferral(InboxItem item)
	{
	}

	[Token(Token = "0x60031F5")]
	[Address(RVA = "0xAFE69C", Offset = "0xAFE69C", VA = "0xAFE69C")]
	private void ProcessDeepLinkFriendRequest(InboxItem item)
	{
	}

	[Token(Token = "0x60031F6")]
	[Address(RVA = "0xAFE72C", Offset = "0xAFE72C", VA = "0xAFE72C")]
	private void ProcessDeepLinkFriendDelete(InboxItem item)
	{
	}
}
