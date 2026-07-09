using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CA7")]
	[Flags]
	public enum OSRequestState
	{
		[Token(Token = "0x4003D78")]
		Initialized = 0,
		[Token(Token = "0x4003D79")]
		Complete = 1,
		[Token(Token = "0x4003D7A")]
		Cancelled = 2,
		[Token(Token = "0x4003D7B")]
		Error = 4,
		[Token(Token = "0x4003D7C")]
		ErrorOrCancelled = 6
	}
}
