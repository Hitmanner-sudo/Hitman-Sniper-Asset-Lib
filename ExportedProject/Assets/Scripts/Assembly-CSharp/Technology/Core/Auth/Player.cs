using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DBA")]
	public class Player
	{
		[Token(Token = "0x40041A3")]
		[FieldOffset(Offset = "0x10")]
		public SquareEnixPersonalRecord SquareEnix;

		[Token(Token = "0x40041A4")]
		[FieldOffset(Offset = "0x18")]
		public GameCenterPersonalRecord GameCenter;

		[Token(Token = "0x40041A5")]
		[FieldOffset(Offset = "0x20")]
		public PlayGameServicesPersonalRecord PlayGameServices;

		[Token(Token = "0x40041A6")]
		[FieldOffset(Offset = "0x28")]
		public FacebookPersonalRecord Facebook;

		[Token(Token = "0x17000B34")]
		public string Username
		{
			[Token(Token = "0x60054A7")]
			[Address(RVA = "0xB82910", Offset = "0xB82910", VA = "0xB82910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B35")]
		public string Id
		{
			[Token(Token = "0x60054A8")]
			[Address(RVA = "0xB8292C", Offset = "0xB8292C", VA = "0xB8292C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60054A9")]
			[Address(RVA = "0xB82948", Offset = "0xB82948", VA = "0xB82948")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000B36")]
		public string Uuid
		{
			[Token(Token = "0x60054AA")]
			[Address(RVA = "0xB82964", Offset = "0xB82964", VA = "0xB82964")]
			get
			{
				return null;
			}
			[Token(Token = "0x60054AB")]
			[Address(RVA = "0xB82980", Offset = "0xB82980", VA = "0xB82980")]
			internal set
			{
			}
		}

		[Token(Token = "0x60054A6")]
		[Address(RVA = "0xB82824", Offset = "0xB82824", VA = "0xB82824")]
		public Player()
		{
		}
	}
}
