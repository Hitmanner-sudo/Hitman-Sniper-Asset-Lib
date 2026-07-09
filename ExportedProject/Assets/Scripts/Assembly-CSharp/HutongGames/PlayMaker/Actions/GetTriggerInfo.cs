using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001079")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A23F0", Offset = "0x5A23F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A23F0", Offset = "0x5A23F0")]
	public class GetTriggerInfo : FsmStateAction
	{
		[Token(Token = "0x4004D67")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2BC0", Offset = "0x5E2BC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2BC0", Offset = "0x5E2BC0")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004D68")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E2C10", Offset = "0x5E2C10")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E2C10", Offset = "0x5E2C10")]
		public FsmString physicsMaterialName;

		[Token(Token = "0x6006270")]
		[Address(RVA = "0xC80B68", Offset = "0xC80B68", VA = "0xC80B68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006271")]
		[Address(RVA = "0xC80B70", Offset = "0xC80B70", VA = "0xC80B70")]
		private void StoreTriggerInfo()
		{
		}

		[Token(Token = "0x6006272")]
		[Address(RVA = "0xC80C50", Offset = "0xC80C50", VA = "0xC80C50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006273")]
		[Address(RVA = "0xC80C78", Offset = "0xC80C78", VA = "0xC80C78")]
		public GetTriggerInfo()
		{
		}
	}
}
