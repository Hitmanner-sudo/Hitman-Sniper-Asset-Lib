using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001260")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC774", Offset = "0x5AC774")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC774", Offset = "0x5AC774")]
	public class Vector2Invert : FsmStateAction
	{
		[Token(Token = "0x40057FC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609DDC", Offset = "0x609DDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609DDC", Offset = "0x609DDC")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057FD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609E3C", Offset = "0x609E3C")]
		public bool everyFrame;

		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0x13C64D0", Offset = "0x13C64D0", VA = "0x13C64D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B7F")]
		[Address(RVA = "0x13C64DC", Offset = "0x13C64DC", VA = "0x13C64DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B80")]
		[Address(RVA = "0x13C6510", Offset = "0x13C6510", VA = "0x13C6510", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B81")]
		[Address(RVA = "0x13C6534", Offset = "0x13C6534", VA = "0x13C6534")]
		public Vector2Invert()
		{
		}
	}
}
