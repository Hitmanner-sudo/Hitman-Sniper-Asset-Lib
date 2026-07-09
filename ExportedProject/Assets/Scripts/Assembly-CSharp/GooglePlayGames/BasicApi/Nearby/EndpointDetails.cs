using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A0A")]
	public struct EndpointDetails
	{
		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x0")]
		private readonly string mEndpointId;

		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mName;

		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x10")]
		private readonly string mServiceId;

		[Token(Token = "0x170007FE")]
		public string EndpointId
		{
			[Token(Token = "0x6003F90")]
			[Address(RVA = "0xE12E24", Offset = "0xE12E24", VA = "0xE12E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FF")]
		public string Name
		{
			[Token(Token = "0x6003F91")]
			[Address(RVA = "0xE12E2C", Offset = "0xE12E2C", VA = "0xE12E2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000800")]
		public string ServiceId
		{
			[Token(Token = "0x6003F92")]
			[Address(RVA = "0xE12E34", Offset = "0xE12E34", VA = "0xE12E34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0xE12D94", Offset = "0xE12D94", VA = "0xE12D94")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}
	}
}
