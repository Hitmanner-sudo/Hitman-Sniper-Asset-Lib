using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC634", Offset = "0x5AC634")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC634", Offset = "0x5AC634")]
	public class Vector2AddXY : FsmStateAction
	{
		[Token(Token = "0x40057E8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609934", Offset = "0x609934")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609934", Offset = "0x609934")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057E9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609994", Offset = "0x609994")]
		public FsmFloat addX;

		[Token(Token = "0x40057EA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6099CC", Offset = "0x6099CC")]
		public FsmFloat addY;

		[Token(Token = "0x40057EB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609A04", Offset = "0x609A04")]
		public bool everyFrame;

		[Token(Token = "0x40057EC")]
		[FieldOffset(Offset = "0x69")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609A3C", Offset = "0x609A3C")]
		public bool perSecond;

		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0x13C5DC8", Offset = "0x13C5DC8", VA = "0x13C5DC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B6D")]
		[Address(RVA = "0x13C5E0C", Offset = "0x13C5E0C", VA = "0x13C5E0C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B6E")]
		[Address(RVA = "0x13C5EE0", Offset = "0x13C5EE0", VA = "0x13C5EE0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0x13C5E48", Offset = "0x13C5E48", VA = "0x13C5E48")]
		private void DoVector2AddXYZ()
		{
		}

		[Token(Token = "0x6006B70")]
		[Address(RVA = "0x13C5EE4", Offset = "0x13C5EE4", VA = "0x13C5EE4")]
		public Vector2AddXY()
		{
		}
	}
}
