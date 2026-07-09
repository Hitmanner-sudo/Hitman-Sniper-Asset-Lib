using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001024")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A08D0", Offset = "0x5A08D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A08D0", Offset = "0x5A08D0")]
	public class FloatSwitch : FsmStateAction
	{
		[Token(Token = "0x4004BBE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBBFC", Offset = "0x5DBBFC")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DBBFC", Offset = "0x5DBBFC")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004BBF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBC5C", Offset = "0x5DBC5C")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DBC5C", Offset = "0x5DBC5C")]
		public FsmFloat[] lessThan;

		[Token(Token = "0x4004BC0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBCEC", Offset = "0x5DBCEC")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004BC1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBD24", Offset = "0x5DBD24")]
		public bool everyFrame;

		[Token(Token = "0x60060D5")]
		[Address(RVA = "0x95991C", Offset = "0x95991C", VA = "0x95991C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060D6")]
		[Address(RVA = "0x95999C", Offset = "0x95999C", VA = "0x95999C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060D7")]
		[Address(RVA = "0x959AC8", Offset = "0x959AC8", VA = "0x959AC8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060D8")]
		[Address(RVA = "0x9599D8", Offset = "0x9599D8", VA = "0x9599D8")]
		private void DoFloatSwitch()
		{
		}

		[Token(Token = "0x60060D9")]
		[Address(RVA = "0x959ACC", Offset = "0x959ACC", VA = "0x959ACC")]
		public FloatSwitch()
		{
		}
	}
}
