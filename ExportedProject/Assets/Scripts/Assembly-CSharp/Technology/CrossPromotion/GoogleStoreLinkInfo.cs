using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C21")]
	public class GoogleStoreLinkInfo : StoreLinkInfo
	{
		[Token(Token = "0x4003C60")]
		[FieldOffset(Offset = "0x28")]
		public string Package;

		[Token(Token = "0x4003C61")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string PACKAGE_REF;

		[Token(Token = "0x4003C62")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string BASE_LEFT;

		[Token(Token = "0x4003C63")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string BASE_MIDDLE;

		[Token(Token = "0x6004C94")]
		[Address(RVA = "0xC88F40", Offset = "0xC88F40", VA = "0xC88F40")]
		public GoogleStoreLinkInfo()
		{
		}

		[Token(Token = "0x6004C95")]
		[Address(RVA = "0xC89150", Offset = "0xC89150", VA = "0xC89150", Slot = "4")]
		public override string Get()
		{
			return null;
		}

		[Token(Token = "0x6004C96")]
		[Address(RVA = "0xC8928C", Offset = "0xC8928C", VA = "0xC8928C", Slot = "5")]
		public override bool Set(string link)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C97")]
		[Address(RVA = "0xC894E0", Offset = "0xC894E0", VA = "0xC894E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004C98")]
		[Address(RVA = "0xC89538", Offset = "0xC89538", VA = "0xC89538", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C99")]
		[Address(RVA = "0xC895EC", Offset = "0xC895EC", VA = "0xC895EC")]
		public static bool operator ==(GoogleStoreLinkInfo a, GoogleStoreLinkInfo b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0xC89658", Offset = "0xC89658", VA = "0xC89658")]
		public static bool operator !=(GoogleStoreLinkInfo a, GoogleStoreLinkInfo b)
		{
			return default(bool);
		}
	}
}
