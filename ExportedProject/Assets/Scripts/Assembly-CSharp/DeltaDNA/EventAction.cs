using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x200133B")]
	public sealed class EventAction
	{
		[Token(Token = "0x4005C1F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ReadOnlyCollection<EventTrigger> EMPTY_TRIGGERS;

		[Token(Token = "0x4005C20")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameEvent evnt;

		[Token(Token = "0x4005C21")]
		[FieldOffset(Offset = "0x18")]
		private readonly ReadOnlyCollection<EventTrigger> triggers;

		[Token(Token = "0x4005C22")]
		[FieldOffset(Offset = "0x20")]
		private readonly Settings settings;

		[Token(Token = "0x4005C23")]
		[FieldOffset(Offset = "0x28")]
		private readonly ActionStore store;

		[Token(Token = "0x4005C24")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<EventActionHandler> handlers;

		[Token(Token = "0x6007127")]
		[Address(RVA = "0xE16A44", Offset = "0xE16A44", VA = "0xE16A44")]
		internal EventAction(GameEvent evnt, ReadOnlyCollection<EventTrigger> triggers, ActionStore store, Settings settings)
		{
		}

		[Token(Token = "0x6007128")]
		[Address(RVA = "0xE16AE8", Offset = "0xE16AE8", VA = "0xE16AE8")]
		public EventAction Add(EventActionHandler handler)
		{
			return null;
		}

		[Token(Token = "0x6007129")]
		[Address(RVA = "0xE16B80", Offset = "0xE16B80", VA = "0xE16B80")]
		public void Run()
		{
		}

		[Token(Token = "0x600712A")]
		[Address(RVA = "0xE17110", Offset = "0xE17110", VA = "0xE17110")]
		internal static EventAction CreateEmpty(GameEvent evnt)
		{
			return null;
		}
	}
}
