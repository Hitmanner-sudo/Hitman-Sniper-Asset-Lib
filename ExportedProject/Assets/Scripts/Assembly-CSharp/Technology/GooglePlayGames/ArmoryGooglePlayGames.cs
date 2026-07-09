using System;
using Il2CppDummyDll;
using Technology.Core.Auth;
using Technology.Core.Common;

namespace Technology.GooglePlayGames
{
	[Token(Token = "0x2000BA1")]
	[RegisterForInitialize]
	public static class ArmoryGooglePlayGames
	{
		[Token(Token = "0x4003ABA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GooglePlayGamesController _controller;

		[Token(Token = "0x17000953")]
		public static PlayGameServicesPersonalRecord PersonalRecord
		{
			[Token(Token = "0x60049F2")]
			[Address(RVA = "0xD4ECE0", Offset = "0xD4ECE0", VA = "0xD4ECE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000954")]
		public static bool IsLoggedIn
		{
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0xD4ED50", Offset = "0xD4ED50", VA = "0xD4ED50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000114")]
		public static event EventHandler<AuthenticationEvent> OnLogin
		{
			[Token(Token = "0x60049EA")]
			[Address(RVA = "0xD4E8C0", Offset = "0xD4E8C0", VA = "0xD4E8C0")]
			add
			{
			}
			[Token(Token = "0x60049EB")]
			[Address(RVA = "0xD4E944", Offset = "0xD4E944", VA = "0xD4E944")]
			remove
			{
			}
		}

		[Token(Token = "0x14000115")]
		public static event EventHandler<AuthenticationEvent> OnLogout
		{
			[Token(Token = "0x60049EC")]
			[Address(RVA = "0xD4E9C8", Offset = "0xD4E9C8", VA = "0xD4E9C8")]
			add
			{
			}
			[Token(Token = "0x60049ED")]
			[Address(RVA = "0xD4EA4C", Offset = "0xD4EA4C", VA = "0xD4EA4C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000116")]
		public static event EventHandler<AuthenticationEvent> OnConnect
		{
			[Token(Token = "0x60049EE")]
			[Address(RVA = "0xD4EAD0", Offset = "0xD4EAD0", VA = "0xD4EAD0")]
			add
			{
			}
			[Token(Token = "0x60049EF")]
			[Address(RVA = "0xD4EB54", Offset = "0xD4EB54", VA = "0xD4EB54")]
			remove
			{
			}
		}

		[Token(Token = "0x14000117")]
		public static event EventHandler<AuthenticationEvent> OnDisconnect
		{
			[Token(Token = "0x60049F0")]
			[Address(RVA = "0xD4EBD8", Offset = "0xD4EBD8", VA = "0xD4EBD8")]
			add
			{
			}
			[Token(Token = "0x60049F1")]
			[Address(RVA = "0xD4EC5C", Offset = "0xD4EC5C", VA = "0xD4EC5C")]
			remove
			{
			}
		}

		[Token(Token = "0x60049F4")]
		[Address(RVA = "0xD4EDC0", Offset = "0xD4EDC0", VA = "0xD4EDC0")]
		static ArmoryGooglePlayGames()
		{
		}

		[Token(Token = "0x60049F5")]
		[Address(RVA = "0xD4EE88", Offset = "0xD4EE88", VA = "0xD4EE88")]
		public static void Login()
		{
		}

		[Token(Token = "0x60049F6")]
		[Address(RVA = "0xD4EEF8", Offset = "0xD4EEF8", VA = "0xD4EEF8")]
		public static void Logout()
		{
		}

		[Token(Token = "0x60049F7")]
		[Address(RVA = "0xD4EF68", Offset = "0xD4EF68", VA = "0xD4EF68")]
		public static void Disconnect()
		{
		}
	}
}
