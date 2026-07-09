using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.IO
{
	[Token(Token = "0x2000D4C")]
	public interface IFileManager
	{
		[Token(Token = "0x6005233")]
		string Read(string path);

		[Token(Token = "0x6005234")]
		bool Write(string path, string content);

		[Token(Token = "0x6005235")]
		void Delete(string path);

		[Token(Token = "0x6005236")]
		bool IsValid(string content);

		[Token(Token = "0x6005237")]
		List<string> ListDirectory(string path);
	}
}
