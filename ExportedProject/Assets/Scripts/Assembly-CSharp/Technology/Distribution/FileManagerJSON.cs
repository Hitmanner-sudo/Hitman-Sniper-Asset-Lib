using Il2CppDummyDll;
using Technology.Core.IO;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BFC")]
	public class FileManagerJSON : FileManagerLocal
	{
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x9530E0", Offset = "0x9530E0", VA = "0x9530E0", Slot = "9")]
		public override string Read(string path)
		{
			return null;
		}

		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x9531B0", Offset = "0x9531B0", VA = "0x9531B0", Slot = "10")]
		public override bool Write(string path, string content)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x9532C0", Offset = "0x9532C0", VA = "0x9532C0", Slot = "11")]
		public override bool IsValid(string content)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x9533C0", Offset = "0x9533C0", VA = "0x9533C0")]
		public FileManagerJSON()
		{
		}
	}
}
