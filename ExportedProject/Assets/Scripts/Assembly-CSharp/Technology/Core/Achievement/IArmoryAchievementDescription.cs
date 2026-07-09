using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E3B")]
	public interface IArmoryAchievementDescription : IAchievementDescription
	{
		[Token(Token = "0x17000BBC")]
		string Id
		{
			[Token(Token = "0x60057A4")]
			get;
			[Token(Token = "0x60057A5")]
			set;
		}

		[Token(Token = "0x17000BBD")]
		string Title
		{
			[Token(Token = "0x60057A6")]
			get;
		}

		[Token(Token = "0x17000BBE")]
		string AchievedDescription
		{
			[Token(Token = "0x60057A7")]
			get;
		}

		[Token(Token = "0x17000BBF")]
		Texture2D AchievedImage
		{
			[Token(Token = "0x60057A8")]
			get;
		}

		[Token(Token = "0x17000BC0")]
		string UnachievedDescription
		{
			[Token(Token = "0x60057A9")]
			get;
		}

		[Token(Token = "0x17000BC1")]
		Texture2D UnachievedImage
		{
			[Token(Token = "0x60057AA")]
			get;
		}

		[Token(Token = "0x17000BC2")]
		bool Hidden
		{
			[Token(Token = "0x60057AB")]
			get;
		}

		[Token(Token = "0x17000BC3")]
		int Steps
		{
			[Token(Token = "0x60057AC")]
			get;
		}

		[Token(Token = "0x17000BC4")]
		int Points
		{
			[Token(Token = "0x60057AD")]
			get;
		}

		[Token(Token = "0x60057AE")]
		void Update(IAchievementDescription description);
	}
}
