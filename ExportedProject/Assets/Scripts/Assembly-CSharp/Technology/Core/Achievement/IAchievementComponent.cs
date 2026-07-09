using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E38")]
	public interface IAchievementComponent : IArmoryComponent
	{
		[Token(Token = "0x17000BB6")]
		Dictionary<string, IArmoryAchievementDescription> Descriptions
		{
			[Token(Token = "0x6005776")]
			get;
		}

		[Token(Token = "0x6005777")]
		void Reinitialize();

		[Token(Token = "0x6005778")]
		void Unlock(string id);

		[Token(Token = "0x6005779")]
		void Reveal(string id);

		[Token(Token = "0x600577A")]
		void Increment(string id, int steps);

		[Token(Token = "0x600577B")]
		void GetRecords();

		[Token(Token = "0x600577C")]
		void GetRecord(string id);

		[Token(Token = "0x600577D")]
		void RefreshDescriptions();

		[Token(Token = "0x600577E")]
		void ResetPlayerProgression();

		[Token(Token = "0x600577F")]
		void ShowUI();
	}
}
