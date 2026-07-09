using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F94")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DB44", Offset = "0x59DB44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DB44", Offset = "0x59DB44")]
	public class GUIButton : GUIContentAction
	{
		[Token(Token = "0x400499B")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D33B0", Offset = "0x5D33B0")]
		public FsmEvent sendEvent;

		[Token(Token = "0x400499C")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D33E8", Offset = "0x5D33E8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D33E8", Offset = "0x5D33E8")]
		public FsmBool storeButtonState;

		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0xD8E41C", Offset = "0xD8E41C", VA = "0xD8E41C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0xD8E500", Offset = "0xD8E500", VA = "0xD8E500", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0xD8E634", Offset = "0xD8E634", VA = "0xD8E634")]
		public GUIButton()
		{
		}
	}
}
