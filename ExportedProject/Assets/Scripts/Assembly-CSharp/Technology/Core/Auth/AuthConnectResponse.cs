using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DCF")]
	public class AuthConnectResponse
	{
		[Token(Token = "0x40041D4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BF3DC", Offset = "0x5BF3DC")]
		public string Message;

		[Token(Token = "0x40041D5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BF414", Offset = "0x5BF414")]
		public int ErrorCode;

		[Token(Token = "0x60054F0")]
		[Address(RVA = "0xC0AAE0", Offset = "0xC0AAE0", VA = "0xC0AAE0")]
		public AuthConnectResponse()
		{
		}
	}
}
