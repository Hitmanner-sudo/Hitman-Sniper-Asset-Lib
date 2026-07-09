using System;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D23")]
	[Flags]
	public enum PersistorState
	{
		[Token(Token = "0x4003ED1")]
		INITIALIZING = 0,
		[Token(Token = "0x4003ED2")]
		LOADING = 1,
		[Token(Token = "0x4003ED3")]
		LOADED = 2,
		[Token(Token = "0x4003ED4")]
		SAVING = 4,
		[Token(Token = "0x4003ED5")]
		SAVED = 0x10
	}
}
