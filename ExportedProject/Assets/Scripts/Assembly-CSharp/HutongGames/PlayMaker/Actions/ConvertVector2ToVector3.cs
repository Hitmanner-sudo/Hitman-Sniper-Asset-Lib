using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CD94", Offset = "0x59CD94")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CD94", Offset = "0x59CD94")]
	public class ConvertVector2ToVector3 : FsmStateAction
	{
		[Token(Token = "0x40048BB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0294", Offset = "0x5D0294")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0294", Offset = "0x5D0294")]
		public FsmVector2 vector2;

		[Token(Token = "0x40048BC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D02E4", Offset = "0x5D02E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D02E4", Offset = "0x5D02E4")]
		public FsmVector3 vector3;

		[Token(Token = "0x40048BD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0334", Offset = "0x5D0334")]
		public FsmFloat zValue;

		[Token(Token = "0x40048BE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D036C", Offset = "0x5D036C")]
		public bool everyFrame;

		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0xD7FEE8", Offset = "0xD7FEE8", VA = "0xD7FEE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0xD7FEF4", Offset = "0xD7FEF4", VA = "0xD7FEF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0xD7FF68", Offset = "0xD7FF68", VA = "0xD7FF68", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0xD7FFB4", Offset = "0xD7FFB4", VA = "0xD7FFB4")]
		public ConvertVector2ToVector3()
		{
		}
	}
}
