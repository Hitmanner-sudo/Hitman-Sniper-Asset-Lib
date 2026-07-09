using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C5E")]
	public interface IAPIControllerStrategy
	{
		[Token(Token = "0x6004D6C")]
		void RunCanExecuteTest(Action<bool> response);

		[Token(Token = "0x6004D6D")]
		int Throttle();
	}
}
