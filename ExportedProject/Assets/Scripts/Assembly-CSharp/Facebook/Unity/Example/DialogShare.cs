using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012DF")]
	internal class DialogShare : MenuBase
	{
		[Token(Token = "0x4005A71")]
		[FieldOffset(Offset = "0x60")]
		private string shareLink;

		[Token(Token = "0x4005A72")]
		[FieldOffset(Offset = "0x68")]
		private string shareTitle;

		[Token(Token = "0x4005A73")]
		[FieldOffset(Offset = "0x70")]
		private string shareDescription;

		[Token(Token = "0x4005A74")]
		[FieldOffset(Offset = "0x78")]
		private string shareImage;

		[Token(Token = "0x4005A75")]
		[FieldOffset(Offset = "0x80")]
		private string feedTo;

		[Token(Token = "0x4005A76")]
		[FieldOffset(Offset = "0x88")]
		private string feedLink;

		[Token(Token = "0x4005A77")]
		[FieldOffset(Offset = "0x90")]
		private string feedTitle;

		[Token(Token = "0x4005A78")]
		[FieldOffset(Offset = "0x98")]
		private string feedCaption;

		[Token(Token = "0x4005A79")]
		[FieldOffset(Offset = "0xA0")]
		private string feedDescription;

		[Token(Token = "0x4005A7A")]
		[FieldOffset(Offset = "0xA8")]
		private string feedImage;

		[Token(Token = "0x4005A7B")]
		[FieldOffset(Offset = "0xB0")]
		private string feedMediaSource;

		[Token(Token = "0x6006E2F")]
		[Address(RVA = "0xC143D4", Offset = "0xC143D4", VA = "0xC143D4", Slot = "6")]
		protected override bool ShowDialogModeSelector()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E30")]
		[Address(RVA = "0xC143DC", Offset = "0xC143DC", VA = "0xC143DC", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x6006E31")]
		[Address(RVA = "0xC14C6C", Offset = "0xC14C6C", VA = "0xC14C6C")]
		public DialogShare()
		{
		}
	}
}
