using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FAE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E3E8", Offset = "0x59E3E8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E3E8", Offset = "0x59E3E8")]
	public class GUILayoutBeginScrollView : GUILayoutAction
	{
		[Token(Token = "0x40049EC")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D46D0", Offset = "0x5D46D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D46D0", Offset = "0x5D46D0")]
		public FsmVector2 scrollPosition;

		[Token(Token = "0x40049ED")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4730", Offset = "0x5D4730")]
		public FsmBool horizontalScrollbar;

		[Token(Token = "0x40049EE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4768", Offset = "0x5D4768")]
		public FsmBool verticalScrollbar;

		[Token(Token = "0x40049EF")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D47A0", Offset = "0x5D47A0")]
		public FsmBool useCustomStyle;

		[Token(Token = "0x40049F0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D47D8", Offset = "0x5D47D8")]
		public FsmString horizontalStyle;

		[Token(Token = "0x40049F1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4810", Offset = "0x5D4810")]
		public FsmString verticalStyle;

		[Token(Token = "0x40049F2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4848", Offset = "0x5D4848")]
		public FsmString backgroundStyle;

		[Token(Token = "0x6005F01")]
		[Address(RVA = "0xD8FE04", Offset = "0xD8FE04", VA = "0xD8FE04", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F02")]
		[Address(RVA = "0xD8FE34", Offset = "0xD8FE34", VA = "0xD8FE34", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F03")]
		[Address(RVA = "0xD8FFC8", Offset = "0xD8FFC8", VA = "0xD8FFC8")]
		public GUILayoutBeginScrollView()
		{
		}
	}
}
