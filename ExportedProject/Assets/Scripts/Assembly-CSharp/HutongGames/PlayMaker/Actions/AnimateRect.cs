using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599490", Offset = "0x599490")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599490", Offset = "0x599490")]
	public class AnimateRect : AnimateFsmAction
	{
		[Token(Token = "0x4004506")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C0C50", Offset = "0x5C0C50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0C50", Offset = "0x5C0C50")]
		[RequiredField]
		public FsmRect rectVariable;

		[Token(Token = "0x4004507")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0CB0", Offset = "0x5C0CB0")]
		[RequiredField]
		public FsmAnimationCurve curveX;

		[Token(Token = "0x4004508")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0CFC", Offset = "0x5C0CFC")]
		public Calculation calculationX;

		[Token(Token = "0x4004509")]
		[FieldOffset(Offset = "0xF0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0D34", Offset = "0x5C0D34")]
		public FsmAnimationCurve curveY;

		[Token(Token = "0x400450A")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0D80", Offset = "0x5C0D80")]
		public Calculation calculationY;

		[Token(Token = "0x400450B")]
		[FieldOffset(Offset = "0x100")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0DB8", Offset = "0x5C0DB8")]
		public FsmAnimationCurve curveW;

		[Token(Token = "0x400450C")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0E04", Offset = "0x5C0E04")]
		public Calculation calculationW;

		[Token(Token = "0x400450D")]
		[FieldOffset(Offset = "0x110")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0E3C", Offset = "0x5C0E3C")]
		public FsmAnimationCurve curveH;

		[Token(Token = "0x400450E")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0E88", Offset = "0x5C0E88")]
		public Calculation calculationH;

		[Token(Token = "0x400450F")]
		[FieldOffset(Offset = "0x11C")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0xD43D44", Offset = "0xD43D44", VA = "0xD43D44", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0xD43DB8", Offset = "0xD43DB8", VA = "0xD43DB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0xD44190", Offset = "0xD44190", VA = "0xD44190")]
		private void UpdateVariableValue()
		{
		}

		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0xD44228", Offset = "0xD44228", VA = "0xD44228", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A90")]
		[Address(RVA = "0xD442AC", Offset = "0xD442AC", VA = "0xD442AC")]
		public AnimateRect()
		{
		}
	}
}
