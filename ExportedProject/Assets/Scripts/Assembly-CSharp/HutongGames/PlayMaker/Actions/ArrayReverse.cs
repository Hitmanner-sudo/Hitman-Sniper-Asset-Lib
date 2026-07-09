using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B750", Offset = "0x59B750")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B750", Offset = "0x59B750")]
	public class ArrayReverse : FsmStateAction
	{
		[Token(Token = "0x4004760")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CAAE4", Offset = "0x5CAAE4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAAE4", Offset = "0x5CAAE4")]
		public FsmArray array;

		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0xBFD868", Offset = "0xBFD868", VA = "0xBFD868", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0xBFD870", Offset = "0xBFD870", VA = "0xBFD870", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0xBFD968", Offset = "0xBFD968", VA = "0xBFD968")]
		public ArrayReverse()
		{
		}
	}
}
