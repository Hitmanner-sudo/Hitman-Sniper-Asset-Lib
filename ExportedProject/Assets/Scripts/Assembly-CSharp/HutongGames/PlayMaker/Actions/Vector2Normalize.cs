using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001265")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC904", Offset = "0x5AC904")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC904", Offset = "0x5AC904")]
	public class Vector2Normalize : FsmStateAction
	{
		[Token(Token = "0x400580E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A2D0", Offset = "0x60A2D0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A2D0", Offset = "0x60A2D0")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x400580F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A330", Offset = "0x60A330")]
		public bool everyFrame;

		[Token(Token = "0x6006B93")]
		[Address(RVA = "0x13C69F8", Offset = "0x13C69F8", VA = "0x13C69F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B94")]
		[Address(RVA = "0x13C6A04", Offset = "0x13C6A04", VA = "0x13C6A04", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B95")]
		[Address(RVA = "0x13C6A64", Offset = "0x13C6A64", VA = "0x13C6A64", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B96")]
		[Address(RVA = "0x13C6AA4", Offset = "0x13C6AA4", VA = "0x13C6AA4")]
		public Vector2Normalize()
		{
		}
	}
}
