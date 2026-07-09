using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F97")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DC40", Offset = "0x59DC40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DC40", Offset = "0x59DC40")]
	public class GUIHorizontalSlider : GUIAction
	{
		[Token(Token = "0x40049AC")]
		[FieldOffset(Offset = "0x90")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D3760", Offset = "0x5D3760")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3760", Offset = "0x5D3760")]
		public FsmFloat floatVariable;

		[Token(Token = "0x40049AD")]
		[FieldOffset(Offset = "0x98")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D37C0", Offset = "0x5D37C0")]
		public FsmFloat leftValue;

		[Token(Token = "0x40049AE")]
		[FieldOffset(Offset = "0xA0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D380C", Offset = "0x5D380C")]
		public FsmFloat rightValue;

		[Token(Token = "0x40049AF")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3858", Offset = "0x5D3858")]
		public FsmString sliderStyle;

		[Token(Token = "0x40049B0")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3890", Offset = "0x5D3890")]
		public FsmString thumbStyle;

		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0xD8ED20", Offset = "0xD8ED20", VA = "0xD8ED20", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0xD8EDCC", Offset = "0xD8EDCC", VA = "0xD8EDCC", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0xD8F000", Offset = "0xD8F000", VA = "0xD8F000")]
		public GUIHorizontalSlider()
		{
		}
	}
}
