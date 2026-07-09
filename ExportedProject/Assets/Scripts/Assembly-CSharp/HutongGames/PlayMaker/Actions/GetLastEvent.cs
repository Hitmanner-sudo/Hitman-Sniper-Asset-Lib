using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001164")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7574", Offset = "0x5A7574")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7574", Offset = "0x5A7574")]
	public class GetLastEvent : FsmStateAction
	{
		[Token(Token = "0x40052AC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7BB0", Offset = "0x5F7BB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7BB0", Offset = "0x5F7BB0")]
		public FsmString storeEvent;

		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x1063B68", Offset = "0x1063B68", VA = "0x1063B68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x1063B70", Offset = "0x1063B70", VA = "0x1063B70", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x1063BEC", Offset = "0x1063BEC", VA = "0x1063BEC")]
		public GetLastEvent()
		{
		}
	}
}
