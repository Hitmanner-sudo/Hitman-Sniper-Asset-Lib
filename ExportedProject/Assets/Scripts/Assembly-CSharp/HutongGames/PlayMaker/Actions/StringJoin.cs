using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001193")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8AF4", Offset = "0x5A8AF4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8AF4", Offset = "0x5A8AF4")]
	public class StringJoin : FsmStateAction
	{
		[Token(Token = "0x4005398")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAA50", Offset = "0x5FAA50")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5FAA50", Offset = "0x5FAA50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAA50", Offset = "0x5FAA50")]
		public FsmArray stringArray;

		[Token(Token = "0x4005399")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAAD4", Offset = "0x5FAAD4")]
		public FsmString separator;

		[Token(Token = "0x400539A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAB0C", Offset = "0x5FAB0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAB0C", Offset = "0x5FAB0C")]
		public FsmString storeResult;

		[Token(Token = "0x6006799")]
		[Address(RVA = "0xD2E8D8", Offset = "0xD2E8D8", VA = "0xD2E8D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600679A")]
		[Address(RVA = "0xD2E958", Offset = "0xD2E958", VA = "0xD2E958")]
		public StringJoin()
		{
		}
	}
}
