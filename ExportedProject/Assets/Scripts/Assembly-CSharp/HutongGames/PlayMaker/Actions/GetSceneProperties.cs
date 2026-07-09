using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001113")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A570C", Offset = "0x5A570C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A570C", Offset = "0x5A570C")]
	public class GetSceneProperties : GetSceneActionBase
	{
		[Token(Token = "0x40050C6")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5F1540", Offset = "0x5F1540")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1540", Offset = "0x5F1540")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1540", Offset = "0x5F1540")]
		public FsmString name;

		[Token(Token = "0x40050C7")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F15B4", Offset = "0x5F15B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F15B4", Offset = "0x5F15B4")]
		public FsmString path;

		[Token(Token = "0x40050C8")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1604", Offset = "0x5F1604")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1604", Offset = "0x5F1604")]
		public FsmInt buildIndex;

		[Token(Token = "0x40050C9")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1654", Offset = "0x5F1654")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1654", Offset = "0x5F1654")]
		public FsmBool isValid;

		[Token(Token = "0x40050CA")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F16A4", Offset = "0x5F16A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F16A4", Offset = "0x5F16A4")]
		public FsmBool isLoaded;

		[Token(Token = "0x40050CB")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F16F4", Offset = "0x5F16F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F16F4", Offset = "0x5F16F4")]
		public FsmBool isDirty;

		[Token(Token = "0x40050CC")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1744", Offset = "0x5F1744")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1744", Offset = "0x5F1744")]
		public FsmInt rootCount;

		[Token(Token = "0x40050CD")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F1794", Offset = "0x5F1794")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1794", Offset = "0x5F1794")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5F1794", Offset = "0x5F1794")]
		public FsmArray rootGameObjects;

		[Token(Token = "0x40050CE")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F1818", Offset = "0x5F1818")]
		public bool everyFrame;

		[Token(Token = "0x6006572")]
		[Address(RVA = "0xC7E090", Offset = "0xC7E090", VA = "0xC7E090", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006573")]
		[Address(RVA = "0xC7E0C4", Offset = "0xC7E0C4", VA = "0xC7E0C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006574")]
		[Address(RVA = "0xC7E10C", Offset = "0xC7E10C", VA = "0xC7E10C")]
		private void DoGetSceneProperties()
		{
		}

		[Token(Token = "0x6006575")]
		[Address(RVA = "0xC7E300", Offset = "0xC7E300", VA = "0xC7E300")]
		public GetSceneProperties()
		{
		}
	}
}
