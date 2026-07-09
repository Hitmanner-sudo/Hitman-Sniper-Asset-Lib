using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F9A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DD30", Offset = "0x59DD30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DD30", Offset = "0x59DD30")]
	public class GUIVerticalSlider : GUIAction
	{
		[Token(Token = "0x40049B2")]
		[FieldOffset(Offset = "0x90")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D3918", Offset = "0x5D3918")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3918", Offset = "0x5D3918")]
		public FsmFloat floatVariable;

		[Token(Token = "0x40049B3")]
		[FieldOffset(Offset = "0x98")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3978", Offset = "0x5D3978")]
		public FsmFloat topValue;

		[Token(Token = "0x40049B4")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D39C4", Offset = "0x5D39C4")]
		[RequiredField]
		public FsmFloat bottomValue;

		[Token(Token = "0x40049B5")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3A10", Offset = "0x5D3A10")]
		public FsmString sliderStyle;

		[Token(Token = "0x40049B6")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3A48", Offset = "0x5D3A48")]
		public FsmString thumbStyle;

		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0xD92CE4", Offset = "0xD92CE4", VA = "0xD92CE4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0xD92DA4", Offset = "0xD92DA4", VA = "0xD92DA4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EC9")]
		[Address(RVA = "0xD92FD8", Offset = "0xD92FD8", VA = "0xD92FD8")]
		public GUIVerticalSlider()
		{
		}
	}
}
