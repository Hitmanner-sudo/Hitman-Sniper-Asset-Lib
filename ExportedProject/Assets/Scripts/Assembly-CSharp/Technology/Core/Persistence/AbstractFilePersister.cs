using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D41")]
	public abstract class AbstractFilePersister : IPersister
	{
		[Token(Token = "0x4003F3C")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string _relativePath;

		[Token(Token = "0x4003F3D")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string _fileExtension;

		[Token(Token = "0x60051C6")]
		public abstract void WriteObject(string filename, Dictionary<string, object> dictionary);

		[Token(Token = "0x60051C7")]
		public abstract void WriteInt(string filename, Dictionary<string, int> dictionary);

		[Token(Token = "0x60051C8")]
		public abstract void WriteBool(string filename, Dictionary<string, bool> dictionary);

		[Token(Token = "0x60051C9")]
		public abstract void WriteFloat(string filename, Dictionary<string, float> dictionary);

		[Token(Token = "0x60051CA")]
		public abstract void WriteLong(string filename, Dictionary<string, long> dictionary);

		[Token(Token = "0x60051CB")]
		public abstract void WriteString(string filename, Dictionary<string, string> dictionary);

		[Token(Token = "0x60051CC")]
		public abstract void ReadInt(string filename, IPersistableCache<int> cache);

		[Token(Token = "0x60051CD")]
		public abstract void ReadFloat(string filename, IPersistableCache<float> cache);

		[Token(Token = "0x60051CE")]
		public abstract void ReadLong(string filename, IPersistableCache<long> cache);

		[Token(Token = "0x60051CF")]
		public abstract void ReadString(string filename, IPersistableCache<string> cache);

		[Token(Token = "0x60051D0")]
		public abstract void ReadBool(string filename, IPersistableCache<bool> cache);

		[Token(Token = "0x60051D1")]
		[Address(RVA = "0xAA0D58", Offset = "0xAA0D58", VA = "0xAA0D58")]
		protected AbstractFilePersister(string relativePath, string fileExtension)
		{
		}

		[Token(Token = "0x60051D2")]
		[Address(RVA = "0xAA0D90", Offset = "0xAA0D90", VA = "0xAA0D90", Slot = "15")]
		public void Flush()
		{
		}

		[Token(Token = "0x60051D3")]
		[Address(RVA = "0xAA0D94", Offset = "0xAA0D94", VA = "0xAA0D94", Slot = "16")]
		public void Clear()
		{
		}

		[Token(Token = "0x60051D4")]
		[Address(RVA = "0xAA0D98", Offset = "0xAA0D98", VA = "0xAA0D98", Slot = "4")]
		public void Read(string filename, IPersistableCache<int> intCache, IPersistableCache<float> floatCache, IPersistableCache<string> stringCache, IPersistableCache<bool> boolCache, IPersistableCache<long> longCache)
		{
		}

		[Token(Token = "0x60051D5")]
		[Address(RVA = "0xAA0D9C", Offset = "0xAA0D9C", VA = "0xAA0D9C")]
		protected bool CreateFile(string filepath, bool replace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60051D6")]
		[Address(RVA = "0xAA0DEC", Offset = "0xAA0DEC", VA = "0xAA0DEC")]
		protected Dictionary<string, object> Read(string filename)
		{
			return null;
		}
	}
}
