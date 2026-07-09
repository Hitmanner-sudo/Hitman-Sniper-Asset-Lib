using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D42")]
	public class PersisterJSONLocalFile : AbstractFilePersister
	{
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x905B70", Offset = "0x905B70", VA = "0x905B70")]
		private PersisterJSONLocalFile()
		{
		}

		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x905BCC", Offset = "0x905BCC", VA = "0x905BCC")]
		public PersisterJSONLocalFile(string relativeRelativePath, string fileExtension)
		{
		}

		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x905BD4", Offset = "0x905BD4", VA = "0x905BD4", Slot = "17")]
		public override void WriteObject(string filename, Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x905DA4", Offset = "0x905DA4", VA = "0x905DA4", Slot = "18")]
		public override void WriteInt(string filename, Dictionary<string, int> dictionary)
		{
		}

		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x905E14", Offset = "0x905E14", VA = "0x905E14", Slot = "19")]
		public override void WriteBool(string filename, Dictionary<string, bool> dictionary)
		{
		}

		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x905E84", Offset = "0x905E84", VA = "0x905E84", Slot = "20")]
		public override void WriteFloat(string filename, Dictionary<string, float> dictionary)
		{
		}

		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x905EF4", Offset = "0x905EF4", VA = "0x905EF4", Slot = "21")]
		public override void WriteLong(string filename, Dictionary<string, long> dictionary)
		{
		}

		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x905F64", Offset = "0x905F64", VA = "0x905F64", Slot = "22")]
		public override void WriteString(string filename, Dictionary<string, string> dictionary)
		{
		}

		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x905FD4", Offset = "0x905FD4", VA = "0x905FD4", Slot = "27")]
		public override void ReadBool(string filename, IPersistableCache<bool> cache)
		{
		}

		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x906088", Offset = "0x906088", VA = "0x906088", Slot = "23")]
		public override void ReadInt(string filename, IPersistableCache<int> cache)
		{
		}

		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x90613C", Offset = "0x90613C", VA = "0x90613C", Slot = "24")]
		public override void ReadFloat(string filename, IPersistableCache<float> cache)
		{
		}

		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x9061F0", Offset = "0x9061F0", VA = "0x9061F0", Slot = "25")]
		public override void ReadLong(string filename, IPersistableCache<long> cache)
		{
		}

		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x9062A4", Offset = "0x9062A4", VA = "0x9062A4", Slot = "26")]
		public override void ReadString(string filename, IPersistableCache<string> cache)
		{
		}

		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x905C44", Offset = "0x905C44", VA = "0x905C44")]
		private void WriteAllText(string absoluteFilePath, IDictionary data)
		{
		}
	}
}
