using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	[Token(Token = "0x2000A12")]
	public interface IEvent
	{
		[Token(Token = "0x17000809")]
		string Id
		{
			[Token(Token = "0x6003FB0")]
			get;
		}

		[Token(Token = "0x1700080A")]
		string Name
		{
			[Token(Token = "0x6003FB1")]
			get;
		}

		[Token(Token = "0x1700080B")]
		string Description
		{
			[Token(Token = "0x6003FB2")]
			get;
		}

		[Token(Token = "0x1700080C")]
		string ImageUrl
		{
			[Token(Token = "0x6003FB3")]
			get;
		}

		[Token(Token = "0x1700080D")]
		ulong CurrentCount
		{
			[Token(Token = "0x6003FB4")]
			get;
		}

		[Token(Token = "0x1700080E")]
		EventVisibility Visibility
		{
			[Token(Token = "0x6003FB5")]
			get;
		}
	}
}
