using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001144")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6428", Offset = "0x5A6428")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6428", Offset = "0x5A6428")]
	public class BlockEvents : FsmStateAction
	{
		[Token(Token = "0x2001145")]
		public enum Options
		{
			[Token(Token = "0x40051F7")]
			Timeout = 0,
			[Token(Token = "0x40051F8")]
			WhileTrue = 1,
			[Token(Token = "0x40051F9")]
			WhileFalse = 2,
			[Token(Token = "0x40051FA")]
			UntilTrue = 3,
			[Token(Token = "0x40051FB")]
			UntilFalse = 4,
			[Token(Token = "0x40051FC")]
			UntilEvent = 5
		}

		[Token(Token = "0x40051F0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5594", Offset = "0x5F5594")]
		public Options condition;

		[Token(Token = "0x40051F1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F55CC", Offset = "0x5F55CC")]
		public FsmFloat floatParam;

		[Token(Token = "0x40051F2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5604", Offset = "0x5F5604")]
		public FsmBool boolParam;

		[Token(Token = "0x40051F3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F563C", Offset = "0x5F563C")]
		[EventNotSent]
		public FsmEvent eventParam;

		[Token(Token = "0x40051F4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ActionSection", RVA = "0x5F5688", Offset = "0x5F5688")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5688", Offset = "0x5F5688")]
		public FsmBool logBlockedEvents;

		[Token(Token = "0x40051F5")]
		[FieldOffset(Offset = "0x70")]
		private bool firstTime;

		[Token(Token = "0x6006632")]
		[Address(RVA = "0xC68CC8", Offset = "0xC68CC8", VA = "0xC68CC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006633")]
		[Address(RVA = "0xC68D04", Offset = "0xC68D04", VA = "0xC68D04", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6006634")]
		[Address(RVA = "0xC68D10", Offset = "0xC68D10", VA = "0xC68D10", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006635")]
		[Address(RVA = "0xC68E44", Offset = "0xC68E44", VA = "0xC68E44", Slot = "31")]
		public override bool Event(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6006636")]
		[Address(RVA = "0xC68FF4", Offset = "0xC68FF4", VA = "0xC68FF4")]
		private bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x6006637")]
		[Address(RVA = "0xC69098", Offset = "0xC69098", VA = "0xC69098")]
		private bool DoBlockEvent(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6006638")]
		[Address(RVA = "0xC69208", Offset = "0xC69208", VA = "0xC69208")]
		public BlockEvents()
		{
		}
	}
}
