using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C0B")]
	public struct ImageInfo
	{
		[Token(Token = "0x4003C0B")]
		[FieldOffset(Offset = "0x0")]
		public int Width;

		[Token(Token = "0x4003C0C")]
		[FieldOffset(Offset = "0x4")]
		public int Height;

		[Token(Token = "0x4003C0D")]
		[FieldOffset(Offset = "0x8")]
		public string LocalPath;

		[Token(Token = "0x4003C0E")]
		[FieldOffset(Offset = "0x10")]
		public string Link;

		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0xA16EA8", Offset = "0xA16EA8", VA = "0xA16EA8")]
		public void Init()
		{
		}

		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0xA16F0C", Offset = "0xA16F0C", VA = "0xA16F0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0xA16F78", Offset = "0xA16F78", VA = "0xA16F78", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0xA1702C", Offset = "0xA1702C", VA = "0xA1702C")]
		public static bool operator ==(ImageInfo a, ImageInfo b)
		{
			return default(bool);
		}

		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0xA17120", Offset = "0xA17120", VA = "0xA17120")]
		public static bool operator !=(ImageInfo a, ImageInfo b)
		{
			return default(bool);
		}
	}
}
