using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009ED")]
	public struct PlayGamesClientConfiguration
	{
		[Token(Token = "0x20009EE")]
		public class Builder
		{
			[Token(Token = "0x400349E")]
			[FieldOffset(Offset = "0x10")]
			private bool mEnableSaveGames;

			[Token(Token = "0x400349F")]
			[FieldOffset(Offset = "0x18")]
			private List<string> mScopes;

			[Token(Token = "0x40034A0")]
			[FieldOffset(Offset = "0x20")]
			private bool mHidePopups;

			[Token(Token = "0x40034A1")]
			[FieldOffset(Offset = "0x21")]
			private bool mRequestAuthCode;

			[Token(Token = "0x40034A2")]
			[FieldOffset(Offset = "0x22")]
			private bool mForceRefresh;

			[Token(Token = "0x40034A3")]
			[FieldOffset(Offset = "0x23")]
			private bool mRequestEmail;

			[Token(Token = "0x40034A4")]
			[FieldOffset(Offset = "0x24")]
			private bool mRequestIdToken;

			[Token(Token = "0x40034A5")]
			[FieldOffset(Offset = "0x28")]
			private string mAccountName;

			[Token(Token = "0x6003EFD")]
			[Address(RVA = "0x8D13E4", Offset = "0x8D13E4", VA = "0x8D13E4")]
			public Builder EnableSavedGames()
			{
				return null;
			}

			[Token(Token = "0x6003EFE")]
			[Address(RVA = "0x8D13F0", Offset = "0x8D13F0", VA = "0x8D13F0")]
			public Builder EnableHidePopups()
			{
				return null;
			}

			[Token(Token = "0x6003EFF")]
			[Address(RVA = "0x8D13FC", Offset = "0x8D13FC", VA = "0x8D13FC")]
			public Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			[Token(Token = "0x6003F00")]
			[Address(RVA = "0x8D1410", Offset = "0x8D1410", VA = "0x8D1410")]
			public Builder RequestEmail()
			{
				return null;
			}

			[Token(Token = "0x6003F01")]
			[Address(RVA = "0x8D141C", Offset = "0x8D141C", VA = "0x8D141C")]
			public Builder RequestIdToken()
			{
				return null;
			}

			[Token(Token = "0x6003F02")]
			[Address(RVA = "0x8D1428", Offset = "0x8D1428", VA = "0x8D1428")]
			public Builder SetAccountName(string accountName)
			{
				return null;
			}

			[Token(Token = "0x6003F03")]
			[Address(RVA = "0x8D1430", Offset = "0x8D1430", VA = "0x8D1430")]
			public Builder AddOauthScope(string scope)
			{
				return null;
			}

			[Token(Token = "0x6003F04")]
			[Address(RVA = "0x8D14E4", Offset = "0x8D14E4", VA = "0x8D14E4")]
			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			[Token(Token = "0x6003F05")]
			[Address(RVA = "0x8D14FC", Offset = "0x8D14FC", VA = "0x8D14FC")]
			internal bool HasEnableSaveGames()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F06")]
			[Address(RVA = "0x8D1504", Offset = "0x8D1504", VA = "0x8D1504")]
			internal bool IsRequestingAuthCode()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F07")]
			[Address(RVA = "0x8D150C", Offset = "0x8D150C", VA = "0x8D150C")]
			internal bool IsHidingPopups()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F08")]
			[Address(RVA = "0x8D1514", Offset = "0x8D1514", VA = "0x8D1514")]
			internal bool IsForcingRefresh()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F09")]
			[Address(RVA = "0x8D151C", Offset = "0x8D151C", VA = "0x8D151C")]
			internal bool IsRequestingEmail()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F0A")]
			[Address(RVA = "0x8D1524", Offset = "0x8D1524", VA = "0x8D1524")]
			internal bool IsRequestingIdToken()
			{
				return default(bool);
			}

			[Token(Token = "0x6003F0B")]
			[Address(RVA = "0x8D152C", Offset = "0x8D152C", VA = "0x8D152C")]
			internal string GetAccountName()
			{
				return null;
			}

			[Token(Token = "0x6003F0C")]
			[Address(RVA = "0x8D1534", Offset = "0x8D1534", VA = "0x8D1534")]
			internal string[] getScopes()
			{
				return null;
			}

			[Token(Token = "0x6003F0D")]
			[Address(RVA = "0x8D15AC", Offset = "0x8D15AC", VA = "0x8D15AC")]
			public Builder()
			{
			}
		}

		[Token(Token = "0x4003495")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		[Token(Token = "0x4003496")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mEnableSavedGames;

		[Token(Token = "0x4003497")]
		[FieldOffset(Offset = "0x8")]
		private readonly string[] mScopes;

		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool mRequestAuthCode;

		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x11")]
		private readonly bool mForceRefresh;

		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x12")]
		private readonly bool mHidePopups;

		[Token(Token = "0x400349B")]
		[FieldOffset(Offset = "0x13")]
		private readonly bool mRequestEmail;

		[Token(Token = "0x400349C")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool mRequestIdToken;

		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x18")]
		private readonly string mAccountName;

		[Token(Token = "0x170007C9")]
		public bool EnableSavedGames
		{
			[Token(Token = "0x6003EF0")]
			[Address(RVA = "0xB75688", Offset = "0xB75688", VA = "0xB75688")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CA")]
		public bool IsHidingPopups
		{
			[Token(Token = "0x6003EF1")]
			[Address(RVA = "0xB75690", Offset = "0xB75690", VA = "0xB75690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CB")]
		public bool IsRequestingAuthCode
		{
			[Token(Token = "0x6003EF2")]
			[Address(RVA = "0xB75698", Offset = "0xB75698", VA = "0xB75698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CC")]
		public bool IsForcingRefresh
		{
			[Token(Token = "0x6003EF3")]
			[Address(RVA = "0xB756A0", Offset = "0xB756A0", VA = "0xB756A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CD")]
		public bool IsRequestingEmail
		{
			[Token(Token = "0x6003EF4")]
			[Address(RVA = "0xB756A8", Offset = "0xB756A8", VA = "0xB756A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CE")]
		public bool IsRequestingIdToken
		{
			[Token(Token = "0x6003EF5")]
			[Address(RVA = "0xB756B0", Offset = "0xB756B0", VA = "0xB756B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007CF")]
		public string AccountName
		{
			[Token(Token = "0x6003EF6")]
			[Address(RVA = "0xB756B8", Offset = "0xB756B8", VA = "0xB756B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D0")]
		public string[] Scopes
		{
			[Token(Token = "0x6003EF7")]
			[Address(RVA = "0xB756C0", Offset = "0xB756C0", VA = "0xB756C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0xB75618", Offset = "0xB75618", VA = "0xB75618")]
		private PlayGamesClientConfiguration(Builder builder)
		{
		}

		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0xB756C8", Offset = "0xB756C8", VA = "0xB756C8")]
		public static bool operator ==(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return default(bool);
		}

		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0xB757EC", Offset = "0xB757EC", VA = "0xB757EC")]
		public static bool operator !=(PlayGamesClientConfiguration c1, PlayGamesClientConfiguration c2)
		{
			return default(bool);
		}

		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0xB75890", Offset = "0xB75890", VA = "0xB75890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0xB759C8", Offset = "0xB759C8", VA = "0xB759C8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
