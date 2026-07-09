using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.IO
{
	[Token(Token = "0x2000D4A")]
	public class FileManagerLocal : IFileManager
	{
		[Token(Token = "0x6005219")]
		[Address(RVA = "0x95313C", Offset = "0x95313C", VA = "0x95313C", Slot = "9")]
		public virtual string Read(string path)
		{
			return null;
		}

		[Token(Token = "0x600521A")]
		[Address(RVA = "0x95321C", Offset = "0x95321C", VA = "0x95321C", Slot = "10")]
		public virtual bool Write(string path, string content)
		{
			return default(bool);
		}

		[Token(Token = "0x600521B")]
		[Address(RVA = "0x9533D0", Offset = "0x9533D0", VA = "0x9533D0", Slot = "6")]
		public void Delete(string path)
		{
		}

		[Token(Token = "0x600521C")]
		[Address(RVA = "0x9533DC", Offset = "0x9533DC", VA = "0x9533DC", Slot = "11")]
		public virtual bool IsValid(string content)
		{
			return default(bool);
		}

		[Token(Token = "0x600521D")]
		[Address(RVA = "0x9533E4", Offset = "0x9533E4", VA = "0x9533E4", Slot = "12")]
		public virtual List<string> ListDirectory(string path)
		{
			return null;
		}

		[Token(Token = "0x600521E")]
		[Address(RVA = "0x9533C8", Offset = "0x9533C8", VA = "0x9533C8")]
		public FileManagerLocal()
		{
		}
	}
}
