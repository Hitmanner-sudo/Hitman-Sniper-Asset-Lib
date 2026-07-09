using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip
{
	[Token(Token = "0x2000D57")]
	public interface ICoder
	{
		[Token(Token = "0x600527E")]
		void Code(Stream inStream, Stream outStream, long inSize, long outSize, ICodeProgress progress);
	}
}
