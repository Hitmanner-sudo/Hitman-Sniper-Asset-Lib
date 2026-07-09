using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F13")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B430", Offset = "0x59B430")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B430", Offset = "0x59B430")]
	public class ArrayDeleteAt : FsmStateAction
	{
		[Token(Token = "0x4004736")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9E98", Offset = "0x5C9E98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9E98", Offset = "0x5C9E98")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x4004737")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9EF8", Offset = "0x5C9EF8")]
		public FsmInt index;

		[Token(Token = "0x4004738")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ActionSection", RVA = "0x5C9F30", Offset = "0x5C9F30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9F30", Offset = "0x5C9F30")]
		public FsmEvent indexOutOfRangeEvent;

		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0xD56724", Offset = "0xD56724", VA = "0xD56724", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0xD56730", Offset = "0xD56730", VA = "0xD56730", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0xD56758", Offset = "0xD56758", VA = "0xD56758")]
		private void DoDeleteAt()
		{
		}

		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0xD568BC", Offset = "0xD568BC", VA = "0xD568BC")]
		public ArrayDeleteAt()
		{
		}
	}
}
