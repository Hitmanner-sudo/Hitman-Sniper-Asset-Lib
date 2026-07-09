using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B3A")]
	internal interface ILedgerEntry
	{
		[Token(Token = "0x170008F5")]
		int LQuantity
		{
			[Token(Token = "0x60046EF")]
			get;
		}

		[Token(Token = "0x170008F6")]
		string LIdentifier
		{
			[Token(Token = "0x60046F0")]
			get;
		}
	}
}
