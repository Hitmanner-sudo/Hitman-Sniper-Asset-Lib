using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D40")]
	public interface IPersister
	{
		[Token(Token = "0x60051B9")]
		void Read(string filename, IPersistableCache<int> intCache, IPersistableCache<float> floatCache, IPersistableCache<string> stringCache, IPersistableCache<bool> boolCache, IPersistableCache<long> longCache);

		[Token(Token = "0x60051BA")]
		void ReadInt(string filename, IPersistableCache<int> cache);

		[Token(Token = "0x60051BB")]
		void ReadFloat(string filename, IPersistableCache<float> cache);

		[Token(Token = "0x60051BC")]
		void ReadLong(string filename, IPersistableCache<long> cache);

		[Token(Token = "0x60051BD")]
		void ReadString(string filename, IPersistableCache<string> cache);

		[Token(Token = "0x60051BE")]
		void ReadBool(string filename, IPersistableCache<bool> cache);

		[Token(Token = "0x60051BF")]
		void WriteInt(string filename, Dictionary<string, int> dictionary);

		[Token(Token = "0x60051C0")]
		void WriteBool(string filename, Dictionary<string, bool> dictionary);

		[Token(Token = "0x60051C1")]
		void WriteFloat(string filename, Dictionary<string, float> dictionary);

		[Token(Token = "0x60051C2")]
		void WriteLong(string filename, Dictionary<string, long> dictionary);

		[Token(Token = "0x60051C3")]
		void WriteString(string filename, Dictionary<string, string> dictionary);

		[Token(Token = "0x60051C4")]
		void Flush();

		[Token(Token = "0x60051C5")]
		void Clear();
	}
}
