using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D2B")]
	public class PersistenceCache<T> : IPersistableCache<T>
	{
		[Token(Token = "0x4003EE5")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, T> _cache;

		[Token(Token = "0x4003EE6")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _defaultValue;

		[Token(Token = "0x4003EE7")]
		[FieldOffset(Offset = "0x0")]
		private readonly HashSet<string> _excludeKeys;

		[Token(Token = "0x4003EE8")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE314", Offset = "0x5BE314")]
		private bool _003CSkipCollisionCheck_003Ek__BackingField;

		[Token(Token = "0x4003EE9")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BE324", Offset = "0x5BE324")]
		private bool _003CIsDirty_003Ek__BackingField;

		[Token(Token = "0x17000AC0")]
		public bool SkipCollisionCheck
		{
			[Token(Token = "0x6005154")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296B0", Offset = "0x6296B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005155")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296C0", Offset = "0x6296C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC1")]
		public bool IsDirty
		{
			[Token(Token = "0x6005156")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296D0", Offset = "0x6296D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005157")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6296E0", Offset = "0x6296E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC2")]
		public Dictionary<string, T>.KeyCollection Keys
		{
			[Token(Token = "0x6005164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005158")]
		public PersistenceCache(T defaultValue)
		{
		}

		[Token(Token = "0x6005159")]
		public PersistenceCache(Dictionary<string, T> initialDictionary)
		{
		}

		[Token(Token = "0x600515A")]
		public bool Contains(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600515B")]
		public T Get(string aKey)
		{
			return (T)null;
		}

		[Token(Token = "0x600515C")]
		public void Set(string aKey, T value)
		{
		}

		[Token(Token = "0x600515D")]
		public void Add(string aKey, T value)
		{
		}

		[Token(Token = "0x600515E")]
		public void Clear()
		{
		}

		[Token(Token = "0x600515F")]
		public void Remove(string aKey)
		{
		}

		[Token(Token = "0x6005160")]
		public void ExcludeKey(string key)
		{
		}

		[Token(Token = "0x6005161")]
		public void IncludeKey(string key)
		{
		}

		[Token(Token = "0x6005162")]
		private bool KeyCollisionCheck(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6005163")]
		public Dictionary<string, T> GetDictionary()
		{
			return null;
		}

		[Token(Token = "0x6005165")]
		public string Debug()
		{
			return null;
		}

		[Token(Token = "0x6005166")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6005167")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
