using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F06")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B0B0", Offset = "0x59B0B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B0B0", Offset = "0x59B0B0")]
	public class GetScreenHeight : FsmStateAction
	{
		[Token(Token = "0x400470B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C93D0", Offset = "0x5C93D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C93D0", Offset = "0x5C93D0")]
		public FsmFloat storeScreenHeight;

		[Token(Token = "0x400470C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9430", Offset = "0x5C9430")]
		public bool everyFrame;

		[Token(Token = "0x6005C73")]
		[Address(RVA = "0xC7EA40", Offset = "0xC7EA40", VA = "0xC7EA40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C74")]
		[Address(RVA = "0xC7EA4C", Offset = "0xC7EA4C", VA = "0xC7EA4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C75")]
		[Address(RVA = "0xC7EAA0", Offset = "0xC7EAA0", VA = "0xC7EAA0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C76")]
		[Address(RVA = "0xC7EAD4", Offset = "0xC7EAD4", VA = "0xC7EAD4")]
		public GetScreenHeight()
		{
		}
	}
}
