using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001172")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7A68", Offset = "0x5A7A68")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7A68", Offset = "0x5A7A68")]
	public class SendEventByName : FsmStateAction
	{
		[Token(Token = "0x40052D4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F821C", Offset = "0x5F821C")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40052D5")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8254", Offset = "0x5F8254")]
		public FsmString sendEvent;

		[Token(Token = "0x40052D6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F82A0", Offset = "0x5F82A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F82A0", Offset = "0x5F82A0")]
		public FsmFloat delay;

		[Token(Token = "0x40052D7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F82F4", Offset = "0x5F82F4")]
		public bool everyFrame;

		[Token(Token = "0x40052D8")]
		[FieldOffset(Offset = "0x70")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x6006701")]
		[Address(RVA = "0xB70BAC", Offset = "0xB70BAC", VA = "0xB70BAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006702")]
		[Address(RVA = "0xB70BBC", Offset = "0xB70BBC", VA = "0xB70BBC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006703")]
		[Address(RVA = "0xB70CE8", Offset = "0xB70CE8", VA = "0xB70CE8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006704")]
		[Address(RVA = "0xB70D6C", Offset = "0xB70D6C", VA = "0xB70D6C")]
		public SendEventByName()
		{
		}
	}
}
