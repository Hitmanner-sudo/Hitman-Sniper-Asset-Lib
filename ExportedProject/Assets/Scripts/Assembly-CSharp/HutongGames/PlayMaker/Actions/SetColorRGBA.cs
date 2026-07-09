using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F53")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C910", Offset = "0x59C910")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C910", Offset = "0x59C910")]
	public class SetColorRGBA : FsmStateAction
	{
		[Token(Token = "0x4004876")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF164", Offset = "0x5CF164")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF164", Offset = "0x5CF164")]
		public FsmColor colorVariable;

		[Token(Token = "0x4004877")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CF1C4", Offset = "0x5CF1C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF1C4", Offset = "0x5CF1C4")]
		public FsmFloat red;

		[Token(Token = "0x4004878")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CF218", Offset = "0x5CF218")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF218", Offset = "0x5CF218")]
		public FsmFloat green;

		[Token(Token = "0x4004879")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF26C", Offset = "0x5CF26C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CF26C", Offset = "0x5CF26C")]
		public FsmFloat blue;

		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CF2C0", Offset = "0x5CF2C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF2C0", Offset = "0x5CF2C0")]
		public FsmFloat alpha;

		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF314", Offset = "0x5CF314")]
		public bool everyFrame;

		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x1038A4C", Offset = "0x1038A4C", VA = "0x1038A4C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x1038AB0", Offset = "0x1038AB0", VA = "0x1038AB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x1038BDC", Offset = "0x1038BDC", VA = "0x1038BDC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x1038AEC", Offset = "0x1038AEC", VA = "0x1038AEC")]
		private void DoSetColorRGBA()
		{
		}

		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x1038BE0", Offset = "0x1038BE0", VA = "0x1038BE0")]
		public SetColorRGBA()
		{
		}
	}
}
