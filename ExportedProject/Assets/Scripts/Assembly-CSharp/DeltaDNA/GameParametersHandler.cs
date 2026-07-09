using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200133D")]
	public class GameParametersHandler : EventActionHandler
	{
		[Token(Token = "0x4005C25")]
		[FieldOffset(Offset = "0x10")]
		private readonly Action<Dictionary<string, object>> callback;

		[Token(Token = "0x600712F")]
		[Address(RVA = "0xD9A3DC", Offset = "0xD9A3DC", VA = "0xD9A3DC")]
		public GameParametersHandler(Action<Dictionary<string, object>> callback)
		{
		}

		[Token(Token = "0x6007130")]
		[Address(RVA = "0xD9A408", Offset = "0xD9A408", VA = "0xD9A408", Slot = "4")]
		internal override bool Handle(EventTrigger trigger, ActionStore store)
		{
			return default(bool);
		}

		[Token(Token = "0x6007131")]
		[Address(RVA = "0xD9A628", Offset = "0xD9A628", VA = "0xD9A628", Slot = "5")]
		internal override string Type()
		{
			return null;
		}
	}
}
