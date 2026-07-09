using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EBB8", Offset = "0x59EBB8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EBB8", Offset = "0x59EBB8")]
	public class GUILayoutVerticalSlider : GUILayoutAction
	{
		[Token(Token = "0x4004A42")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5B30", Offset = "0x5D5B30")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D5B30", Offset = "0x5D5B30")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004A43")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5B90", Offset = "0x5D5B90")]
		public FsmFloat topValue;

		[Token(Token = "0x4004A44")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5BDC", Offset = "0x5D5BDC")]
		public FsmFloat bottomValue;

		[Token(Token = "0x4004A45")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5C28", Offset = "0x5D5C28")]
		public FsmEvent changedEvent;

		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0xD92A80", Offset = "0xD92A80", VA = "0xD92A80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F50")]
		[Address(RVA = "0xD92AC8", Offset = "0xD92AC8", VA = "0xD92AC8", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F51")]
		[Address(RVA = "0xD92C58", Offset = "0xD92C58", VA = "0xD92C58")]
		public GUILayoutVerticalSlider()
		{
		}
	}
}
