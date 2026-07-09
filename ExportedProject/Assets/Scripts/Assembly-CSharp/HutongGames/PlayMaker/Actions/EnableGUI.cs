using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F91")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DA6C", Offset = "0x59DA6C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DA6C", Offset = "0x59DA6C")]
	public class EnableGUI : FsmStateAction
	{
		[Token(Token = "0x4004993")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D31FC", Offset = "0x5D31FC")]
		public FsmBool enableGUI;

		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0xE0D9F0", Offset = "0xE0D9F0", VA = "0xE0D9F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0xE0DA1C", Offset = "0xE0DA1C", VA = "0xE0DA1C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0xE0DAB8", Offset = "0xE0DAB8", VA = "0xE0DAB8")]
		public EnableGUI()
		{
		}
	}
}
