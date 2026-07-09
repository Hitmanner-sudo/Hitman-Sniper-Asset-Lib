using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E4E")]
	internal static class Schemas
	{
		[Token(Token = "0x40043B8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Schema HasValidInstall;

		[Token(Token = "0x40043B9")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Schema Receipt;

		[Token(Token = "0x40043BA")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Schema ReceiptFromRefresh;

		[Token(Token = "0x40043BB")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Schema OriginalPurchaseDate;

		[Token(Token = "0x40043BC")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Schema AssemblyHash;
	}
}
