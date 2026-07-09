using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CA00", Offset = "0x59CA00")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CA00", Offset = "0x59CA00")]
	public class ConvertBoolToFloat : FsmStateAction
	{
		[Token(Token = "0x400488C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF5A8", Offset = "0x5CF5A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF5A8", Offset = "0x5CF5A8")]
		public FsmBool boolVariable;

		[Token(Token = "0x400488D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF608", Offset = "0x5CF608")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF608", Offset = "0x5CF608")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x400488E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF668", Offset = "0x5CF668")]
		public FsmFloat falseValue;

		[Token(Token = "0x400488F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF6A0", Offset = "0x5CF6A0")]
		public FsmFloat trueValue;

		[Token(Token = "0x4004890")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF6D8", Offset = "0x5CF6D8")]
		public bool everyFrame;

		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0xD7F0B4", Offset = "0xD7F0B4", VA = "0xD7F0B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0xD7F0F8", Offset = "0xD7F0F8", VA = "0xD7F0F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0xD7F190", Offset = "0xD7F190", VA = "0xD7F190", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0xD7F134", Offset = "0xD7F134", VA = "0xD7F134")]
		private void DoConvertBoolToFloat()
		{
		}

		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0xD7F194", Offset = "0xD7F194", VA = "0xD7F194")]
		public ConvertBoolToFloat()
		{
		}
	}
}
