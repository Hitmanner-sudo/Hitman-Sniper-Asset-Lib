using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EAD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599678", Offset = "0x599678")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599678", Offset = "0x599678")]
	public class CurveVector3 : CurveFsmAction
	{
		[Token(Token = "0x4004558")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C1988", Offset = "0x5C1988")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1988", Offset = "0x5C1988")]
		public FsmVector3 vectorVariable;

		[Token(Token = "0x4004559")]
		[FieldOffset(Offset = "0xE8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C19E8", Offset = "0x5C19E8")]
		public FsmVector3 fromValue;

		[Token(Token = "0x400455A")]
		[FieldOffset(Offset = "0xF0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1A34", Offset = "0x5C1A34")]
		public FsmVector3 toValue;

		[Token(Token = "0x400455B")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1A80", Offset = "0x5C1A80")]
		[RequiredField]
		public FsmAnimationCurve curveX;

		[Token(Token = "0x400455C")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1ACC", Offset = "0x5C1ACC")]
		public Calculation calculationX;

		[Token(Token = "0x400455D")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1B04", Offset = "0x5C1B04")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Token(Token = "0x400455E")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1B50", Offset = "0x5C1B50")]
		public Calculation calculationY;

		[Token(Token = "0x400455F")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1B88", Offset = "0x5C1B88")]
		[RequiredField]
		public FsmAnimationCurve curveZ;

		[Token(Token = "0x4004560")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1BD4", Offset = "0x5C1BD4")]
		public Calculation calculationZ;

		[Token(Token = "0x4004561")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 vct;

		[Token(Token = "0x4004562")]
		[FieldOffset(Offset = "0x130")]
		private bool finishInNextStep;

		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0xD8D9F0", Offset = "0xD8D9F0", VA = "0xD8D9F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0xD8DAB0", Offset = "0xD8DAB0", VA = "0xD8DAB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0xD8DE1C", Offset = "0xD8DE1C", VA = "0xD8DE1C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0xD8DE20", Offset = "0xD8DE20", VA = "0xD8DE20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0xD8DF54", Offset = "0xD8DF54", VA = "0xD8DF54")]
		public CurveVector3()
		{
		}
	}
}
