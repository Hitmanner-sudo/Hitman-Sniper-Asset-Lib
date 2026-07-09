using System;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C74")]
	public static class TriggerEventExtensions
	{
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0xC9EBD0", Offset = "0xC9EBD0", VA = "0xC9EBD0")]
		public static void RaiseEvent(this TriggerEvent handler, object sender)
		{
		}

		[Token(Token = "0x6004DA5")]
		public static void RaiseEvent<T>(this TriggerEvent<T> handler, object sender, T args) where T : EventArgs
		{
		}
	}
}
