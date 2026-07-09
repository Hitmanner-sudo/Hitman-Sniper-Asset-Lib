using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011EC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA374", Offset = "0x5AA374")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA374", Offset = "0x5AA374")]
	public class UiIsPointerOverUiObject : FsmStateAction
	{
		[Token(Token = "0x40055DE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60147C", Offset = "0x60147C")]
		public FsmInt pointerId;

		[Token(Token = "0x40055DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6014B4", Offset = "0x6014B4")]
		public FsmEvent pointerOverUI;

		[Token(Token = "0x40055E0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6014EC", Offset = "0x6014EC")]
		public FsmEvent pointerNotOverUI;

		[Token(Token = "0x40055E1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601524", Offset = "0x601524")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601524", Offset = "0x601524")]
		public FsmBool isPointerOverUI;

		[Token(Token = "0x40055E2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601574", Offset = "0x601574")]
		public bool everyFrame;

		[Token(Token = "0x6006955")]
		[Address(RVA = "0xB91FB8", Offset = "0xB91FB8", VA = "0xB91FB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006956")]
		[Address(RVA = "0xB9202C", Offset = "0xB9202C", VA = "0xB9202C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006957")]
		[Address(RVA = "0xB92224", Offset = "0xB92224", VA = "0xB92224", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006958")]
		[Address(RVA = "0xB92068", Offset = "0xB92068", VA = "0xB92068")]
		private void DoCheckPointer()
		{
		}

		[Token(Token = "0x6006959")]
		[Address(RVA = "0xB92228", Offset = "0xB92228", VA = "0xB92228")]
		public UiIsPointerOverUiObject()
		{
		}
	}
}
