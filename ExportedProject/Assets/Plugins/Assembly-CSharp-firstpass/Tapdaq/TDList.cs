using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000069")]
	public class TDList<T>
	{
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x0")]
		public List<T> items;

		[Token(Token = "0x600029A")]
		public TDList()
		{
		}
	}
}
