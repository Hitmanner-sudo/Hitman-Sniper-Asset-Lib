using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CB40", Offset = "0x59CB40")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CB40", Offset = "0x59CB40")]
	public class ConvertFloatToInt : FsmStateAction
	{
		[Token(Token = "0x2000F5D")]
		public enum FloatRounding
		{
			[Token(Token = "0x40048A3")]
			RoundDown = 0,
			[Token(Token = "0x40048A4")]
			RoundUp = 1,
			[Token(Token = "0x40048A5")]
			Nearest = 2
		}

		[Token(Token = "0x400489E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFAD8", Offset = "0x5CFAD8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFAD8", Offset = "0x5CFAD8")]
		public FsmFloat floatVariable;

		[Token(Token = "0x400489F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFB38", Offset = "0x5CFB38")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFB38", Offset = "0x5CFB38")]
		[RequiredField]
		public FsmInt intVariable;

		[Token(Token = "0x40048A0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFB98", Offset = "0x5CFB98")]
		public FloatRounding rounding;

		[Token(Token = "0x40048A1")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFBD0", Offset = "0x5CFBD0")]
		public bool everyFrame;

		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0xD7F48C", Offset = "0xD7F48C", VA = "0xD7F48C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0xD7F4A0", Offset = "0xD7F4A0", VA = "0xD7F4A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0xD7F588", Offset = "0xD7F588", VA = "0xD7F588", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0xD7F4DC", Offset = "0xD7F4DC", VA = "0xD7F4DC")]
		private void DoConvertFloatToInt()
		{
		}

		[Token(Token = "0x6005DED")]
		[Address(RVA = "0xD7F58C", Offset = "0xD7F58C", VA = "0xD7F58C")]
		public ConvertFloatToInt()
		{
		}
	}
}
