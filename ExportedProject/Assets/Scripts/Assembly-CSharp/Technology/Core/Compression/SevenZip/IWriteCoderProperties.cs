using System.IO;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip
{
	[Token(Token = "0x2000D5A")]
	public interface IWriteCoderProperties
	{
		[Token(Token = "0x6005280")]
		void WriteCoderProperties(Stream outStream);
	}
}
