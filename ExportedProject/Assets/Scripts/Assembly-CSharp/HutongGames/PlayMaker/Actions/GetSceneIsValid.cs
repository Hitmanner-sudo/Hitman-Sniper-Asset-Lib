using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A55CC", Offset = "0x5A55CC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A55CC", Offset = "0x5A55CC")]
	public class GetSceneIsValid : GetSceneActionBase
	{
		[Token(Token = "0x40050B7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1008", Offset = "0x5F1008")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1008", Offset = "0x5F1008")]
		[Attribute(Name = "ActionSection", RVA = "0x5F1008", Offset = "0x5F1008")]
		public FsmBool isValid;

		[Token(Token = "0x40050B8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F107C", Offset = "0x5F107C")]
		public FsmEvent isValidEvent;

		[Token(Token = "0x40050B9")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F10B4", Offset = "0x5F10B4")]
		public FsmEvent isNotValidEvent;

		[Token(Token = "0x6006562")]
		[Address(RVA = "0xC7DB14", Offset = "0xC7DB14", VA = "0xC7DB14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006563")]
		[Address(RVA = "0xC7DB3C", Offset = "0xC7DB3C", VA = "0xC7DB3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006564")]
		[Address(RVA = "0xC7DB70", Offset = "0xC7DB70", VA = "0xC7DB70")]
		private void DoGetSceneIsValid()
		{
		}

		[Token(Token = "0x6006565")]
		[Address(RVA = "0xC7DC30", Offset = "0xC7DC30", VA = "0xC7DC30")]
		public GetSceneIsValid()
		{
		}
	}
}
