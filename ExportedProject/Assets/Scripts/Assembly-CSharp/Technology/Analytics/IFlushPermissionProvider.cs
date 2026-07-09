using System;
using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E5A")]
	public interface IFlushPermissionProvider
	{
		[Token(Token = "0x17000BDB")]
		bool CanFlush
		{
			[Token(Token = "0x6005872")]
			get;
		}

		[Token(Token = "0x1400017D")]
		event Action<bool> CanFlushStateChanged;
	}
}
