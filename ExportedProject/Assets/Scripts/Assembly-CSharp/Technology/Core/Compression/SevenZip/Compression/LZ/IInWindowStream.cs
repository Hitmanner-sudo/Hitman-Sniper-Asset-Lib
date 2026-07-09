using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.Compression.LZ
{
	[Token(Token = "0x2000D6F")]
	internal interface IInWindowStream
	{
		[Token(Token = "0x6005304")]
		void SetStream(Stream inStream);

		[Token(Token = "0x6005305")]
		void Init();

		[Token(Token = "0x6005306")]
		void ReleaseStream();

		[Token(Token = "0x6005307")]
		byte GetIndexByte(int index);

		[Token(Token = "0x6005308")]
		uint GetMatchLen(int index, uint distance, uint limit);

		[Token(Token = "0x6005309")]
		uint GetNumAvailableBytes();
	}
}
