using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D9D")]
	public class AuthenticationContext
	{
		[Token(Token = "0x40040E1")]
		[FieldOffset(Offset = "0x10")]
		private readonly Player _player;

		[Token(Token = "0x40040E2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE774", Offset = "0x5BE774")]
		private bool _003CIsInitialized_003Ek__BackingField;

		[Token(Token = "0x40040E3")]
		[FieldOffset(Offset = "0x20")]
		public AuthenticationConfiguration Configuration;

		[Token(Token = "0x17000AF7")]
		public Player Player
		{
			[Token(Token = "0x60053CC")]
			[Address(RVA = "0xC0BD34", Offset = "0xC0BD34", VA = "0xC0BD34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF8")]
		public bool IsInitialized
		{
			[Token(Token = "0x60053CD")]
			[Address(RVA = "0xC0BD3C", Offset = "0xC0BD3C", VA = "0xC0BD3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2B0", Offset = "0x62A2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60053CE")]
			[Address(RVA = "0xC0BD44", Offset = "0xC0BD44", VA = "0xC0BD44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2C0", Offset = "0x62A2C0")]
			internal set
			{
			}
		}

		[Token(Token = "0x60053CF")]
		[Address(RVA = "0xC0BC60", Offset = "0xC0BC60", VA = "0xC0BC60")]
		internal AuthenticationContext(AuthenticationConfiguration configuration)
		{
		}
	}
}
