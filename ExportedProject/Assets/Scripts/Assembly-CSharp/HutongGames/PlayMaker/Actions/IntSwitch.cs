using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001033")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0F80", Offset = "0x5A0F80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0F80", Offset = "0x5A0F80")]
	public class IntSwitch : FsmStateAction
	{
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD26C", Offset = "0x5DD26C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD26C", Offset = "0x5DD26C")]
		public FsmInt intVariable;

		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD2CC", Offset = "0x5DD2CC")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DD2CC", Offset = "0x5DD2CC")]
		public FsmInt[] compareTo;

		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD35C", Offset = "0x5DD35C")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD394", Offset = "0x5DD394")]
		public bool everyFrame;

		[Token(Token = "0x600611F")]
		[Address(RVA = "0xB167CC", Offset = "0xB167CC", VA = "0xB167CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006120")]
		[Address(RVA = "0xB1684C", Offset = "0xB1684C", VA = "0xB1684C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006121")]
		[Address(RVA = "0xB1696C", Offset = "0xB1696C", VA = "0xB1696C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006122")]
		[Address(RVA = "0xB16888", Offset = "0xB16888", VA = "0xB16888")]
		private void DoIntSwitch()
		{
		}

		[Token(Token = "0x6006123")]
		[Address(RVA = "0xB16970", Offset = "0xB16970", VA = "0xB16970")]
		public IntSwitch()
		{
		}
	}
}
