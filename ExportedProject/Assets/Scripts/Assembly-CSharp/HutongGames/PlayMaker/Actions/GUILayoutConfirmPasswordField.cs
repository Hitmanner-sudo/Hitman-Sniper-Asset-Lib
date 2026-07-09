using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FB2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E528", Offset = "0x59E528")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E528", Offset = "0x59E528")]
	public class GUILayoutConfirmPasswordField : GUILayoutAction
	{
		[Token(Token = "0x4004A01")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4BA8", Offset = "0x5D4BA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4BA8", Offset = "0x5D4BA8")]
		public FsmString text;

		[Token(Token = "0x4004A02")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4BF8", Offset = "0x5D4BF8")]
		public FsmInt maxLength;

		[Token(Token = "0x4004A03")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4C30", Offset = "0x5D4C30")]
		public FsmString style;

		[Token(Token = "0x4004A04")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4C68", Offset = "0x5D4C68")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004A05")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4CA0", Offset = "0x5D4CA0")]
		public FsmString mask;

		[Token(Token = "0x4004A06")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4CD8", Offset = "0x5D4CD8")]
		public FsmBool confirm;

		[Token(Token = "0x4004A07")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4D10", Offset = "0x5D4D10")]
		public FsmString password;

		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0xD905A4", Offset = "0xD905A4", VA = "0xD905A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0xD90640", Offset = "0xD90640", VA = "0xD90640", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0xD90814", Offset = "0xD90814", VA = "0xD90814")]
		public GUILayoutConfirmPasswordField()
		{
		}
	}
}
