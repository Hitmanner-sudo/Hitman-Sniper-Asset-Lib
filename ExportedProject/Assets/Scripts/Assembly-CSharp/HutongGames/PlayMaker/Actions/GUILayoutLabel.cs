using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E938", Offset = "0x59E938")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E938", Offset = "0x59E938")]
	public class GUILayoutLabel : GUILayoutAction
	{
		[Token(Token = "0x4004A1D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D52C8", Offset = "0x5D52C8")]
		public FsmTexture image;

		[Token(Token = "0x4004A1E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5300", Offset = "0x5D5300")]
		public FsmString text;

		[Token(Token = "0x4004A1F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5338", Offset = "0x5D5338")]
		public FsmString tooltip;

		[Token(Token = "0x4004A20")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5370", Offset = "0x5D5370")]
		public FsmString style;

		[Token(Token = "0x6005F33")]
		[Address(RVA = "0xD91568", Offset = "0xD91568", VA = "0xD91568", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F34")]
		[Address(RVA = "0xD915E4", Offset = "0xD915E4", VA = "0xD915E4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F35")]
		[Address(RVA = "0xD9175C", Offset = "0xD9175C", VA = "0xD9175C")]
		public GUILayoutLabel()
		{
		}
	}
}
