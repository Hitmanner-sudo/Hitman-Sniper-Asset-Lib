using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A543C", Offset = "0x5A543C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A543C", Offset = "0x5A543C")]
	public class GetSceneBuildIndex : GetSceneActionBase
	{
		[Token(Token = "0x40050AB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0C54", Offset = "0x5F0C54")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0C54", Offset = "0x5F0C54")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5F0C54", Offset = "0x5F0C54")]
		public FsmInt buildIndex;

		[Token(Token = "0x600654B")]
		[Address(RVA = "0xC7D6E4", Offset = "0xC7D6E4", VA = "0xC7D6E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600654C")]
		[Address(RVA = "0xC7D70C", Offset = "0xC7D70C", VA = "0xC7D70C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600654D")]
		[Address(RVA = "0xC7D740", Offset = "0xC7D740", VA = "0xC7D740")]
		private void DoGetSceneBuildIndex()
		{
		}

		[Token(Token = "0x600654E")]
		[Address(RVA = "0xC7D7B0", Offset = "0xC7D7B0", VA = "0xC7D7B0")]
		public GetSceneBuildIndex()
		{
		}
	}
}
