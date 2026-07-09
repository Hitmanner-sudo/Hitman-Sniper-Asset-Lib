using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FB0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E488", Offset = "0x59E488")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E488", Offset = "0x59E488")]
	public class GUILayoutBox : GUILayoutAction
	{
		[Token(Token = "0x40049F7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4960", Offset = "0x5D4960")]
		public FsmTexture image;

		[Token(Token = "0x40049F8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4998", Offset = "0x5D4998")]
		public FsmString text;

		[Token(Token = "0x40049F9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D49D0", Offset = "0x5D49D0")]
		public FsmString tooltip;

		[Token(Token = "0x40049FA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4A08", Offset = "0x5D4A08")]
		public FsmString style;

		[Token(Token = "0x6005F07")]
		[Address(RVA = "0xD90180", Offset = "0xD90180", VA = "0xD90180", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F08")]
		[Address(RVA = "0xD901FC", Offset = "0xD901FC", VA = "0xD901FC", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F09")]
		[Address(RVA = "0xD90374", Offset = "0xD90374", VA = "0xD90374")]
		public GUILayoutBox()
		{
		}
	}
}
