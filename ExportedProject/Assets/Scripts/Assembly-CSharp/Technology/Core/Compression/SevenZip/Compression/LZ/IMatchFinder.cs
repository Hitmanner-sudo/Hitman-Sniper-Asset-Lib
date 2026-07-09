using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZ
{
	[Token(Token = "0x2000D70")]
	internal interface IMatchFinder : IInWindowStream
	{
		[Token(Token = "0x600530A")]
		void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter);

		[Token(Token = "0x600530B")]
		uint GetMatches(uint[] distances);

		[Token(Token = "0x600530C")]
		void Skip(uint num);
	}
}
