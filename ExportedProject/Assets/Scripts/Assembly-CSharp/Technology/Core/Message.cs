using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C7A")]
	public class Message
	{
		[Token(Token = "0x2000C7B")]
		public enum MessageState
		{
			[Token(Token = "0x4003CFE")]
			NONE = 0,
			[Token(Token = "0x4003CFF")]
			SENT = 1,
			[Token(Token = "0x4003D00")]
			READ = 2,
			[Token(Token = "0x4003D01")]
			DELETED = 3
		}

		[Token(Token = "0x2000C7C")]
		public class Attachment
		{
			[Token(Token = "0x4003D02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDC24", Offset = "0x5BDC24")]
			public string ID;

			[Token(Token = "0x4003D03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDC5C", Offset = "0x5BDC5C")]
			public int Quantity;

			[Token(Token = "0x6004DE0")]
			[Address(RVA = "0x8C7A68", Offset = "0x8C7A68", VA = "0x8C7A68")]
			public Attachment()
			{
			}

			[Token(Token = "0x6004DE1")]
			[Address(RVA = "0x8C7ACC", Offset = "0x8C7ACC", VA = "0x8C7ACC")]
			public Attachment(string id, int quantity)
			{
			}
		}

		[Token(Token = "0x4003CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDBC4", Offset = "0x5BDBC4")]
		private ulong _003CID_003Ek__BackingField;

		[Token(Token = "0x4003CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDBD4", Offset = "0x5BDBD4")]
		private MessageState _003CState_003Ek__BackingField;

		[Token(Token = "0x4003CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDBE4", Offset = "0x5BDBE4")]
		private MessageHeader _003CHeader_003Ek__BackingField;

		[Token(Token = "0x4003CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDBF4", Offset = "0x5BDBF4")]
		private TargetUser _003CSender_003Ek__BackingField;

		[Token(Token = "0x4003CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDC04", Offset = "0x5BDC04")]
		private TargetUser _003CReceiver_003Ek__BackingField;

		[Token(Token = "0x4003CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDC14", Offset = "0x5BDC14")]
		private string _003CBody_003Ek__BackingField;

		[Token(Token = "0x4003CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Attachment> _attachments;

		[Token(Token = "0x4003CF5")]
		private const string MESSAGE_HEADER_KEY = "c_messageHeader";

		[Token(Token = "0x4003CF6")]
		private const string SENDER_KEY = "c_sender";

		[Token(Token = "0x4003CF7")]
		private const string RECEIVER_KEY = "c_receiver";

		[Token(Token = "0x4003CF8")]
		private const string MESSAGE_BODY_KEY = "s_messageBody";

		[Token(Token = "0x4003CF9")]
		private const string ATTACHMENTS_A_KEY = "a_attachments";

		[Token(Token = "0x4003CFA")]
		private const string ATTACHMENTS_C_KEY = "c_attachments";

		[Token(Token = "0x4003CFB")]
		private const string STATE_KEY = "s_messageState";

		[Token(Token = "0x4003CFC")]
		private const string MESSAGE_ID_KEY = "i64_messageId";

		[Token(Token = "0x170009E5")]
		public ulong ID
		{
			[Token(Token = "0x6004DC4")]
			[Address(RVA = "0x9C071C", Offset = "0x9C071C", VA = "0x9C071C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6288F0", Offset = "0x6288F0")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6004DC5")]
			[Address(RVA = "0x9C0724", Offset = "0x9C0724", VA = "0x9C0724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628900", Offset = "0x628900")]
			private set
			{
			}
		}

		[Token(Token = "0x170009E6")]
		public MessageState State
		{
			[Token(Token = "0x6004DC6")]
			[Address(RVA = "0x9C072C", Offset = "0x9C072C", VA = "0x9C072C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628910", Offset = "0x628910")]
			get
			{
				return default(MessageState);
			}
			[Token(Token = "0x6004DC7")]
			[Address(RVA = "0x9C0734", Offset = "0x9C0734", VA = "0x9C0734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628920", Offset = "0x628920")]
			private set
			{
			}
		}

		[Token(Token = "0x170009E7")]
		public bool IsRead
		{
			[Token(Token = "0x6004DC8")]
			[Address(RVA = "0x9C073C", Offset = "0x9C073C", VA = "0x9C073C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009E8")]
		public bool IsDeleted
		{
			[Token(Token = "0x6004DC9")]
			[Address(RVA = "0x9C074C", Offset = "0x9C074C", VA = "0x9C074C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009E9")]
		public MessageHeader Header
		{
			[Token(Token = "0x6004DCA")]
			[Address(RVA = "0x9C075C", Offset = "0x9C075C", VA = "0x9C075C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628930", Offset = "0x628930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DCB")]
			[Address(RVA = "0x9C0764", Offset = "0x9C0764", VA = "0x9C0764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628940", Offset = "0x628940")]
			set
			{
			}
		}

		[Token(Token = "0x170009EA")]
		public TargetUser Sender
		{
			[Token(Token = "0x6004DCC")]
			[Address(RVA = "0x9C076C", Offset = "0x9C076C", VA = "0x9C076C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628950", Offset = "0x628950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DCD")]
			[Address(RVA = "0x9C0774", Offset = "0x9C0774", VA = "0x9C0774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628960", Offset = "0x628960")]
			set
			{
			}
		}

		[Token(Token = "0x170009EB")]
		public TargetUser Receiver
		{
			[Token(Token = "0x6004DCE")]
			[Address(RVA = "0x9C077C", Offset = "0x9C077C", VA = "0x9C077C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628970", Offset = "0x628970")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DCF")]
			[Address(RVA = "0x9C0784", Offset = "0x9C0784", VA = "0x9C0784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628980", Offset = "0x628980")]
			set
			{
			}
		}

		[Token(Token = "0x170009EC")]
		public string Body
		{
			[Token(Token = "0x6004DD0")]
			[Address(RVA = "0x9C078C", Offset = "0x9C078C", VA = "0x9C078C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x628990", Offset = "0x628990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DD1")]
			[Address(RVA = "0x9C0794", Offset = "0x9C0794", VA = "0x9C0794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289A0", Offset = "0x6289A0")]
			set
			{
			}
		}

		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x9C079C", Offset = "0x9C079C", VA = "0x9C079C")]
		public Message(MessageHeader header, TargetUser sender, TargetUser receiver, string body)
		{
		}

		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x9C0844", Offset = "0x9C0844", VA = "0x9C0844")]
		public List<Attachment> OpenAttachments()
		{
			return null;
		}

		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x9C084C", Offset = "0x9C084C", VA = "0x9C084C")]
		public void AddAttachment(string id, int quantity = 1)
		{
		}

		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x9C08E8", Offset = "0x9C08E8", VA = "0x9C08E8")]
		public void AddAttachment(Attachment attachment)
		{
		}

		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x9C094C", Offset = "0x9C094C", VA = "0x9C094C")]
		public void MarkAsRead([Optional] Action action)
		{
		}

		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x9C0A64", Offset = "0x9C0A64", VA = "0x9C0A64")]
		public void MarkAsUnread([Optional] Action action)
		{
		}

		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x9C0B7C", Offset = "0x9C0B7C", VA = "0x9C0B7C")]
		public void Delete([Optional] Action action)
		{
		}

		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x9C0C8C", Offset = "0x9C0C8C", VA = "0x9C0C8C")]
		public void Restore([Optional] Action action)
		{
		}

		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x9C0D9C", Offset = "0x9C0D9C", VA = "0x9C0D9C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x9C102C", Offset = "0x9C102C", VA = "0x9C102C")]
		public static Message FromString(string json)
		{
			return null;
		}

		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x9C1600", Offset = "0x9C1600", VA = "0x9C1600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289B0", Offset = "0x6289B0")]
		private void _003CMarkAsRead_003Eb__42_0()
		{
		}

		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x9C160C", Offset = "0x9C160C", VA = "0x9C160C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289C0", Offset = "0x6289C0")]
		private void _003CMarkAsUnread_003Eb__43_0()
		{
		}

		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x9C1618", Offset = "0x9C1618", VA = "0x9C1618")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289D0", Offset = "0x6289D0")]
		private void _003CDelete_003Eb__44_0()
		{
		}

		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x9C1624", Offset = "0x9C1624", VA = "0x9C1624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6289E0", Offset = "0x6289E0")]
		private void _003CRestore_003Eb__45_0()
		{
		}
	}
}
