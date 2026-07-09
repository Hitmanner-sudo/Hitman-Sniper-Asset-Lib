using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.GooglePlayGames.Auth;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D9A")]
	public class Authentication
	{
		[Serializable]
		[Token(Token = "0x2000D9B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598944", Offset = "0x598944")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40040D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40040D8")]
			[FieldOffset(Offset = "0x8")]
			public static EventHandler<AuthenticationEvent> _003C_003E9__34_0;

			[Token(Token = "0x40040D9")]
			[FieldOffset(Offset = "0x10")]
			public static EventHandler<AuthenticationEvent> _003C_003E9__35_0;

			[Token(Token = "0x40040DA")]
			[FieldOffset(Offset = "0x18")]
			public static EventHandler<AuthenticationEvent> _003C_003E9__35_1;

			[Token(Token = "0x40040DB")]
			[FieldOffset(Offset = "0x20")]
			public static EventHandler<AuthenticationEvent> _003C_003E9__35_2;

			[Token(Token = "0x40040DC")]
			[FieldOffset(Offset = "0x28")]
			public static EventHandler<AuthenticationEvent> _003C_003E9__35_3;

			[Token(Token = "0x60053C5")]
			[Address(RVA = "0x925B44", Offset = "0x925B44", VA = "0x925B44")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60053C6")]
			[Address(RVA = "0x925B4C", Offset = "0x925B4C", VA = "0x925B4C")]
			internal void _003CInitialize_003Eb__34_0(object sender, AuthenticationEvent @event)
			{
			}

			[Token(Token = "0x60053C7")]
			[Address(RVA = "0x925BC8", Offset = "0x925BC8", VA = "0x925BC8")]
			internal void _003CHookEvents_003Eb__35_0(object sender, AuthenticationEvent @event)
			{
			}

			[Token(Token = "0x60053C8")]
			[Address(RVA = "0x925C44", Offset = "0x925C44", VA = "0x925C44")]
			internal void _003CHookEvents_003Eb__35_1(object sender, AuthenticationEvent @event)
			{
			}

			[Token(Token = "0x60053C9")]
			[Address(RVA = "0x925CC0", Offset = "0x925CC0", VA = "0x925CC0")]
			internal void _003CHookEvents_003Eb__35_2(object sender, AuthenticationEvent @event)
			{
			}

			[Token(Token = "0x60053CA")]
			[Address(RVA = "0x925D3C", Offset = "0x925D3C", VA = "0x925D3C")]
			internal void _003CHookEvents_003Eb__35_3(object sender, AuthenticationEvent @event)
			{
			}
		}

		[Token(Token = "0x40040D3")]
		[FieldOffset(Offset = "0x8")]
		private static Authentication _instance;

		[Token(Token = "0x40040D4")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<AuthenticationType, AbstractAuthenticationContext> _authModules;

		[Token(Token = "0x40040D5")]
		[FieldOffset(Offset = "0x18")]
		private readonly AuthenticationContext _authenticationContext;

		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0x20")]
		private readonly SquareEnixContext _squareEnixContext;

		[Token(Token = "0x17000AF0")]
		public static Authentication Instance
		{
			[Token(Token = "0x60053AE")]
			[Address(RVA = "0xC0AC78", Offset = "0xC0AC78", VA = "0xC0AC78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF1")]
		public bool IsInitialized
		{
			[Token(Token = "0x60053AF")]
			[Address(RVA = "0xC0AFD8", Offset = "0xC0AFD8", VA = "0xC0AFD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000AF2")]
		public AuthenticationContext Context
		{
			[Token(Token = "0x60053B0")]
			[Address(RVA = "0xC0AFF4", Offset = "0xC0AFF4", VA = "0xC0AFF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF3")]
		public SquareEnixContext SquareEnixContext
		{
			[Token(Token = "0x60053B1")]
			[Address(RVA = "0xC0AFFC", Offset = "0xC0AFFC", VA = "0xC0AFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF4")]
		public FacebookContext FacebookContext
		{
			[Token(Token = "0x60053B2")]
			[Address(RVA = "0xC0B004", Offset = "0xC0B004", VA = "0xC0B004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF5")]
		public GameCenterContext GameCenterContext
		{
			[Token(Token = "0x60053B3")]
			[Address(RVA = "0xC0B054", Offset = "0xC0B054", VA = "0xC0B054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF6")]
		public GooglePlayGamesContext GooglePlayGamesContext
		{
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0xC0B0A4", Offset = "0xC0B0A4", VA = "0xC0B0A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400015E")]
		public static event EventHandler<AuthenticationEvent> OnStateChange
		{
			[Token(Token = "0x60053AC")]
			[Address(RVA = "0xC0AB00", Offset = "0xC0AB00", VA = "0xC0AB00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A290", Offset = "0x62A290")]
			add
			{
			}
			[Token(Token = "0x60053AD")]
			[Address(RVA = "0xC0ABBC", Offset = "0xC0ABBC", VA = "0xC0ABBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A2A0", Offset = "0x62A2A0")]
			remove
			{
			}
		}

		[Token(Token = "0x60053B5")]
		private T TryGetContext<T>(AuthenticationType type) where T : AbstractAuthenticationContext
		{
			return null;
		}

		[Token(Token = "0x60053B6")]
		[Address(RVA = "0xC0B0F4", Offset = "0xC0B0F4", VA = "0xC0B0F4")]
		public static Authentication ForceResolve()
		{
			return null;
		}

		[Token(Token = "0x60053B7")]
		[Address(RVA = "0xC0B0F8", Offset = "0xC0B0F8", VA = "0xC0B0F8")]
		public void Login(AuthenticationType type)
		{
		}

		[Token(Token = "0x60053B8")]
		[Address(RVA = "0xC0B1A8", Offset = "0xC0B1A8", VA = "0xC0B1A8")]
		public void Logout(AuthenticationType type)
		{
		}

		[Token(Token = "0x60053B9")]
		[Address(RVA = "0xC0B258", Offset = "0xC0B258", VA = "0xC0B258")]
		public void Connect(AuthenticationType type)
		{
		}

		[Token(Token = "0x60053BA")]
		[Address(RVA = "0xC0B308", Offset = "0xC0B308", VA = "0xC0B308")]
		public bool IsConnecting(AuthenticationType type)
		{
			return default(bool);
		}

		[Token(Token = "0x60053BB")]
		[Address(RVA = "0xC0B3E4", Offset = "0xC0B3E4", VA = "0xC0B3E4")]
		public void MigrateData(AuthenticationType type)
		{
		}

		[Token(Token = "0x60053BC")]
		[Address(RVA = "0xC0B494", Offset = "0xC0B494", VA = "0xC0B494")]
		public void Disconnect(AuthenticationType type)
		{
		}

		[Token(Token = "0x60053BD")]
		[Address(RVA = "0xC0B544", Offset = "0xC0B544", VA = "0xC0B544")]
		public void SetAccountForMigrate(string passphrase)
		{
		}

		[Token(Token = "0x60053BE")]
		[Address(RVA = "0xC0B560", Offset = "0xC0B560", VA = "0xC0B560")]
		public void GetMigrationData(string passphrase, string uid)
		{
		}

		[Token(Token = "0x60053BF")]
		[Address(RVA = "0xC0B57C", Offset = "0xC0B57C", VA = "0xC0B57C")]
		public void GetMigrationData(string uid)
		{
		}

		[Token(Token = "0x60053C0")]
		[Address(RVA = "0xC0B6D8", Offset = "0xC0B6D8", VA = "0xC0B6D8")]
		internal void RegisterModule(Type authType)
		{
		}

		[Token(Token = "0x60053C1")]
		[Address(RVA = "0xC0AD04", Offset = "0xC0AD04", VA = "0xC0AD04")]
		private Authentication()
		{
		}

		[Token(Token = "0x60053C2")]
		[Address(RVA = "0xC0AE5C", Offset = "0xC0AE5C", VA = "0xC0AE5C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60053C3")]
		[Address(RVA = "0xC0B968", Offset = "0xC0B968", VA = "0xC0B968")]
		private static void HookEvents(AbstractAuthenticationContext authContext)
		{
		}
	}
}
