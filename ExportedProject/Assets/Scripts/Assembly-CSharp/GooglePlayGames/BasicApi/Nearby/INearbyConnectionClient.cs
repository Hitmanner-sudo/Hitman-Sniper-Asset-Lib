using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A0B")]
	public interface INearbyConnectionClient
	{
		[Token(Token = "0x6003F93")]
		int MaxUnreliableMessagePayloadLength();

		[Token(Token = "0x6003F94")]
		int MaxReliableMessagePayloadLength();

		[Token(Token = "0x6003F95")]
		void SendReliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x6003F96")]
		void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);

		[Token(Token = "0x6003F97")]
		void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);

		[Token(Token = "0x6003F98")]
		void StopAdvertising();

		[Token(Token = "0x6003F99")]
		void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);

		[Token(Token = "0x6003F9A")]
		void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);

		[Token(Token = "0x6003F9B")]
		void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener);

		[Token(Token = "0x6003F9C")]
		void StopDiscovery(string serviceId);

		[Token(Token = "0x6003F9D")]
		void RejectConnectionRequest(string requestingEndpointId);

		[Token(Token = "0x6003F9E")]
		void DisconnectFromEndpoint(string remoteEndpointId);

		[Token(Token = "0x6003F9F")]
		void StopAllConnections();

		[Token(Token = "0x6003FA0")]
		string GetAppBundleId();

		[Token(Token = "0x6003FA1")]
		string GetServiceId();
	}
}
