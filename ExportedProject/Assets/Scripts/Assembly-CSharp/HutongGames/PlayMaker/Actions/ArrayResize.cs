using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B700", Offset = "0x59B700")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B700", Offset = "0x59B700")]
	public class ArrayResize : FsmStateAction
	{
		[Token(Token = "0x400475D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CAA14", Offset = "0x5CAA14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAA14", Offset = "0x5CAA14")]
		public FsmArray array;

		[Token(Token = "0x400475E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAA74", Offset = "0x5CAA74")]
		public FsmInt newSize;

		[Token(Token = "0x400475F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAAAC", Offset = "0x5CAAAC")]
		public FsmEvent sizeOutOfRangeEvent;

		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0xBFD768", Offset = "0xBFD768", VA = "0xBFD768", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0xBFD860", Offset = "0xBFD860", VA = "0xBFD860")]
		public ArrayResize()
		{
		}
	}
}
