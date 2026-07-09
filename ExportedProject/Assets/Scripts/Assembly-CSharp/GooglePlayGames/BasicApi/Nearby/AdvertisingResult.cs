using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A05")]
	public struct AdvertisingResult
	{
		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0x0")]
		private readonly ResponseStatus mStatus;

		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mLocalEndpointName;

		[Token(Token = "0x170007F5")]
		public bool Succeeded
		{
			[Token(Token = "0x6003F6B")]
			[Address(RVA = "0xD5E008", Offset = "0xD5E008", VA = "0xD5E008")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007F6")]
		public ResponseStatus Status
		{
			[Token(Token = "0x6003F6C")]
			[Address(RVA = "0xD5E018", Offset = "0xD5E018", VA = "0xD5E018")]
			get
			{
				return default(ResponseStatus);
			}
		}

		[Token(Token = "0x170007F7")]
		public string LocalEndpointName
		{
			[Token(Token = "0x6003F6D")]
			[Address(RVA = "0xD5E020", Offset = "0xD5E020", VA = "0xD5E020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0xD5DFA0", Offset = "0xD5DFA0", VA = "0xD5DFA0")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}
	}
}
