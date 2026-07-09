using Il2CppDummyDll;
using PlayMaker.ConditionalExpression;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F65")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x59CDE4", Offset = "0x59CDE4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CDE4", Offset = "0x59CDE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CDE4", Offset = "0x59CDE4")]
	public class Assert : FsmStateAction, IEvaluatorContext
	{
		[Token(Token = "0x2000F66")]
		public enum AssertType
		{
			[Token(Token = "0x40048C6")]
			IsTrue = 0,
			[Token(Token = "0x40048C7")]
			IsFalse = 1
		}

		[Token(Token = "0x40048BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D03A4", Offset = "0x5D03A4")]
		private CompiledAst _003CAst_003Ek__BackingField;

		[Token(Token = "0x40048C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D03B4", Offset = "0x5D03B4")]
		private string _003CLastErrorMessage_003Ek__BackingField;

		[Token(Token = "0x40048C1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D03C4", Offset = "0x5D03C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D03C4", Offset = "0x5D03C4")]
		public FsmString expression;

		[Token(Token = "0x40048C2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0414", Offset = "0x5D0414")]
		public AssertType assert;

		[Token(Token = "0x40048C3")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D044C", Offset = "0x5D044C")]
		public bool everyFrame;

		[Token(Token = "0x40048C4")]
		[FieldOffset(Offset = "0x70")]
		private string cachedExpression;

		[Token(Token = "0x17000C35")]
		public CompiledAst Ast
		{
			[Token(Token = "0x6005E10")]
			[Address(RVA = "0xC00BB8", Offset = "0xC00BB8", VA = "0xC00BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C040", Offset = "0x62C040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E11")]
			[Address(RVA = "0xC00BC0", Offset = "0xC00BC0", VA = "0xC00BC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C050", Offset = "0x62C050")]
			set
			{
			}
		}

		[Token(Token = "0x17000C36")]
		public string LastErrorMessage
		{
			[Token(Token = "0x6005E12")]
			[Address(RVA = "0xC00BC8", Offset = "0xC00BC8", VA = "0xC00BC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C060", Offset = "0x62C060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E13")]
			[Address(RVA = "0xC00BD0", Offset = "0xC00BD0", VA = "0xC00BD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C070", Offset = "0x62C070")]
			set
			{
			}
		}

		[Token(Token = "0x6005E14")]
		[Address(RVA = "0xC00BD8", Offset = "0xC00BD8", VA = "0xC00BD8", Slot = "62")]
		private FsmVar PlayMaker_002EConditionalExpression_002EIEvaluatorContext_002EGetVariable(string name)
		{
			return null;
		}

		[Token(Token = "0x6005E15")]
		[Address(RVA = "0xC00CA4", Offset = "0xC00CA4", VA = "0xC00CA4")]
		public Assert()
		{
		}
	}
}
