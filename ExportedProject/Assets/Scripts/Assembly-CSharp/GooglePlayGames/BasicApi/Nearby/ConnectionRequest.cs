using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A06")]
	public struct ConnectionRequest
	{
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x170007F8")]
		public EndpointDetails RemoteEndpoint
		{
			[Token(Token = "0x6003F6F")]
			[Address(RVA = "0x8E12FC", Offset = "0x8E12FC", VA = "0x8E12FC")]
			get
			{
				return default(EndpointDetails);
			}
		}

		[Token(Token = "0x170007F9")]
		public byte[] Payload
		{
			[Token(Token = "0x6003F70")]
			[Address(RVA = "0x8E1310", Offset = "0x8E1310", VA = "0x8E1310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x8E1204", Offset = "0x8E1204", VA = "0x8E1204")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}
	}
}
