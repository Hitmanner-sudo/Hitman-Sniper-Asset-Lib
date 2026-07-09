using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F5A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CAA0", Offset = "0x59CAA0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CAA0", Offset = "0x59CAA0")]
	public class ConvertBoolToString : FsmStateAction
	{
		[Token(Token = "0x4004896")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF878", Offset = "0x5CF878")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF878", Offset = "0x5CF878")]
		[RequiredField]
		public FsmBool boolVariable;

		[Token(Token = "0x4004897")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF8D8", Offset = "0x5CF8D8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF8D8", Offset = "0x5CF8D8")]
		public FsmString stringVariable;

		[Token(Token = "0x4004898")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF938", Offset = "0x5CF938")]
		public FsmString falseString;

		[Token(Token = "0x4004899")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF970", Offset = "0x5CF970")]
		public FsmString trueString;

		[Token(Token = "0x400489A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF9A8", Offset = "0x5CF9A8")]
		public bool everyFrame;

		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0xD7F284", Offset = "0xD7F284", VA = "0xD7F284", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0xD7F304", Offset = "0xD7F304", VA = "0xD7F304", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0xD7F39C", Offset = "0xD7F39C", VA = "0xD7F39C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0xD7F340", Offset = "0xD7F340", VA = "0xD7F340")]
		private void DoConvertBoolToString()
		{
		}

		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0xD7F3A0", Offset = "0xD7F3A0", VA = "0xD7F3A0")]
		public ConvertBoolToString()
		{
		}
	}
}
