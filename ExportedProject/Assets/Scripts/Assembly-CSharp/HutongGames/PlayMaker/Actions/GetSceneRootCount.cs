using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001114")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A575C", Offset = "0x5A575C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A575C", Offset = "0x5A575C")]
	public class GetSceneRootCount : GetSceneActionBase
	{
		[Token(Token = "0x40050CF")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5F1850", Offset = "0x5F1850")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1850", Offset = "0x5F1850")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1850", Offset = "0x5F1850")]
		public FsmInt rootCount;

		[Token(Token = "0x40050D0")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F18D4", Offset = "0x5F18D4")]
		public bool everyFrame;

		[Token(Token = "0x6006576")]
		[Address(RVA = "0xC7E308", Offset = "0xC7E308", VA = "0xC7E308", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006577")]
		[Address(RVA = "0xC7E334", Offset = "0xC7E334", VA = "0xC7E334", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006578")]
		[Address(RVA = "0xC7E3EC", Offset = "0xC7E3EC", VA = "0xC7E3EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006579")]
		[Address(RVA = "0xC7E37C", Offset = "0xC7E37C", VA = "0xC7E37C")]
		private void DoGetSceneRootCount()
		{
		}

		[Token(Token = "0x600657A")]
		[Address(RVA = "0xC7E3F0", Offset = "0xC7E3F0", VA = "0xC7E3F0")]
		public GetSceneRootCount()
		{
		}
	}
}
