using System;
using Il2CppDummyDll;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E39")]
	internal interface IAchievementProvider : IComponentProvider<IAchievementComponent>, IArmoryProvider
	{
		[Token(Token = "0x14000173")]
		event Action<bool, string> OnUnlock;

		[Token(Token = "0x14000174")]
		event Action<bool, string> OnReveal;

		[Token(Token = "0x14000175")]
		event Action<bool> OnIncrement;

		[Token(Token = "0x14000176")]
		event Action<bool> OnShowUI;

		[Token(Token = "0x14000177")]
		event Action<bool, IArmoryAchievement[]> OnGetRecords;

		[Token(Token = "0x14000178")]
		event Action<bool, IArmoryAchievement> OnGetRecord;

		[Token(Token = "0x14000179")]
		event Action<bool> OnRefreshDescriptions;

		[Token(Token = "0x1400017A")]
		event Action<bool> OnResetPlayerProgression;

		[Token(Token = "0x6005790")]
		void RaiseOnUnlock(bool success, string id);

		[Token(Token = "0x6005791")]
		void RaiseOnReveal(bool success, string id);

		[Token(Token = "0x6005792")]
		void RaiseOnIncrement(bool success);

		[Token(Token = "0x6005793")]
		void RaiseOnShowUI(bool success);

		[Token(Token = "0x6005794")]
		void RaiseOnGetRecords(bool success, IArmoryAchievement[] records);

		[Token(Token = "0x6005795")]
		void RaiseOnGetRecord(bool success, IArmoryAchievement record);

		[Token(Token = "0x6005796")]
		void RaiseOnRefreshDescriptions(bool success);

		[Token(Token = "0x6005797")]
		void RaiseOnResetPlayerProgression(bool success);
	}
}
