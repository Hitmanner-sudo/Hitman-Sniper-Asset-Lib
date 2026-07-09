using System;
using Il2CppDummyDll;
using Technology.Core;
using Technology.Core.Auth;
using Technology.Core.GooglePlayGames;
using Technology.GooglePlayGames.Auth;

namespace Technology.GooglePlayGames
{
	[Token(Token = "0x2000BA3")]
	internal class GooglePlayGamesController : IGooglePlayGamesProvider, IArmoryProvider
	{
		[Serializable]
		[Token(Token = "0x2000BA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598344", Offset = "0x598344")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003AC0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003AC1")]
			[FieldOffset(Offset = "0x8")]
			public static EventHandler _003C_003E9__13_0;

			[Token(Token = "0x6004A06")]
			[Address(RVA = "0x876EF8", Offset = "0x876EF8", VA = "0x876EF8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A07")]
			[Address(RVA = "0x876F00", Offset = "0x876F00", VA = "0x876F00")]
			internal void _003CRegisterComponents_003Eb__13_0(object sender, EventArgs evt)
			{
			}
		}

		[Token(Token = "0x17000955")]
		public GooglePlayGamesContext Context
		{
			[Token(Token = "0x60049FD")]
			[Address(RVA = "0xC865B4", Offset = "0xC865B4", VA = "0xC865B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000956")]
		public PlayGameServicesPersonalRecord Record
		{
			[Token(Token = "0x60049FE")]
			[Address(RVA = "0xC86668", Offset = "0xC86668", VA = "0xC86668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000957")]
		public bool IsLoggedIn
		{
			[Token(Token = "0x60049FF")]
			[Address(RVA = "0xC8669C", Offset = "0xC8669C", VA = "0xC8669C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000118")]
		public event EventHandler<AuthenticationEvent> OnLogin
		{
			[Token(Token = "0x60049F9")]
			[Address(RVA = "0xC86584", Offset = "0xC86584", VA = "0xC86584")]
			add
			{
			}
			[Token(Token = "0x60049FA")]
			[Address(RVA = "0xC865D8", Offset = "0xC865D8", VA = "0xC865D8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000119")]
		public event EventHandler<AuthenticationEvent> OnLogout
		{
			[Token(Token = "0x60049FB")]
			[Address(RVA = "0xC86608", Offset = "0xC86608", VA = "0xC86608")]
			add
			{
			}
			[Token(Token = "0x60049FC")]
			[Address(RVA = "0xC86638", Offset = "0xC86638", VA = "0xC86638")]
			remove
			{
			}
		}

		[Token(Token = "0x6004A00")]
		[Address(RVA = "0xC866BC", Offset = "0xC866BC", VA = "0xC866BC")]
		public GooglePlayGamesController()
		{
		}

		[Token(Token = "0x6004A01")]
		[Address(RVA = "0xC86728", Offset = "0xC86728", VA = "0xC86728")]
		private static void RegisterComponents()
		{
		}

		[Token(Token = "0x6004A02")]
		[Address(RVA = "0xC86858", Offset = "0xC86858", VA = "0xC86858")]
		public void Login()
		{
		}

		[Token(Token = "0x6004A03")]
		[Address(RVA = "0xC8687C", Offset = "0xC8687C", VA = "0xC8687C")]
		public void Logout()
		{
		}

		[Token(Token = "0x6004A04")]
		[Address(RVA = "0xC868A0", Offset = "0xC868A0", VA = "0xC868A0")]
		public void Disconnect()
		{
		}
	}
}
