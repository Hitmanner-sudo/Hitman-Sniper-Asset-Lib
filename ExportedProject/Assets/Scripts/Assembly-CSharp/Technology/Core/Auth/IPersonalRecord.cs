using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB1")]
	public interface IPersonalRecord
	{
		[Token(Token = "0x17000B09")]
		string Id
		{
			[Token(Token = "0x6005457")]
			get;
		}

		[Token(Token = "0x17000B0A")]
		string LastName
		{
			[Token(Token = "0x6005458")]
			get;
		}

		[Token(Token = "0x17000B0B")]
		string FirstName
		{
			[Token(Token = "0x6005459")]
			get;
		}

		[Token(Token = "0x17000B0C")]
		string Name
		{
			[Token(Token = "0x600545A")]
			get;
		}

		[Token(Token = "0x17000B0D")]
		string Username
		{
			[Token(Token = "0x600545B")]
			get;
		}

		[Token(Token = "0x17000B0E")]
		bool IsUnderAge
		{
			[Token(Token = "0x600545C")]
			get;
		}

		[Token(Token = "0x17000B0F")]
		int AvatarImageWidth
		{
			[Token(Token = "0x600545D")]
			get;
		}

		[Token(Token = "0x17000B10")]
		int AvatarImageHeight
		{
			[Token(Token = "0x600545E")]
			get;
		}

		[Token(Token = "0x17000B11")]
		Texture2D AvatarImage
		{
			[Token(Token = "0x600545F")]
			get;
		}

		[Token(Token = "0x17000B12")]
		AvatarStatus AvatarStatus
		{
			[Token(Token = "0x6005460")]
			get;
		}

		[Token(Token = "0x17000B13")]
		byte[] RawAvatarData
		{
			[Token(Token = "0x6005461")]
			get;
		}

		[Token(Token = "0x17000B14")]
		string Gender
		{
			[Token(Token = "0x6005462")]
			get;
		}

		[Token(Token = "0x17000B15")]
		string Locale
		{
			[Token(Token = "0x6005463")]
			get;
		}

		[Token(Token = "0x17000B16")]
		string Language
		{
			[Token(Token = "0x6005464")]
			get;
		}

		[Token(Token = "0x17000B17")]
		string DateOfBirth
		{
			[Token(Token = "0x6005465")]
			get;
		}

		[Token(Token = "0x17000B18")]
		bool IsLoggedIn
		{
			[Token(Token = "0x6005466")]
			get;
			[Token(Token = "0x6005467")]
			set;
		}
	}
}
