using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012E2")]
	internal sealed class MainMenu : MenuBase
	{
		[Token(Token = "0x20012E3")]
		private enum Scope
		{
			[Token(Token = "0x4005A82")]
			PublicProfile = 1,
			[Token(Token = "0x4005A83")]
			UserFriends = 2,
			[Token(Token = "0x4005A84")]
			UserBirthday = 4,
			[Token(Token = "0x4005A85")]
			UserAgeRange = 8,
			[Token(Token = "0x4005A86")]
			PublishActions = 0x10,
			[Token(Token = "0x4005A87")]
			UserLocation = 0x20,
			[Token(Token = "0x4005A88")]
			UserHometown = 0x40,
			[Token(Token = "0x4005A89")]
			UserGender = 0x80
		}

		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0x9AC09C", Offset = "0x9AC09C", VA = "0x9AC09C", Slot = "7")]
		protected override bool ShowBackButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0x9AC0A4", Offset = "0x9AC0A4", VA = "0x9AC0A4", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0x9ACF94", Offset = "0x9ACF94", VA = "0x9ACF94")]
		private void CallFBLogin(LoginTracking mode, Scope scopemask)
		{
		}

		[Token(Token = "0x6006E3F")]
		[Address(RVA = "0x9AD260", Offset = "0x9AD260", VA = "0x9AD260")]
		private void CallFBLoginForPublish()
		{
		}

		[Token(Token = "0x6006E40")]
		[Address(RVA = "0x9AD3A4", Offset = "0x9AD3A4", VA = "0x9AD3A4")]
		private void CallFBLogout()
		{
		}

		[Token(Token = "0x6006E41")]
		[Address(RVA = "0x9AD400", Offset = "0x9AD400", VA = "0x9AD400")]
		private void OnInitComplete()
		{
		}

		[Token(Token = "0x6006E42")]
		[Address(RVA = "0x9AD5D0", Offset = "0x9AD5D0", VA = "0x9AD5D0")]
		private void OnHideUnity(bool isGameShown)
		{
		}

		[Token(Token = "0x6006E43")]
		[Address(RVA = "0x9AD6F0", Offset = "0x9AD6F0", VA = "0x9AD6F0")]
		public MainMenu()
		{
		}
	}
}
