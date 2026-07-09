using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A09")]
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0xC212B0", Offset = "0xC212B0", VA = "0xC212B0", Slot = "4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0xC212B8", Offset = "0xC212B8", VA = "0xC212B8", Slot = "5")]
		public int MaxReliableMessagePayloadLength()
		{
			return default(int);
		}

		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0xC212C0", Offset = "0xC212C0", VA = "0xC212C0", Slot = "6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6003F80")]
		[Address(RVA = "0xC21334", Offset = "0xC21334", VA = "0xC21334", Slot = "7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Token(Token = "0x6003F81")]
		[Address(RVA = "0xC213A8", Offset = "0xC213A8", VA = "0xC213A8", Slot = "8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Token(Token = "0x6003F82")]
		[Address(RVA = "0xC21440", Offset = "0xC21440", VA = "0xC21440", Slot = "9")]
		public void StopAdvertising()
		{
		}

		[Token(Token = "0x6003F83")]
		[Address(RVA = "0xC214B4", Offset = "0xC214B4", VA = "0xC214B4", Slot = "10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Token(Token = "0x6003F84")]
		[Address(RVA = "0xC215D8", Offset = "0xC215D8", VA = "0xC215D8", Slot = "11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Token(Token = "0x6003F85")]
		[Address(RVA = "0xC2164C", Offset = "0xC2164C", VA = "0xC2164C", Slot = "12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		[Token(Token = "0x6003F86")]
		[Address(RVA = "0xC216C0", Offset = "0xC216C0", VA = "0xC216C0", Slot = "13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Token(Token = "0x6003F87")]
		[Address(RVA = "0xC21734", Offset = "0xC21734", VA = "0xC21734", Slot = "14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Token(Token = "0x6003F88")]
		[Address(RVA = "0xC217A8", Offset = "0xC217A8", VA = "0xC217A8", Slot = "15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Token(Token = "0x6003F89")]
		[Address(RVA = "0xC2181C", Offset = "0xC2181C", VA = "0xC2181C", Slot = "16")]
		public void StopAllConnections()
		{
		}

		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0xC21890", Offset = "0xC21890", VA = "0xC21890")]
		public string LocalEndpointId()
		{
			return null;
		}

		[Token(Token = "0x6003F8B")]
		[Address(RVA = "0xC218DC", Offset = "0xC218DC", VA = "0xC218DC")]
		public string LocalDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0xC21920", Offset = "0xC21920", VA = "0xC21920", Slot = "17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0xC21964", Offset = "0xC21964", VA = "0xC21964", Slot = "18")]
		public string GetServiceId()
		{
			return null;
		}

		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0xC219A8", Offset = "0xC219A8", VA = "0xC219A8")]
		public DummyNearbyConnectionClient()
		{
		}
	}
}
