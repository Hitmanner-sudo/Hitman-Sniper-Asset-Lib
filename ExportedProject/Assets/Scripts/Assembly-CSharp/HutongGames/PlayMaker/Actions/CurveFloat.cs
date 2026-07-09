using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599590", Offset = "0x599590")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599590", Offset = "0x599590")]
	public class CurveFloat : CurveFsmAction
	{
		[Token(Token = "0x4004525")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C13B4", Offset = "0x5C13B4")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C13B4", Offset = "0x5C13B4")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004526")]
		[FieldOffset(Offset = "0xE8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1414", Offset = "0x5C1414")]
		public FsmFloat fromValue;

		[Token(Token = "0x4004527")]
		[FieldOffset(Offset = "0xF0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C1460", Offset = "0x5C1460")]
		public FsmFloat toValue;

		[Token(Token = "0x4004528")]
		[FieldOffset(Offset = "0xF8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C14AC", Offset = "0x5C14AC")]
		public FsmAnimationCurve animCurve;

		[Token(Token = "0x4004529")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C14F8", Offset = "0x5C14F8")]
		public Calculation calculation;

		[Token(Token = "0x400452A")]
		[FieldOffset(Offset = "0x104")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0xD8CF78", Offset = "0xD8CF78", VA = "0xD8CF78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0xD8D038", Offset = "0xD8D038", VA = "0xD8D038", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0xD8D1F4", Offset = "0xD8D1F4", VA = "0xD8D1F4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0xD8D1F8", Offset = "0xD8D1F8", VA = "0xD8D1F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0xD8D2E4", Offset = "0xD8D2E4", VA = "0xD8D2E4")]
		public CurveFloat()
		{
		}
	}
}
