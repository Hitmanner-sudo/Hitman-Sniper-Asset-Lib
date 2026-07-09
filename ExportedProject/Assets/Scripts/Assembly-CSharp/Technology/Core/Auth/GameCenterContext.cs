using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DAA")]
	public class GameCenterContext : AbstractAuthenticationContext
	{
		[Token(Token = "0x17000B07")]
		public override bool IsLoggedIn
		{
			[Token(Token = "0x6005433")]
			[Address(RVA = "0xD935C8", Offset = "0xD935C8", VA = "0xD935C8", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005434")]
			[Address(RVA = "0xD935F8", Offset = "0xD935F8", VA = "0xD935F8", Slot = "6")]
			protected set
			{
			}
		}

		[Token(Token = "0x14000167")]
		public static event EventHandler<AuthenticationEvent> OnImageLoadFailure
		{
			[Token(Token = "0x600542D")]
			[Address(RVA = "0xD92FE0", Offset = "0xD92FE0", VA = "0xD92FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A520", Offset = "0x62A520")]
			add
			{
			}
			[Token(Token = "0x600542E")]
			[Address(RVA = "0xD9309C", Offset = "0xD9309C", VA = "0xD9309C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A530", Offset = "0x62A530")]
			remove
			{
			}
		}

		[Token(Token = "0x14000168")]
		public static event EventHandler<AuthenticationEvent> OnImageLoadSuccess
		{
			[Token(Token = "0x600542F")]
			[Address(RVA = "0xD93158", Offset = "0xD93158", VA = "0xD93158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A540", Offset = "0x62A540")]
			add
			{
			}
			[Token(Token = "0x6005430")]
			[Address(RVA = "0xD93218", Offset = "0xD93218", VA = "0xD93218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A550", Offset = "0x62A550")]
			remove
			{
			}
		}

		[Token(Token = "0x6005431")]
		[Address(RVA = "0xD932D8", Offset = "0xD932D8", VA = "0xD932D8")]
		public GameCenterContext(AuthenticationContext context)
		{
		}

		[Token(Token = "0x6005432")]
		[Address(RVA = "0xD9339C", Offset = "0xD9339C", VA = "0xD9339C", Slot = "4")]
		protected override IAuthenticationState[] InitializeStates()
		{
			return null;
		}

		[Token(Token = "0x6005435")]
		[Address(RVA = "0xD9362C", Offset = "0xD9362C", VA = "0xD9362C", Slot = "9")]
		internal override void Login()
		{
		}

		[Token(Token = "0x6005436")]
		[Address(RVA = "0xD9385C", Offset = "0xD9385C", VA = "0xD9385C")]
		protected void RaiseOnImageLoadFailure(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x6005437")]
		[Address(RVA = "0xD938D8", Offset = "0xD938D8", VA = "0xD938D8")]
		protected void RaiseOnImageLoadSuccess(AuthenticationEvent authenticationEvent)
		{
		}

		[Token(Token = "0x6005438")]
		[Address(RVA = "0xD93954", Offset = "0xD93954", VA = "0xD93954", Slot = "7")]
		public override void MigrateData()
		{
		}

		[Token(Token = "0x6005439")]
		[Address(RVA = "0xD93958", Offset = "0xD93958", VA = "0xD93958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A560", Offset = "0x62A560")]
		private void _003CLogin_003Eb__11_0(object result)
		{
		}
	}
}
