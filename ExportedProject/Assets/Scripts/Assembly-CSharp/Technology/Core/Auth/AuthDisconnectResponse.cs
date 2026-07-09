using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DD0")]
	public class AuthDisconnectResponse
	{
		[Token(Token = "0x40041D6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BF44C", Offset = "0x5BF44C")]
		public int ErrorCode;

		[Token(Token = "0x60054F1")]
		[Address(RVA = "0xC0AAF0", Offset = "0xC0AAF0", VA = "0xC0AAF0")]
		public AuthDisconnectResponse()
		{
		}
	}
}
