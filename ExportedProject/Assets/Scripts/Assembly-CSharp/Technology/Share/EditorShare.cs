using Il2CppDummyDll;

namespace Technology.Share
{
	[Token(Token = "0x2000B97")]
	public class EditorShare : IShare
	{
		[Token(Token = "0x4003A95")]
		[FieldOffset(Offset = "0x10")]
		private string _title;

		[Token(Token = "0x4003A96")]
		[FieldOffset(Offset = "0x18")]
		private string _description;

		[Token(Token = "0x4003A97")]
		[FieldOffset(Offset = "0x20")]
		private string _text;

		[Token(Token = "0x4003A98")]
		[FieldOffset(Offset = "0x28")]
		private string _url;

		[Token(Token = "0x4003A99")]
		[FieldOffset(Offset = "0x30")]
		private string _image;

		[Token(Token = "0x4003A9A")]
		[FieldOffset(Offset = "0x38")]
		private string _mimeType;

		[Token(Token = "0x60049A6")]
		[Address(RVA = "0xE0BE50", Offset = "0xE0BE50", VA = "0xE0BE50", Slot = "4")]
		public void SetTitle(string title)
		{
		}

		[Token(Token = "0x60049A7")]
		[Address(RVA = "0xE0BE58", Offset = "0xE0BE58", VA = "0xE0BE58", Slot = "5")]
		public void SetDescription(string description)
		{
		}

		[Token(Token = "0x60049A8")]
		[Address(RVA = "0xE0BE60", Offset = "0xE0BE60", VA = "0xE0BE60", Slot = "6")]
		public void SetText(string text)
		{
		}

		[Token(Token = "0x60049A9")]
		[Address(RVA = "0xE0BE68", Offset = "0xE0BE68", VA = "0xE0BE68", Slot = "7")]
		public void SetUrl(string url)
		{
		}

		[Token(Token = "0x60049AA")]
		[Address(RVA = "0xE0BE70", Offset = "0xE0BE70", VA = "0xE0BE70", Slot = "8")]
		public void SetImage(byte[] image, ShareImageFormat format)
		{
		}

		[Token(Token = "0x60049AB")]
		[Address(RVA = "0xE0BF68", Offset = "0xE0BF68", VA = "0xE0BF68", Slot = "9")]
		public void SetMimeType(string mimeType)
		{
		}

		[Token(Token = "0x60049AC")]
		[Address(RVA = "0xE0BF70", Offset = "0xE0BF70", VA = "0xE0BF70", Slot = "10")]
		public void Share()
		{
		}

		[Token(Token = "0x60049AD")]
		[Address(RVA = "0xE0BF74", Offset = "0xE0BF74", VA = "0xE0BF74")]
		public EditorShare()
		{
		}
	}
}
