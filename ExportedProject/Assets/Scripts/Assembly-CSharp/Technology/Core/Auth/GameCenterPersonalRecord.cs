using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB8")]
	public class GameCenterPersonalRecord : PersonalRecord
	{
		[Token(Token = "0x40041A0")]
		[FieldOffset(Offset = "0x80")]
		public IUserProfile[] Friends;

		[Token(Token = "0x60054A4")]
		[Address(RVA = "0xD93E68", Offset = "0xD93E68", VA = "0xD93E68")]
		public GameCenterPersonalRecord()
		{
		}
	}
}
