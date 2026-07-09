using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CBB")]
	public interface IPostRequestContext : IRequestContext
	{
		[Token(Token = "0x17000A4E")]
		string PostData
		{
			[Token(Token = "0x6004EFC")]
			get;
			[Token(Token = "0x6004EFD")]
			set;
		}
	}
}
