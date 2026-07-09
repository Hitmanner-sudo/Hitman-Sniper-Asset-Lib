using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A548C", Offset = "0x5A548C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A548C", Offset = "0x5A548C")]
	public class GetSceneCount : FsmStateAction
	{
		[Token(Token = "0x40050AC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0CD8", Offset = "0x5F0CD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0CD8", Offset = "0x5F0CD8")]
		[RequiredField]
		public FsmInt sceneCount;

		[Token(Token = "0x40050AD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0D38", Offset = "0x5F0D38")]
		public bool everyFrame;

		[Token(Token = "0x600654F")]
		[Address(RVA = "0xC7D7B8", Offset = "0xC7D7B8", VA = "0xC7D7B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006550")]
		[Address(RVA = "0xC7D7C4", Offset = "0xC7D7C4", VA = "0xC7D7C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006551")]
		[Address(RVA = "0xC7D874", Offset = "0xC7D874", VA = "0xC7D874", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006552")]
		[Address(RVA = "0xC7D800", Offset = "0xC7D800", VA = "0xC7D800")]
		private void DoGetSceneCount()
		{
		}

		[Token(Token = "0x6006553")]
		[Address(RVA = "0xC7D878", Offset = "0xC7D878", VA = "0xC7D878")]
		public GetSceneCount()
		{
		}
	}
}
