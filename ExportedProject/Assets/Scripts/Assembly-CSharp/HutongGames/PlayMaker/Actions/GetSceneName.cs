using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001111")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A566C", Offset = "0x5A566C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A566C", Offset = "0x5A566C")]
	public class GetSceneName : GetSceneActionBase
	{
		[Token(Token = "0x40050C4")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1438", Offset = "0x5F1438")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1438", Offset = "0x5F1438")]
		[Attribute(Name = "ActionSection", RVA = "0x5F1438", Offset = "0x5F1438")]
		[RequiredField]
		public FsmString name;

		[Token(Token = "0x600656A")]
		[Address(RVA = "0xC7DEE8", Offset = "0xC7DEE8", VA = "0xC7DEE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600656B")]
		[Address(RVA = "0xC7DF10", Offset = "0xC7DF10", VA = "0xC7DF10", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600656C")]
		[Address(RVA = "0xC7DF44", Offset = "0xC7DF44", VA = "0xC7DF44")]
		private void DoGetSceneName()
		{
		}

		[Token(Token = "0x600656D")]
		[Address(RVA = "0xC7DFB4", Offset = "0xC7DFB4", VA = "0xC7DFB4")]
		public GetSceneName()
		{
		}
	}
}
