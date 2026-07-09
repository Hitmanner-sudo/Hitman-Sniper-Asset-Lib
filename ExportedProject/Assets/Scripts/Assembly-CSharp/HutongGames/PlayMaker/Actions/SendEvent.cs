using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001171")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7964", Offset = "0x5A7964")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7964", Offset = "0x5A7964")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7964", Offset = "0x5A7964")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7964", Offset = "0x5A7964")]
	public class SendEvent : FsmStateAction
	{
		[Token(Token = "0x40052CF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F810C", Offset = "0x5F810C")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40052D0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8144", Offset = "0x5F8144")]
		[RequiredField]
		public FsmEvent sendEvent;

		[Token(Token = "0x40052D1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8190", Offset = "0x5F8190")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F8190", Offset = "0x5F8190")]
		public FsmFloat delay;

		[Token(Token = "0x40052D2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F81E4", Offset = "0x5F81E4")]
		public bool everyFrame;

		[Token(Token = "0x40052D3")]
		[FieldOffset(Offset = "0x70")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x60066FD")]
		[Address(RVA = "0xB70A78", Offset = "0xB70A78", VA = "0xB70A78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066FE")]
		[Address(RVA = "0xB70A88", Offset = "0xB70A88", VA = "0xB70A88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066FF")]
		[Address(RVA = "0xB70B3C", Offset = "0xB70B3C", VA = "0xB70B3C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006700")]
		[Address(RVA = "0xB70BA4", Offset = "0xB70BA4", VA = "0xB70BA4")]
		public SendEvent()
		{
		}
	}
}
