using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3A34", Offset = "0x5A3A34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3A34", Offset = "0x5A3A34")]
	public class PlayerPrefsHasKey : FsmStateAction
	{
		[Token(Token = "0x4004F29")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA7A8", Offset = "0x5EA7A8")]
		public FsmString key;

		[Token(Token = "0x4004F2A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5EA7F4", Offset = "0x5EA7F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA7F4", Offset = "0x5EA7F4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA7F4", Offset = "0x5EA7F4")]
		public FsmBool variable;

		[Token(Token = "0x4004F2B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA868", Offset = "0x5EA868")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004F2C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA8A0", Offset = "0x5EA8A0")]
		public FsmEvent falseEvent;

		[Token(Token = "0x60063D5")]
		[Address(RVA = "0xB8BF34", Offset = "0xB8BF34", VA = "0xB8BF34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063D6")]
		[Address(RVA = "0xB8BF88", Offset = "0xB8BF88", VA = "0xB8BF88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063D7")]
		[Address(RVA = "0xB8C070", Offset = "0xB8C070", VA = "0xB8C070")]
		public PlayerPrefsHasKey()
		{
		}
	}
}
