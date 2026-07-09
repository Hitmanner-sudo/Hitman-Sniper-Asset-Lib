using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A0C")]
	public interface IMessageListener
	{
		[Token(Token = "0x6003FA2")]
		void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

		[Token(Token = "0x6003FA3")]
		void OnRemoteEndpointDisconnected(string remoteEndpointId);
	}
}
