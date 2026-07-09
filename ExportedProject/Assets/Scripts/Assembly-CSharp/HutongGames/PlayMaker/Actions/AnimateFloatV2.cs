using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EA3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599440", Offset = "0x599440")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599440", Offset = "0x599440")]
	public class AnimateFloatV2 : AnimateFsmAction
	{
		[Token(Token = "0x40044E2")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0A1C", Offset = "0x5C0A1C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C0A1C", Offset = "0x5C0A1C")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x40044E3")]
		[FieldOffset(Offset = "0xE0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0A7C", Offset = "0x5C0A7C")]
		public FsmAnimationCurve animCurve;

		[Token(Token = "0x40044E4")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0AC8", Offset = "0x5C0AC8")]
		public Calculation calculation;

		[Token(Token = "0x40044E5")]
		[FieldOffset(Offset = "0xEC")]
		private bool finishInNextStep;

		[Token(Token = "0x6005A7E")]
		[Address(RVA = "0xD42DC4", Offset = "0xD42DC4", VA = "0xD42DC4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0xD42E38", Offset = "0xD42E38", VA = "0xD42E38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A80")]
		[Address(RVA = "0xD42FA4", Offset = "0xD42FA4", VA = "0xD42FA4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0xD42FA8", Offset = "0xD42FA8", VA = "0xD42FA8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A82")]
		[Address(RVA = "0xD43094", Offset = "0xD43094", VA = "0xD43094")]
		public AnimateFloatV2()
		{
		}
	}
}
