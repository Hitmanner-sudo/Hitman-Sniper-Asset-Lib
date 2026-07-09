using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FB1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E4D8", Offset = "0x59E4D8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E4D8", Offset = "0x59E4D8")]
	public class GUILayoutButton : GUILayoutAction
	{
		[Token(Token = "0x40049FB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4A40", Offset = "0x5D4A40")]
		public FsmEvent sendEvent;

		[Token(Token = "0x40049FC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4A78", Offset = "0x5D4A78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4A78", Offset = "0x5D4A78")]
		public FsmBool storeButtonState;

		[Token(Token = "0x40049FD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4AC8", Offset = "0x5D4AC8")]
		public FsmTexture image;

		[Token(Token = "0x40049FE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4B00", Offset = "0x5D4B00")]
		public FsmString text;

		[Token(Token = "0x40049FF")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4B38", Offset = "0x5D4B38")]
		public FsmString tooltip;

		[Token(Token = "0x4004A00")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4B70", Offset = "0x5D4B70")]
		public FsmString style;

		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0xD9037C", Offset = "0xD9037C", VA = "0xD9037C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0xD903FC", Offset = "0xD903FC", VA = "0xD903FC", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0xD9059C", Offset = "0xD9059C", VA = "0xD9059C")]
		public GUILayoutButton()
		{
		}
	}
}
