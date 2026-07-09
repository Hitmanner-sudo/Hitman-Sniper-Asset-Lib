using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F59")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CA50", Offset = "0x59CA50")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CA50", Offset = "0x59CA50")]
	public class ConvertBoolToInt : FsmStateAction
	{
		[Token(Token = "0x4004891")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF710", Offset = "0x5CF710")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF710", Offset = "0x5CF710")]
		public FsmBool boolVariable;

		[Token(Token = "0x4004892")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF770", Offset = "0x5CF770")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF770", Offset = "0x5CF770")]
		public FsmInt intVariable;

		[Token(Token = "0x4004893")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF7D0", Offset = "0x5CF7D0")]
		public FsmInt falseValue;

		[Token(Token = "0x4004894")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF808", Offset = "0x5CF808")]
		public FsmInt trueValue;

		[Token(Token = "0x4004895")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF840", Offset = "0x5CF840")]
		public bool everyFrame;

		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0xD7F19C", Offset = "0xD7F19C", VA = "0xD7F19C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0xD7F1E0", Offset = "0xD7F1E0", VA = "0xD7F1E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0xD7F278", Offset = "0xD7F278", VA = "0xD7F278", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0xD7F21C", Offset = "0xD7F21C", VA = "0xD7F21C")]
		private void DoConvertBoolToInt()
		{
		}

		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0xD7F27C", Offset = "0xD7F27C", VA = "0xD7F27C")]
		public ConvertBoolToInt()
		{
		}
	}
}
