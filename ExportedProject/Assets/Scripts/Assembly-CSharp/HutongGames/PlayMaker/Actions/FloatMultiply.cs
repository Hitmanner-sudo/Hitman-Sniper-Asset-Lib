using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001050")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1890", Offset = "0x5A1890")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1890", Offset = "0x5A1890")]
	public class FloatMultiply : FsmStateAction
	{
		[Token(Token = "0x4004C99")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF968", Offset = "0x5DF968")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF968", Offset = "0x5DF968")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004C9A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF9C8", Offset = "0x5DF9C8")]
		[RequiredField]
		public FsmFloat multiplyBy;

		[Token(Token = "0x4004C9B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFA14", Offset = "0x5DFA14")]
		public bool everyFrame;

		[Token(Token = "0x60061A8")]
		[Address(RVA = "0x95946C", Offset = "0x95946C", VA = "0x95946C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x959478", Offset = "0x959478", VA = "0x959478", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x9594F0", Offset = "0x9594F0", VA = "0x9594F0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x959548", Offset = "0x959548", VA = "0x959548")]
		public FloatMultiply()
		{
		}
	}
}
