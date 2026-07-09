using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116C")]
	[Attribute(Name = "NoteAttribute", RVA = "0x5A77C8", Offset = "0x5A77C8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A77C8", Offset = "0x5A77C8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A77C8", Offset = "0x5A77C8")]
	public class LoopState : FsmStateAction
	{
		[Token(Token = "0x40052C0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7E90", Offset = "0x5F7E90")]
		[RequiredField]
		public FsmInt loops;

		[Token(Token = "0x40052C1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7EDC", Offset = "0x5F7EDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7EDC", Offset = "0x5F7EDC")]
		public FsmInt storeCurrentLoop;

		[Token(Token = "0x40052C2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7F2C", Offset = "0x5F7F2C")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40052C3")]
		[FieldOffset(Offset = "0x68")]
		private int loopedCount;

		[Token(Token = "0x60066D1")]
		[Address(RVA = "0x9E066C", Offset = "0x9E066C", VA = "0x9E066C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066D2")]
		[Address(RVA = "0x9E070C", Offset = "0x9E070C", VA = "0x9E070C")]
		public LoopState()
		{
		}
	}
}
