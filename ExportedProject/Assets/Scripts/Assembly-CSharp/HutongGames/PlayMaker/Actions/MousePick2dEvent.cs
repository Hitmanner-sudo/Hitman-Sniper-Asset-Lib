using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A31F0", Offset = "0x5A31F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A31F0", Offset = "0x5A31F0")]
	public class MousePick2dEvent : FsmStateAction
	{
		[Token(Token = "0x4004E9F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E8140", Offset = "0x5E8140")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8140", Offset = "0x5E8140")]
		public FsmOwnerDefault GameObject;

		[Token(Token = "0x4004EA0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E81C4", Offset = "0x5E81C4")]
		public FsmEvent mouseOver;

		[Token(Token = "0x4004EA1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E81FC", Offset = "0x5E81FC")]
		public FsmEvent mouseDown;

		[Token(Token = "0x4004EA2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8234", Offset = "0x5E8234")]
		public FsmEvent mouseUp;

		[Token(Token = "0x4004EA3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E826C", Offset = "0x5E826C")]
		public FsmEvent mouseOff;

		[Token(Token = "0x4004EA4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E82A4", Offset = "0x5E82A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E82A4", Offset = "0x5E82A4")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004EA5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E82F4", Offset = "0x5E82F4")]
		public FsmBool invertMask;

		[Token(Token = "0x4004EA6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E832C", Offset = "0x5E832C")]
		public bool everyFrame;

		[Token(Token = "0x6006359")]
		[Address(RVA = "0xA2D900", Offset = "0xA2D900", VA = "0xA2D900", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600635A")]
		[Address(RVA = "0xA2D978", Offset = "0xA2D978", VA = "0xA2D978", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600635B")]
		[Address(RVA = "0xA2DA68", Offset = "0xA2DA68", VA = "0xA2DA68", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600635C")]
		[Address(RVA = "0xA2D9B4", Offset = "0xA2D9B4", VA = "0xA2D9B4")]
		private void DoMousePickEvent()
		{
		}

		[Token(Token = "0x600635D")]
		[Address(RVA = "0xA2DA6C", Offset = "0xA2DA6C", VA = "0xA2DA6C")]
		private bool DoRaycast()
		{
			return default(bool);
		}

		[Token(Token = "0x600635E")]
		[Address(RVA = "0xA2DCC0", Offset = "0xA2DCC0", VA = "0xA2DCC0")]
		public MousePick2dEvent()
		{
		}
	}
}
