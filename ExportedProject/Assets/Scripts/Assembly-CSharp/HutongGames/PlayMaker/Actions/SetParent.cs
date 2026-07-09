using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FED")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F800", Offset = "0x59F800")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F800", Offset = "0x59F800")]
	public class SetParent : FsmStateAction
	{
		[Token(Token = "0x4004AD3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8110", Offset = "0x5D8110")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AD4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D815C", Offset = "0x5D815C")]
		public FsmGameObject parent;

		[Token(Token = "0x4004AD5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8194", Offset = "0x5D8194")]
		public FsmBool worldPositionStays;

		[Token(Token = "0x4004AD6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D81CC", Offset = "0x5D81CC")]
		public FsmBool resetLocalPosition;

		[Token(Token = "0x4004AD7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8204", Offset = "0x5D8204")]
		public FsmBool resetLocalRotation;

		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x104123C", Offset = "0x104123C", VA = "0x104123C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x1041270", Offset = "0x1041270", VA = "0x1041270", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x1041430", Offset = "0x1041430", VA = "0x1041430")]
		public SetParent()
		{
		}
	}
}
