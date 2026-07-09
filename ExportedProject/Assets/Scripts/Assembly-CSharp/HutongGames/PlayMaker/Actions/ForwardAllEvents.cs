using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001149")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6618", Offset = "0x5A6618")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6618", Offset = "0x5A6618")]
	public class ForwardAllEvents : FsmStateAction
	{
		[Token(Token = "0x4005206")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F58E8", Offset = "0x5F58E8")]
		public FsmEventTarget forwardTo;

		[Token(Token = "0x4005207")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5920", Offset = "0x5F5920")]
		public FsmEvent[] exceptThese;

		[Token(Token = "0x4005208")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5958", Offset = "0x5F5958")]
		public bool eatEvents;

		[Token(Token = "0x6006643")]
		[Address(RVA = "0x95ADDC", Offset = "0x95ADDC", VA = "0x95ADDC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006644")]
		[Address(RVA = "0x95AF34", Offset = "0x95AF34", VA = "0x95AF34", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6006645")]
		[Address(RVA = "0x95AF40", Offset = "0x95AF40", VA = "0x95AF40", Slot = "31")]
		public override bool Event(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6006646")]
		[Address(RVA = "0x95AFD4", Offset = "0x95AFD4", VA = "0x95AFD4")]
		public ForwardAllEvents()
		{
		}
	}
}
