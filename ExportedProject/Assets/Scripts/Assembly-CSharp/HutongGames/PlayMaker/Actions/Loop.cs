using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7778", Offset = "0x5A7778")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7778", Offset = "0x5A7778")]
	public class Loop : FsmStateAction
	{
		[Token(Token = "0x40052BB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7D84", Offset = "0x5F7D84")]
		public FsmInt loops;

		[Token(Token = "0x40052BC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7DD0", Offset = "0x5F7DD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7DD0", Offset = "0x5F7DD0")]
		public FsmInt storeCurrentLoop;

		[Token(Token = "0x40052BD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7E20", Offset = "0x5F7E20")]
		public FsmEvent loopEvent;

		[Token(Token = "0x40052BE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7E58", Offset = "0x5F7E58")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40052BF")]
		[FieldOffset(Offset = "0x70")]
		private int loopedCount;

		[Token(Token = "0x60066CF")]
		[Address(RVA = "0x9E05D4", Offset = "0x9E05D4", VA = "0x9E05D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066D0")]
		[Address(RVA = "0x9E0664", Offset = "0x9E0664", VA = "0x9E0664")]
		public Loop()
		{
		}
	}
}
