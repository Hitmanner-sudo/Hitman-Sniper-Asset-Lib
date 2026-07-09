using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A07")]
	public struct ConnectionResponse
	{
		[Token(Token = "0x2000A08")]
		public enum Status
		{
			[Token(Token = "0x4003501")]
			Accepted = 0,
			[Token(Token = "0x4003502")]
			Rejected = 1,
			[Token(Token = "0x4003503")]
			ErrorInternal = 2,
			[Token(Token = "0x4003504")]
			ErrorNetworkNotConnected = 3,
			[Token(Token = "0x4003505")]
			ErrorEndpointNotConnected = 4,
			[Token(Token = "0x4003506")]
			ErrorAlreadyConnected = 5
		}

		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyPayload;

		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly long mLocalClientId;

		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mRemoteEndpointId;

		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Status mResponseStatus;

		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x170007FA")]
		public long LocalClientId
		{
			[Token(Token = "0x6003F72")]
			[Address(RVA = "0x8E13B8", Offset = "0x8E13B8", VA = "0x8E13B8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170007FB")]
		public string RemoteEndpointId
		{
			[Token(Token = "0x6003F73")]
			[Address(RVA = "0x8E13C0", Offset = "0x8E13C0", VA = "0x8E13C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FC")]
		public Status ResponseStatus
		{
			[Token(Token = "0x6003F74")]
			[Address(RVA = "0x8E13C8", Offset = "0x8E13C8", VA = "0x8E13C8")]
			get
			{
				return default(Status);
			}
		}

		[Token(Token = "0x170007FD")]
		public byte[] Payload
		{
			[Token(Token = "0x6003F75")]
			[Address(RVA = "0x8E13D0", Offset = "0x8E13D0", VA = "0x8E13D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x8E1318", Offset = "0x8E1318", VA = "0x8E1318")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload)
		{
		}

		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x8E13D8", Offset = "0x8E13D8", VA = "0x8E13D8")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x8E1468", Offset = "0x8E1468", VA = "0x8E1468")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x8E14F8", Offset = "0x8E14F8", VA = "0x8E14F8")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x8E1588", Offset = "0x8E1588", VA = "0x8E1588")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x8E1618", Offset = "0x8E1618", VA = "0x8E1618")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x8E1638", Offset = "0x8E1638", VA = "0x8E1638")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}
	}
}
