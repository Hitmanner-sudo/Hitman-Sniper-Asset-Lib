using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001115")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A57AC", Offset = "0x5A57AC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A57AC", Offset = "0x5A57AC")]
	public class GetSceneRootGameObjects : GetSceneActionBase
	{
		[Token(Token = "0x40050D1")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5F190C", Offset = "0x5F190C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F190C", Offset = "0x5F190C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F190C", Offset = "0x5F190C")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F190C", Offset = "0x5F190C")]
		public FsmArray rootGameObjects;

		[Token(Token = "0x40050D2")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F19C4", Offset = "0x5F19C4")]
		public bool everyFrame;

		[Token(Token = "0x600657B")]
		[Address(RVA = "0xC7E3F8", Offset = "0xC7E3F8", VA = "0xC7E3F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600657C")]
		[Address(RVA = "0xC7E424", Offset = "0xC7E424", VA = "0xC7E424", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600657D")]
		[Address(RVA = "0xC7E4E8", Offset = "0xC7E4E8", VA = "0xC7E4E8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600657E")]
		[Address(RVA = "0xC7E46C", Offset = "0xC7E46C", VA = "0xC7E46C")]
		private void DoGetSceneRootGameObjects()
		{
		}

		[Token(Token = "0x600657F")]
		[Address(RVA = "0xC7E4EC", Offset = "0xC7E4EC", VA = "0xC7E4EC")]
		public GetSceneRootGameObjects()
		{
		}
	}
}
