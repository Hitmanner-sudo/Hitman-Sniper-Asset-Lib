using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001005")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FF1C", Offset = "0x59FF1C")]
	[Attribute(Name = "ActionTarget", RVA = "0x59FF1C", Offset = "0x59FF1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FF1C", Offset = "0x59FF1C")]
	public class MousePickEvent : FsmStateAction
	{
		[Token(Token = "0x4004B3C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5D99A0", Offset = "0x5D99A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D99A0", Offset = "0x5D99A0")]
		public FsmOwnerDefault GameObject;

		[Token(Token = "0x4004B3D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9A24", Offset = "0x5D9A24")]
		public FsmFloat rayDistance;

		[Token(Token = "0x4004B3E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9A5C", Offset = "0x5D9A5C")]
		public FsmEvent mouseOver;

		[Token(Token = "0x4004B3F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9A94", Offset = "0x5D9A94")]
		public FsmEvent mouseDown;

		[Token(Token = "0x4004B40")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9ACC", Offset = "0x5D9ACC")]
		public FsmEvent mouseUp;

		[Token(Token = "0x4004B41")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9B04", Offset = "0x5D9B04")]
		public FsmEvent mouseOff;

		[Token(Token = "0x4004B42")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9B3C", Offset = "0x5D9B3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9B3C", Offset = "0x5D9B3C")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004B43")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9B8C", Offset = "0x5D9B8C")]
		public FsmBool invertMask;

		[Token(Token = "0x4004B44")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9BC4", Offset = "0x5D9BC4")]
		public bool everyFrame;

		[Token(Token = "0x6006052")]
		[Address(RVA = "0xA2DCC8", Offset = "0xA2DCC8", VA = "0xA2DCC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006053")]
		[Address(RVA = "0xA2DD54", Offset = "0xA2DD54", VA = "0xA2DD54", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006054")]
		[Address(RVA = "0xA2DEB0", Offset = "0xA2DEB0", VA = "0xA2DEB0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006055")]
		[Address(RVA = "0xA2DD90", Offset = "0xA2DD90", VA = "0xA2DD90")]
		private void DoMousePickEvent()
		{
		}

		[Token(Token = "0x6006056")]
		[Address(RVA = "0xA2DEB4", Offset = "0xA2DEB4", VA = "0xA2DEB4")]
		private bool DoRaycast()
		{
			return default(bool);
		}

		[Token(Token = "0x6006057")]
		[Address(RVA = "0xA2DF50", Offset = "0xA2DF50", VA = "0xA2DF50", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6006058")]
		[Address(RVA = "0xA2DFF4", Offset = "0xA2DFF4", VA = "0xA2DFF4")]
		public MousePickEvent()
		{
		}
	}
}
