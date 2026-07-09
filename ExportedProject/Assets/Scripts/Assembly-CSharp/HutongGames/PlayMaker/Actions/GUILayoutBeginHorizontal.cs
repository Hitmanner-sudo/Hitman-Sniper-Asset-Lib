using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FAD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E398", Offset = "0x59E398")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E398", Offset = "0x59E398")]
	public class GUILayoutBeginHorizontal : GUILayoutAction
	{
		[Token(Token = "0x40049E8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D45F0", Offset = "0x5D45F0")]
		public FsmTexture image;

		[Token(Token = "0x40049E9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4628", Offset = "0x5D4628")]
		public FsmString text;

		[Token(Token = "0x40049EA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4660", Offset = "0x5D4660")]
		public FsmString tooltip;

		[Token(Token = "0x40049EB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4698", Offset = "0x5D4698")]
		public FsmString style;

		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0xD8FC54", Offset = "0xD8FC54", VA = "0xD8FC54", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0xD8FCD0", Offset = "0xD8FCD0", VA = "0xD8FCD0", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F00")]
		[Address(RVA = "0xD8FDFC", Offset = "0xD8FDFC", VA = "0xD8FDFC")]
		public GUILayoutBeginHorizontal()
		{
		}
	}
}
