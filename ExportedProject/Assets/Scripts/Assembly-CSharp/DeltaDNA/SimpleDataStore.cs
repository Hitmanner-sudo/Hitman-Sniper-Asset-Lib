using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200131E")]
	public abstract class SimpleDataStore<K, V>
	{
		[Token(Token = "0x4005BCA")]
		[FieldOffset(Offset = "0x0")]
		private static object LOCK;

		[Token(Token = "0x4005BCB")]
		[FieldOffset(Offset = "0x0")]
		private readonly string location;

		[Token(Token = "0x4005BCC")]
		[FieldOffset(Offset = "0x0")]
		private readonly string storename;

		[Token(Token = "0x4005BCD")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<K, V> data;

		[Token(Token = "0x4005BCE")]
		[FieldOffset(Offset = "0x0")]
		private char paramSeparator;

		[Token(Token = "0x600706C")]
		internal SimpleDataStore(string directory, string storename, char paramSeparator = ' ')
		{
		}

		[Token(Token = "0x600706D")]
		protected abstract K parseKey(string key);

		[Token(Token = "0x600706E")]
		protected abstract V parseValue(string value);

		[Token(Token = "0x600706F")]
		protected abstract string createLine(K key, V value);

		[Token(Token = "0x6007070")]
		public void Put(K key, V value)
		{
		}

		[Token(Token = "0x6007071")]
		public V GetOrDefault(K key, V defaultValue)
		{
			return (V)null;
		}

		[Token(Token = "0x6007072")]
		internal void Save()
		{
		}

		[Token(Token = "0x6007073")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6007074")]
		private void CreateDirectory()
		{
		}

		[Token(Token = "0x6007075")]
		protected char getKeyValueSeparator()
		{
			return default(char);
		}

		[Token(Token = "0x6007077")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3D0", Offset = "0x62D3D0")]
		private K _003C_002Ector_003Eb__5_0(string e)
		{
			return (K)null;
		}

		[Token(Token = "0x6007078")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3E0", Offset = "0x62D3E0")]
		private V _003C_002Ector_003Eb__5_1(string e)
		{
			return (V)null;
		}

		[Token(Token = "0x6007079")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D3F0", Offset = "0x62D3F0")]
		private string _003CSave_003Eb__11_0(KeyValuePair<K, V> e)
		{
			return null;
		}
	}
}
