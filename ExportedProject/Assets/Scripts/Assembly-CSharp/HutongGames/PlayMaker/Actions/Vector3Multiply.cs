using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200127B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACF94", Offset = "0x5ACF94")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACF94", Offset = "0x5ACF94")]
	public class Vector3Multiply : FsmStateAction
	{
		[Token(Token = "0x400586B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B8D4", Offset = "0x60B8D4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B8D4", Offset = "0x60B8D4")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400586C")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B934", Offset = "0x60B934")]
		public FsmFloat multiplyBy;

		[Token(Token = "0x400586D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B980", Offset = "0x60B980")]
		public bool everyFrame;

		[Token(Token = "0x6006BF2")]
		[Address(RVA = "0x13C8808", Offset = "0x13C8808", VA = "0x13C8808", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BF3")]
		[Address(RVA = "0x13C883C", Offset = "0x13C883C", VA = "0x13C883C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BF4")]
		[Address(RVA = "0x13C88D4", Offset = "0x13C88D4", VA = "0x13C88D4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BF5")]
		[Address(RVA = "0x13C8948", Offset = "0x13C8948", VA = "0x13C8948")]
		public Vector3Multiply()
		{
		}
	}
}
