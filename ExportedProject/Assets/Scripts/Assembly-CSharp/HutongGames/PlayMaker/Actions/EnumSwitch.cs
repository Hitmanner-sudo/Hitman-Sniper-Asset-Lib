using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001020")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0790", Offset = "0x5A0790")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0790", Offset = "0x5A0790")]
	public class EnumSwitch : FsmStateAction
	{
		[Token(Token = "0x4004BAB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB6C4", Offset = "0x5DB6C4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB6C4", Offset = "0x5DB6C4")]
		public FsmEnum enumVariable;

		[Token(Token = "0x4004BAC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB724", Offset = "0x5DB724")]
		[Attribute(Name = "MatchFieldTypeAttribute", RVA = "0x5DB724", Offset = "0x5DB724")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5DB724", Offset = "0x5DB724")]
		public FsmEnum[] compareTo;

		[Token(Token = "0x4004BAD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB7D8", Offset = "0x5DB7D8")]
		public FsmEvent[] sendEvent;

		[Token(Token = "0x4004BAE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB810", Offset = "0x5DB810")]
		public bool everyFrame;

		[Token(Token = "0x60060C0")]
		[Address(RVA = "0xE15E1C", Offset = "0xE15E1C", VA = "0xE15E1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060C1")]
		[Address(RVA = "0xE15E9C", Offset = "0xE15E9C", VA = "0xE15E9C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060C2")]
		[Address(RVA = "0xE15FC8", Offset = "0xE15FC8", VA = "0xE15FC8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060C3")]
		[Address(RVA = "0xE15ED8", Offset = "0xE15ED8", VA = "0xE15ED8")]
		private void DoEnumSwitch()
		{
		}

		[Token(Token = "0x60060C4")]
		[Address(RVA = "0xE15FCC", Offset = "0xE15FCC", VA = "0xE15FCC")]
		public EnumSwitch()
		{
		}
	}
}
