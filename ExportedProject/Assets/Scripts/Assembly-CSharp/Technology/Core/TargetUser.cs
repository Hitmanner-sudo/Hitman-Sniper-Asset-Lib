using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C7E")]
	public class TargetUser
	{
		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BDDE4", Offset = "0x5BDDE4")]
		public string UserID;

		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BDE1C", Offset = "0x5BDE1C")]
		public string GameID;

		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "OSJsonKey", RVA = "0x5BDE54", Offset = "0x5BDE54")]
		public int MailboxID;

		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0xB544E4", Offset = "0xB544E4", VA = "0xB544E4")]
		public TargetUser()
		{
		}
	}
}
