using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB0")]
	public enum AvatarStatus
	{
		[Token(Token = "0x400416C")]
		NotStarted = 0,
		[Token(Token = "0x400416D")]
		Downloading = 1,
		[Token(Token = "0x400416E")]
		Complete = 2,
		[Token(Token = "0x400416F")]
		Failed = 3
	}
}
