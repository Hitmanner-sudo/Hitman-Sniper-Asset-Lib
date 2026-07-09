using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20009F4")]
	public class SignInHelper
	{
		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x0")]
		private static int True;

		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x4")]
		private static int False;

		[Token(Token = "0x40034BC")]
		private const string PromptSignInKey = "prompt_sign_in";

		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x8455D0", Offset = "0x8455D0", VA = "0x8455D0")]
		public static SignInStatus ToSignInStatus(int code)
		{
			return default(SignInStatus);
		}

		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x845798", Offset = "0x845798", VA = "0x845798")]
		public static void SetPromptUiSignIn(bool value)
		{
		}

		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x84584C", Offset = "0x84584C", VA = "0x84584C")]
		public static bool ShouldPromptUiSignIn()
		{
			return default(bool);
		}

		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x8458E4", Offset = "0x8458E4", VA = "0x8458E4")]
		public SignInHelper()
		{
		}
	}
}
