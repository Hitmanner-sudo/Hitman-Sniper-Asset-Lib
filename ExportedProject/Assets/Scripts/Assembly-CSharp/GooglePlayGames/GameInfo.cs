using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000957")]
	public static class GameInfo
	{
		[Token(Token = "0x40032D6")]
		private const string UnescapedApplicationId = "APP_ID";

		[Token(Token = "0x40032D7")]
		private const string UnescapedIosClientId = "IOS_CLIENTID";

		[Token(Token = "0x40032D8")]
		private const string UnescapedWebClientId = "WEB_CLIENTID";

		[Token(Token = "0x40032D9")]
		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		[Token(Token = "0x40032DA")]
		public const string ApplicationId = "246152210526";

		[Token(Token = "0x40032DB")]
		public const string IosClientId = "__IOS_CLIENTID__";

		[Token(Token = "0x40032DC")]
		public const string WebClientId = "246152210526-ljln3813n7na70o61ikja3mhm2h232ec.apps.googleusercontent.com";

		[Token(Token = "0x40032DD")]
		public const string NearbyConnectionServiceId = "";

		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0xD984FC", Offset = "0xD984FC", VA = "0xD984FC")]
		public static bool ApplicationIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0xD985E4", Offset = "0xD985E4", VA = "0xD985E4")]
		public static bool IosClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0xD9867C", Offset = "0xD9867C", VA = "0xD9867C")]
		public static bool WebClientIdInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0xD98714", Offset = "0xD98714", VA = "0xD98714")]
		public static bool NearbyConnectionsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0xD98594", Offset = "0xD98594", VA = "0xD98594")]
		private static string ToEscapedToken(string token)
		{
			return null;
		}
	}
}
