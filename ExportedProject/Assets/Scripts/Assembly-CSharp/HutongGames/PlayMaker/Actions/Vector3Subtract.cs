using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001282")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD174", Offset = "0x5AD174")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD174", Offset = "0x5AD174")]
	public class Vector3Subtract : FsmStateAction
	{
		[Token(Token = "0x400588C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BE90", Offset = "0x60BE90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BE90", Offset = "0x60BE90")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400588D")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BEF0", Offset = "0x60BEF0")]
		public FsmVector3 subtractVector;

		[Token(Token = "0x400588E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BF3C", Offset = "0x60BF3C")]
		public bool everyFrame;

		[Token(Token = "0x6006C0B")]
		[Address(RVA = "0x13C92B4", Offset = "0x13C92B4", VA = "0x13C92B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C0C")]
		[Address(RVA = "0x13C9328", Offset = "0x13C9328", VA = "0x13C9328", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C0D")]
		[Address(RVA = "0x13C93C0", Offset = "0x13C93C0", VA = "0x13C93C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C0E")]
		[Address(RVA = "0x13C9434", Offset = "0x13C9434", VA = "0x13C9434")]
		public Vector3Subtract()
		{
		}
	}
}
