using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F50")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C820", Offset = "0x59C820")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C820", Offset = "0x59C820")]
	public class ColorRamp : FsmStateAction
	{
		[Token(Token = "0x4004869")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CED18", Offset = "0x5CED18")]
		public FsmColor[] colors;

		[Token(Token = "0x400486A")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CED64", Offset = "0x5CED64")]
		public FsmFloat sampleAt;

		[Token(Token = "0x400486B")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEDB0", Offset = "0x5CEDB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEDB0", Offset = "0x5CEDB0")]
		public FsmColor storeColor;

		[Token(Token = "0x400486C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEE10", Offset = "0x5CEE10")]
		public bool everyFrame;

		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x8DB3C4", Offset = "0x8DB3C4", VA = "0x8DB3C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0x8DB42C", Offset = "0x8DB42C", VA = "0x8DB42C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0x8DB5E8", Offset = "0x8DB5E8", VA = "0x8DB5E8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0x8DB468", Offset = "0x8DB468", VA = "0x8DB468")]
		private void DoColorRamp()
		{
		}

		[Token(Token = "0x6005DAA")]
		[Address(RVA = "0x8DB5EC", Offset = "0x8DB5EC", VA = "0x8DB5EC", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005DAB")]
		[Address(RVA = "0x8DB64C", Offset = "0x8DB64C", VA = "0x8DB64C")]
		public ColorRamp()
		{
		}
	}
}
