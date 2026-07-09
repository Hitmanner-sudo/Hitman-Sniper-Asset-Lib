using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599540", Offset = "0x599540")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599540", Offset = "0x599540")]
	public class CurveColor : CurveFsmAction
	{
		[Token(Token = "0x4004518")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C10AC", Offset = "0x5C10AC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C10AC", Offset = "0x5C10AC")]
		[RequiredField]
		public FsmColor colorVariable;

		[Token(Token = "0x4004519")]
		[FieldOffset(Offset = "0xE8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C110C", Offset = "0x5C110C")]
		public FsmColor fromValue;

		[Token(Token = "0x400451A")]
		[FieldOffset(Offset = "0xF0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1158", Offset = "0x5C1158")]
		public FsmColor toValue;

		[Token(Token = "0x400451B")]
		[FieldOffset(Offset = "0xF8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C11A4", Offset = "0x5C11A4")]
		public FsmAnimationCurve curveR;

		[Token(Token = "0x400451C")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C11F0", Offset = "0x5C11F0")]
		public Calculation calculationR;

		[Token(Token = "0x400451D")]
		[FieldOffset(Offset = "0x108")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1228", Offset = "0x5C1228")]
		public FsmAnimationCurve curveG;

		[Token(Token = "0x400451E")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1274", Offset = "0x5C1274")]
		public Calculation calculationG;

		[Token(Token = "0x400451F")]
		[FieldOffset(Offset = "0x118")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C12AC", Offset = "0x5C12AC")]
		public FsmAnimationCurve curveB;

		[Token(Token = "0x4004520")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C12F8", Offset = "0x5C12F8")]
		public Calculation calculationB;

		[Token(Token = "0x4004521")]
		[FieldOffset(Offset = "0x128")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1330", Offset = "0x5C1330")]
		public FsmAnimationCurve curveA;

		[Token(Token = "0x4004522")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C137C", Offset = "0x5C137C")]
		public Calculation calculationA;

		[Token(Token = "0x4004523")]
		[FieldOffset(Offset = "0x134")]
		private Color clr;

		[Token(Token = "0x4004524")]
		[FieldOffset(Offset = "0x144")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A96")]
		[Address(RVA = "0xD8B108", Offset = "0xD8B108", VA = "0xD8B108", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A97")]
		[Address(RVA = "0xD8B35C", Offset = "0xD8B35C", VA = "0xD8B35C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A98")]
		[Address(RVA = "0xD8BD94", Offset = "0xD8BD94", VA = "0xD8BD94", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A99")]
		[Address(RVA = "0xD8BD98", Offset = "0xD8BD98", VA = "0xD8BD98", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0xD8CF68", Offset = "0xD8CF68", VA = "0xD8CF68")]
		public CurveColor()
		{
		}
	}
}
