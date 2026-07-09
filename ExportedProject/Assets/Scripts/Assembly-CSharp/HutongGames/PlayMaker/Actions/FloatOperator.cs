using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001051")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A18E0", Offset = "0x5A18E0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A18E0", Offset = "0x5A18E0")]
	public class FloatOperator : FsmStateAction
	{
		[Token(Token = "0x2001052")]
		public enum Operation
		{
			[Token(Token = "0x4004CA2")]
			Add = 0,
			[Token(Token = "0x4004CA3")]
			Subtract = 1,
			[Token(Token = "0x4004CA4")]
			Multiply = 2,
			[Token(Token = "0x4004CA5")]
			Divide = 3,
			[Token(Token = "0x4004CA6")]
			Min = 4,
			[Token(Token = "0x4004CA7")]
			Max = 5,
			[Token(Token = "0x4004CA8")]
			Modulus = 6
		}

		[Token(Token = "0x4004C9C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFA4C", Offset = "0x5DFA4C")]
		[RequiredField]
		public FsmFloat float1;

		[Token(Token = "0x4004C9D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFA98", Offset = "0x5DFA98")]
		[RequiredField]
		public FsmFloat float2;

		[Token(Token = "0x4004C9E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFAE4", Offset = "0x5DFAE4")]
		public Operation operation;

		[Token(Token = "0x4004C9F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DFB1C", Offset = "0x5DFB1C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFB1C", Offset = "0x5DFB1C")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004CA0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFB7C", Offset = "0x5DFB7C")]
		public bool everyFrame;

		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x959550", Offset = "0x959550", VA = "0x959550", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061AD")]
		[Address(RVA = "0x959564", Offset = "0x959564", VA = "0x959564", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061AE")]
		[Address(RVA = "0x959694", Offset = "0x959694", VA = "0x959694", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061AF")]
		[Address(RVA = "0x9595A0", Offset = "0x9595A0", VA = "0x9595A0")]
		private void DoFloatOperator()
		{
		}

		[Token(Token = "0x60061B0")]
		[Address(RVA = "0x959698", Offset = "0x959698", VA = "0x959698")]
		public FloatOperator()
		{
		}
	}
}
