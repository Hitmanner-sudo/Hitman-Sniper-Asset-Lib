using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F51")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C870", Offset = "0x59C870")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C870", Offset = "0x59C870")]
	public class GetColorRGBA : FsmStateAction
	{
		[Token(Token = "0x400486D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEE48", Offset = "0x5CEE48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEE48", Offset = "0x5CEE48")]
		public FsmColor color;

		[Token(Token = "0x400486E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEEA8", Offset = "0x5CEEA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEEA8", Offset = "0x5CEEA8")]
		public FsmFloat storeRed;

		[Token(Token = "0x400486F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEEF8", Offset = "0x5CEEF8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEEF8", Offset = "0x5CEEF8")]
		public FsmFloat storeGreen;

		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEF48", Offset = "0x5CEF48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEF48", Offset = "0x5CEF48")]
		public FsmFloat storeBlue;

		[Token(Token = "0x4004871")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEF98", Offset = "0x5CEF98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEF98", Offset = "0x5CEF98")]
		public FsmFloat storeAlpha;

		[Token(Token = "0x4004872")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEFE8", Offset = "0x5CEFE8")]
		public bool everyFrame;

		[Token(Token = "0x6005DAC")]
		[Address(RVA = "0x105EA3C", Offset = "0x105EA3C", VA = "0x105EA3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0x105EA50", Offset = "0x105EA50", VA = "0x105EA50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0x105EB20", Offset = "0x105EB20", VA = "0x105EB20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0x105EA8C", Offset = "0x105EA8C", VA = "0x105EA8C")]
		private void DoGetColorRGBA()
		{
		}

		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x105EB24", Offset = "0x105EB24", VA = "0x105EB24")]
		public GetColorRGBA()
		{
		}
	}
}
