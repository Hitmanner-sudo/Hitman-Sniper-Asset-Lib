using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F15")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B4D0", Offset = "0x59B4D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B4D0", Offset = "0x59B4D0")]
	public class ArrayGet : FsmStateAction
	{
		[Token(Token = "0x400473E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA10C", Offset = "0x5CA10C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA10C", Offset = "0x5CA10C")]
		public FsmArray array;

		[Token(Token = "0x400473F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA16C", Offset = "0x5CA16C")]
		public FsmInt index;

		[Token(Token = "0x4004740")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CA1A4", Offset = "0x5CA1A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA1A4", Offset = "0x5CA1A4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA1A4", Offset = "0x5CA1A4")]
		public FsmVar storeValue;

		[Token(Token = "0x4004741")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA228", Offset = "0x5CA228")]
		public bool everyFrame;

		[Token(Token = "0x4004742")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5CA260", Offset = "0x5CA260")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA260", Offset = "0x5CA260")]
		public FsmEvent indexOutOfRange;

		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0xBFCE64", Offset = "0xBFCE64", VA = "0xBFCE64", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0xBFCE78", Offset = "0xBFCE78", VA = "0xBFCE78", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0xBFCFA4", Offset = "0xBFCFA4", VA = "0xBFCFA4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0xBFCEB4", Offset = "0xBFCEB4", VA = "0xBFCEB4")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0xBFCFA8", Offset = "0xBFCFA8", VA = "0xBFCFA8")]
		public ArrayGet()
		{
		}
	}
}
