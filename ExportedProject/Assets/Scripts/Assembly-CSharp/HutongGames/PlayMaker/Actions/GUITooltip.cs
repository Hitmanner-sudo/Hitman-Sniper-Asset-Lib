using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F99")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DCE0", Offset = "0x59DCE0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DCE0", Offset = "0x59DCE0")]
	public class GUITooltip : FsmStateAction
	{
		[Token(Token = "0x40049B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D38C8", Offset = "0x5D38C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D38C8", Offset = "0x5D38C8")]
		public FsmString storeTooltip;

		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0xD92C60", Offset = "0xD92C60", VA = "0xD92C60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0xD92C68", Offset = "0xD92C68", VA = "0xD92C68", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0xD92CDC", Offset = "0xD92CDC", VA = "0xD92CDC")]
		public GUITooltip()
		{
		}
	}
}
