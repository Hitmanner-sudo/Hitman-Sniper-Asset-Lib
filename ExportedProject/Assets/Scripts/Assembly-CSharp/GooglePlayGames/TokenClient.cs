using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000973")]
	internal interface TokenClient
	{
		[Token(Token = "0x6003CB3")]
		string GetEmail();

		[Token(Token = "0x6003CB4")]
		string GetAuthCode();

		[Token(Token = "0x6003CB5")]
		string GetIdToken();

		[Token(Token = "0x6003CB6")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		[Token(Token = "0x6003CB7")]
		void Signout();

		[Token(Token = "0x6003CB8")]
		void SetRequestAuthCode(bool flag, bool forceRefresh);

		[Token(Token = "0x6003CB9")]
		void SetRequestEmail(bool flag);

		[Token(Token = "0x6003CBA")]
		void SetRequestIdToken(bool flag);

		[Token(Token = "0x6003CBB")]
		void SetWebClientId(string webClientId);

		[Token(Token = "0x6003CBC")]
		void SetAccountName(string accountName);

		[Token(Token = "0x6003CBD")]
		void AddOauthScopes(params string[] scopes);

		[Token(Token = "0x6003CBE")]
		void SetHidePopups(bool flag);

		[Token(Token = "0x6003CBF")]
		void FetchTokens(bool silent, Action<int> callback);

		[Token(Token = "0x6003CC0")]
		void RequestPermissions(string[] scopes, Action<SignInStatus> callback);

		[Token(Token = "0x6003CC1")]
		bool HasPermissions(string[] scopes);
	}
}
