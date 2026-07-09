using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EAC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599618", Offset = "0x599618")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599618", Offset = "0x599618")]
	public class CurveRect : CurveFsmAction
	{
		[Token(Token = "0x400454B")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1680", Offset = "0x5C1680")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C1680", Offset = "0x5C1680")]
		[RequiredField]
		public FsmRect rectVariable;

		[Token(Token = "0x400454C")]
		[FieldOffset(Offset = "0xE8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C16E0", Offset = "0x5C16E0")]
		public FsmRect fromValue;

		[Token(Token = "0x400454D")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C172C", Offset = "0x5C172C")]
		[RequiredField]
		public FsmRect toValue;

		[Token(Token = "0x400454E")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1778", Offset = "0x5C1778")]
		[RequiredField]
		public FsmAnimationCurve curveX;

		[Token(Token = "0x400454F")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C17C4", Offset = "0x5C17C4")]
		public Calculation calculationX;

		[Token(Token = "0x4004550")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C17FC", Offset = "0x5C17FC")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Token(Token = "0x4004551")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1848", Offset = "0x5C1848")]
		public Calculation calculationY;

		[Token(Token = "0x4004552")]
		[FieldOffset(Offset = "0x118")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1880", Offset = "0x5C1880")]
		public FsmAnimationCurve curveW;

		[Token(Token = "0x4004553")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C18CC", Offset = "0x5C18CC")]
		public Calculation calculationW;

		[Token(Token = "0x4004554")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1904", Offset = "0x5C1904")]
		[RequiredField]
		public FsmAnimationCurve curveH;

		[Token(Token = "0x4004555")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1950", Offset = "0x5C1950")]
		public Calculation calculationH;

		[Token(Token = "0x4004556")]
		[FieldOffset(Offset = "0x134")]
		private Rect rct;

		[Token(Token = "0x4004557")]
		[FieldOffset(Offset = "0x144")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0xD8D2EC", Offset = "0xD8D2EC", VA = "0xD8D2EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0xD8D3AC", Offset = "0xD8D3AC", VA = "0xD8D3AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0xD8D860", Offset = "0xD8D860", VA = "0xD8D860", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0xD8D864", Offset = "0xD8D864", VA = "0xD8D864", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0xD8D9E8", Offset = "0xD8D9E8", VA = "0xD8D9E8")]
		public CurveRect()
		{
		}
	}
}
