using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D2A")]
	public interface IPersistableCache<T>
	{
		[Token(Token = "0x17000ABD")]
		Dictionary<string, T>.KeyCollection Keys
		{
			[Token(Token = "0x6005147")]
			get;
		}

		[Token(Token = "0x17000ABE")]
		bool IsDirty
		{
			[Token(Token = "0x6005149")]
			get;
			[Token(Token = "0x600514A")]
			set;
		}

		[Token(Token = "0x17000ABF")]
		bool SkipCollisionCheck
		{
			[Token(Token = "0x600514B")]
			get;
			[Token(Token = "0x600514C")]
			set;
		}

		[Token(Token = "0x6005146")]
		Dictionary<string, T> GetDictionary();

		[Token(Token = "0x6005148")]
		void Add(string aKey, T value);

		[Token(Token = "0x600514D")]
		void Clear();

		[Token(Token = "0x600514E")]
		bool Contains(string key);

		[Token(Token = "0x600514F")]
		void Set(string key, T value);

		[Token(Token = "0x6005150")]
		T Get(string key);

		[Token(Token = "0x6005151")]
		void Remove(string key);

		[Token(Token = "0x6005152")]
		void ExcludeKey(string key);

		[Token(Token = "0x6005153")]
		void IncludeKey(string key);
	}
}
