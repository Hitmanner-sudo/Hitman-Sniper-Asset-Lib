using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D3E")]
	public class PersistenceLocalFile<T> : AbstractPersistence<T>
	{
		[Token(Token = "0x60051B3")]
		public PersistenceLocalFile(string key, [Optional] T defaultValue)
		{
		}

		[Token(Token = "0x60051B4")]
		protected override T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60051B5")]
		protected override void Set(T value)
		{
		}
	}
}
