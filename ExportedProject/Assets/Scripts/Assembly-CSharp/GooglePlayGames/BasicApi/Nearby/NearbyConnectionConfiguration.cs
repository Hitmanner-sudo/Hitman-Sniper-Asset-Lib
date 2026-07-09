using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A0F")]
	public struct NearbyConnectionConfiguration
	{
		[Token(Token = "0x400350E")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		[Token(Token = "0x400350F")]
		public const int MaxReliableMessagePayloadLength = 4096;

		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x8")]
		private readonly long mLocalClientId;

		[Token(Token = "0x17000801")]
		public long LocalClientId
		{
			[Token(Token = "0x6003FA7")]
			[Address(RVA = "0xC58E68", Offset = "0xC58E68", VA = "0xC58E68")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000802")]
		public Action<InitializationStatus> InitializationCallback
		{
			[Token(Token = "0x6003FA8")]
			[Address(RVA = "0xC58E70", Offset = "0xC58E70", VA = "0xC58E70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0xC58E04", Offset = "0xC58E04", VA = "0xC58E04")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}
	}
}
