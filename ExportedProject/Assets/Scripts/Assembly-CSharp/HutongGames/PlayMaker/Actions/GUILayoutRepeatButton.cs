using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E9D8", Offset = "0x59E9D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E9D8", Offset = "0x59E9D8")]
	public class GUILayoutRepeatButton : GUILayoutAction
	{
		[Token(Token = "0x4004A26")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D54D8", Offset = "0x5D54D8")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004A27")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5510", Offset = "0x5D5510")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5510", Offset = "0x5D5510")]
		public FsmBool storeButtonState;

		[Token(Token = "0x4004A28")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5560", Offset = "0x5D5560")]
		public FsmTexture image;

		[Token(Token = "0x4004A29")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5598", Offset = "0x5D5598")]
		public FsmString text;

		[Token(Token = "0x4004A2A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D55D0", Offset = "0x5D55D0")]
		public FsmString tooltip;

		[Token(Token = "0x4004A2B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5608", Offset = "0x5D5608")]
		public FsmString style;

		[Token(Token = "0x6005F39")]
		[Address(RVA = "0xD919CC", Offset = "0xD919CC", VA = "0xD919CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0xD91A4C", Offset = "0xD91A4C", VA = "0xD91A4C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0xD91BEC", Offset = "0xD91BEC", VA = "0xD91BEC")]
		public GUILayoutRepeatButton()
		{
		}
	}
}
