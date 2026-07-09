using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x2000A0D")]
	public interface IDiscoveryListener
	{
		[Token(Token = "0x6003FA4")]
		void OnEndpointFound(EndpointDetails discoveredEndpoint);

		[Token(Token = "0x6003FA5")]
		void OnEndpointLost(string lostEndpointId);
	}
}
