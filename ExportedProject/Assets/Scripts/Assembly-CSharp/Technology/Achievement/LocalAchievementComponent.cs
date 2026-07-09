using System;
using Il2CppDummyDll;
using Technology.Core.Achievement;

namespace Technology.Achievement
{
	[Token(Token = "0x2000E77")]
	internal sealed class LocalAchievementComponent : AbstractAchievementComponent<LocalAchievement>
	{
		[Token(Token = "0x4004407")]
		[FieldOffset(Offset = "0x28")]
		private DateTime _lastLoadLocalPersistenceTimestamp;

		[Token(Token = "0x6005942")]
		[Address(RVA = "0x9D4430", Offset = "0x9D4430", VA = "0x9D4430")]
		public LocalAchievementComponent()
		{
		}

		[Token(Token = "0x6005943")]
		[Address(RVA = "0x9D44EC", Offset = "0x9D44EC", VA = "0x9D44EC", Slot = "14")]
		public override void Reinitialize()
		{
		}

		[Token(Token = "0x6005944")]
		[Address(RVA = "0x9D4604", Offset = "0x9D4604", VA = "0x9D4604", Slot = "15")]
		protected override string GetPlatformSpecificId(AchievementData achievementData)
		{
			return null;
		}

		[Token(Token = "0x6005945")]
		[Address(RVA = "0x9D461C", Offset = "0x9D461C", VA = "0x9D461C", Slot = "17")]
		protected override void OnGetRecords(Action<bool, IArmoryAchievement[]> onComplete)
		{
		}

		[Token(Token = "0x6005946")]
		[Address(RVA = "0x9D46E8", Offset = "0x9D46E8", VA = "0x9D46E8", Slot = "18")]
		protected override void OnGetRecord(string id, string specificId, Action<bool, IArmoryAchievement> onComplete)
		{
		}

		[Token(Token = "0x6005947")]
		[Address(RVA = "0x9D4798", Offset = "0x9D4798", VA = "0x9D4798", Slot = "16")]
		protected override void OnRefreshDescriptions(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6005948")]
		[Address(RVA = "0x9D4AB4", Offset = "0x9D4AB4", VA = "0x9D4AB4", Slot = "23")]
		protected override void OnShowUI(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6005949")]
		[Address(RVA = "0x9D4B04", Offset = "0x9D4B04", VA = "0x9D4B04", Slot = "19")]
		protected override void OnUnlock(string id, string specificId, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x600594A")]
		[Address(RVA = "0x9D4B64", Offset = "0x9D4B64", VA = "0x9D4B64", Slot = "20")]
		protected override void OnReveal(string id, string specificId, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x600594B")]
		[Address(RVA = "0x9D4BC4", Offset = "0x9D4BC4", VA = "0x9D4BC4", Slot = "21")]
		protected override void OnIncrement(string id, string specificId, int steps, Action<bool, string> onComplete)
		{
		}

		[Token(Token = "0x600594C")]
		[Address(RVA = "0x9D4C24", Offset = "0x9D4C24", VA = "0x9D4C24", Slot = "22")]
		protected override void OnResetPlayerProgression(Action<bool> onComplete)
		{
		}
	}
}
