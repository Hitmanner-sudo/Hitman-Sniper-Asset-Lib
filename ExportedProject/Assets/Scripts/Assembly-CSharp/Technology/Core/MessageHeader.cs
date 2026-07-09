using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C7D")]
	public class MessageHeader
	{
		[Token(Token = "0x4003D04")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDC94", Offset = "0x5BDC94")]
		public string To;

		[Token(Token = "0x4003D05")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDCCC", Offset = "0x5BDCCC")]
		public string From;

		[Token(Token = "0x4003D06")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDD04", Offset = "0x5BDD04")]
		public string Subject;

		[Token(Token = "0x4003D07")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDD3C", Offset = "0x5BDD3C")]
		public string ContentType;

		[Token(Token = "0x4003D08")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDD74", Offset = "0x5BDD74")]
		private string _sentDate;

		[Token(Token = "0x4003D09")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "OSJsonKey", RVA = "0x5BDDAC", Offset = "0x5BDDAC")]
		private string _expiryDate;

		[Token(Token = "0x170009ED")]
		public DateTime SentDate
		{
			[Token(Token = "0x6004DE2")]
			[Address(RVA = "0x9C1630", Offset = "0x9C1630", VA = "0x9C1630")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004DE3")]
			[Address(RVA = "0x9C163C", Offset = "0x9C163C", VA = "0x9C163C")]
			set
			{
			}
		}

		[Token(Token = "0x170009EE")]
		public DateTime ExpiryDate
		{
			[Token(Token = "0x6004DE4")]
			[Address(RVA = "0x9C1668", Offset = "0x9C1668", VA = "0x9C1668")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004DE5")]
			[Address(RVA = "0x9C1674", Offset = "0x9C1674", VA = "0x9C1674")]
			set
			{
			}
		}

		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x9C16A0", Offset = "0x9C16A0", VA = "0x9C16A0")]
		public MessageHeader()
		{
		}
	}
}
