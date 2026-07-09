using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001268")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC9A4", Offset = "0x5AC9A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC9A4", Offset = "0x5AC9A4")]
	public class Vector2PerSecond : FsmStateAction
	{
		[Token(Token = "0x4005820")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A510", Offset = "0x60A510")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A510", Offset = "0x60A510")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x4005821")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A570", Offset = "0x60A570")]
		public bool everyFrame;

		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x13C6D78", Offset = "0x13C6D78", VA = "0x13C6D78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0x13C6D88", Offset = "0x13C6D88", VA = "0x13C6D88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0x13C6DEC", Offset = "0x13C6DEC", VA = "0x13C6DEC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0x13C6E2C", Offset = "0x13C6E2C", VA = "0x13C6E2C")]
		public Vector2PerSecond()
		{
		}
	}
}
