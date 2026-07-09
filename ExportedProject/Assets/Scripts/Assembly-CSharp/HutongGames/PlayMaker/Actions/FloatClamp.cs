using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1750", Offset = "0x5A1750")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1750", Offset = "0x5A1750")]
	public class FloatClamp : FsmStateAction
	{
		[Token(Token = "0x4004C85")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF424", Offset = "0x5DF424")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF424", Offset = "0x5DF424")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004C86")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF484", Offset = "0x5DF484")]
		[RequiredField]
		public FsmFloat minValue;

		[Token(Token = "0x4004C87")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF4D0", Offset = "0x5DF4D0")]
		[RequiredField]
		public FsmFloat maxValue;

		[Token(Token = "0x4004C88")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF51C", Offset = "0x5DF51C")]
		public bool everyFrame;

		[Token(Token = "0x6006196")]
		[Address(RVA = "0x958CE4", Offset = "0x958CE4", VA = "0x958CE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006197")]
		[Address(RVA = "0x958CF4", Offset = "0x958CF4", VA = "0x958CF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006198")]
		[Address(RVA = "0x958DAC", Offset = "0x958DAC", VA = "0x958DAC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006199")]
		[Address(RVA = "0x958D30", Offset = "0x958D30", VA = "0x958D30")]
		private void DoClamp()
		{
		}

		[Token(Token = "0x600619A")]
		[Address(RVA = "0x958DB0", Offset = "0x958DB0", VA = "0x958DB0")]
		public FloatClamp()
		{
		}
	}
}
