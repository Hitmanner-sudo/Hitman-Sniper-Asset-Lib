using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200110E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A557C", Offset = "0x5A557C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A557C", Offset = "0x5A557C")]
	public class GetSceneIsLoaded : GetSceneActionBase
	{
		[Token(Token = "0x40050B3")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0EEC", Offset = "0x5F0EEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F0EEC", Offset = "0x5F0EEC")]
		[Attribute(Name = "ActionSection", RVA = "0x5F0EEC", Offset = "0x5F0EEC")]
		public FsmBool isLoaded;

		[Token(Token = "0x40050B4")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0F60", Offset = "0x5F0F60")]
		public FsmEvent isLoadedEvent;

		[Token(Token = "0x40050B5")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0F98", Offset = "0x5F0F98")]
		public FsmEvent isNotLoadedEvent;

		[Token(Token = "0x40050B6")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0FD0", Offset = "0x5F0FD0")]
		public bool everyFrame;

		[Token(Token = "0x600655D")]
		[Address(RVA = "0xC7DA20", Offset = "0xC7DA20", VA = "0xC7DA20", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600655E")]
		[Address(RVA = "0xC7DA4C", Offset = "0xC7DA4C", VA = "0xC7DA4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600655F")]
		[Address(RVA = "0xC7DB08", Offset = "0xC7DB08", VA = "0xC7DB08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006560")]
		[Address(RVA = "0xC7DA94", Offset = "0xC7DA94", VA = "0xC7DA94")]
		private void DoGetSceneIsLoaded()
		{
		}

		[Token(Token = "0x6006561")]
		[Address(RVA = "0xC7DB0C", Offset = "0xC7DB0C", VA = "0xC7DB0C")]
		public GetSceneIsLoaded()
		{
		}
	}
}
