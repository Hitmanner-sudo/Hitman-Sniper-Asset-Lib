using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F57")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C9B0", Offset = "0x59C9B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C9B0", Offset = "0x59C9B0")]
	public class ConvertBoolToColor : FsmStateAction
	{
		[Token(Token = "0x4004887")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF440", Offset = "0x5CF440")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF440", Offset = "0x5CF440")]
		[RequiredField]
		public FsmBool boolVariable;

		[Token(Token = "0x4004888")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF4A0", Offset = "0x5CF4A0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF4A0", Offset = "0x5CF4A0")]
		[RequiredField]
		public FsmColor colorVariable;

		[Token(Token = "0x4004889")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF500", Offset = "0x5CF500")]
		public FsmColor falseColor;

		[Token(Token = "0x400488A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF538", Offset = "0x5CF538")]
		public FsmColor trueColor;

		[Token(Token = "0x400488B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF570", Offset = "0x5CF570")]
		public bool everyFrame;

		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0xD7EFC8", Offset = "0xD7EFC8", VA = "0xD7EFC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DD1")]
		[Address(RVA = "0xD7F014", Offset = "0xD7F014", VA = "0xD7F014", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DD2")]
		[Address(RVA = "0xD7F0A8", Offset = "0xD7F0A8", VA = "0xD7F0A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DD3")]
		[Address(RVA = "0xD7F050", Offset = "0xD7F050", VA = "0xD7F050")]
		private void DoConvertBoolToColor()
		{
		}

		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0xD7F0AC", Offset = "0xD7F0AC", VA = "0xD7F0AC")]
		public ConvertBoolToColor()
		{
		}
	}
}
