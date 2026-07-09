using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001039")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1160", Offset = "0x5A1160")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1160", Offset = "0x5A1160")]
	public class StringSwitch : FsmStateAction
	{
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDB3C", Offset = "0x5DDB3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DDB3C", Offset = "0x5DDB3C")]
		public FsmString stringVariable;

		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DDB9C", Offset = "0x5DDB9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDB9C", Offset = "0x5DDB9C")]
		public FsmString[] compareTo;

		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDC2C", Offset = "0x5DDC2C")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDC64", Offset = "0x5DDC64")]
		public bool everyFrame;

		[Token(Token = "0x600613D")]
		[Address(RVA = "0xD2ECE8", Offset = "0xD2ECE8", VA = "0xD2ECE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600613E")]
		[Address(RVA = "0xD2ED68", Offset = "0xD2ED68", VA = "0xD2ED68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600613F")]
		[Address(RVA = "0xD2EE94", Offset = "0xD2EE94", VA = "0xD2EE94", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006140")]
		[Address(RVA = "0xD2EDA4", Offset = "0xD2EDA4", VA = "0xD2EDA4")]
		private void DoStringSwitch()
		{
		}

		[Token(Token = "0x6006141")]
		[Address(RVA = "0xD2EE98", Offset = "0xD2EE98", VA = "0xD2EE98")]
		public StringSwitch()
		{
		}
	}
}
