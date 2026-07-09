using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001195")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8B94", Offset = "0x5A8B94")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8B94", Offset = "0x5A8B94")]
	public class StringSplit : FsmStateAction
	{
		[Token(Token = "0x40053A0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FACC4", Offset = "0x5FACC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FACC4", Offset = "0x5FACC4")]
		public FsmString stringToSplit;

		[Token(Token = "0x40053A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAD14", Offset = "0x5FAD14")]
		public FsmString separators;

		[Token(Token = "0x40053A2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAD4C", Offset = "0x5FAD4C")]
		public FsmBool trimStrings;

		[Token(Token = "0x40053A3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAD84", Offset = "0x5FAD84")]
		public FsmString trimChars;

		[Token(Token = "0x40053A4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5FADBC", Offset = "0x5FADBC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FADBC", Offset = "0x5FADBC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FADBC", Offset = "0x5FADBC")]
		public FsmArray stringArray;

		[Token(Token = "0x60067A0")]
		[Address(RVA = "0xD2EAA0", Offset = "0xD2EAA0", VA = "0xD2EAA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067A1")]
		[Address(RVA = "0xD2EAD4", Offset = "0xD2EAD4", VA = "0xD2EAD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067A2")]
		[Address(RVA = "0xD2ECE0", Offset = "0xD2ECE0", VA = "0xD2ECE0")]
		public StringSplit()
		{
		}
	}
}
