using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACAE4", Offset = "0x5ACAE4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACAE4", Offset = "0x5ACAE4")]
	public class Vector2Subtract : FsmStateAction
	{
		[Token(Token = "0x400582E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A854", Offset = "0x60A854")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A854", Offset = "0x60A854")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x400582F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A8B4", Offset = "0x60A8B4")]
		public FsmVector2 subtractVector;

		[Token(Token = "0x4005830")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A900", Offset = "0x60A900")]
		public bool everyFrame;

		[Token(Token = "0x6006BAE")]
		[Address(RVA = "0x13C7788", Offset = "0x13C7788", VA = "0x13C7788", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BAF")]
		[Address(RVA = "0x13C77FC", Offset = "0x13C77FC", VA = "0x13C77FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BB0")]
		[Address(RVA = "0x13C7844", Offset = "0x13C7844", VA = "0x13C7844", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BB1")]
		[Address(RVA = "0x13C7878", Offset = "0x13C7878", VA = "0x13C7878")]
		public Vector2Subtract()
		{
		}
	}
}
