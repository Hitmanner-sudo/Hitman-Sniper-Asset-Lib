using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C20")]
	public class AppleStoreLinkInfo : StoreLinkInfo
	{
		[Token(Token = "0x4003C59")]
		[FieldOffset(Offset = "0x28")]
		public string UserCountryCode;

		[Token(Token = "0x4003C5A")]
		[FieldOffset(Offset = "0x30")]
		public string ID;

		[Token(Token = "0x4003C5B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string COUNTRY_REF;

		[Token(Token = "0x4003C5C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string ID_REF;

		[Token(Token = "0x4003C5D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string BASE_LEFT;

		[Token(Token = "0x4003C5E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string BASE_MIDDLE;

		[Token(Token = "0x4003C5F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string BASE_RIGHT;

		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0xD4B260", Offset = "0xD4B260", VA = "0xD4B260")]
		public AppleStoreLinkInfo()
		{
		}

		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0xD4B4F4", Offset = "0xD4B4F4", VA = "0xD4B4F4", Slot = "4")]
		public override string Get()
		{
			return null;
		}

		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0xD4B64C", Offset = "0xD4B64C", VA = "0xD4B64C", Slot = "5")]
		public override bool Set(string link)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0xD4B92C", Offset = "0xD4B92C", VA = "0xD4B92C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004C90")]
		[Address(RVA = "0xD4B9A4", Offset = "0xD4B9A4", VA = "0xD4B9A4", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C91")]
		[Address(RVA = "0xD4BA58", Offset = "0xD4BA58", VA = "0xD4BA58")]
		public static bool operator ==(AppleStoreLinkInfo a, AppleStoreLinkInfo b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C92")]
		[Address(RVA = "0xD4BAD8", Offset = "0xD4BAD8", VA = "0xD4BAD8")]
		public static bool operator !=(AppleStoreLinkInfo a, AppleStoreLinkInfo b)
		{
			return default(bool);
		}
	}
}
