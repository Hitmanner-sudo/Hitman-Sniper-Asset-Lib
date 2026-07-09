using System;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001167")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A7664", Offset = "0x5A7664")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A7664", Offset = "0x5A7664")]
	public class IgnoreEvents : FsmStateAction
	{
		[Serializable]
		[Token(Token = "0x2001168")]
		public enum EventType
		{
			[Token(Token = "0x40052B2")]
			mouse = 0,
			[Token(Token = "0x40052B3")]
			application = 1,
			[Token(Token = "0x40052B4")]
			collision = 2,
			[Token(Token = "0x40052B5")]
			collision2d = 3,
			[Token(Token = "0x40052B6")]
			trigger = 4,
			[Token(Token = "0x40052B7")]
			trigger2d = 5,
			[Token(Token = "0x40052B8")]
			UI = 6,
			[Token(Token = "0x40052B9")]
			anyUnityEvent = 7
		}

		[Token(Token = "0x40052AE")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F7C50", Offset = "0x5F7C50")]
		public EventType[] eventTypes;

		[Token(Token = "0x40052AF")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F7C88", Offset = "0x5F7C88")]
		[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x5F7C88", Offset = "0x5F7C88")]
		public FsmString[] events;

		[Token(Token = "0x40052B0")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5F7CD8", Offset = "0x5F7CD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5F7CD8", Offset = "0x5F7CD8")]
		public FsmBool logIgnoredEvents;

		[Token(Token = "0x60066C3")]
		[Address(RVA = "0xA165B4", Offset = "0xA165B4", VA = "0xA165B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066C4")]
		[Address(RVA = "0xA1663C", Offset = "0xA1663C", VA = "0xA1663C", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60066C5")]
		[Address(RVA = "0xA16668", Offset = "0xA16668", VA = "0xA16668", Slot = "31")]
		public override bool Event(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x60066C6")]
		[Address(RVA = "0xA16728", Offset = "0xA16728", VA = "0xA16728")]
		private bool DoIgnoreEvent(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x60066C7")]
		[Address(RVA = "0xA168F4", Offset = "0xA168F4", VA = "0xA168F4")]
		public IgnoreEvents()
		{
		}
	}
}
