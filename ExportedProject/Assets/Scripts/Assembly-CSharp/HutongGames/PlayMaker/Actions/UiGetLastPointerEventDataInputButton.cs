using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011EA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA2D4", Offset = "0x5AA2D4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA2D4", Offset = "0x5AA2D4")]
	public class UiGetLastPointerEventDataInputButton : FsmStateAction
	{
		[Token(Token = "0x40055D6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x60124C", Offset = "0x60124C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60124C", Offset = "0x60124C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60124C", Offset = "0x60124C")]
		public FsmEnum inputButton;

		[Token(Token = "0x40055D7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6012E4", Offset = "0x6012E4")]
		public FsmEvent leftClick;

		[Token(Token = "0x40055D8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60131C", Offset = "0x60131C")]
		public FsmEvent middleClick;

		[Token(Token = "0x40055D9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601354", Offset = "0x601354")]
		public FsmEvent rightClick;

		[Token(Token = "0x600694C")]
		[Address(RVA = "0x117AEE0", Offset = "0x117AEE0", VA = "0x117AEE0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600694D")]
		[Address(RVA = "0x117AF4C", Offset = "0x117AF4C", VA = "0x117AF4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600694E")]
		[Address(RVA = "0x117AF74", Offset = "0x117AF74", VA = "0x117AF74")]
		private void ExecuteAction()
		{
		}

		[Token(Token = "0x600694F")]
		[Address(RVA = "0x117B0C4", Offset = "0x117B0C4", VA = "0x117B0C4")]
		public UiGetLastPointerEventDataInputButton()
		{
		}
	}
}
