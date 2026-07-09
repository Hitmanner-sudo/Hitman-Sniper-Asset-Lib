using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FAF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E438", Offset = "0x59E438")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E438", Offset = "0x59E438")]
	public class GUILayoutBeginVertical : GUILayoutAction
	{
		[Token(Token = "0x40049F3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4880", Offset = "0x5D4880")]
		public FsmTexture image;

		[Token(Token = "0x40049F4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D48B8", Offset = "0x5D48B8")]
		public FsmString text;

		[Token(Token = "0x40049F5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D48F0", Offset = "0x5D48F0")]
		public FsmString tooltip;

		[Token(Token = "0x40049F6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4928", Offset = "0x5D4928")]
		public FsmString style;

		[Token(Token = "0x6005F04")]
		[Address(RVA = "0xD8FFD0", Offset = "0xD8FFD0", VA = "0xD8FFD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F05")]
		[Address(RVA = "0xD9004C", Offset = "0xD9004C", VA = "0xD9004C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F06")]
		[Address(RVA = "0xD90178", Offset = "0xD90178", VA = "0xD90178")]
		public GUILayoutBeginVertical()
		{
		}
	}
}
