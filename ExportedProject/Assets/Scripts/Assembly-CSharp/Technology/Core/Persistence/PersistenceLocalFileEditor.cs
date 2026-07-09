using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D3F")]
	public class PersistenceLocalFileEditor<T> : AbstractPersistence<T>
	{
		[Token(Token = "0x60051B6")]
		public PersistenceLocalFileEditor(string key, [Optional] T defaultValue)
		{
		}

		[Token(Token = "0x60051B7")]
		protected override T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60051B8")]
		protected override void Set(T value)
		{
		}
	}
}
