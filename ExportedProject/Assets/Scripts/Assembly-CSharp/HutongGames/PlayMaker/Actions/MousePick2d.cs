using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A31A0", Offset = "0x5A31A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A31A0", Offset = "0x5A31A0")]
	public class MousePick2d : FsmStateAction
	{
		[Token(Token = "0x4004E99")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7F90", Offset = "0x5E7F90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7F90", Offset = "0x5E7F90")]
		public FsmBool storeDidPickObject;

		[Token(Token = "0x4004E9A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7FE0", Offset = "0x5E7FE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7FE0", Offset = "0x5E7FE0")]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x4004E9B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8030", Offset = "0x5E8030")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8030", Offset = "0x5E8030")]
		public FsmVector2 storePoint;

		[Token(Token = "0x4004E9C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E8080", Offset = "0x5E8080")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8080", Offset = "0x5E8080")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E9D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E80D0", Offset = "0x5E80D0")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E9E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8108", Offset = "0x5E8108")]
		public bool everyFrame;

		[Token(Token = "0x6006354")]
		[Address(RVA = "0xA2D63C", Offset = "0xA2D63C", VA = "0xA2D63C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006355")]
		[Address(RVA = "0xA2D6AC", Offset = "0xA2D6AC", VA = "0xA2D6AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006356")]
		[Address(RVA = "0xA2D8F4", Offset = "0xA2D8F4", VA = "0xA2D8F4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006357")]
		[Address(RVA = "0xA2D6E8", Offset = "0xA2D6E8", VA = "0xA2D6E8")]
		private void DoMousePick2d()
		{
		}

		[Token(Token = "0x6006358")]
		[Address(RVA = "0xA2D8F8", Offset = "0xA2D8F8", VA = "0xA2D8F8")]
		public MousePick2d()
		{
		}
	}
}
