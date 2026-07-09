using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F52")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C8C0", Offset = "0x59C8C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C8C0", Offset = "0x59C8C0")]
	public class SelectRandomColor : FsmStateAction
	{
		[Token(Token = "0x4004873")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5CF020", Offset = "0x5CF020")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF020", Offset = "0x5CF020")]
		public FsmColor[] colors;

		[Token(Token = "0x4004874")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF0B0", Offset = "0x5CF0B0")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5CF0B0", Offset = "0x5CF0B0")]
		public FsmFloat[] weights;

		[Token(Token = "0x4004875")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF104", Offset = "0x5CF104")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF104", Offset = "0x5CF104")]
		[RequiredField]
		public FsmColor storeColor;

		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0xB6FA38", Offset = "0xB6FA38", VA = "0xB6FA38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0xB6FB80", Offset = "0xB6FB80", VA = "0xB6FB80", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0xB6FBA8", Offset = "0xB6FBA8", VA = "0xB6FBA8")]
		private void DoSelectRandomColor()
		{
		}

		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0xB6FC30", Offset = "0xB6FC30", VA = "0xB6FC30")]
		public SelectRandomColor()
		{
		}
	}
}
