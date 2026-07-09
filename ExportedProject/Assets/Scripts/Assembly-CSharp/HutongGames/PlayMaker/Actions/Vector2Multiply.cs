using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001264")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC8B4", Offset = "0x5AC8B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC8B4", Offset = "0x5AC8B4")]
	public class Vector2Multiply : FsmStateAction
	{
		[Token(Token = "0x400580B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A1EC", Offset = "0x60A1EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A1EC", Offset = "0x60A1EC")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x400580C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A24C", Offset = "0x60A24C")]
		[RequiredField]
		public FsmFloat multiplyBy;

		[Token(Token = "0x400580D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A298", Offset = "0x60A298")]
		public bool everyFrame;

		[Token(Token = "0x6006B8F")]
		[Address(RVA = "0x13C6908", Offset = "0x13C6908", VA = "0x13C6908", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B90")]
		[Address(RVA = "0x13C693C", Offset = "0x13C693C", VA = "0x13C693C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B91")]
		[Address(RVA = "0x13C69A8", Offset = "0x13C69A8", VA = "0x13C69A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B92")]
		[Address(RVA = "0x13C69F0", Offset = "0x13C69F0", VA = "0x13C69F0")]
		public Vector2Multiply()
		{
		}
	}
}
