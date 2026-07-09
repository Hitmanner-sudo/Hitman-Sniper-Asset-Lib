using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001004")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FECC", Offset = "0x59FECC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FECC", Offset = "0x59FECC")]
	public class MousePick : FsmStateAction
	{
		[Token(Token = "0x4004B33")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9704", Offset = "0x5D9704")]
		public FsmFloat rayDistance;

		[Token(Token = "0x4004B34")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9750", Offset = "0x5D9750")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9750", Offset = "0x5D9750")]
		public FsmBool storeDidPickObject;

		[Token(Token = "0x4004B35")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D97A0", Offset = "0x5D97A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D97A0", Offset = "0x5D97A0")]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x4004B36")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D97F0", Offset = "0x5D97F0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D97F0", Offset = "0x5D97F0")]
		public FsmVector3 storePoint;

		[Token(Token = "0x4004B37")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9840", Offset = "0x5D9840")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9840", Offset = "0x5D9840")]
		public FsmVector3 storeNormal;

		[Token(Token = "0x4004B38")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9890", Offset = "0x5D9890")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D9890", Offset = "0x5D9890")]
		public FsmFloat storeDistance;

		[Token(Token = "0x4004B39")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D98E0", Offset = "0x5D98E0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D98E0", Offset = "0x5D98E0")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004B3A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9930", Offset = "0x5D9930")]
		public FsmBool invertMask;

		[Token(Token = "0x4004B3B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9968", Offset = "0x5D9968")]
		public bool everyFrame;

		[Token(Token = "0x600604D")]
		[Address(RVA = "0xA2D360", Offset = "0xA2D360", VA = "0xA2D360", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600604E")]
		[Address(RVA = "0xA2D3E4", Offset = "0xA2D3E4", VA = "0xA2D3E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600604F")]
		[Address(RVA = "0xA2D600", Offset = "0xA2D600", VA = "0xA2D600", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006050")]
		[Address(RVA = "0xA2D420", Offset = "0xA2D420", VA = "0xA2D420")]
		private void DoMousePick()
		{
		}

		[Token(Token = "0x6006051")]
		[Address(RVA = "0xA2D604", Offset = "0xA2D604", VA = "0xA2D604")]
		public MousePick()
		{
		}
	}
}
