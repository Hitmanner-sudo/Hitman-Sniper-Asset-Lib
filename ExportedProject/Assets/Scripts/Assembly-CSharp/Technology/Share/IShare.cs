using Il2CppDummyDll;

namespace Technology.Share
{
	[Token(Token = "0x2000B98")]
	public interface IShare
	{
		[Token(Token = "0x60049AE")]
		void SetTitle(string title);

		[Token(Token = "0x60049AF")]
		void SetDescription(string description);

		[Token(Token = "0x60049B0")]
		void SetText(string text);

		[Token(Token = "0x60049B1")]
		void SetUrl(string url);

		[Token(Token = "0x60049B2")]
		void SetImage(byte[] image, ShareImageFormat format);

		[Token(Token = "0x60049B3")]
		void SetMimeType(string mimeType);

		[Token(Token = "0x60049B4")]
		void Share();
	}
}
