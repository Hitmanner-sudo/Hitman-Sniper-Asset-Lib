using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6668", Offset = "0x5A6668")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6668", Offset = "0x5A6668")]
	public class ForwardEvent : FsmStateAction
	{
		[Token(Token = "0x4005209")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5990", Offset = "0x5F5990")]
		public FsmEventTarget forwardTo;

		[Token(Token = "0x400520A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F59C8", Offset = "0x5F59C8")]
		public FsmEvent[] eventsToForward;

		[Token(Token = "0x400520B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5A00", Offset = "0x5F5A00")]
		public bool eatEvents;

		[Token(Token = "0x6006647")]
		[Address(RVA = "0x95AFDC", Offset = "0x95AFDC", VA = "0x95AFDC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006648")]
		[Address(RVA = "0x95B050", Offset = "0x95B050", VA = "0x95B050", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6006649")]
		[Address(RVA = "0x95B05C", Offset = "0x95B05C", VA = "0x95B05C", Slot = "31")]
		public override bool Event(FsmEvent fsmEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600664A")]
		[Address(RVA = "0x95B0F0", Offset = "0x95B0F0", VA = "0x95B0F0")]
		public ForwardEvent()
		{
		}
	}
}
