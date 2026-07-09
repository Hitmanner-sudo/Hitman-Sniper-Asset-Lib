using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E3A")]
	public interface IArmoryAchievement : IAchievement
	{
		[Token(Token = "0x17000BB7")]
		IArmoryAchievementDescription Description
		{
			[Token(Token = "0x6005798")]
			get;
		}

		[Token(Token = "0x17000BB8")]
		bool Hidden
		{
			[Token(Token = "0x6005799")]
			get;
		}

		[Token(Token = "0x17000BB9")]
		bool Completed
		{
			[Token(Token = "0x600579A")]
			get;
		}

		[Token(Token = "0x17000BBA")]
		float Steps
		{
			[Token(Token = "0x600579B")]
			get;
		}

		[Token(Token = "0x17000BBB")]
		DateTime LastModificationDate
		{
			[Token(Token = "0x600579C")]
			get;
		}

		[Token(Token = "0x600579D")]
		void Update(IAchievement achievement);

		[Token(Token = "0x600579E")]
		void Unlock();

		[Token(Token = "0x600579F")]
		void Increment(int progress);

		[Token(Token = "0x60057A0")]
		void Reveal();

		[Token(Token = "0x60057A1")]
		void Reset();

		[Token(Token = "0x60057A2")]
		void Load();

		[Token(Token = "0x60057A3")]
		void Save();
	}
}
