using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200101E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A06F0", Offset = "0x5A06F0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A06F0", Offset = "0x5A06F0")]
	public class ColorCompare : FsmStateAction
	{
		[Token(Token = "0x4004B9F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB380", Offset = "0x5DB380")]
		public FsmColor color1;

		[Token(Token = "0x4004BA0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB3CC", Offset = "0x5DB3CC")]
		[RequiredField]
		public FsmColor color2;

		[Token(Token = "0x4004BA1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB418", Offset = "0x5DB418")]
		[RequiredField]
		public FsmFloat tolerance;

		[Token(Token = "0x4004BA2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB464", Offset = "0x5DB464")]
		public FsmEvent equal;

		[Token(Token = "0x4004BA3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB49C", Offset = "0x5DB49C")]
		public FsmEvent notEqual;

		[Token(Token = "0x4004BA4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB4D4", Offset = "0x5DB4D4")]
		public bool everyFrame;

		[Token(Token = "0x60060B5")]
		[Address(RVA = "0x8DA080", Offset = "0x8DA080", VA = "0x8DA080", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060B6")]
		[Address(RVA = "0x8DA0DC", Offset = "0x8DA0DC", VA = "0x8DA0DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060B7")]
		[Address(RVA = "0x8DA230", Offset = "0x8DA230", VA = "0x8DA230", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060B8")]
		[Address(RVA = "0x8DA118", Offset = "0x8DA118", VA = "0x8DA118")]
		private void DoCompare()
		{
		}

		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x8DA234", Offset = "0x8DA234", VA = "0x8DA234", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60060BA")]
		[Address(RVA = "0x8DA308", Offset = "0x8DA308", VA = "0x8DA308")]
		public ColorCompare()
		{
		}
	}
}
