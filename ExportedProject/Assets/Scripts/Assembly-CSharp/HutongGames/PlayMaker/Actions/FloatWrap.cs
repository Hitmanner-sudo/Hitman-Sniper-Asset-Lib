using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001054")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1980", Offset = "0x5A1980")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1980", Offset = "0x5A1980")]
	public class FloatWrap : FsmStateAction
	{
		[Token(Token = "0x4004CAD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFCD0", Offset = "0x5DFCD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DFCD0", Offset = "0x5DFCD0")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004CAE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFD30", Offset = "0x5DFD30")]
		[RequiredField]
		public FsmFloat minValue;

		[Token(Token = "0x4004CAF")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFD7C", Offset = "0x5DFD7C")]
		public FsmFloat maxValue;

		[Token(Token = "0x4004CB0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFDC8", Offset = "0x5DFDC8")]
		public bool everyFrame;

		[Token(Token = "0x60061B6")]
		[Address(RVA = "0x959AD4", Offset = "0x959AD4", VA = "0x959AD4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061B7")]
		[Address(RVA = "0x959AE4", Offset = "0x959AE4", VA = "0x959AE4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061B8")]
		[Address(RVA = "0x959BC4", Offset = "0x959BC4", VA = "0x959BC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061B9")]
		[Address(RVA = "0x959B20", Offset = "0x959B20", VA = "0x959B20")]
		private void DoWrap()
		{
		}

		[Token(Token = "0x60061BA")]
		[Address(RVA = "0x959BC8", Offset = "0x959BC8", VA = "0x959BC8")]
		public FloatWrap()
		{
		}
	}
}
