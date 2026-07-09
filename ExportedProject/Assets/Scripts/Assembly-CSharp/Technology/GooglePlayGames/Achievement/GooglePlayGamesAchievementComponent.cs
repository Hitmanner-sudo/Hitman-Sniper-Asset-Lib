using System;
using Il2CppDummyDll;
using Technology.Core.Achievement;

namespace Technology.GooglePlayGames.Achievement
{
	[Token(Token = "0x2000BB0")]
	internal class GooglePlayGamesAchievementComponent : SocialAchievementComponent<GooglePlayGamesAchievement, GooglePlayGamesAchievementDescription>
	{
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0xC84E64", Offset = "0xC84E64", VA = "0xC84E64")]
		public GooglePlayGamesAchievementComponent()
		{
		}

		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0xC84F08", Offset = "0xC84F08", VA = "0xC84F08", Slot = "15")]
		protected override string GetPlatformSpecificId(AchievementData achievementObject)
		{
			return null;
		}

		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0xC84F20", Offset = "0xC84F20", VA = "0xC84F20", Slot = "22")]
		protected override void OnResetPlayerProgression(Action<bool> action)
		{
		}

		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0xC84F70", Offset = "0xC84F70", VA = "0xC84F70", Slot = "24")]
		protected override GooglePlayGamesAchievementDescription CreateDescription(AchievementData data)
		{
			return null;
		}

		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0xC84FEC", Offset = "0xC84FEC", VA = "0xC84FEC", Slot = "25")]
		protected override GooglePlayGamesAchievement CreateAchievement(GooglePlayGamesAchievementDescription description)
		{
			return null;
		}
	}
}
