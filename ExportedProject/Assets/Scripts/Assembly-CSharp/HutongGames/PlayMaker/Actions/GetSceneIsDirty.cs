using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A552C", Offset = "0x5A552C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A552C", Offset = "0x5A552C")]
	public class GetSceneIsDirty : GetSceneActionBase
	{
		[Token(Token = "0x40050AF")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ActionSection", RVA = "0x5F0DD0", Offset = "0x5F0DD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0DD0", Offset = "0x5F0DD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0DD0", Offset = "0x5F0DD0")]
		public FsmBool isDirty;

		[Token(Token = "0x40050B0")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0E44", Offset = "0x5F0E44")]
		public FsmEvent isDirtyEvent;

		[Token(Token = "0x40050B1")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0E7C", Offset = "0x5F0E7C")]
		public FsmEvent isNotDirtyEvent;

		[Token(Token = "0x40050B2")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0EB4", Offset = "0x5F0EB4")]
		public bool everyFrame;

		[Token(Token = "0x6006558")]
		[Address(RVA = "0xC7D92C", Offset = "0xC7D92C", VA = "0xC7D92C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006559")]
		[Address(RVA = "0xC7D958", Offset = "0xC7D958", VA = "0xC7D958", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600655A")]
		[Address(RVA = "0xC7DA14", Offset = "0xC7DA14", VA = "0xC7DA14", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600655B")]
		[Address(RVA = "0xC7D9A0", Offset = "0xC7D9A0", VA = "0xC7D9A0")]
		private void DoGetSceneIsDirty()
		{
		}

		[Token(Token = "0x600655C")]
		[Address(RVA = "0xC7DA18", Offset = "0xC7DA18", VA = "0xC7DA18")]
		public GetSceneIsDirty()
		{
		}
	}
}
