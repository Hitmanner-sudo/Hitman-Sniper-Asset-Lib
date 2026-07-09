using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5993A0", Offset = "0x5993A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5993A0", Offset = "0x5993A0")]
	public class AnimateColor : AnimateFsmAction
	{
		[Token(Token = "0x40044D0")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0690", Offset = "0x5C0690")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C0690", Offset = "0x5C0690")]
		[RequiredField]
		public FsmColor colorVariable;

		[Token(Token = "0x40044D1")]
		[FieldOffset(Offset = "0xE0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C06F0", Offset = "0x5C06F0")]
		public FsmAnimationCurve curveR;

		[Token(Token = "0x40044D2")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C073C", Offset = "0x5C073C")]
		public Calculation calculationR;

		[Token(Token = "0x40044D3")]
		[FieldOffset(Offset = "0xF0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0774", Offset = "0x5C0774")]
		public FsmAnimationCurve curveG;

		[Token(Token = "0x40044D4")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C07C0", Offset = "0x5C07C0")]
		public Calculation calculationG;

		[Token(Token = "0x40044D5")]
		[FieldOffset(Offset = "0x100")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C07F8", Offset = "0x5C07F8")]
		public FsmAnimationCurve curveB;

		[Token(Token = "0x40044D6")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0844", Offset = "0x5C0844")]
		public Calculation calculationB;

		[Token(Token = "0x40044D7")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C087C", Offset = "0x5C087C")]
		[RequiredField]
		public FsmAnimationCurve curveA;

		[Token(Token = "0x40044D8")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C08C8", Offset = "0x5C08C8")]
		public Calculation calculationA;

		[Token(Token = "0x40044D9")]
		[FieldOffset(Offset = "0x11C")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A75")]
		[Address(RVA = "0xD41F2C", Offset = "0xD41F2C", VA = "0xD41F2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A76")]
		[Address(RVA = "0xD42124", Offset = "0xD42124", VA = "0xD42124", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A77")]
		[Address(RVA = "0xD42A50", Offset = "0xD42A50", VA = "0xD42A50")]
		private void UpdateVariableValue()
		{
		}

		[Token(Token = "0x6005A78")]
		[Address(RVA = "0xD42AE8", Offset = "0xD42AE8", VA = "0xD42AE8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A79")]
		[Address(RVA = "0xD42BB4", Offset = "0xD42BB4", VA = "0xD42BB4")]
		public AnimateColor()
		{
		}
	}
}
