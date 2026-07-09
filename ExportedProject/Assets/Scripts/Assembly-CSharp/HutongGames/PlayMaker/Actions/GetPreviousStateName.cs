using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001165")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A75C4", Offset = "0x5A75C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A75C4", Offset = "0x5A75C4")]
	public class GetPreviousStateName : FsmStateAction
	{
		[Token(Token = "0x40052AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7C00", Offset = "0x5F7C00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7C00", Offset = "0x5F7C00")]
		public FsmString storeName;

		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x106746C", Offset = "0x106746C", VA = "0x106746C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x1067474", Offset = "0x1067474", VA = "0x1067474", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x10674AC", Offset = "0x10674AC", VA = "0x10674AC")]
		public GetPreviousStateName()
		{
		}
	}
}
