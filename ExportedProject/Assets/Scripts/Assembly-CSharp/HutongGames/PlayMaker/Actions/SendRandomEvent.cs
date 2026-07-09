using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001174")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7B2C", Offset = "0x5A7B2C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7B2C", Offset = "0x5A7B2C")]
	public class SendRandomEvent : FsmStateAction
	{
		[Token(Token = "0x40052E0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5F847C", Offset = "0x5F847C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F847C", Offset = "0x5F847C")]
		public FsmEvent[] events;

		[Token(Token = "0x40052E1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F850C", Offset = "0x5F850C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F850C", Offset = "0x5F850C")]
		public FsmFloat[] weights;

		[Token(Token = "0x40052E2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8560", Offset = "0x5F8560")]
		public FsmFloat delay;

		[Token(Token = "0x40052E3")]
		[FieldOffset(Offset = "0x68")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x6006709")]
		[Address(RVA = "0xB718C0", Offset = "0xB718C0", VA = "0xB718C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600670A")]
		[Address(RVA = "0xB71A08", Offset = "0xB71A08", VA = "0xB71A08", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600670B")]
		[Address(RVA = "0xB71AF8", Offset = "0xB71AF8", VA = "0xB71AF8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600670C")]
		[Address(RVA = "0xB71B38", Offset = "0xB71B38", VA = "0xB71B38")]
		public SendRandomEvent()
		{
		}
	}
}
