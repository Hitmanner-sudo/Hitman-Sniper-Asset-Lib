using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C56")]
	public class APIControllerStrategyOnline : IAPIControllerStrategy
	{
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0xA9A84C", Offset = "0xA9A84C", VA = "0xA9A84C", Slot = "4")]
		public void RunCanExecuteTest(Action<bool> response)
		{
		}

		[Token(Token = "0x6004D55")]
		[Address(RVA = "0xA9A8B0", Offset = "0xA9A8B0", VA = "0xA9A8B0", Slot = "5")]
		public int Throttle()
		{
			return default(int);
		}

		[Token(Token = "0x6004D56")]
		[Address(RVA = "0xA9A904", Offset = "0xA9A904", VA = "0xA9A904")]
		public APIControllerStrategyOnline()
		{
		}
	}
}
