using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5994F0", Offset = "0x5994F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5994F0", Offset = "0x5994F0")]
	public class AnimateVector3 : AnimateFsmAction
	{
		[Token(Token = "0x4004510")]
		[FieldOffset(Offset = "0xD8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0EC0", Offset = "0x5C0EC0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C0EC0", Offset = "0x5C0EC0")]
		public FsmVector3 vectorVariable;

		[Token(Token = "0x4004511")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0F20", Offset = "0x5C0F20")]
		[RequiredField]
		public FsmAnimationCurve curveX;

		[Token(Token = "0x4004512")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0F6C", Offset = "0x5C0F6C")]
		public Calculation calculationX;

		[Token(Token = "0x4004513")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0FA4", Offset = "0x5C0FA4")]
		[RequiredField]
		public FsmAnimationCurve curveY;

		[Token(Token = "0x4004514")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0FF0", Offset = "0x5C0FF0")]
		public Calculation calculationY;

		[Token(Token = "0x4004515")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1028", Offset = "0x5C1028")]
		[RequiredField]
		public FsmAnimationCurve curveZ;

		[Token(Token = "0x4004516")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1074", Offset = "0x5C1074")]
		public Calculation calculationZ;

		[Token(Token = "0x4004517")]
		[FieldOffset(Offset = "0x10C")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A91")]
		[Address(RVA = "0xD442B4", Offset = "0xD442B4", VA = "0xD442B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A92")]
		[Address(RVA = "0xD44328", Offset = "0xD44328", VA = "0xD44328", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A93")]
		[Address(RVA = "0xD4463C", Offset = "0xD4463C", VA = "0xD4463C")]
		private void UpdateVariableValue()
		{
		}

		[Token(Token = "0x6005A94")]
		[Address(RVA = "0xD446B4", Offset = "0xD446B4", VA = "0xD446B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A95")]
		[Address(RVA = "0xD44738", Offset = "0xD44738", VA = "0xD44738")]
		public AnimateVector3()
		{
		}
	}
}
